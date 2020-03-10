
using seq.Domain.Entities;
using seq.Domain.Entities.GRU5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seq.Processo.Amazon
{
    public class AmazonGRU5Processo : IAmazonGRU5Processo
    {

        public AmazonGRU5Processo()
        { }

        public async Task<IEnumerable<AmazonHeaderModel>> Header(transmission trans, Guid headerIdPai, string nomeArquivo, string descricao)
        {
            try
            {
                var lst = new List<AmazonHeaderModel>();

                lst.Add(new AmazonHeaderModel()
                {
                    Arquivo = nomeArquivo,
                    Linha = 0,
                    HeaderIdPai = headerIdPai,
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
                    Campo015 = "shipmentDay",
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

                lst.Add(new AmazonHeaderModel()
                {
                    Arquivo = nomeArquivo,
                    Linha = 1,
                    HeaderIdPai = headerIdPai,
                    Descricao = descricao,
                    Campo001 = trans.receivingPartyID,
                    Campo002 = trans.sendingPartyID,
                    Campo003 = trans.transmissionCreationDate.ToString(),
                    Campo004 = trans.transmissionSchemaVersionNumber.ToString(),
                    Campo005 = trans.message.amazonManifest.manifestHeader.warehouseLocationID.ToString(),
                    Campo006 = trans.message.amazonManifest.manifestHeader.manifestCreateDateTime.ToString(),
                    Campo007 = trans.message.amazonManifest.manifestHeader.loadReferenceID.ToString(),
                    Campo008 = trans.message.amazonManifest.manifestHeader.trailerName.ToString(),
                    Campo009 = trans.message.amazonManifest.manifestHeader.carrierInternalID.ToString(),
                    Campo010 = trans.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName.ToString(),
                    Campo011 = !string.IsNullOrEmpty(trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName.ToString())
                               ? trans.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName.ToString()
                               : null,
                    Campo012 = trans.message.amazonManifest.manifestHeader.manifestNumber.ToString(),
                    Campo013 = trans.message.amazonManifest.manifestHeader.carrierAccountID.ToString(),
                    Campo014 = string.Format("{0:dd/MM/yyyy}", trans.message.amazonManifest.manifestHeader.shipmentDate),
                    Campo015 = string.Format("{0:dd/MM/yyyy}", trans.message.amazonManifest.manifestHeader.shipmentDay),
                    Campo016 = trans.message.amazonManifest.manifestHeader.currencyCode.ToString(),
                    Campo017 = trans.message.amazonManifest.manifestHeader.shipFromAddress.AddressType.ToString(),
                    Campo018 = trans.message.amazonManifest.manifestHeader.shipperInformation.amazonTaxID.ToString(),
                    Campo019 = trans.message.amazonManifest.manifestHeader.prepaidCollect.ToString(),
                    Campo020 = trans.message.amazonManifest.manifestHeader.shipFromAddress.name.ToString(),
                    Campo021 = trans.message.amazonManifest.manifestHeader.shipFromAddress.addressLine1.ToString(),
                    Campo022 = trans.message.amazonManifest.manifestHeader.shipFromAddress.addressLine2.ToString(),
                    Campo023 = trans.message.amazonManifest.manifestHeader.shipFromAddress.city.ToString(),
                    Campo024 = trans.message.amazonManifest.manifestHeader.shipFromAddress.stateChoice.stateProvince.ToString(),
                    Campo025 = trans.message.amazonManifest.manifestHeader.shipFromAddress.zip.ToString(),
                    Campo026 = trans.message.amazonManifest.manifestHeader.shipFromAddress.countryCode.ToString(),
                    Campo027 = trans.message.amazonManifest.manifestHeader.shipFromAddress.countryName,
                });

                return lst;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<AmazonDetalheModel>> Detalhe(transmission trans, Guid headerIdPai)
        {
            try
            {
                List<AmazonDetalheModel> lst = new List<AmazonDetalheModel>();

                lst.Add(new AmazonDetalheModel()
                {
                    HeaderIdPai = headerIdPai,
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

                });
                
                var lst1 = trans.message.amazonManifest.manifestDetail.SelectMany(x => 
                       x.shipmentPackageInfo.shipmentPackageItemDetail.Select(y => new AmazonDetalheModel
                 {
                    Linha = 1,
                    HeaderIdPai = headerIdPai,
                    Campo001 = x.customerOrderNumber,
                    Campo002 = x.consigneeAddress.AddressType,
                    Campo003 = x.consigneeAddress.name,
                    Campo004 = x.consigneeAddress.addressLine1,
                    Campo005 = x.consigneeAddress.addressLine2,
                    Campo006 = x.consigneeAddress.city,
                    Campo007 = x.consigneeAddress.stateChoice.stateProvince,
                    Campo008 = x.consigneeAddress.zip,
                    Campo009 = x.consigneeAddress.countryCode,
                    Campo010 = x.consigneeAddress.countryName,
                    Campo011 = x.consigneeAddress.contactPhone,
                    Campo012 = x.consigneeAddress.contactEmail,
                    Campo013 = x.consigneeAddress.contactEmailFull,
                    Campo014 = x.consigneeAddress.amzShipAddressUsage,
                    Campo015 = x.isExportChargePrepaid,
                    Campo016 = x.brNFe.sellerCnpj.ToString(),
                    Campo017 = x.brNFe.customerCnpjCpf.ToString(),
                    Campo018 = x.brNFe.nfeSerie.ToString(),
                    Campo019 = x.brNFe.nfeAccessCode,
                    Campo020 = string.Format("{0:dd/MM/yyyy}", x.brNFe.nfeIssuanceDate),
                    Campo021 = x.brNFe.nfeAddress.Street,
                    Campo022 = x.brNFe.nfeAddress.number,
                    Campo023 = x.brNFe.nfeAddress.complement,
                    Campo024 = x.brNFe.nfeAddress.borough,
                    Campo025 = x.brNFe.nfeAddress.zipcode,
                    Campo026 = x.brNFe.nfeAddress.city,
                    Campo027 = x.brNFe.nfeAddress.state,
                    Campo028 = x.brNFe.nfeAddress.phone,
                    Campo029 = string.Format("{0:0.00#,##}", x.brNFe.nfeICMSSTAmount),
                    Campo030 = string.Format("{0:0.00#,##}", x.brNFe.nfeProductsTotalValue),
                    Campo031 = string.Format("{0:0.00#,##}", x.brNFe.nfeTotalValue),

                    Campo032 = x.shipmentCostInfo.termsOfSale,
                    Campo033 = x.shipmentCostInfo.amazonFreightCost.chargeOrAllowance,
                    Campo034 = string.Format("{0:0.00#,##}", x.shipmentCostInfo.amazonFreightCost.monetaryAmount.Value),
                    Campo035 = x.shipmentCostInfo.amazonFreightCost.monetaryAmount.currencyISOCode,
                    Campo036 = x.shipmentCostInfo.valueOfGoods.chargeOrAllowance,
                    Campo037 = string.Format("{0:0.00#,##}", x.shipmentCostInfo.valueOfGoods.monetaryAmount.Value),
                    Campo038 = x.shipmentCostInfo.valueOfGoods.monetaryAmount.currencyISOCode,
                    Campo039 = x.shipmentCostInfo.CIF.chargeOrAllowance,
                    Campo040 = string.Format("{0:0.00#,##}", x.shipmentCostInfo.CIF.monetaryAmount.Value),
                    Campo041 = x.shipmentCostInfo.CIF.monetaryAmount.currencyISOCode,
                    Campo042 = x.shipmentCostInfo.consigneeFreightCharge.chargeOrAllowance,
                    Campo043 = string.Format("{0:0.00#,##}", x.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.Value),
                    Campo044 = x.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.currencyISOCode,
                    Campo045 = x.shipmentPackageInfo.cartonID.amazonBarCode,
                    Campo046 = x.shipmentPackageInfo.cartonID.encryptedShipmentID,

                    Campo047 = x.shipmentPackageInfo.cartonID.packageID.ToString(),
                    Campo048 = x.shipmentPackageInfo.cartonID.trackingID,
                    Campo049 = x.shipmentPackageInfo.packageShipmentMethod.amazonTechnicalName,
                    Campo050 = x.shipmentPackageInfo.shipZone,
                    Campo051 = x.shipmentPackageInfo.shipSort,

                    Campo052 = string.Format("{0:dd/MM/yyyy}", x.shipmentPackageInfo.commercialInvoiceDate),
                    Campo053 = string.Format("{0:dd/MM/yyyy}", x.shipmentPackageInfo.scheduledDeliveryDate),

                    Campo054 = x.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.Value.ToString(),
                    Campo055 = x.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.unitOfMeasure,
                    Campo056 = x.shipmentPackageInfo.shipmentPackageDimWtCalcMethod,

                    Campo057 = string.Format("{0:0.00#,##}", x.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.Value),
                    Campo058 = x.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.unitOfMeasure,
                    Campo059 = string.Format("{0:0.00#,##}", x.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.Value),
                    Campo060 = x.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.unitOfMeasure,
                    Campo061 = string.Format("{0:0.00#,##}", x.shipmentPackageInfo.shipmentPackageDimensions.heightValue.Value),
                    Campo062 = x.shipmentPackageInfo.shipmentPackageDimensions.heightValue.unitOfMeasure,
                    Campo063 = string.Format("{0:0.00#,##}", x.shipmentPackageInfo.shipmentPackageDimensions.widthValue.Value),
                    Campo064 = x.shipmentPackageInfo.shipmentPackageDimensions.widthValue.unitOfMeasure,

                    Campo065 = y.OrderingOrderId,
                    Campo066 = y.itemID.Value,
                    Campo067 = y.itemID.type,
                    Campo068 = y.itemID.isFreeRep,
                    Campo069 = y.itemTitle,
                    Campo070 = y.itemQuantity.quantity.Value.ToString(),
                    Campo071 = y.itemQuantity.quantity.unitOfMeasure,
                    Campo072 = y.isHazmat,
                    Campo073 = y.itemPriceInfo.itemUnitPrice.chargeOrAllowance,
                    Campo074 = string.Format("{0:0.00#,##}", y.itemPriceInfo.itemUnitPrice.monetaryAmount.Value),
                    Campo075 = y.itemPriceInfo.itemUnitPrice.monetaryAmount.currencyISOCode,
                    Campo076 = y.itemPriceInfo.itemExtendedPrice.chargeOrAllowance,
                    Campo077 = string.Format("{0:0.00#,##}", y.itemPriceInfo.itemExtendedPrice.monetaryAmount.Value),
                    Campo078 = y.itemPriceInfo.itemExtendedPrice.monetaryAmount.currencyISOCode,
                    Campo079 = y.itemWeight.weightValue.unitOfMeasure,
                    Campo080 = string.Format("{0:0.00#,##}", y.itemWeight.weightValue.Value),
                    Campo081 = y.harmonizedTariffNumber,
                    Campo082 = y.harmonizedTariffDescription,
                    Campo083 = y.countryOfOrigin,
                }));

                return lst.Union(lst1);

            } catch(Exception e)
            {
                return null;
            }
        }
  
    }
}
