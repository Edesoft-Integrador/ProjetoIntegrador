using seq.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using seq.Domain.Entities.Sellers;
using Microsoft.Extensions.Logging;
using seq.Domain.Interface.Services;

namespace seq.Processo
{
    public class AmazonSELLERSProcesso : IAmazonSELLERSProcesso
    {
        private readonly ILogger<AmazonSELLERSProcesso> _logger;
        private readonly IGeralHeaderService _headerService;
        private readonly IGeralDetalheService _detalherService;

        public AmazonSELLERSProcesso(ILogger<AmazonSELLERSProcesso> logger, IGeralHeaderService headerService, IGeralDetalheService detalherService)
        {
            _logger = logger;
            _headerService = headerService;
            _detalherService = detalherService;
        }

        public async Task Processa(transmission trans, string nomeArquivo, string descricao)
        {
            try
            {

                var headerId = await _headerService.AddAsync( new GeralHeaderModel()
                {
                    RefHeader = 0,
                    Arquivo = nomeArquivo,
                    Linha = 0,
                    Descricao = descricao,
                    Campo001 = "receivingPartyID",
                    Campo002 = "sendingPartyID",
                    Campo003 = "transmissionCreationDate",
                    Campo004 = "transmissionSchemaVersionNumber",
                    Campo005 = "warehouseLocationID",
                    Campo006 = "manifestCreateDateTime",
                    Campo007 = "loadReferenceID",
                    Campo008 = "trailerName",
                    Campo009 = "carrierInternalID",
                    Campo010 = "amazonTechnicalName01",
                    Campo011 = "amazonTechnicalName02",
                    Campo012 = "manifestNumber",
                    Campo013 = "carrierAccountID",
                    Campo014 = "shipmentDate",
                    Campo016 = "currencyCode",
                    Campo017 = "AddressType",
                    Campo018 = "amazonTaxID",
                    Campo019 = "prepaidCollect",
                    Campo020 = "name",
                    Campo021 = "addressLine1",
                    Campo022 = "addressLine2",
                    Campo023 = "city",
                    Campo024 = "stateProvince",
                    Campo025 = "zip",
                    Campo026 = "countryCode",
                    Campo027 = "countryName"
                });

                await _headerService.AddAsync(new GeralHeaderModel()
                {
                    RefHeader = headerId,
                    Arquivo = nomeArquivo,
                    Linha = 1,
                    Descricao = descricao,
                    Campo001 = trans.receivingPartyID,
                    Campo002 = trans.sendingPartyID,
                    Campo003 = trans.transmissionCreationDate.ToString(),
                    Campo004 = trans.transmissionSchemaVersionNumber.ToString(),
                    Campo005 = trans.message.amazonManifest.manifestHeader.warehouseLocationID,
                    Campo006 = trans.message.amazonManifest.manifestHeader.manifestCreateDateTime.ToString(),
                    Campo007 = trans.message.amazonManifest.manifestHeader.loadReferenceID,
                    Campo008 = trans.message.amazonManifest.manifestHeader.trailerName,
                    Campo009 = trans.message.amazonManifest.manifestHeader.carrierInternalID,
                    Campo010 = trans.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName,
                    Campo011 = !string.IsNullOrEmpty(trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName)
                             ? trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName
                             : null,
                    Campo012 = trans.message.amazonManifest.manifestHeader.manifestNumber.ToString(),
                    Campo013 = trans.message.amazonManifest.manifestHeader.carrierAccountID,
                    Campo014 = trans.message.amazonManifest.manifestHeader.shipmentDate.ToString(),
                    Campo016 = trans.message.amazonManifest.manifestHeader.currencyCode,
                    Campo017 = trans.message.amazonManifest.manifestHeader.shipFromAddress.AddressType,
                    Campo018 = trans.message.amazonManifest.manifestHeader.shipperInformation.amazonTaxID,
                    Campo019 = trans.message.amazonManifest.manifestHeader.prepaidCollect,
                    Campo020 = trans.message.amazonManifest.manifestHeader.shipFromAddress.name,
                    Campo021 = trans.message.amazonManifest.manifestHeader.shipFromAddress.addressLine1.ToString(),
                    Campo022 = trans.message.amazonManifest.manifestHeader.shipFromAddress.addressLine2.ToString(),
                    Campo023 = trans.message.amazonManifest.manifestHeader.shipFromAddress.city,
                    Campo024 = trans.message.amazonManifest.manifestHeader.shipFromAddress.stateChoice.stateProvince,
                    Campo025 = trans.message.amazonManifest.manifestHeader.shipFromAddress.zip.ToString(),
                    Campo026 = trans.message.amazonManifest.manifestHeader.shipFromAddress.countryCode.ToString(),
                    Campo027 = trans.message.amazonManifest.manifestHeader.shipFromAddress.countryName.ToString(),
                });

          
                var lst = new List<GeralDetalheModel>();

                lst.Add(new GeralDetalheModel()
                {
                    HeaderId = headerId,                    
                    Linha = 0,
                    Campo001 = "manifestDetail.customerOrderNumber",
                    Campo002 = "manifestDetail.consigneeAddress.AddressType",
                    Campo003 = "manifestDetail.consigneeAddress.name",
                    Campo004 = "manifestDetail.consigneeAddress.addressLine1",
                    Campo005 = "manifestDetail.consigneeAddress.addressLine2",
                    Campo006 = "manifestDetail.consigneeAddress.city",
                    Campo007 = "manifestDetail.consigneeAddress.stateChoice.stateProvince",
                    Campo008 = "manifestDetail.consigneeAddress.zip",
                    Campo009 = "manifestDetail.consigneeAddress.countryCode",
                    Campo010 = "manifestDetail.consigneeAddress.countryName",
                    Campo011 = "manifestDetail.consigneeAddress.contactPhone",
                    Campo012 = "manifestDetail.consigneeAddress.contactEmail",
                    Campo013 = "manifestDetail.consigneeAddress.contactEmailFull",
                    Campo014 = "manifestDetail.consigneeAddress.amzShipAddressUsage",
                    Campo015 = "manifestDetail.isExportChargePrepaid",
                    Campo016 = "manifestDetail.brNFe.sellerCnpj",
                    Campo017 = "manifestDetail.brNFe.customerCnpjCpf",
                    Campo018 = "manifestDetail.brNFe.nfeSerie",
                    Campo019 = "manifestDetail.brNFe.nfeAccessCode",
                    Campo020 = "manifestDetail.brNFe.nfeIssuanceDate",
                    Campo021 = "manifestDetail.brNFe.nfeAddress.Street",
                    Campo022 = "manifestDetail.brNFe.nfeAddress.number",
                    Campo023 = "manifestDetail.brNFe.nfeAddress.complement",
                    Campo024 = "manifestDetail.brNFe.nfeAddress.borough",
                    Campo025 = "manifestDetail.brNFe.nfeAddress.zipcode",
                    Campo026 = "manifestDetail.brNFe.nfeAddress.city",
                    Campo027 = "manifestDetail.brNFe.nfeAddress.state",
                    Campo028 = "manifestDetail.brNFe.nfeAddress.phone",
                    Campo029 = "manifestDetail.brNFe.nfeICMSSTAmount",
                    Campo030 = "manifestDetail.brNFe.nfeProductsTotalValue",
                    Campo031 = "manifestDetail.brNFe.nfeTotalValue",
                    Campo032 = "manifestDetail.shipmentCostInfo.termsOfSale",
                    Campo033 = "manifestDetail.shipmentCostInfo.amazonFreightCost.chargeOrAllowance",
                    Campo034 = "manifestDetail.shipmentCostInfo.amazonFreightCost.monetaryAmount",
                    Campo035 = "manifestDetail.shipmentCostInfo.amazonFreightCost.monetaryAmount.currencyISOCode",
                    Campo036 = "manifestDetail.shipmentCostInfo.valueOfGoods.chargeOrAllowance",
                    Campo037 = "manifestDetail.shipmentCostInfo.valueOfGoods.monetaryAmount",
                    Campo038 = "manifestDetail.shipmentCostInfo.valueOfGoods.monetaryAmount.currencyISOCode",
                    Campo039 = "manifestDetail.shipmentCostInfo.CIF.chargeOrAllowance",
                    Campo040 = "manifestDetail.shipmentCostInfo.CIF.monetaryAmount",
                    Campo041 = "manifestDetail.shipmentCostInfo.CIF.monetaryAmount.currencyISOCode",
                    Campo042 = "manifestDetail.shipmentCostInfo.consigneeFreightCharge.chargeOrAllowance",
                    Campo043 = "manifestDetail.shipmentCostInfo.consigneeFreightCharge.monetaryAmount",
                    Campo044 = "manifestDetail.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.currencyISOCode",
                    Campo045 = "manifestDetail.shipmentPackageInfo.cartonID.amazonBarCode",
                    Campo046 = "manifestDetail.shipmentPackageInfo.cartonID.encryptedShipmentID",
                    Campo047 = "manifestDetail.shipmentPackageInfo.cartonID.packageID",
                    Campo048 = "manifestDetail.shipmentPackageInfo.cartonID.trackingID",
                    Campo049 = "manifestDetail.shipmentPackageInfo.packageShipmentMethod.amazonTechnicalName",
                    Campo050 = "manifestDetail.shipmentPackageInfo.shipZone",
                    Campo051 = "manifestDetail.shipmentPackageInfo.shipSort",
                    Campo052 = "manifestDetail.shipmentPackageInfo.commercialInvoiceDate",
                    Campo053 = "manifestDetail.shipmentPackageInfo.scheduledDeliveryDate",
                    Campo054 = "manifestDetail.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue",
                    Campo055 = "manifestDetail.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.unitOfMeasure",
                    Campo056 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimWtCalcMethod",
                    Campo057 = "manifestDetail.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue",
                    Campo058 = "manifestDetail.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.unitOfMeasure",
                    Campo059 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.lengthValue",
                    Campo060 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.unitOfMeasure",
                    Campo061 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.heightValue",
                    Campo062 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.heightValue.unitOfMeasure",
                    Campo063 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.widthValue",
                    Campo064 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.widthValue.unitOfMeasure",
                    Campo065 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.OrderingOrderId",
                    Campo066 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemID",
                    Campo067 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemID.type",
                    Campo068 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemID.isFreeRep",
                    Campo069 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemTitle",
                    Campo070 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemQuantity.quantity",
                    Campo071 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemQuantity.quantity.unitOfMeasure",
                    Campo072 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.isHazmat",
                    Campo073 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemUnitPrice.chargeOrAllowance",
                    Campo074 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemUnitPrice.monetaryAmount",
                    Campo075 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemUnitPrice.monetaryAmount.currencyISOCode",
                    Campo076 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemExtendedPrice.chargeOrAllowance",
                    Campo077 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemExtendedPrice.monetaryAmount",
                    Campo078 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemExtendedPrice.monetaryAmount.currencyISOCode",
                    Campo079 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemWeight.weightValue.unitOfMeasure",
                    Campo080 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemWeight.weightValue",
                    Campo081 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.harmonizedTariffNumber",
                    Campo082 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.harmonizedTariffDescription",
                    Campo083 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.countryOfOrigin",

                }) ;

                lst.Add(new GeralDetalheModel()
                {
                    HeaderId = headerId,
                    Linha = 1,
                    Campo001 = trans.receivingPartyID,
                    Campo002 = trans.sendingPartyID,
                    Campo003 = string.Format("{0:dd/MM/yyyy}", trans.transmissionCreationDate),
                    Campo004 = string.Format("{0:0.00#,##}", trans.transmissionSchemaVersionNumber),
                    Campo005 = trans.message.amazonManifest.manifestHeader.warehouseLocationID,
                    Campo006 = string.Format("{0:dd/MM/yyyy}", trans.message.amazonManifest.manifestHeader.manifestCreateDateTime),
                    Campo007 = trans.message.amazonManifest.manifestHeader.loadReferenceID,
                    Campo008 = trans.message.amazonManifest.manifestHeader.trailerName,
                    Campo009 = trans.message.amazonManifest.manifestHeader.carrierInternalID,
                    Campo010 = trans.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName,
                    Campo011 = !string.IsNullOrEmpty(trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName)
                             ? trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName
                             : null,
                    Campo012 = trans.message.amazonManifest.manifestHeader.manifestNumber.ToString(),
                    Campo013 = trans.message.amazonManifest.manifestHeader.carrierAccountID,
                    Campo014 = string.Format("{0:dd/MM/yyyy}", trans.message.amazonManifest.manifestHeader.shipmentDate),
                    Campo016 = trans.message.amazonManifest.manifestHeader.currencyCode,
                    Campo017 = trans.message.amazonManifest.manifestHeader.shipFromAddress.AddressType,
                    Campo018 = trans.message.amazonManifest.manifestHeader.shipperInformation.amazonTaxID,
                    Campo019 = trans.message.amazonManifest.manifestHeader.prepaidCollect,
                    Campo020 = trans.message.amazonManifest.manifestHeader.shipFromAddress.name,
                    Campo021 = trans.message.amazonManifest.manifestHeader.shipFromAddress.addressLine1.ToString(),
                    Campo022 = trans.message.amazonManifest.manifestHeader.shipFromAddress.addressLine2.ToString(),
                    Campo023 = trans.message.amazonManifest.manifestHeader.shipFromAddress.city,
                    Campo024 = trans.message.amazonManifest.manifestHeader.shipFromAddress.stateChoice.stateProvince,
                    Campo025 = trans.message.amazonManifest.manifestHeader.shipFromAddress.zip.ToString(),
                    Campo026 = trans.message.amazonManifest.manifestHeader.shipFromAddress.countryCode.ToString(),
                    Campo027 = trans.message.amazonManifest.manifestHeader.shipFromAddress.countryName.ToString(),
                });

                await _detalherService.AddRangeAsync(lst);

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, "It seems the exception happened. :(");
                _logger.LogWarning(e.Message, "This is your last warning!");
                _logger.LogInformation(e.Message, "And this is fatal error...");
            }
        }
                //public async Task<bool> Processa(string value, string arquivo, string id, string pasta)
                //{
                //    try
                //    {

                //        //XmlSerializer ser = new XmlSerializer(typeof(AmazonSellersModel.transmission));
                //        //AmazonSellersModel.transmission lista;
                //        //using (Stream reader = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                //        //{
                //        //    lista = (AmazonSellersModel.transmission)ser.Deserialize(reader);
                //        //}

                //        GeralHeaderModel GeralHeaderModel = new GeralHeaderModel();

                //        GeralHeaderModel = new GeralHeaderModel()
                //        {
                //            Arquivo = 0,
                //            Linha = 0,
                //            Campo001 = "receivingPartyID",
                //            Campo002 = "sendingPartyID",
                //            Campo003 = "transmissionCreationDate",
                //            Campo004 = "transmissionSchemaVersionNumber",
                //            Campo005 = "warehouseLocationID",
                //            Campo006 = "manifestCreateDateTime",
                //            Campo007 = "loadReferenceID",
                //            Campo008 = "trailerName",
                //            Campo009 = "carrierInternalID",
                //            Campo010 = "amazonTechnicalName01",
                //            Campo011 = "amazonTechnicalName02",
                //            Campo012 = "manifestNumber",
                //            Campo013 = "carrierAccountID",
                //            Campo014 = "shipmentDate",
                //            Campo016 = "currencyCode",
                //            Campo017 = "AddressType",
                //            Campo018 = "amazonTaxID",
                //            Campo019 = "prepaidCollect",
                //            Campo020 = "name",
                //            Campo021 = "addressLine1",
                //            Campo022 = "addressLine2",
                //            Campo023 = "city",
                //            Campo024 = "stateProvince",
                //            Campo025 = "zip",
                //            Campo026 = "countryCode",
                //            Campo027 = "countryName"
                //        };

                //        var headerId = await _contextHeader.AddAsync(GeralHeaderModel);

                //        GeralHeaderModel.Arquivo = headerId;
                //        GeralHeaderModel.Linha = 1;
                //        GeralHeaderModel.Descricao = pasta + " - " + arquivo + " - " + id;
                //        GeralHeaderModel.Campo001 = lista.receivingPartyID;
                //        GeralHeaderModel.Campo002 = lista.sendingPartyID;
                //        GeralHeaderModel.Campo003 = lista.transmissionCreationDate.ToString();
                //        GeralHeaderModel.Campo004 = lista.transmissionSchemaVersionNumber.ToString();
                //        GeralHeaderModel.Campo005 = lista.message.amazonManifest.manifestHeader.warehouseLocationID;
                //        GeralHeaderModel.Campo006 = lista.message.amazonManifest.manifestHeader.manifestCreateDateTime.ToString();
                //        GeralHeaderModel.Campo007 = lista.message.amazonManifest.manifestHeader.loadReferenceID;
                //        GeralHeaderModel.Campo008 = lista.message.amazonManifest.manifestHeader.trailerName;
                //        GeralHeaderModel.Campo009 = lista.message.amazonManifest.manifestHeader.carrierInternalID;
                //        GeralHeaderModel.Campo010 = lista.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName;
                //        GeralHeaderModel.Campo011 = null;
                //        if (arquivo == "EXPEDITED" && id == "XBRA")
                //        {
                //            GeralHeaderModel.Campo011 = lista.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName;
                //        }
                //        GeralHeaderModel.Campo012 = lista.message.amazonManifest.manifestHeader.manifestNumber.ToString();
                //        GeralHeaderModel.Campo013 = lista.message.amazonManifest.manifestHeader.carrierAccountID;
                //        GeralHeaderModel.Campo014 = lista.message.amazonManifest.manifestHeader.shipmentDate.ToString();
                //        GeralHeaderModel.Campo016 = lista.message.amazonManifest.manifestHeader.currencyCode;
                //        GeralHeaderModel.Campo017 = lista.message.amazonManifest.manifestHeader.shipFromAddress.AddressType;
                //        GeralHeaderModel.Campo018 = lista.message.amazonManifest.manifestHeader.shipperInformation.amazonTaxID;
                //        GeralHeaderModel.Campo019 = lista.message.amazonManifest.manifestHeader.prepaidCollect;
                //        GeralHeaderModel.Campo020 = lista.message.amazonManifest.manifestHeader.shipFromAddress.name;
                //        GeralHeaderModel.Campo021 = lista.message.amazonManifest.manifestHeader.shipFromAddress.addressLine1.ToString();
                //        GeralHeaderModel.Campo022 = lista.message.amazonManifest.manifestHeader.shipFromAddress.addressLine2.ToString();
                //        GeralHeaderModel.Campo023 = lista.message.amazonManifest.manifestHeader.shipFromAddress.city;
                //        GeralHeaderModel.Campo024 = lista.message.amazonManifest.manifestHeader.shipFromAddress.stateChoice.stateProvince;
                //        GeralHeaderModel.Campo025 = lista.message.amazonManifest.manifestHeader.shipFromAddress.zip.ToString();
                //        GeralHeaderModel.Campo026 = lista.message.amazonManifest.manifestHeader.shipFromAddress.countryCode.ToString();
                //        GeralHeaderModel.Campo027 = lista.message.amazonManifest.manifestHeader.shipFromAddress.countryName.ToString();

                //        headerId = await _contextHeader.AddAsync(GeralHeaderModel);

                //        long detalheId = 0;

                //        List<GeralDetalheModel> _GeralDetalheModel = new List<GeralDetalheModel>();

                //        _GeralDetalheModel.Clear();
                //        _GeralDetalheModel.Add(new GeralDetalheModel()
                //        {
                //            HeaderIdPai = headerId,
                //            Linha = 0,
                //            Campo001 = "manifestDetail.customerOrderNumber",
                //            Campo002 = "manifestDetail.consigneeAddress.AddressType",
                //            Campo003 = "manifestDetail.consigneeAddress.name",
                //            Campo004 = "manifestDetail.consigneeAddress.addressLine1",
                //            Campo005 = "manifestDetail.consigneeAddress.addressLine2",
                //            Campo006 = "manifestDetail.consigneeAddress.city",
                //            Campo007 = "manifestDetail.consigneeAddress.stateChoice.stateProvince",
                //            Campo008 = "manifestDetail.consigneeAddress.zip",
                //            Campo009 = "manifestDetail.consigneeAddress.countryCode",
                //            Campo010 = "manifestDetail.consigneeAddress.countryName",
                //            Campo011 = "manifestDetail.consigneeAddress.contactPhone",
                //            Campo012 = "manifestDetail.consigneeAddress.contactEmail",
                //            Campo013 = "manifestDetail.consigneeAddress.contactEmailFull",
                //            Campo014 = "manifestDetail.consigneeAddress.amzShipAddressUsage",
                //            Campo015 = "manifestDetail.isExportChargePrepaid",
                //            Campo016 = "manifestDetail.brNFe.sellerCnpj",
                //            Campo017 = "manifestDetail.brNFe.customerCnpjCpf",
                //            Campo018 = "manifestDetail.brNFe.nfeSerie",
                //            Campo019 = "manifestDetail.brNFe.nfeAccessCode",
                //            Campo020 = "manifestDetail.brNFe.nfeIssuanceDate",
                //            Campo021 = "manifestDetail.brNFe.nfeAddress.Street",
                //            Campo022 = "manifestDetail.brNFe.nfeAddress.number",
                //            Campo023 = "manifestDetail.brNFe.nfeAddress.complement",
                //            Campo024 = "manifestDetail.brNFe.nfeAddress.borough",
                //            Campo025 = "manifestDetail.brNFe.nfeAddress.zipcode",
                //            Campo026 = "manifestDetail.brNFe.nfeAddress.city",
                //            Campo027 = "manifestDetail.brNFe.nfeAddress.state",
                //            Campo028 = "manifestDetail.brNFe.nfeAddress.phone",
                //            Campo029 = "manifestDetail.brNFe.nfeICMSSTAmount",
                //            Campo030 = "manifestDetail.brNFe.nfeProductsTotalValue",
                //            Campo031 = "manifestDetail.brNFe.nfeTotalValue",
                //            Campo032 = "manifestDetail.shipmentCostInfo.termsOfSale",
                //            Campo033 = "manifestDetail.shipmentCostInfo.amazonFreightCost.chargeOrAllowance",
                //            Campo034 = "manifestDetail.shipmentCostInfo.amazonFreightCost.monetaryAmount",
                //            Campo035 = "manifestDetail.shipmentCostInfo.amazonFreightCost.monetaryAmount.currencyISOCode",
                //            Campo036 = "manifestDetail.shipmentCostInfo.valueOfGoods.chargeOrAllowance",
                //            Campo037 = "manifestDetail.shipmentCostInfo.valueOfGoods.monetaryAmount",
                //            Campo038 = "manifestDetail.shipmentCostInfo.valueOfGoods.monetaryAmount.currencyISOCode",
                //            Campo039 = "manifestDetail.shipmentCostInfo.CIF.chargeOrAllowance",
                //            Campo040 = "manifestDetail.shipmentCostInfo.CIF.monetaryAmount",
                //            Campo041 = "manifestDetail.shipmentCostInfo.CIF.monetaryAmount.currencyISOCode",
                //            Campo042 = "manifestDetail.shipmentCostInfo.consigneeFreightCharge.chargeOrAllowance",
                //            Campo043 = "manifestDetail.shipmentCostInfo.consigneeFreightCharge.monetaryAmount",
                //            Campo044 = "manifestDetail.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.currencyISOCode",
                //            Campo045 = "manifestDetail.shipmentPackageInfo.cartonID.amazonBarCode",
                //            Campo046 = "manifestDetail.shipmentPackageInfo.cartonID.encryptedShipmentID",
                //            Campo047 = "manifestDetail.shipmentPackageInfo.cartonID.packageID",
                //            Campo048 = "manifestDetail.shipmentPackageInfo.cartonID.trackingID",
                //            Campo049 = "manifestDetail.shipmentPackageInfo.packageShipmentMethod.amazonTechnicalName",
                //            Campo050 = "manifestDetail.shipmentPackageInfo.shipZone",
                //            Campo051 = "manifestDetail.shipmentPackageInfo.shipSort",
                //            Campo052 = "manifestDetail.shipmentPackageInfo.commercialInvoiceDate",
                //            Campo053 = "manifestDetail.shipmentPackageInfo.scheduledDeliveryDate",
                //            Campo054 = "manifestDetail.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue",
                //            Campo055 = "manifestDetail.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.unitOfMeasure",
                //            Campo056 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimWtCalcMethod",
                //            Campo057 = "manifestDetail.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue",
                //            Campo058 = "manifestDetail.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.unitOfMeasure",
                //            Campo059 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.lengthValue",
                //            Campo060 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.unitOfMeasure",
                //            Campo061 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.heightValue",
                //            Campo062 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.heightValue.unitOfMeasure",
                //            Campo063 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.widthValue",
                //            Campo064 = "manifestDetail.shipmentPackageInfo.shipmentPackageDimensions.widthValue.unitOfMeasure",
                //            Campo065 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.OrderingOrderId",
                //            Campo066 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemID",
                //            Campo067 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemID.type",
                //            Campo068 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemID.isFreeRep",
                //            Campo069 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemTitle",
                //            Campo070 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemQuantity.quantity",
                //            Campo071 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemQuantity.quantity.unitOfMeasure",
                //            Campo072 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.isHazmat",
                //            Campo073 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemUnitPrice.chargeOrAllowance",
                //            Campo074 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemUnitPrice.monetaryAmount",
                //            Campo075 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemUnitPrice.monetaryAmount.currencyISOCode",
                //            Campo076 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemExtendedPrice.chargeOrAllowance",
                //            Campo077 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemExtendedPrice.monetaryAmount",
                //            Campo078 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemPriceInfo.itemExtendedPrice.monetaryAmount.currencyISOCode",
                //            Campo079 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemWeight.weightValue.unitOfMeasure",
                //            Campo080 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.itemWeight.weightValue",
                //            Campo081 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.harmonizedTariffNumber",
                //            Campo082 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.harmonizedTariffDescription",
                //            Campo083 = "manifestDetail.shipmentPackageInfo.shipmentPackageItemDetail.countryOfOrigin",

                //        });
                //        detalheId = await _contextDetalhe.AddAsync(_GeralDetalheModel[0]);

                //        foreach (var item in lista.message.amazonManifest.manifestDetail)
                //        {
                //            _GeralDetalheModel.Clear();
                //            _GeralDetalheModel.Add(new GeralDetalheModel()
                //            {
                //            HeaderIdPai = headerId,
                //            Linha = 1,
                //            Campo001 = item.customerOrderNumber,
                //            Campo002 = item.consigneeAddress.AddressType,
                //            Campo003 = item.consigneeAddress.name,
                //            Campo004 = item.consigneeAddress.addressLine1,
                //            Campo005 = item.consigneeAddress.addressLine2,
                //            Campo006 = item.consigneeAddress.city,
                //            Campo007 = item.consigneeAddress.stateChoice.stateProvince,
                //            Campo008 = item.consigneeAddress.zip.ToString(),
                //            Campo009 = item.consigneeAddress.countryCode,
                //            Campo010 = item.consigneeAddress.countryName,
                //            Campo011 = item.consigneeAddress.contactPhone,
                //            Campo015 = item.isExportChargePrepaid,
                //            Campo016 = item.brNFe.sellerCnpj.ToString(),
                //            Campo017 = item.brNFe.customerCnpjCpf.ToString(),
                //            Campo018 = item.brNFe.nfeSerie.ToString(),
                //            Campo019 = item.brNFe.nfeAccessCode,
                //            Campo020 = item.brNFe.nfeIssuanceDate.ToString(),
                //            Campo021 = item.brNFe.nfeAddress.Street,
                //            Campo022 = item.brNFe.nfeAddress.number.ToString(),
                //            Campo023 = item.brNFe.nfeAddress.complement,
                //            Campo024 = item.brNFe.nfeAddress.borough,
                //            Campo025 = item.brNFe.nfeAddress.zipcode.ToString(),
                //            Campo026 = item.brNFe.nfeAddress.city,
                //            Campo027 = item.brNFe.nfeAddress.state,
                //            Campo028 = item.brNFe.nfeAddress.phone.ToString(),
                //            Campo029 = item.brNFe.nfeICMSSTAmount.ToString(),
                //            Campo030 = item.brNFe.nfeProductsTotalValue.ToString(),
                //            Campo031 = item.brNFe.nfeTotalValue.ToString(),
                //            Campo032 = item.shipmentCostInfo.termsOfSale,
                //            Campo033 = item.shipmentCostInfo.amazonFreightCost.chargeOrAllowance,
                //            Campo034 = item.shipmentCostInfo.amazonFreightCost.monetaryAmount.ToString(),
                //            Campo035 = item.shipmentCostInfo.amazonFreightCost.monetaryAmount.currencyISOCode,
                //            Campo036 = item.shipmentCostInfo.valueOfGoods.chargeOrAllowance,
                //            Campo037 = item.shipmentCostInfo.valueOfGoods.monetaryAmount.ToString(),
                //            Campo038 = item.shipmentCostInfo.valueOfGoods.monetaryAmount.currencyISOCode.ToString(),
                //            Campo039 = item.shipmentCostInfo.CIF.chargeOrAllowance,
                //            Campo040 = item.shipmentCostInfo.CIF.monetaryAmount.ToString(),
                //            Campo041 = item.shipmentCostInfo.CIF.monetaryAmount.currencyISOCode,
                //            Campo042 = item.shipmentCostInfo.consigneeFreightCharge.chargeOrAllowance,
                //            Campo043 = item.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.ToString(),
                //            Campo044 = item.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.currencyISOCode,
                //            Campo045 = item.shipmentPackageInfo.cartonID.amazonBarCode,
                //            Campo046 = item.shipmentPackageInfo.cartonID.encryptedShipmentID,
                //            Campo047 = item.shipmentPackageInfo.cartonID.packageID.ToString(),
                //            Campo048 = item.shipmentPackageInfo.cartonID.trackingID,
                //            Campo049 = item.shipmentPackageInfo.packageShipmentMethod.amazonTechnicalName,
                //            Campo050 = item.shipmentPackageInfo.shipZone,
                //            Campo051 = item.shipmentPackageInfo.shipSort,
                //            Campo052 = item.shipmentPackageInfo.commercialInvoiceDate.ToString(),
                //            Campo053 = item.shipmentPackageInfo.scheduledDeliveryDate.ToString(),
                //            Campo054 = item.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.ToString(),
                //            Campo055 = item.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.unitOfMeasure,
                //            Campo056 = item.shipmentPackageInfo.shipmentPackageDimWtCalcMethod,
                //            Campo057 = item.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.ToString(),
                //            Campo058 = item.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.unitOfMeasure,
                //            Campo059 = item.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.ToString(),
                //            Campo060 = item.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.unitOfMeasure,
                //            Campo061 = item.shipmentPackageInfo.shipmentPackageDimensions.heightValue.ToString(),
                //            Campo062 = item.shipmentPackageInfo.shipmentPackageDimensions.heightValue.unitOfMeasure,
                //            Campo063 = item.shipmentPackageInfo.shipmentPackageDimensions.widthValue.ToString(),
                //            Campo064 = item.shipmentPackageInfo.shipmentPackageDimensions.widthValue.unitOfMeasure,
                //        });

                //        foreach (var subitem in item.shipmentPackageInfo.shipmentPackageItemDetail)
                //            {
                //                _GeralDetalheModel[0].Campo065 = subitem.itemID.ToString();
                //                _GeralDetalheModel[0].Campo066 = subitem.itemID.type;
                //                _GeralDetalheModel[0].Campo067 = subitem.itemID.isFreeRep;
                //                _GeralDetalheModel[0].Campo068 = subitem.itemTitle;
                //                _GeralDetalheModel[0].Campo069 = subitem.itemQuantity.quantity.ToString();
                //                _GeralDetalheModel[0].Campo070 = subitem.itemQuantity.quantity.unitOfMeasure;
                //                _GeralDetalheModel[0].Campo071 = subitem.isHazmat;
                //                _GeralDetalheModel[0].Campo072 = subitem.itemPriceInfo.itemUnitPrice.chargeOrAllowance;
                //                _GeralDetalheModel[0].Campo073 = subitem.itemPriceInfo.itemUnitPrice.monetaryAmount.ToString();
                //                _GeralDetalheModel[0].Campo074 = subitem.itemPriceInfo.itemUnitPrice.monetaryAmount.currencyISOCode;
                //                _GeralDetalheModel[0].Campo075 = subitem.itemPriceInfo.itemExtendedPrice.chargeOrAllowance;
                //                _GeralDetalheModel[0].Campo076 = subitem.itemPriceInfo.itemExtendedPrice.monetaryAmount.ToString();
                //                _GeralDetalheModel[0].Campo077 = subitem.itemPriceInfo.itemExtendedPrice.monetaryAmount.currencyISOCode;
                //                _GeralDetalheModel[0].Campo080 = subitem.harmonizedTariffNumber;
                //                _GeralDetalheModel[0].Campo081 = subitem.harmonizedTariffDescription;
                //                _GeralDetalheModel[0].Campo082 = subitem.countryOfOrigin;

                //                detalheId = await _contextDetalhe.AddAsync(_GeralDetalheModel[0]);
                //            }
                //        }
                //    }

                //    catch (Exception e)
                //    {
                //        Console.WriteLine("{0} Exception caught.", e);
                //    }
                //    return true;
                //}
            }
}
