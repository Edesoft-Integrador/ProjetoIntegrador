using Microsoft.Extensions.Logging;
using seq.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace seq.Processo
{
    public class AmazonProcessaXML : IAmazonProcessaXML
    {
        private readonly IAmazonGRU5Processo _amazonGRU5Processo;
        private readonly IAmazonSELLERSProcesso _amazonSELLERSProcesso;
        private readonly IAmazonLUFTProcesso _AmazonLUFTProcesso;
        private readonly ILogger<AmazonProcessaXML> _logger;
        private readonly IGeralHeaderService _headerService;
        private readonly IGeralDetalheService _detalherService;

        public AmazonProcessaXML
        (
            IGeralHeaderService serviceBase
          , IGeralDetalheService geralDetalheService
          , IAmazonGRU5Processo amazonGRU5Processo
          , IAmazonSELLERSProcesso amazonSELLERSProcesso
          , IAmazonLUFTProcesso amazonLUFTProcesso
          , ILogger<AmazonProcessaXML> logger
          , IGeralHeaderService headerService
          , IGeralDetalheService detalherService
        )
        {
            _amazonGRU5Processo = amazonGRU5Processo;
            _amazonSELLERSProcesso = amazonSELLERSProcesso;
            _AmazonLUFTProcesso = amazonLUFTProcesso;
            _logger = logger;
            _headerService = headerService;
            _detalherService = detalherService;
        }

        public async Task<int> ProcessaXML(string value)
        {

            string nomearquivo = Path.GetFileName(value);
            string Extensao = Path.GetExtension(value);

            if (Extensao == ".xtrk")
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(seq.Domain.Entities.LUFT.transmission));
                    seq.Domain.Entities.LUFT.transmission trans;
                    using (Stream reader = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        trans = (seq.Domain.Entities.LUFT.transmission)ser.Deserialize(reader);
                    }

                    await _AmazonLUFTProcesso.Processa(trans, nomearquivo);
                    return 0;

                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, "It seems the exception happened. :(");
                    _logger.LogWarning(e.Message, "This is your last warning!");
                    _logger.LogInformation(e.Message, "And this is fatal error...");

                    return 1;
                }
            }
            else
            {
                if (nomearquivo.Contains("GRU5"))
                {
                    try
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(Domain.Entities.GRU5.transmission));
                        Domain.Entities.GRU5.transmission trans;
                        using (Stream reader = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            trans = (Domain.Entities.GRU5.transmission)ser.Deserialize(reader);
                        }

                        var amazonTechnicalName =
                             string.IsNullOrEmpty(trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName)
                                                ? trans.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName
                                                : trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName;

                        var descricao = "GRU5" + " - " + amazonTechnicalName + " - " + trans.message.amazonManifest.manifestHeader.warehouseLocationID;

                        await _amazonGRU5Processo.Processa(trans, nomearquivo, descricao);

                        return 0;
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message, "It seems the exception happened. :(");
                        _logger.LogWarning(e.Message, "This is your last warning!");
                        _logger.LogInformation(e.Message, "And this is fatal error...");

                        return 1;
                    }

                }
                else
                {
                    try
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(seq.Domain.Entities.Sellers.transmission));
                        seq.Domain.Entities.Sellers.transmission trans;
                        using (Stream reader = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            trans = (seq.Domain.Entities.Sellers.transmission)ser.Deserialize(reader);
                        }

                        var amazonTechnicalName =
                             string.IsNullOrEmpty(trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName)
                                                ? trans.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName
                                                : trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName;

                        var descricao = "SELLERS" + " - " + amazonTechnicalName + " - " + trans.message.amazonManifest.manifestHeader.warehouseLocationID;

                        await _amazonSELLERSProcesso.Processa(trans, nomearquivo, descricao);

                        return 0;
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message, "It seems the exception happened. :(");
                        _logger.LogWarning(e.Message, "This is your last warning!");
                        _logger.LogInformation(e.Message, "And this is fatal error...");

                        return 1;
                    }

                }

            };

        }
    }

}
