using seq.Domain.Interface.Repositories;
using seq.Processo.Amazon;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace seq.Application
{
    public class AmazonAppServiceOld 
    {

        private readonly IGeralHeaderRepository _contextHeader;
        private readonly IGeralDetalheRepository _contextDetalhe;

        public AmazonAppServiceOld(IGeralHeaderRepository contextHeader, IGeralDetalheRepository contextDetalhe)
        {
            _contextHeader = contextHeader;
            _contextDetalhe = contextDetalhe;
        }

        public Task<long> Processa(string value)
        {
            string arq = Path.GetFileName(value);
            string Extensao = Path.GetExtension(value);
            string pasta = null;
            string arquivo = null;
            string id = null;
            string nome01 = null;
            string nome02 = null;
            bool sair = false;


            TextReader textReader = (TextReader)new StreamReader(value);
            XmlTextReader reader = new XmlTextReader(textReader);
            if (Extensao == ".xtrk") 
            {
                pasta = "LUFT";
                arquivo = "LUFT";
                id = "LUFT";
                nome01 = "LUFT";
                nome02 = "LUFT";
            }
            else 
            {
                if (arq.Contains("GRU5"))
                {
                    pasta = "GRU5";
                }
                else 
                {
                    pasta = "SELLERS";
                }
                while (reader.Read())
                {
                    switch (reader.NodeType) 
                    {
                        case XmlNodeType.Element: // The node is an element.

                            if (reader.Name == "manifestNumber") 
                            {
                                sair = true;
                                break;
                            }
                            break;
                        case XmlNodeType.Text:
                            if (reader.Value == "SEQBR_STD") 
                            {
                                nome02 = "SEQBR_STD";
                            }
                            else if (reader.Value == "SEQBR_EXPEDITED") 
                            {
                                arquivo = "EXPEDITED";
                                nome01 = "SEQBR_EXPEDITED";

                            }
                            break;
                    }                
                }
                if (pasta == "SELLERS")
                {
                    if (nome01 != null && nome02 != null)
                    {
                        id = "XBRA";
                        arquivo = "EXPEDITED";
                    }
                    else 
                    {
                        id = "SBLE";
                        arquivo = "STD";
                    }
                }
                else 
                {
                    id = "GRU5";
                    if (nome01 != null && nome02 != null)
                    {
                        arquivo = "EXPEDITED";
                    }
                    else 
                    {
                        arquivo = "STD";
                    }
                }
            };
            if (pasta == "GRU5" && arquivo == "EXPEDITED" && id  == "GRU5" && nome01 =="SEQBR_EXPEDITED")
            {
                AmazonGRU5 _processo = new AmazonGRU5(_contextHeader, _contextDetalhe);
                _processo.Processa(value, arquivo, id, pasta);
            }
            else if (pasta == "GRU5" && arquivo == "STD" && id  == "GRU5" && nome01 == null)
            {
                AmazonGRU5 _processo = new AmazonGRU5(_contextHeader, _contextDetalhe);
                _processo.Processa(value, arquivo, id, pasta);
            }
            else if (pasta == "SELLERS" && arquivo == "EXPEDITED" && id  == "XBRA" && nome01 =="SEQBR_EXPEDITED")
            {
                AmazonSELLERS _processo = new AmazonSELLERS(_contextHeader, _contextDetalhe);
                _processo.Processa(value, arquivo, id, pasta);
            }
            else if (pasta == "SELLERS" && arquivo == "STD" && id  == "SBLE" && nome01 == null)
            {
                AmazonSELLERS _processo = new AmazonSELLERS(_contextHeader, _contextDetalhe);
                _processo.Processa(value, arquivo, id, pasta);
            }
            else if (pasta == "LUFT" && arquivo == "LUFT" && id  == "LUFT" && nome01 == "LUFT")
            {
                AmazonLUFT _processo = new AmazonLUFT(_contextHeader, _contextDetalhe);
                _processo.Processa(value, arquivo, id, pasta);
            }

            return null;
        }

    }
}