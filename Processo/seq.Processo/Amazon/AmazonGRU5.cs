using seq.Domain.Entities.Amazon;
using seq.Domain.Interface.Repository.Amazon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace seq.Processo.Amazon
{
    public class AmazonGRU5
    {
        private readonly IAmazonHeaderRepository _contextHeader;
        private readonly IAmazonDetalheRepository _contextDetalhe;

        public AmazonGRU5(IAmazonHeaderRepository contextHeader, IAmazonDetalheRepository contextDetalhe)
        {
            _contextHeader = contextHeader;
            _contextDetalhe = contextDetalhe;
        }

        public async Task<bool> Processa(string value, string arquivo, string id, string pasta)
        {
            try 
            {
                XmlSerializer ser = new XmlSerializer(typeof(transmission));
                transmission lista;
                using (Stream reader = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    lista = (transmission)ser.Deserialize(reader);
                }

                AmazonHeaderModel amazonHeaderModel = new AmazonHeaderModel();

                amazonHeaderModel = new AmazonHeaderModel()
                {
                    Arquivo = 0,
                    Linha = 0,
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
                };

                var headerId = await _contextHeader.Insert(amazonHeaderModel);

                amazonHeaderModel.Arquivo = headerId;
                amazonHeaderModel.Linha = 1;
                amazonHeaderModel.Descricao = pasta + " - " + arquivo + " - " + id;
                amazonHeaderModel.Campo001 = lista.receivingPartyID;
                amazonHeaderModel.Campo002 = lista.sendingPartyID;
                amazonHeaderModel.Campo003 = lista.transmissionCreationDate.ToString();
                amazonHeaderModel.Campo004 = lista.transmissionSchemaVersionNumber.ToString();
                amazonHeaderModel.Campo005 = lista.message.amazonManifest.manifestHeader.warehouseLocationID.ToString();
                amazonHeaderModel.Campo006 = lista.message.amazonManifest.manifestHeader.manifestCreateDateTime.ToString();
                amazonHeaderModel.Campo007 = lista.message.amazonManifest.manifestHeader.loadReferenceID.ToString();
                amazonHeaderModel.Campo008 = lista.message.amazonManifest.manifestHeader.trailerName.ToString();
                amazonHeaderModel.Campo009 = lista.message.amazonManifest.manifestHeader.carrierInternalID.ToString();
                amazonHeaderModel.Campo010 = lista.message.amazonManifest.manifestHeader.shipmentMethod[0].amazonTechnicalName.ToString();
                amazonHeaderModel.Campo011 = null;
                if (arquivo == "EXPEDITED" && id == "XBRA")
                {
                    amazonHeaderModel.Campo011 = lista.message.amazonManifest.manifestHeader.shipmentMethod[1].amazonTechnicalName;
                }
                amazonHeaderModel.Campo012 = lista.message.amazonManifest.manifestHeader.manifestNumber.ToString();
                amazonHeaderModel.Campo013 = lista.message.amazonManifest.manifestHeader.carrierAccountID.ToString();
                amazonHeaderModel.Campo014 = lista.message.amazonManifest.manifestHeader.shipmentDate.ToString();
                amazonHeaderModel.Campo015 = lista.message.amazonManifest.manifestHeader.shipmentDay.ToString();
                amazonHeaderModel.Campo016 = lista.message.amazonManifest.manifestHeader.currencyCode.ToString();
                amazonHeaderModel.Campo017 = lista.message.amazonManifest.manifestHeader.shipFromAddress.AddressType.ToString();
                amazonHeaderModel.Campo018 = lista.message.amazonManifest.manifestHeader.shipperInformation.amazonTaxID.ToString();
                amazonHeaderModel.Campo019 = lista.message.amazonManifest.manifestHeader.prepaidCollect.ToString();
                amazonHeaderModel.Campo020 = lista.message.amazonManifest.manifestHeader.shipFromAddress.name.ToString();
                amazonHeaderModel.Campo021 = lista.message.amazonManifest.manifestHeader.shipFromAddress.addressLine1.ToString();
                amazonHeaderModel.Campo022 = lista.message.amazonManifest.manifestHeader.shipFromAddress.addressLine2.ToString();
                amazonHeaderModel.Campo023 = lista.message.amazonManifest.manifestHeader.shipFromAddress.city.ToString();
                amazonHeaderModel.Campo024 = lista.message.amazonManifest.manifestHeader.shipFromAddress.stateChoice.stateProvince.ToString();
                amazonHeaderModel.Campo025 = lista.message.amazonManifest.manifestHeader.shipFromAddress.zip.ToString();
                amazonHeaderModel.Campo026 = lista.message.amazonManifest.manifestHeader.shipFromAddress.countryCode.ToString();
                amazonHeaderModel.Campo027 = lista.message.amazonManifest.manifestHeader.shipFromAddress.countryName;

                headerId = await _contextHeader.Insert(amazonHeaderModel);

                long detalheId = 0;

                List<AmazonDetalheModel> _amazonDetalheModel = new List<AmazonDetalheModel>();

                _amazonDetalheModel.Clear();

                _amazonDetalheModel.Clear();
                _amazonDetalheModel.Add(new AmazonDetalheModel()
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

                });
                detalheId = await _contextDetalhe.Insert(_amazonDetalheModel[0]);

                foreach (var item in lista.message.amazonManifest.manifestDetail)
                {
                    _amazonDetalheModel.Clear();
                    _amazonDetalheModel.Add(new AmazonDetalheModel()
                    {
                        HeaderId = headerId,
                        Linha = 1,
                        Campo001 = item.customerOrderNumber,
                        Campo002 = item.consigneeAddress.AddressType,
                        Campo003 = item.consigneeAddress.name,
                        Campo004 = item.consigneeAddress.addressLine1,
                        Campo005 = item.consigneeAddress.addressLine2,
                        Campo006 = item.consigneeAddress.city,
                        Campo007 = item.consigneeAddress.stateChoice.stateProvince,
                        Campo008 = item.consigneeAddress.zip.ToString(),
                        Campo009 = item.consigneeAddress.countryCode,
                        Campo010 = item.consigneeAddress.countryName,
                        Campo011 = item.consigneeAddress.contactPhone,
                        Campo012 = item.consigneeAddress.contactEmail,
                        Campo013 = item.consigneeAddress.contactEmailFull,
                        Campo014 = item.consigneeAddress.amzShipAddressUsage,
                        Campo015 = item.isExportChargePrepaid,
                        Campo016 = item.brNFe.sellerCnpj.ToString(),
                        Campo017 = item.brNFe.customerCnpjCpf.ToString(),
                        Campo018 = item.brNFe.nfeSerie.ToString(),
                        Campo019 = item.brNFe.nfeAccessCode,
                        Campo020 = item.brNFe.nfeIssuanceDate.ToString(),
                        Campo021 = item.brNFe.nfeAddress.Street,
                        Campo022 = item.brNFe.nfeAddress.number.ToString(),
                        Campo023 = item.brNFe.nfeAddress.complement,
                        Campo024 = item.brNFe.nfeAddress.borough,
                        Campo025 = item.brNFe.nfeAddress.zipcode.ToString(),
                        Campo026 = item.brNFe.nfeAddress.city,
                        Campo027 = item.brNFe.nfeAddress.state,
                        Campo028 = item.brNFe.nfeAddress.phone.ToString(),
                        Campo029 = item.brNFe.nfeICMSSTAmount.ToString(),
                        Campo030 = item.brNFe.nfeProductsTotalValue.ToString(),
                        Campo031 = item.brNFe.nfeTotalValue.ToString(),
                        Campo032 = item.shipmentCostInfo.termsOfSale,
                        Campo033 = item.shipmentCostInfo.amazonFreightCost.chargeOrAllowance,
                        Campo034 = item.shipmentCostInfo.amazonFreightCost.monetaryAmount.Value.ToString(),
                        Campo035 = item.shipmentCostInfo.amazonFreightCost.monetaryAmount.currencyISOCode,
                        Campo036 = item.shipmentCostInfo.valueOfGoods.chargeOrAllowance,
                        Campo037 = item.shipmentCostInfo.valueOfGoods.monetaryAmount.Value.ToString(),
                        Campo038 = item.shipmentCostInfo.valueOfGoods.monetaryAmount.currencyISOCode.ToString(),
                        Campo039 = item.shipmentCostInfo.CIF.chargeOrAllowance,
                        Campo040 = item.shipmentCostInfo.CIF.monetaryAmount.Value.ToString(),
                        Campo041 = item.shipmentCostInfo.CIF.monetaryAmount.currencyISOCode,
                        Campo042 = item.shipmentCostInfo.consigneeFreightCharge.chargeOrAllowance,
                        Campo043 = item.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.Value.ToString(),
                        Campo044 = item.shipmentCostInfo.consigneeFreightCharge.monetaryAmount.currencyISOCode,
                        Campo045 = item.shipmentPackageInfo.cartonID.amazonBarCode,
                        Campo046 = item.shipmentPackageInfo.cartonID.encryptedShipmentID,
                        Campo047 = item.shipmentPackageInfo.cartonID.packageID.ToString(),
                        Campo048 = item.shipmentPackageInfo.cartonID.trackingID,
                        Campo049 = item.shipmentPackageInfo.packageShipmentMethod.amazonTechnicalName,
                        Campo050 = item.shipmentPackageInfo.shipZone,
                        Campo051 = item.shipmentPackageInfo.shipSort,
                        Campo052 = item.shipmentPackageInfo.commercialInvoiceDate.ToString(),
                        Campo053 = item.shipmentPackageInfo.scheduledDeliveryDate.ToString(),
                        Campo054 = item.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.Value.ToString(),
                        Campo055 = item.shipmentPackageInfo.shipmentPackageDeclaredGrossWeight.weightValue.unitOfMeasure,
                        Campo056 = item.shipmentPackageInfo.shipmentPackageDimWtCalcMethod,
                        Campo057 = item.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.Value.ToString(),
                        Campo058 = item.shipmentPackageInfo.shipmentPackageActualGrossWeight.weightValue.unitOfMeasure,
                        Campo059 = item.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.Value.ToString(),
                        Campo060 = item.shipmentPackageInfo.shipmentPackageDimensions.lengthValue.unitOfMeasure,
                        Campo061 = item.shipmentPackageInfo.shipmentPackageDimensions.heightValue.Value.ToString(),
                        Campo062 = item.shipmentPackageInfo.shipmentPackageDimensions.heightValue.unitOfMeasure,
                        Campo063 = item.shipmentPackageInfo.shipmentPackageDimensions.widthValue.Value.ToString(),
                        Campo064 = item.shipmentPackageInfo.shipmentPackageDimensions.widthValue.unitOfMeasure,
                    });

                    foreach (var subitem in item.shipmentPackageInfo.shipmentPackageItemDetail)
                    {
                        _amazonDetalheModel[0].Campo064 = subitem.OrderingOrderId;
                        _amazonDetalheModel[0].Campo065 = subitem.itemID.Value.ToString();
                        _amazonDetalheModel[0].Campo066 = subitem.itemID.type;
                        _amazonDetalheModel[0].Campo067 = subitem.itemID.isFreeRep;
                        _amazonDetalheModel[0].Campo068 = subitem.itemTitle;
                        _amazonDetalheModel[0].Campo069 = subitem.itemQuantity.quantity.Value.ToString();
                        _amazonDetalheModel[0].Campo070 = subitem.itemQuantity.quantity.unitOfMeasure;
                        _amazonDetalheModel[0].Campo071 = subitem.isHazmat;
                        _amazonDetalheModel[0].Campo072 = subitem.itemPriceInfo.itemUnitPrice.chargeOrAllowance;
                        _amazonDetalheModel[0].Campo073 = subitem.itemPriceInfo.itemUnitPrice.monetaryAmount.Value.ToString();
                        _amazonDetalheModel[0].Campo074 = subitem.itemPriceInfo.itemUnitPrice.monetaryAmount.currencyISOCode;
                        _amazonDetalheModel[0].Campo075 = subitem.itemPriceInfo.itemExtendedPrice.chargeOrAllowance;
                        _amazonDetalheModel[0].Campo076 = subitem.itemPriceInfo.itemExtendedPrice.monetaryAmount.Value.ToString();
                        _amazonDetalheModel[0].Campo077 = subitem.itemPriceInfo.itemExtendedPrice.monetaryAmount.currencyISOCode;
                        _amazonDetalheModel[0].Campo078 = subitem.itemWeight.weightValue.unitOfMeasure;
                        _amazonDetalheModel[0].Campo079 = subitem.itemWeight.weightValue.Value.ToString();
                        _amazonDetalheModel[0].Campo080 = subitem.harmonizedTariffNumber;
                        _amazonDetalheModel[0].Campo081 = subitem.harmonizedTariffDescription;
                        _amazonDetalheModel[0].Campo082 = subitem.countryOfOrigin;

                        detalheId = await _contextDetalhe.Insert(_amazonDetalheModel[0]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }
    }
}
