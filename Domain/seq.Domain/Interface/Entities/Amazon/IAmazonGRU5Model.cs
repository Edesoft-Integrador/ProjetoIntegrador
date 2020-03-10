using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Amazon
{
	public interface IAmazonGRU5Model
	{
		Transmission Transmission { get; set; }
	}
	public interface ShipmentMethod
	{
		string AmazonTechnicalName { get; set; }
	}

	public interface StateChoice
	{
		string StateProvince { get; set; }
	}

	public interface ShipFromAddress
	{
		string Name { get; set; }
		string AddressLine1 { get; set; }
		string AddressLine2 { get; set; }
		string City { get; set; }
		public StateChoice StateChoice { get; set; }
		string Zip { get; set; }
		string CountryCode { get; set; }
		string CountryName { get; set; }
		string AddressType { get; set; }
	}

	public interface ShipperInformation
	{
		string AmazonTaxID { get; set; }
	}

	public interface ManifestHeader
	{
		string WarehouseLocationID { get; set; }
		string ManifestCreateDateTime { get; set; }
		string LoadReferenceID { get; set; }
		string TrailerName { get; set; }
		string CarrierInternalID { get; set; }
		public List<ShipmentMethod> ShipmentMethod { get; set; }
		string ManifestNumber { get; set; }
		string CarrierAccountID { get; set; }
		string CarrierManifestID { get; set; }
		string ShipmentDate { get; set; }
		string ShipmentDay { get; set; }
		string CurrencyCode { get; set; }
		public ShipFromAddress ShipFromAddress { get; set; }
		public ShipperInformation ShipperInformation { get; set; }
		string PrepaidCollect { get; set; }
	}

	public interface ConsigneeAddress
	{
		string Name { get; set; }
		string AddressLine1 { get; set; }
		string AddressLine2 { get; set; }
		string City { get; set; }
		public StateChoice StateChoice { get; set; }
		string Zip { get; set; }
		string CountryCode { get; set; }
		string CountryName { get; set; }
		string ContactPhone { get; set; }
		string ContactEmail { get; set; }
		string ContactEmailFull { get; set; }
		string AmzShipAddressUsage { get; set; }
		string AddressType { get; set; }
	}

	public interface NfeAddress
	{
		string Street { get; set; }
		string Number { get; set; }
		string Complement { get; set; }
		string Borough { get; set; }
		string Zipcode { get; set; }
		string City { get; set; }
		string State { get; set; }
		string Phone { get; set; }
	}

	public interface BrNFe
	{
		string SellerCnpj { get; set; }
		string CustomerCnpjCpf { get; set; }
		string NfeNumber { get; set; }
		string NfeSerie { get; set; }
		string NfeAccessCode { get; set; }
		string NfeIssuanceDate { get; set; }
		public NfeAddress NfeAddress { get; set; }
		string NfeICMSSTAmount { get; set; }
		string NfeICMSAmount { get; set; }
		string NfeProductsTotalValue { get; set; }
		string NfeTotalValue { get; set; }
	}

	public interface MonetaryAmount
	{
		string CurrencyISOCode { get; set; }
		string Text { get; set; }
	}

	public interface AmazonFreightCost
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface ValueOfGoods
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface CIF
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface ConsigneeFreightCharge
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface ShipmentCostInfo
	{
		string TermsOfSale { get; set; }
		public AmazonFreightCost AmazonFreightCost { get; set; }
		public ValueOfGoods ValueOfGoods { get; set; }
		public CIF CIF { get; set; }
		public ConsigneeFreightCharge ConsigneeFreightCharge { get; set; }
	}

	public interface CartonID
	{
		string AmazonBarCode { get; set; }
		string EncryptedShipmentID { get; set; }
		string PackageID { get; set; }
		string TrackingID { get; set; }
	}

	public interface PackageShipmentMethod
	{
		string AmazonTechnicalName { get; set; }
	}

	public interface WeightValue
	{
		string UnitOfMeasure { get; set; }
		string Text { get; set; }
	}

	public interface ShipmentPackageDeclaredGrossWeight
	{
		public WeightValue WeightValue { get; set; }
	}

	public interface ShipmentPackageActualGrossWeight
	{
		public WeightValue WeightValue { get; set; }
	}

	public interface LengthValue
	{
		string UnitOfMeasure { get; set; }
		string Text { get; set; }
	}

	public interface HeightValue
	{
		string UnitOfMeasure { get; set; }
		string Text { get; set; }
	}

	public interface WidthValue
	{
		string UnitOfMeasure { get; set; }
		string Text { get; set; }
	}

	public interface ShipmentPackageDimensions
	{
		public LengthValue LengthValue { get; set; }
		public HeightValue HeightValue { get; set; }
		public WidthValue WidthValue { get; set; }
	}

	public interface ItemID
	{
		string Type { get; set; }
		string IsFreeRep { get; set; }
		string Text { get; set; }
	}

	public interface Quantity
	{
		string UnitOfMeasure { get; set; }
		string Text { get; set; }
	}

	public interface ItemQuantity
	{
		public Quantity Quantity { get; set; }
	}

	public interface ItemUnitPrice
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface ItemExtendedPrice
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface ItemPriceInfo
	{
		public ItemUnitPrice ItemUnitPrice { get; set; }
		public ItemExtendedPrice ItemExtendedPrice { get; set; }
	}

	public interface ItemWeight
	{
		public WeightValue WeightValue { get; set; }
	}

	public interface ShipmentPackageItemDetail
	{
		string OrderingOrderId { get; set; }
		public ItemID ItemID { get; set; }
		string ItemTitle { get; set; }
		public ItemQuantity ItemQuantity { get; set; }
		string IsHazmat { get; set; }
		public ItemPriceInfo ItemPriceInfo { get; set; }
		public ItemWeight ItemWeight { get; set; }
		string HarmonizedTariffNumber { get; set; }
		string HarmonizedTariffDescription { get; set; }
		string CountryOfOrigin { get; set; }
	}

	public interface TotalDeclaredValue
	{
		string CurrencyISOCode { get; set; }
		string Text { get; set; }
	}

	public interface ShipmentPackageItemQuantity
	{
		public Quantity Quantity { get; set; }
	}

	public interface ShipmentPackageInfo
	{
		public CartonID CartonID { get; set; }
		public PackageShipmentMethod PackageShipmentMethod { get; set; }
		string ShipZone { get; set; }
		string ShipSort { get; set; }
		string CommercialInvoiceDate { get; set; }
		string ScheduledDeliveryDate { get; set; }
		public ShipmentPackageDeclaredGrossWeight ShipmentPackageDeclaredGrossWeight { get; set; }
		string ShipmentPackageDimWtCalcMethod { get; set; }
		public ShipmentPackageActualGrossWeight ShipmentPackageActualGrossWeight { get; set; }
		public ShipmentPackageDimensions ShipmentPackageDimensions { get; set; }
		public List<ShipmentPackageItemDetail> ShipmentPackageItemDetail { get; set; }
		public TotalDeclaredValue TotalDeclaredValue { get; set; }
		string PkgHarmonizedTariffDescription { get; set; }
		public ShipmentPackageItemQuantity ShipmentPackageItemQuantity { get; set; }
	}

	public interface ShipmentDetail
	{
		string CustomerOrderNumber { get; set; }
		public ConsigneeAddress ConsigneeAddress { get; set; }
		string IsExportChargePrepaid { get; set; }
		public BrNFe BrNFe { get; set; }
		public ShipmentCostInfo ShipmentCostInfo { get; set; }
		public ShipmentPackageInfo ShipmentPackageInfo { get; set; }
		string ReasonForExport { get; set; }
	}

	public interface ManifestDetail
	{
		public List<ShipmentDetail> ShipmentDetail { get; set; }
	}

	public interface TotalShipmentQuantity
	{
		public Quantity Quantity { get; set; }
	}

	public interface TotalShipmentValue
	{
		string ChargeOrAllowance { get; set; }
		public MonetaryAmount MonetaryAmount { get; set; }
	}

	public interface TotalDeclaredGrossWeight
	{
		public WeightValue WeightValue { get; set; }
	}

	public interface TotalActualGrossWeight
	{
		public WeightValue WeightValue { get; set; }
	}

	public interface ManifestSummary
	{
		public TotalShipmentQuantity TotalShipmentQuantity { get; set; }
		public TotalShipmentValue TotalShipmentValue { get; set; }
		public TotalDeclaredGrossWeight TotalDeclaredGrossWeight { get; set; }
		public TotalActualGrossWeight TotalActualGrossWeight { get; set; }
	}

	public interface AmazonManifest
	{
		public ManifestHeader ManifestHeader { get; set; }
		public ManifestDetail ManifestDetail { get; set; }
		public ManifestSummary ManifestSummary { get; set; }
	}

	public interface Message
	{
		public AmazonManifest AmazonManifest { get; set; }
		string MessageType { get; set; }
	}

	public interface Transmission
	{
		public Message Message { get; set; }
		string Xsi { get; set; }
		string NoNamespaceSchemaLocation { get; set; }
		string SendingPartyID { get; set; }
		string ReceivingPartyID { get; set; }
		string TransmissionCreationDate { get; set; }
		string TransmissionSchemaVersionNumber { get; set; }
	}
}