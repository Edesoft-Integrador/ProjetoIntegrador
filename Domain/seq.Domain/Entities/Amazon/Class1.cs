using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Amazon
{
	/* 
	 Licensed under the Apache License, Version 2.0

	 http://www.apache.org/licenses/LICENSE-2.0
	 */
	using System;
	using System.Xml.Serialization;
	using System.Collections.Generic;
	namespace Xml2CSharp
	{
		[XmlRoot(ElementName = "shipmentMethod")]
		public class ShipmentMethod
		{
			[XmlElement(ElementName = "amazonTechnicalName")]
			public string AmazonTechnicalName { get; set; }
		}

		[XmlRoot(ElementName = "stateChoice")]
		public class StateChoice
		{
			[XmlElement(ElementName = "stateProvince")]
			public string StateProvince { get; set; }
		}

		[XmlRoot(ElementName = "shipFromAddress")]
		public class ShipFromAddress
		{
			[XmlElement(ElementName = "name")]
			public string Name { get; set; }
			[XmlElement(ElementName = "addressLine1")]
			public string AddressLine1 { get; set; }
			[XmlElement(ElementName = "addressLine2")]
			public string AddressLine2 { get; set; }
			[XmlElement(ElementName = "city")]
			public string City { get; set; }
			[XmlElement(ElementName = "stateChoice")]
			public StateChoice StateChoice { get; set; }
			[XmlElement(ElementName = "zip")]
			public string Zip { get; set; }
			[XmlElement(ElementName = "countryCode")]
			public string CountryCode { get; set; }
			[XmlElement(ElementName = "countryName")]
			public string CountryName { get; set; }
			[XmlAttribute(AttributeName = "AddressType")]
			public string AddressType { get; set; }
		}

		[XmlRoot(ElementName = "shipperInformation")]
		public class ShipperInformation
		{
			[XmlElement(ElementName = "amazonTaxID")]
			public string AmazonTaxID { get; set; }
		}

		[XmlRoot(ElementName = "manifestHeader")]
		public class ManifestHeader
		{
			[XmlElement(ElementName = "warehouseLocationID")]
			public string WarehouseLocationID { get; set; }
			[XmlElement(ElementName = "manifestCreateDateTime")]
			public string ManifestCreateDateTime { get; set; }
			[XmlElement(ElementName = "loadReferenceID")]
			public string LoadReferenceID { get; set; }
			[XmlElement(ElementName = "trailerName")]
			public string TrailerName { get; set; }
			[XmlElement(ElementName = "carrierInternalID")]
			public string CarrierInternalID { get; set; }
			[XmlElement(ElementName = "shipmentMethod")]
			public List<ShipmentMethod> ShipmentMethod { get; set; }
			[XmlElement(ElementName = "manifestNumber")]
			public string ManifestNumber { get; set; }
			[XmlElement(ElementName = "carrierAccountID")]
			public string CarrierAccountID { get; set; }
			[XmlElement(ElementName = "carrierManifestID")]
			public string CarrierManifestID { get; set; }
			[XmlElement(ElementName = "shipmentDate")]
			public string ShipmentDate { get; set; }
			[XmlElement(ElementName = "shipmentDay")]
			public string ShipmentDay { get; set; }
			[XmlElement(ElementName = "currencyCode")]
			public string CurrencyCode { get; set; }
			[XmlElement(ElementName = "shipFromAddress")]
			public List<ShipFromAddress> ShipFromAddress { get; set; }
			[XmlElement(ElementName = "shipperInformation")]
			public List<ShipperInformation> ShipperInformation { get; set; }
			[XmlElement(ElementName = "prepaidCollect")]
			public string PrepaidCollect { get; set; }
		}

		[XmlRoot(ElementName = "consigneeAddress")]
		public class ConsigneeAddress
		{
			[XmlElement(ElementName = "name")]
			public string Name { get; set; }
			[XmlElement(ElementName = "addressLine1")]
			public string AddressLine1 { get; set; }
			[XmlElement(ElementName = "addressLine2")]
			public string AddressLine2 { get; set; }
			[XmlElement(ElementName = "city")]
			public string City { get; set; }
			[XmlElement(ElementName = "stateChoice")]
			public StateChoice StateChoice { get; set; }
			[XmlElement(ElementName = "zip")]
			public string Zip { get; set; }
			[XmlElement(ElementName = "countryCode")]
			public string CountryCode { get; set; }
			[XmlElement(ElementName = "countryName")]
			public string CountryName { get; set; }
			[XmlElement(ElementName = "contactPhone")]
			public string ContactPhone { get; set; }
			[XmlElement(ElementName = "contactEmail")]
			public string ContactEmail { get; set; }
			[XmlElement(ElementName = "contactEmailFull")]
			public string ContactEmailFull { get; set; }
			[XmlElement(ElementName = "amzShipAddressUsage")]
			public string AmzShipAddressUsage { get; set; }
			[XmlAttribute(AttributeName = "AddressType")]
			public string AddressType { get; set; }
		}

		[XmlRoot(ElementName = "nfeAddress")]
		public class NfeAddress
		{
			[XmlElement(ElementName = "Street")]
			public string Street { get; set; }
			[XmlElement(ElementName = "number")]
			public string Number { get; set; }
			[XmlElement(ElementName = "complement")]
			public string Complement { get; set; }
			[XmlElement(ElementName = "borough")]
			public string Borough { get; set; }
			[XmlElement(ElementName = "zipcode")]
			public string Zipcode { get; set; }
			[XmlElement(ElementName = "city")]
			public string City { get; set; }
			[XmlElement(ElementName = "state")]
			public string State { get; set; }
			[XmlElement(ElementName = "phone")]
			public string Phone { get; set; }
		}

		[XmlRoot(ElementName = "brNFe")]
		public class BrNFe
		{
			[XmlElement(ElementName = "sellerCnpj")]
			public string SellerCnpj { get; set; }
			[XmlElement(ElementName = "customerCnpjCpf")]
			public string CustomerCnpjCpf { get; set; }
			[XmlElement(ElementName = "nfeNumber")]
			public string NfeNumber { get; set; }
			[XmlElement(ElementName = "nfeSerie")]
			public string NfeSerie { get; set; }
			[XmlElement(ElementName = "nfeAccessCode")]
			public string NfeAccessCode { get; set; }
			[XmlElement(ElementName = "nfeIssuanceDate")]
			public string NfeIssuanceDate { get; set; }
			[XmlElement(ElementName = "nfeAddress")]
			public NfeAddress NfeAddress { get; set; }
			[XmlElement(ElementName = "nfeICMSSTAmount")]
			public string NfeICMSSTAmount { get; set; }
			[XmlElement(ElementName = "nfeICMSAmount")]
			public string NfeICMSAmount { get; set; }
			[XmlElement(ElementName = "nfeProductsTotalValue")]
			public string NfeProductsTotalValue { get; set; }
			[XmlElement(ElementName = "nfeTotalValue")]
			public string NfeTotalValue { get; set; }
		}

		[XmlRoot(ElementName = "monetaryAmount")]
		public class MonetaryAmount
		{
			[XmlAttribute(AttributeName = "currencyISOCode")]
			public string CurrencyISOCode { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "amazonFreightCost")]
		public class AmazonFreightCost
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "valueOfGoods")]
		public class ValueOfGoods
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "CIF")]
		public class CIF
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "consigneeFreightCharge")]
		public class ConsigneeFreightCharge
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "shipmentCostInfo")]
		public class ShipmentCostInfo
		{
			[XmlElement(ElementName = "termsOfSale")]
			public string TermsOfSale { get; set; }
			[XmlElement(ElementName = "amazonFreightCost")]
			public List<AmazonFreightCost> AmazonFreightCost { get; set; }
			[XmlElement(ElementName = "valueOfGoods")]
			public List<ValueOfGoods> ValueOfGoods { get; set; }
			[XmlElement(ElementName = "CIF")]
			public List<CIF> CIF { get; set; }
			[XmlElement(ElementName = "consigneeFreightCharge")]
			public List<ConsigneeFreightCharge> ConsigneeFreightCharge { get; set; }
		}

		[XmlRoot(ElementName = "cartonID")]
		public class CartonID
		{
			[XmlElement(ElementName = "amazonBarCode")]
			public string AmazonBarCode { get; set; }
			[XmlElement(ElementName = "encryptedShipmentID")]
			public string EncryptedShipmentID { get; set; }
			[XmlElement(ElementName = "packageID")]
			public string PackageID { get; set; }
			[XmlElement(ElementName = "trackingID")]
			public string TrackingID { get; set; }
		}

		[XmlRoot(ElementName = "packageShipmentMethod")]
		public class PackageShipmentMethod
		{
			[XmlElement(ElementName = "amazonTechnicalName")]
			public string AmazonTechnicalName { get; set; }
		}

		[XmlRoot(ElementName = "weightValue")]
		public class WeightValue
		{
			[XmlAttribute(AttributeName = "unitOfMeasure")]
			public string UnitOfMeasure { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "shipmentPackageDeclaredGrossWeight")]
		public class ShipmentPackageDeclaredGrossWeight
		{
			[XmlElement(ElementName = "weightValue")]
			public List<WeightValue> WeightValue { get; set; }
		}

		[XmlRoot(ElementName = "shipmentPackageActualGrossWeight")]
		public class ShipmentPackageActualGrossWeight
		{
			[XmlElement(ElementName = "weightValue")]
			public List<WeightValue> WeightValue { get; set; }
		}

		[XmlRoot(ElementName = "lengthValue")]
		public class LengthValue
		{
			[XmlAttribute(AttributeName = "unitOfMeasure")]
			public string UnitOfMeasure { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "heightValue")]
		public class HeightValue
		{
			[XmlAttribute(AttributeName = "unitOfMeasure")]
			public string UnitOfMeasure { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "widthValue")]
		public class WidthValue
		{
			[XmlAttribute(AttributeName = "unitOfMeasure")]
			public string UnitOfMeasure { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "shipmentPackageDimensions")]
		public class ShipmentPackageDimensions
		{
			[XmlElement(ElementName = "lengthValue")]
			public List<LengthValue> LengthValue { get; set; }
			[XmlElement(ElementName = "heightValue")]
			public List<HeightValue> HeightValue { get; set; }
			[XmlElement(ElementName = "widthValue")]
			public List<WidthValue> WidthValue { get; set; }
		}

		[XmlRoot(ElementName = "itemID")]
		public class ItemID
		{
			[XmlAttribute(AttributeName = "type")]
			public string Type { get; set; }
			[XmlAttribute(AttributeName = "isFreeRep")]
			public string IsFreeRep { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "quantity")]
		public class Quantity
		{
			[XmlAttribute(AttributeName = "unitOfMeasure")]
			public string UnitOfMeasure { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "itemQuantity")]
		public class ItemQuantity
		{
			[XmlElement(ElementName = "quantity")]
			public List<Quantity> Quantity { get; set; }
		}

		[XmlRoot(ElementName = "itemUnitPrice")]
		public class ItemUnitPrice
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "itemExtendedPrice")]
		public class ItemExtendedPrice
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "itemPriceInfo")]
		public class ItemPriceInfo
		{
			[XmlElement(ElementName = "itemUnitPrice")]
			public List<ItemUnitPrice> ItemUnitPrice { get; set; }
			[XmlElement(ElementName = "itemExtendedPrice")]
			public List<ItemExtendedPrice> ItemExtendedPrice { get; set; }
		}

		[XmlRoot(ElementName = "itemWeight")]
		public class ItemWeight
		{
			[XmlElement(ElementName = "weightValue")]
			public List<WeightValue> WeightValue { get; set; }
		}

		[XmlRoot(ElementName = "shipmentPackageItemDetail")]
		public class ShipmentPackageItemDetail
		{
			[XmlElement(ElementName = "OrderingOrderId")]
			public string OrderingOrderId { get; set; }
			[XmlElement(ElementName = "itemID")]
			public List<ItemID> ItemID { get; set; }
			[XmlElement(ElementName = "itemTitle")]
			public string ItemTitle { get; set; }
			[XmlElement(ElementName = "itemQuantity")]
			public List<ItemQuantity> ItemQuantity { get; set; }
			[XmlElement(ElementName = "isHazmat")]
			public string IsHazmat { get; set; }
			[XmlElement(ElementName = "itemPriceInfo")]
			public List<ItemPriceInfo> ItemPriceInfo { get; set; }
			[XmlElement(ElementName = "itemWeight")]
			public List<ItemWeight> ItemWeight { get; set; }
			[XmlElement(ElementName = "harmonizedTariffNumber")]
			public string HarmonizedTariffNumber { get; set; }
			[XmlElement(ElementName = "harmonizedTariffDescription")]
			public string HarmonizedTariffDescription { get; set; }
			[XmlElement(ElementName = "countryOfOrigin")]
			public string CountryOfOrigin { get; set; }
		}

		[XmlRoot(ElementName = "totalDeclaredValue")]
		public class TotalDeclaredValue
		{
			[XmlAttribute(AttributeName = "currencyISOCode")]
			public string CurrencyISOCode { get; set; }
			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "shipmentPackageItemQuantity")]
		public class ShipmentPackageItemQuantity
		{
			[XmlElement(ElementName = "quantity")]
			public List<Quantity> Quantity { get; set; }
		}

		[XmlRoot(ElementName = "shipmentPackageInfo")]
		public class ShipmentPackageInfo
		{
			[XmlElement(ElementName = "cartonID")]
			public List<CartonID> CartonID { get; set; }
			[XmlElement(ElementName = "packageShipmentMethod")]
			public List<PackageShipmentMethod> PackageShipmentMethod { get; set; }
			[XmlElement(ElementName = "shipZone")]
			public string ShipZone { get; set; }
			[XmlElement(ElementName = "shipSort")]
			public string ShipSort { get; set; }
			[XmlElement(ElementName = "commercialInvoiceDate")]
			public string CommercialInvoiceDate { get; set; }
			[XmlElement(ElementName = "scheduledDeliveryDate")]
			public string ScheduledDeliveryDate { get; set; }
			[XmlElement(ElementName = "shipmentPackageDeclaredGrossWeight")]
			public ShipmentPackageDeclaredGrossWeight ShipmentPackageDeclaredGrossWeight { get; set; }
			[XmlElement(ElementName = "shipmentPackageDimWtCalcMethod")]
			public string ShipmentPackageDimWtCalcMethod { get; set; }
			[XmlElement(ElementName = "shipmentPackageActualGrossWeight")]
			public ShipmentPackageActualGrossWeight ShipmentPackageActualGrossWeight { get; set; }
			[XmlElement(ElementName = "shipmentPackageDimensions")]
			public List<ShipmentPackageDimensions> ShipmentPackageDimensions { get; set; }
			[XmlElement(ElementName = "shipmentPackageItemDetail")]
			public List<ShipmentPackageItemDetail> ShipmentPackageItemDetail { get; set; }
			[XmlElement(ElementName = "totalDeclaredValue")]
			public List<TotalDeclaredValue> TotalDeclaredValue { get; set; }
			[XmlElement(ElementName = "pkgHarmonizedTariffDescription")]
			public string PkgHarmonizedTariffDescription { get; set; }
			[XmlElement(ElementName = "shipmentPackageItemQuantity")]
			public List<ShipmentPackageItemQuantity> ShipmentPackageItemQuantity { get; set; }
		}

		[XmlRoot(ElementName = "shipmentDetail")]
		public class ShipmentDetail
		{
			[XmlElement(ElementName = "customerOrderNumber")]
			public string CustomerOrderNumber { get; set; }
			[XmlElement(ElementName = "consigneeAddress")]
			public List<ConsigneeAddress> ConsigneeAddress { get; set; }
			[XmlElement(ElementName = "isExportChargePrepaid")]
			public string IsExportChargePrepaid { get; set; }
			[XmlElement(ElementName = "brNFe")]
			public List<BrNFe> BrNFe { get; set; }
			[XmlElement(ElementName = "shipmentCostInfo")]
			public List<ShipmentCostInfo> ShipmentCostInfo { get; set; }
			[XmlElement(ElementName = "shipmentPackageInfo")]
			public List<ShipmentPackageInfo> ShipmentPackageInfo { get; set; }
			[XmlElement(ElementName = "reasonForExport")]
			public string ReasonForExport { get; set; }
		}

		[XmlRoot(ElementName = "manifestDetail")]
		public class ManifestDetail
		{
			[XmlElement(ElementName = "shipmentDetail")]
			public List<ShipmentDetail> ShipmentDetail { get; set; }
		}

		[XmlRoot(ElementName = "totalShipmentQuantity")]
		public class TotalShipmentQuantity
		{
			[XmlElement(ElementName = "quantity")]
			public List<Quantity> Quantity { get; set; }
		}

		[XmlRoot(ElementName = "totalShipmentValue")]
		public class TotalShipmentValue
		{
			[XmlElement(ElementName = "chargeOrAllowance")]
			public string ChargeOrAllowance { get; set; }
			[XmlElement(ElementName = "monetaryAmount")]
			public List<MonetaryAmount> MonetaryAmount { get; set; }
		}

		[XmlRoot(ElementName = "totalDeclaredGrossWeight")]
		public class TotalDeclaredGrossWeight
		{
			[XmlElement(ElementName = "weightValue")]
			public List<WeightValue> WeightValue { get; set; }
		}

		[XmlRoot(ElementName = "totalActualGrossWeight")]
		public class TotalActualGrossWeight
		{
			[XmlElement(ElementName = "weightValue")]
			public List<WeightValue> WeightValue { get; set; }
		}

		[XmlRoot(ElementName = "manifestSummary")]
		public class ManifestSummary
		{
			[XmlElement(ElementName = "totalShipmentQuantity")]
			public List<TotalShipmentQuantity> TotalShipmentQuantity { get; set; }
			[XmlElement(ElementName = "totalShipmentValue")]
			public TotalShipmentValue TotalShipmentValue { get; set; }
			[XmlElement(ElementName = "totalDeclaredGrossWeight")]
			public TotalDeclaredGrossWeight TotalDeclaredGrossWeight { get; set; }
			[XmlElement(ElementName = "totalActualGrossWeight")]
			public List<TotalActualGrossWeight> TotalActualGrossWeight { get; set; }
		}

		[XmlRoot(ElementName = "amazonManifest")]
		public class AmazonManifest
		{
			[XmlElement(ElementName = "manifestHeader")]
			public List<ManifestHeader> ManifestHeader { get; set; }
			[XmlElement(ElementName = "manifestDetail")]
			public List<ManifestDetail> ManifestDetail { get; set; }
			[XmlElement(ElementName = "manifestSummary")]
			public List<ManifestSummary> ManifestSummary { get; set; }
		}

		[XmlRoot(ElementName = "message")]
		public class Message
		{
			[XmlElement(ElementName = "amazonManifest")]
			public List<AmazonManifest> AmazonManifest { get; set; }
			[XmlAttribute(AttributeName = "messageType")]
			public string MessageType { get; set; }
		}

		[XmlRoot(ElementName = "transmission")]
		public class Transmission
		{
			//[XmlElement(ElementName = "message")]
			//public List<Message> Message { get; set; }
			//[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
			//public string Xsi { get; set; }
			//[XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
			//public string NoNamespaceSchemaLocation { get; set; }
			//[XmlAttribute(AttributeName = "sendingPartyID")]
			//public string SendingPartyID { get; set; }
			//[XmlAttribute(AttributeName = "receivingPartyID")]
			//public string ReceivingPartyID { get; set; }
			//[XmlAttribute(AttributeName = "transmissionCreationDate")]
			//public string TransmissionCreationDate { get; set; }
			//[XmlAttribute(AttributeName = "transmissionSchemaVersionNumber")]
			//public string TransmissionSchemaVersionNumber { get; set; }
		}


		[XmlRoot(ElementName = "User")]
		public class User
		{
			[XmlElement(ElementName = "Name")]
			public string Name { get; set; }
			[XmlElement(ElementName = "Class")]
			public string Class { get; set; }
			[XmlElement(ElementName = "Section")]
			public string Section { get; set; }
			[XmlElement(ElementName = "Roll_number")]
			public string Roll_number { get; set; }
			[XmlElement(ElementName = "Joining_Dt")]
			public string Joining_Dt { get; set; }
		}


	}
}
