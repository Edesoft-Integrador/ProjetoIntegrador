using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Amazon
{
    class AmazonGRU5STDModel
    {

        public class Rootobject
        {
            public Transmission transmission { get; set; }
        }

        public class Transmission
        {
            public string transmissionSchemaVersionNumber { get; set; }
            public Message message { get; set; }
        }

        public class Message
        {
            public string messageType { get; set; }
            public Amazonmanifest amazonManifest { get; set; }
        }

        public class Amazonmanifest
        {
            public Manifestheader manifestHeader { get; set; }
            public Manifestdetail manifestDetail { get; set; }
            public Manifestsummary manifestSummary { get; set; }
        }

        public class Manifestheader
        {
            public string warehouseLocationID { get; set; }
            public DateTime manifestCreateDateTime { get; set; }
            public string loadReferenceID { get; set; }
            public string trailerName { get; set; }
            public string carrierInternalID { get; set; }
            public Shipmentmethod shipmentMethod { get; set; }
            public string manifestNumber { get; set; }
            public string carrierAccountID { get; set; }
            public DateTime shipmentDate { get; set; }
            public string shipmentDay { get; set; }
            public string currencyCode { get; set; }
            public Shipfromaddress shipFromAddress { get; set; }
            public Shipperinformation shipperInformation { get; set; }
            public string prepaidCollect { get; set; }
        }

        public class Shipmentmethod
        {
            public string amazonTechnicalName { get; set; }
        }

        public class Shipfromaddress
        {
            public string AddressType { get; set; }
            public string name { get; set; }
            public string addressLine1 { get; set; }
            public string addressLine2 { get; set; }
            public string city { get; set; }
            public Statechoice stateChoice { get; set; }
            public string zip { get; set; }
            public string countryCode { get; set; }
            public string countryName { get; set; }
        }

        public class Statechoice
        {
            public string stateProvince { get; set; }
        }

        public class Shipperinformation
        {
            public string amazonTaxID { get; set; }
        }

        public class Manifestdetail
        {
            public Shipmentdetail shipmentDetail { get; set; }
        }

        public class Shipmentdetail
        {
            public string customerOrderNumber { get; set; }
            public Consigneeaddress consigneeAddress { get; set; }
            public string isExportChargePrepaid { get; set; }
            public Brnfe brNFe { get; set; }
            public Shipmentcostinfo shipmentCostInfo { get; set; }
            public Shipmentpackageinfo shipmentPackageInfo { get; set; }
            public string reasonForExport { get; set; }
        }

        public class Consigneeaddress
        {
            public string AddressType { get; set; }
            public string name { get; set; }
            public string addressLine1 { get; set; }
            public string addressLine2 { get; set; }
            public string city { get; set; }
            public Statechoice1 stateChoice { get; set; }
            public string zip { get; set; }
            public string countryCode { get; set; }
            public string countryName { get; set; }
            public string contactPhone { get; set; }
            public string contactEmail { get; set; }
            public string contactEmailFull { get; set; }
            public string amzShipAddressUsage { get; set; }
        }

        public class Statechoice1
        {
            public string stateProvince { get; set; }
        }

        public class Brnfe
        {
            public string sellerCnpj { get; set; }
            public string customerCnpjCpf { get; set; }
            public string nfeNumber { get; set; }
            public string nfeSerie { get; set; }
            public string nfeAccessCode { get; set; }
            public DateTime nfeIssuanceDate { get; set; }
            public Nfeaddress nfeAddress { get; set; }
            public string nfeICMSSTAmount { get; set; }
            public string nfeICMSAmount { get; set; }
            public string nfeProductsTotalValue { get; set; }
            public string nfeTotalValue { get; set; }
        }

        public class Nfeaddress
        {
            public string Street { get; set; }
            public string number { get; set; }
            public string complement { get; set; }
            public string borough { get; set; }
            public string zipcode { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string phone { get; set; }
        }

        public class Shipmentcostinfo
        {
            public string termsOfSale { get; set; }
            public Amazonfreightcost amazonFreightCost { get; set; }
            public Valueofgoods valueOfGoods { get; set; }
            public CIF CIF { get; set; }
            public Consigneefreightcharge consigneeFreightCharge { get; set; }
        }

        public class Amazonfreightcost
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount monetaryAmount { get; set; }
        }

        public class Monetaryamount
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Valueofgoods
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount1 monetaryAmount { get; set; }
        }

        public class Monetaryamount1
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class CIF
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount2 monetaryAmount { get; set; }
        }

        public class Monetaryamount2
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Consigneefreightcharge
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount3 monetaryAmount { get; set; }
        }

        public class Monetaryamount3
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Shipmentpackageinfo
        {
            public Cartonid cartonID { get; set; }
            public Packageshipmentmethod packageShipmentMethod { get; set; }
            public string shipZone { get; set; }
            public string shipSort { get; set; }
            public string commercialInvoiceDate { get; set; }
            public string scheduledDeliveryDate { get; set; }
            public Shipmentpackagedeclaredgrossweight shipmentPackageDeclaredGrossWeight { get; set; }
            public string shipmentPackageDimWtCalcMethod { get; set; }
            public Shipmentpackageactualgrossweight shipmentPackageActualGrossWeight { get; set; }
            public Shipmentpackagedimensions shipmentPackageDimensions { get; set; }
            public Shipmentpackageitemdetail shipmentPackageItemDetail { get; set; }
            public Totaldeclaredvalue totalDeclaredValue { get; set; }
            public string pkgHarmonizedTariffDescription { get; set; }
            public Shipmentpackageitemquantity shipmentPackageItemQuantity { get; set; }
        }

        public class Cartonid
        {
            public string amazonBarCode { get; set; }
            public string encryptedShipmentID { get; set; }
            public string packageID { get; set; }
            public string trackingID { get; set; }
        }

        public class Packageshipmentmethod
        {
            public string amazonTechnicalName { get; set; }
        }

        public class Shipmentpackagedeclaredgrossweight
        {
            public Weightvalue weightValue { get; set; }
        }

        public class Weightvalue
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Shipmentpackageactualgrossweight
        {
            public Weightvalue1 weightValue { get; set; }
        }

        public class Weightvalue1
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Shipmentpackagedimensions
        {
            public Lengthvalue lengthValue { get; set; }
            public Heightvalue heightValue { get; set; }
            public Widthvalue widthValue { get; set; }
        }

        public class Lengthvalue
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Heightvalue
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Widthvalue
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Shipmentpackageitemdetail
        {
            public string OrderingOrderId { get; set; }
            public Itemid itemID { get; set; }
            public string itemTitle { get; set; }
            public Itemquantity itemQuantity { get; set; }
            public string isHazmat { get; set; }
            public Itempriceinfo itemPriceInfo { get; set; }
            public Itemweight itemWeight { get; set; }
            public string harmonizedTariffNumber { get; set; }
            public string harmonizedTariffDescription { get; set; }
            public string countryOfOrigin { get; set; }
        }

        public class Itemid
        {
            public string type { get; set; }
            public string isFreeRep { get; set; }
            public string text { get; set; }
        }

        public class Itemquantity
        {
            public Quantity quantity { get; set; }
        }

        public class Quantity
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Itempriceinfo
        {
            public Itemunitprice itemUnitPrice { get; set; }
            public Itemextendedprice itemExtendedPrice { get; set; }
        }

        public class Itemunitprice
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount4 monetaryAmount { get; set; }
        }

        public class Monetaryamount4
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Itemextendedprice
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount5 monetaryAmount { get; set; }
        }

        public class Monetaryamount5
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Itemweight
        {
            public Weightvalue2 weightValue { get; set; }
        }

        public class Weightvalue2
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Totaldeclaredvalue
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Shipmentpackageitemquantity
        {
            public Quantity1 quantity { get; set; }
        }

        public class Quantity1
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Manifestsummary
        {
            public Totalshipmentquantity totalShipmentQuantity { get; set; }
            public Totalshipmentvalue totalShipmentValue { get; set; }
            public Totaldeclaredgrossweight totalDeclaredGrossWeight { get; set; }
            public Totalactualgrossweight totalActualGrossWeight { get; set; }
        }

        public class Totalshipmentquantity
        {
            public Quantity2 quantity { get; set; }
        }

        public class Quantity2
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Totalshipmentvalue
        {
            public string chargeOrAllowance { get; set; }
            public Monetaryamount6 monetaryAmount { get; set; }
        }

        public class Monetaryamount6
        {
            public string currencyISOCode { get; set; }
            public string text { get; set; }
        }

        public class Totaldeclaredgrossweight
        {
            public Weightvalue3 weightValue { get; set; }
        }

        public class Weightvalue3
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

        public class Totalactualgrossweight
        {
            public Weightvalue4 weightValue { get; set; }
        }

        public class Weightvalue4
        {
            public string unitOfMeasure { get; set; }
            public string text { get; set; }
        }

    }
}
