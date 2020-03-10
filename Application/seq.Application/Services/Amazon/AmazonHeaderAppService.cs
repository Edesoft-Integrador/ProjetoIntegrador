﻿
using seq.Domain.Entities;
using seq.Domain.Interface.Services;
using seq.Application.Services;
using seq.Application.Interfaces;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using seq.Processo.Amazon;
using System;

namespace seq.Applications.Services
{
    public class AmazonHeaderAppService : AppServiceBase<AmazonHeaderModel>, IAmazonHeaderAppService
    {
        private readonly IAmazonHeaderService   _amazonHeaderService;
        private readonly IAmazonDetalheService  _amazonDetalheService;
        private readonly IAmazonGRU5Processo    _amazonGRU5Processo;
        private readonly IAmazonSELLERSProcesso _amazonSELLERSProcesso;
        private readonly IAmazonLUFTProcesso    _AmazonLUFTProcesso;


        public AmazonHeaderAppService
        (
            IAmazonHeaderService   serviceBase
          , IAmazonDetalheService  amazonDetalheService
          , IAmazonGRU5Processo    amazonGRU5Processo
          , IAmazonSELLERSProcesso amazonSELLERSProcesso
          , IAmazonLUFTProcesso    amazonLUFTProcesso

        ) : base(serviceBase)
        {
            _amazonHeaderService     = serviceBase;
            _amazonDetalheService    = amazonDetalheService;
            _amazonGRU5Processo      = amazonGRU5Processo;
            _amazonSELLERSProcesso   = amazonSELLERSProcesso;
            _AmazonLUFTProcesso      = amazonLUFTProcesso;

        }

        public async Task<int> ProcessaXML(string value)
        {
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
                                               
                        var HeaderIdPai = Guid.NewGuid();

                        await _amazonHeaderService.AddRangeAsync(await _AmazonLUFTProcesso.Header(trans, HeaderIdPai, nomearquivo));
                        await _amazonDetalheService.AddRangeAsync(await _AmazonLUFTProcesso.Detalhe(trans, HeaderIdPai));
                        return 0;


                    } catch (Exception e)
                    {
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
                            
                            var HeaderIdPai = Guid.NewGuid();

                            var header = await _amazonGRU5Processo.Header(trans, HeaderIdPai, nomearquivo, descricao);
                            var detalhe = await _amazonGRU5Processo.Detalhe(trans, HeaderIdPai);

                            await _amazonHeaderService.AddRangeAsync(header);
                            await _amazonDetalheService.AddRangeAsync(detalhe);

                            return 0;
                        } catch(Exception e)
                        {
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

                            var HeaderIdPai = Guid.NewGuid();

                            await _amazonHeaderService.AddRangeAsync(await _amazonSELLERSProcesso.Header(trans, HeaderIdPai, nomearquivo, descricao));
                            await _amazonDetalheService.AddRangeAsync(await _amazonSELLERSProcesso.Detalhe(trans, HeaderIdPai));

                            return 0;
                        } catch( Exception e)
                        {
                            return 1;
                        }

                    }

                };
              
            }
        }
    }
}
