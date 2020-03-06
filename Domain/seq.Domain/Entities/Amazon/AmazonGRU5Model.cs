using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace seq.Domain.Entities
{


    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class transmission
    {

        private transmissionMessage messageField;

        [Key]
        private string sendingPartyIDField;

        private string receivingPartyIDField;

        private System.DateTime transmissionCreationDateField;

        private decimal transmissionSchemaVersionNumberField;

        /// <remarks/>
        public transmissionMessage message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sendingPartyID
        {
            get
            {
                return this.sendingPartyIDField;
            }
            set
            {
                this.sendingPartyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receivingPartyID
        {
            get
            {
                return this.receivingPartyIDField;
            }
            set
            {
                this.receivingPartyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime transmissionCreationDate
        {
            get
            {
                return this.transmissionCreationDateField;
            }
            set
            {
                this.transmissionCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal transmissionSchemaVersionNumber
        {
            get
            {
                return this.transmissionSchemaVersionNumberField;
            }
            set
            {
                this.transmissionSchemaVersionNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessage
    {

        private transmissionMessageAmazonManifest amazonManifestField;

        private string messageTypeField;

        /// <remarks/>
        public transmissionMessageAmazonManifest amazonManifest
        {
            get
            {
                return this.amazonManifestField;
            }
            set
            {
                this.amazonManifestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string messageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifest
    {

        private transmissionMessageAmazonManifestManifestHeader manifestHeaderField;

        private transmissionMessageAmazonManifestShipmentDetail[] manifestDetailField;

        private transmissionMessageAmazonManifestManifestSummary manifestSummaryField;

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestHeader manifestHeader
        {
            get
            {
                return this.manifestHeaderField;
            }
            set
            {
                this.manifestHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("shipmentDetail", IsNullable = false)]
        public transmissionMessageAmazonManifestShipmentDetail[] manifestDetail
        {
            get
            {
                return this.manifestDetailField;
            }
            set
            {
                this.manifestDetailField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummary manifestSummary
        {
            get
            {
                return this.manifestSummaryField;
            }
            set
            {
                this.manifestSummaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestHeader
    {

        private string warehouseLocationIDField;

        private System.DateTime manifestCreateDateTimeField;

        private string loadReferenceIDField;

        private string trailerNameField;

        private string carrierInternalIDField;

        private transmissionMessageAmazonManifestManifestHeaderShipmentMethod[] shipmentMethodField;

        private string manifestNumberField;

        private string carrierAccountIDField;

        private object carrierManifestIDField;

        private System.DateTime shipmentDateField;

        private System.DateTime shipmentDayField;

        private string currencyCodeField;

        private transmissionMessageAmazonManifestManifestHeaderShipFromAddress shipFromAddressField;

        private transmissionMessageAmazonManifestManifestHeaderShipperInformation shipperInformationField;

        private string prepaidCollectField;

        /// <remarks/>
        public string warehouseLocationID
        {
            get
            {
                return this.warehouseLocationIDField;
            }
            set
            {
                this.warehouseLocationIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime manifestCreateDateTime
        {
            get
            {
                return this.manifestCreateDateTimeField;
            }
            set
            {
                this.manifestCreateDateTimeField = value;
            }
        }

        /// <remarks/>
        public string loadReferenceID
        {
            get
            {
                return this.loadReferenceIDField;
            }
            set
            {
                this.loadReferenceIDField = value;
            }
        }

        /// <remarks/>
        public string trailerName
        {
            get
            {
                return this.trailerNameField;
            }
            set
            {
                this.trailerNameField = value;
            }
        }

        /// <remarks/>
        public string carrierInternalID
        {
            get
            {
                return this.carrierInternalIDField;
            }
            set
            {
                this.carrierInternalIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipmentMethod")]
        public transmissionMessageAmazonManifestManifestHeaderShipmentMethod[] shipmentMethod
        {
            get
            {
                return this.shipmentMethodField;
            }
            set
            {
                this.shipmentMethodField = value;
            }
        }

        /// <remarks/>
        public string manifestNumber
        {
            get
            {
                return this.manifestNumberField;
            }
            set
            {
                this.manifestNumberField = value;
            }
        }

        /// <remarks/>
        public string carrierAccountID
        {
            get
            {
                return this.carrierAccountIDField;
            }
            set
            {
                this.carrierAccountIDField = value;
            }
        }

        /// <remarks/>
        public object carrierManifestID
        {
            get
            {
                return this.carrierManifestIDField;
            }
            set
            {
                this.carrierManifestIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime shipmentDate
        {
            get
            {
                return this.shipmentDateField;
            }
            set
            {
                this.shipmentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime shipmentDay
        {
            get
            {
                return this.shipmentDayField;
            }
            set
            {
                this.shipmentDayField = value;
            }
        }

        /// <remarks/>
        public string currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestHeaderShipFromAddress shipFromAddress
        {
            get
            {
                return this.shipFromAddressField;
            }
            set
            {
                this.shipFromAddressField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestHeaderShipperInformation shipperInformation
        {
            get
            {
                return this.shipperInformationField;
            }
            set
            {
                this.shipperInformationField = value;
            }
        }

        /// <remarks/>
        public string prepaidCollect
        {
            get
            {
                return this.prepaidCollectField;
            }
            set
            {
                this.prepaidCollectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestHeaderShipmentMethod
    {

        private string amazonTechnicalNameField;

        /// <remarks/>
        public string amazonTechnicalName
        {
            get
            {
                return this.amazonTechnicalNameField;
            }
            set
            {
                this.amazonTechnicalNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestHeaderShipFromAddress
    {

        private string nameField;

        private string addressLine1Field;

        private string addressLine2Field;

        private string cityField;

        private transmissionMessageAmazonManifestManifestHeaderShipFromAddressStateChoice stateChoiceField;

        private string zipField;

        private string countryCodeField;

        private string countryNameField;

        private string addressTypeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string addressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }

        /// <remarks/>
        public string addressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestHeaderShipFromAddressStateChoice stateChoice
        {
            get
            {
                return this.stateChoiceField;
            }
            set
            {
                this.stateChoiceField = value;
            }
        }

        /// <remarks/>
        public string zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public string countryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestHeaderShipFromAddressStateChoice
    {

        private string stateProvinceField;

        /// <remarks/>
        public string stateProvince
        {
            get
            {
                return this.stateProvinceField;
            }
            set
            {
                this.stateProvinceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestHeaderShipperInformation
    {

        private string amazonTaxIDField;

        /// <remarks/>
        public string amazonTaxID
        {
            get
            {
                return this.amazonTaxIDField;
            }
            set
            {
                this.amazonTaxIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetail
    {

        private string customerOrderNumberField;

        private transmissionMessageAmazonManifestShipmentDetailConsigneeAddress consigneeAddressField;

        private string isExportChargePrepaidField;

        private transmissionMessageAmazonManifestShipmentDetailBrNFe brNFeField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfo shipmentCostInfoField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfo shipmentPackageInfoField;

        private string reasonForExportField;

        /// <remarks/>
        public string customerOrderNumber
        {
            get
            {
                return this.customerOrderNumberField;
            }
            set
            {
                this.customerOrderNumberField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailConsigneeAddress consigneeAddress
        {
            get
            {
                return this.consigneeAddressField;
            }
            set
            {
                this.consigneeAddressField = value;
            }
        }

        /// <remarks/>
        public string isExportChargePrepaid
        {
            get
            {
                return this.isExportChargePrepaidField;
            }
            set
            {
                this.isExportChargePrepaidField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailBrNFe brNFe
        {
            get
            {
                return this.brNFeField;
            }
            set
            {
                this.brNFeField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfo shipmentCostInfo
        {
            get
            {
                return this.shipmentCostInfoField;
            }
            set
            {
                this.shipmentCostInfoField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfo shipmentPackageInfo
        {
            get
            {
                return this.shipmentPackageInfoField;
            }
            set
            {
                this.shipmentPackageInfoField = value;
            }
        }

        /// <remarks/>
        public string reasonForExport
        {
            get
            {
                return this.reasonForExportField;
            }
            set
            {
                this.reasonForExportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailConsigneeAddress
    {

        private string nameField;

        private string addressLine1Field;

        private string addressLine2Field;

        private string addressLine3Field;

        private string cityField;

        private transmissionMessageAmazonManifestShipmentDetailConsigneeAddressStateChoice stateChoiceField;

        private string zipField;

        private string countryCodeField;

        private string countryNameField;

        private string contactPhoneField;

        private string contactEmailField;

        private string contactEmailFullField;

        private string amzShipAddressUsageField;

        private string addressTypeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string addressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }

        /// <remarks/>
        public string addressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }

        /// <remarks/>
        public string addressLine3
        {
            get
            {
                return this.addressLine3Field;
            }
            set
            {
                this.addressLine3Field = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailConsigneeAddressStateChoice stateChoice
        {
            get
            {
                return this.stateChoiceField;
            }
            set
            {
                this.stateChoiceField = value;
            }
        }

        /// <remarks/>
        public string zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public string countryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }

        /// <remarks/>
        public string contactPhone
        {
            get
            {
                return this.contactPhoneField;
            }
            set
            {
                this.contactPhoneField = value;
            }
        }

        /// <remarks/>
        public string contactEmail
        {
            get
            {
                return this.contactEmailField;
            }
            set
            {
                this.contactEmailField = value;
            }
        }

        /// <remarks/>
        public string contactEmailFull
        {
            get
            {
                return this.contactEmailFullField;
            }
            set
            {
                this.contactEmailFullField = value;
            }
        }

        /// <remarks/>
        public string amzShipAddressUsage
        {
            get
            {
                return this.amzShipAddressUsageField;
            }
            set
            {
                this.amzShipAddressUsageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailConsigneeAddressStateChoice
    {

        private string stateProvinceField;

        /// <remarks/>
        public string stateProvince
        {
            get
            {
                return this.stateProvinceField;
            }
            set
            {
                this.stateProvinceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailBrNFe
    {

        private ulong sellerCnpjField;

        private ulong customerCnpjCpfField;

        private uint nfeNumberField;

        private byte nfeSerieField;

        private string nfeAccessCodeField;

        private System.DateTime nfeIssuanceDateField;

        private transmissionMessageAmazonManifestShipmentDetailBrNFeNfeAddress nfeAddressField;

        private decimal nfeICMSSTAmountField;

        private decimal nfeICMSAmountField;

        private decimal nfeProductsTotalValueField;

        private decimal nfeTotalValueField;

        /// <remarks/>
        public ulong sellerCnpj
        {
            get
            {
                return this.sellerCnpjField;
            }
            set
            {
                this.sellerCnpjField = value;
            }
        }

        /// <remarks/>
        public ulong customerCnpjCpf
        {
            get
            {
                return this.customerCnpjCpfField;
            }
            set
            {
                this.customerCnpjCpfField = value;
            }
        }

        /// <remarks/>
        public uint nfeNumber
        {
            get
            {
                return this.nfeNumberField;
            }
            set
            {
                this.nfeNumberField = value;
            }
        }

        /// <remarks/>
        public byte nfeSerie
        {
            get
            {
                return this.nfeSerieField;
            }
            set
            {
                this.nfeSerieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string nfeAccessCode
        {
            get
            {
                return this.nfeAccessCodeField;
            }
            set
            {
                this.nfeAccessCodeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime nfeIssuanceDate
        {
            get
            {
                return this.nfeIssuanceDateField;
            }
            set
            {
                this.nfeIssuanceDateField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailBrNFeNfeAddress nfeAddress
        {
            get
            {
                return this.nfeAddressField;
            }
            set
            {
                this.nfeAddressField = value;
            }
        }

        /// <remarks/>
        public decimal nfeICMSSTAmount
        {
            get
            {
                return this.nfeICMSSTAmountField;
            }
            set
            {
                this.nfeICMSSTAmountField = value;
            }
        }

        /// <remarks/>
        public decimal nfeICMSAmount
        {
            get
            {
                return this.nfeICMSAmountField;
            }
            set
            {
                this.nfeICMSAmountField = value;
            }
        }

        /// <remarks/>
        public decimal nfeProductsTotalValue
        {
            get
            {
                return this.nfeProductsTotalValueField;
            }
            set
            {
                this.nfeProductsTotalValueField = value;
            }
        }

        /// <remarks/>
        public decimal nfeTotalValue
        {
            get
            {
                return this.nfeTotalValueField;
            }
            set
            {
                this.nfeTotalValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailBrNFeNfeAddress
    {

        private string streetField;

        private string numberField;

        private string complementField;

        private string boroughField;

        private uint zipcodeField;

        private string cityField;

        private string stateField;

        private string phoneField;

        private bool phoneFieldSpecified;

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string complement
        {
            get
            {
                return this.complementField;
            }
            set
            {
                this.complementField = value;
            }
        }

        /// <remarks/>
        public string borough
        {
            get
            {
                return this.boroughField;
            }
            set
            {
                this.boroughField = value;
            }
        }

        /// <remarks/>
        public uint zipcode
        {
            get
            {
                return this.zipcodeField;
            }
            set
            {
                this.zipcodeField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool phoneSpecified
        {
            get
            {
                return this.phoneFieldSpecified;
            }
            set
            {
                this.phoneFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfo
    {

        private string termsOfSaleField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoAmazonFreightCost amazonFreightCostField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoValueOfGoods valueOfGoodsField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoCIF cIFField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeFreightCharge consigneeFreightChargeField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeGiftWrapCharge consigneeGiftWrapChargeField;

        /// <remarks/>
        public string termsOfSale
        {
            get
            {
                return this.termsOfSaleField;
            }
            set
            {
                this.termsOfSaleField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoAmazonFreightCost amazonFreightCost
        {
            get
            {
                return this.amazonFreightCostField;
            }
            set
            {
                this.amazonFreightCostField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoValueOfGoods valueOfGoods
        {
            get
            {
                return this.valueOfGoodsField;
            }
            set
            {
                this.valueOfGoodsField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoCIF CIF
        {
            get
            {
                return this.cIFField;
            }
            set
            {
                this.cIFField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeFreightCharge consigneeFreightCharge
        {
            get
            {
                return this.consigneeFreightChargeField;
            }
            set
            {
                this.consigneeFreightChargeField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeGiftWrapCharge consigneeGiftWrapCharge
        {
            get
            {
                return this.consigneeGiftWrapChargeField;
            }
            set
            {
                this.consigneeGiftWrapChargeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoAmazonFreightCost
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoAmazonFreightCostMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return string.IsNullOrEmpty(this.chargeOrAllowanceField) ? "" : this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoAmazonFreightCostMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoAmazonFreightCostMonetaryAmount
    {

        private string currencyISOCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoValueOfGoods
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoValueOfGoodsMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoValueOfGoodsMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoValueOfGoodsMonetaryAmount
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoCIF
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoCIFMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoCIFMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoCIFMonetaryAmount
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeFreightCharge
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeFreightChargeMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeFreightChargeMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeFreightChargeMonetaryAmount
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeGiftWrapCharge
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeGiftWrapChargeMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeGiftWrapChargeMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentCostInfoConsigneeGiftWrapChargeMonetaryAmount
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfo
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoCartonID cartonIDField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoPackageShipmentMethod packageShipmentMethodField;

        private string shipZoneField;

        private string shipSortField;

        private System.DateTime commercialInvoiceDateField;

        private System.DateTime scheduledDeliveryDateField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDeclaredGrossWeight shipmentPackageDeclaredGrossWeightField;

        private string shipmentPackageDimWtCalcMethodField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageActualGrossWeight shipmentPackageActualGrossWeightField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensions shipmentPackageDimensionsField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetail[] shipmentPackageItemDetailField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoTotalDeclaredValue totalDeclaredValueField;

        private string pkgHarmonizedTariffDescriptionField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemQuantity shipmentPackageItemQuantityField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoCartonID cartonID
        {
            get
            {
                return this.cartonIDField;
            }
            set
            {
                this.cartonIDField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoPackageShipmentMethod packageShipmentMethod
        {
            get
            {
                return this.packageShipmentMethodField;
            }
            set
            {
                this.packageShipmentMethodField = value;
            }
        }

        /// <remarks/>
        public string shipZone
        {
            get
            {
                return this.shipZoneField;
            }
            set
            {
                this.shipZoneField = value;
            }
        }

        /// <remarks/>
        public string shipSort
        {
            get
            {
                return this.shipSortField;
            }
            set
            {
                this.shipSortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime commercialInvoiceDate
        {
            get
            {
                return this.commercialInvoiceDateField;
            }
            set
            {
                this.commercialInvoiceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime scheduledDeliveryDate
        {
            get
            {
                return this.scheduledDeliveryDateField;
            }
            set
            {
                this.scheduledDeliveryDateField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDeclaredGrossWeight shipmentPackageDeclaredGrossWeight
        {
            get
            {
                return this.shipmentPackageDeclaredGrossWeightField;
            }
            set
            {
                this.shipmentPackageDeclaredGrossWeightField = value;
            }
        }

        /// <remarks/>
        public string shipmentPackageDimWtCalcMethod
        {
            get
            {
                return this.shipmentPackageDimWtCalcMethodField;
            }
            set
            {
                this.shipmentPackageDimWtCalcMethodField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageActualGrossWeight shipmentPackageActualGrossWeight
        {
            get
            {
                return this.shipmentPackageActualGrossWeightField;
            }
            set
            {
                this.shipmentPackageActualGrossWeightField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensions shipmentPackageDimensions
        {
            get
            {
                return this.shipmentPackageDimensionsField;
            }
            set
            {
                this.shipmentPackageDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipmentPackageItemDetail")]
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetail[] shipmentPackageItemDetail
        {
            get
            {
                return this.shipmentPackageItemDetailField;
            }
            set
            {
                this.shipmentPackageItemDetailField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoTotalDeclaredValue totalDeclaredValue
        {
            get
            {
                return this.totalDeclaredValueField;
            }
            set
            {
                this.totalDeclaredValueField = value;
            }
        }

        /// <remarks/>
        public string pkgHarmonizedTariffDescription
        {
            get
            {
                return this.pkgHarmonizedTariffDescriptionField;
            }
            set
            {
                this.pkgHarmonizedTariffDescriptionField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemQuantity shipmentPackageItemQuantity
        {
            get
            {
                return this.shipmentPackageItemQuantityField;
            }
            set
            {
                this.shipmentPackageItemQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoCartonID
    {

        private string amazonBarCodeField;

        private string encryptedShipmentIDField;

        private byte packageIDField;

        private string trackingIDField;

        /// <remarks/>
        public string amazonBarCode
        {
            get
            {
                return this.amazonBarCodeField;
            }
            set
            {
                this.amazonBarCodeField = value;
            }
        }

        /// <remarks/>
        public string encryptedShipmentID
        {
            get
            {
                return this.encryptedShipmentIDField;
            }
            set
            {
                this.encryptedShipmentIDField = value;
            }
        }

        /// <remarks/>
        public byte packageID
        {
            get
            {
                return this.packageIDField;
            }
            set
            {
                this.packageIDField = value;
            }
        }

        /// <remarks/>
        public string trackingID
        {
            get
            {
                return this.trackingIDField;
            }
            set
            {
                this.trackingIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoPackageShipmentMethod
    {

        private string amazonTechnicalNameField;

        /// <remarks/>
        public string amazonTechnicalName
        {
            get
            {
                return this.amazonTechnicalNameField;
            }
            set
            {
                this.amazonTechnicalNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDeclaredGrossWeight
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDeclaredGrossWeightWeightValue weightValueField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDeclaredGrossWeightWeightValue weightValue
        {
            get
            {
                return this.weightValueField;
            }
            set
            {
                this.weightValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDeclaredGrossWeightWeightValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageActualGrossWeight
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageActualGrossWeightWeightValue weightValueField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageActualGrossWeightWeightValue weightValue
        {
            get
            {
                return this.weightValueField;
            }
            set
            {
                this.weightValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageActualGrossWeightWeightValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensions
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsLengthValue lengthValueField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsHeightValue heightValueField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsWidthValue widthValueField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsLengthValue lengthValue
        {
            get
            {
                return this.lengthValueField;
            }
            set
            {
                this.lengthValueField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsHeightValue heightValue
        {
            get
            {
                return this.heightValueField;
            }
            set
            {
                this.heightValueField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsWidthValue widthValue
        {
            get
            {
                return this.widthValueField;
            }
            set
            {
                this.widthValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsLengthValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsHeightValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageDimensionsWidthValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetail
    {

        private string orderingOrderIdField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemID itemIDField;

        private string itemTitleField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemQuantity itemQuantityField;

        private string isHazmatField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfo itemPriceInfoField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemWeight itemWeightField;

        private string harmonizedTariffNumberField;

        private string harmonizedTariffDescriptionField;

        private string countryOfOriginField;

        /// <remarks/>
        public string OrderingOrderId
        {
            get
            {
                return this.orderingOrderIdField;
            }
            set
            {
                this.orderingOrderIdField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemID itemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }

        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemQuantity itemQuantity
        {
            get
            {
                return this.itemQuantityField;
            }
            set
            {
                this.itemQuantityField = value;
            }
        }

        /// <remarks/>
        public string isHazmat
        {
            get
            {
                return this.isHazmatField;
            }
            set
            {
                this.isHazmatField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfo itemPriceInfo
        {
            get
            {
                return this.itemPriceInfoField;
            }
            set
            {
                this.itemPriceInfoField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemWeight itemWeight
        {
            get
            {
                return this.itemWeightField;
            }
            set
            {
                this.itemWeightField = value;
            }
        }

        /// <remarks/>
        public string harmonizedTariffNumber
        {
            get
            {
                return this.harmonizedTariffNumberField;
            }
            set
            {
                this.harmonizedTariffNumberField = value;
            }
        }

        /// <remarks/>
        public string harmonizedTariffDescription
        {
            get
            {
                return this.harmonizedTariffDescriptionField;
            }
            set
            {
                this.harmonizedTariffDescriptionField = value;
            }
        }

        /// <remarks/>
        public string countryOfOrigin
        {
            get
            {
                return this.countryOfOriginField;
            }
            set
            {
                this.countryOfOriginField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemID
    {

        private string typeField;

        private string isFreeRepField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isFreeRep
        {
            get
            {
                return this.isFreeRepField;
            }
            set
            {
                this.isFreeRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemQuantity
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemQuantityQuantity quantityField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemQuantityQuantity quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemQuantityQuantity
    {

        private string unitOfMeasureField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfo
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemUnitPrice itemUnitPriceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemExtendedPrice itemExtendedPriceField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemUnitPrice itemUnitPrice
        {
            get
            {
                return this.itemUnitPriceField;
            }
            set
            {
                this.itemUnitPriceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemExtendedPrice itemExtendedPrice
        {
            get
            {
                return this.itemExtendedPriceField;
            }
            set
            {
                this.itemExtendedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemUnitPrice
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemUnitPriceMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemUnitPriceMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemUnitPriceMonetaryAmount
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemExtendedPrice
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemExtendedPriceMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemExtendedPriceMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemPriceInfoItemExtendedPriceMonetaryAmount
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemWeight
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemWeightWeightValue weightValueField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemWeightWeightValue weightValue
        {
            get
            {
                return this.weightValueField;
            }
            set
            {
                this.weightValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemDetailItemWeightWeightValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoTotalDeclaredValue
    {

        private string currencyISOCodeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemQuantity
    {

        private transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemQuantityQuantity quantityField;

        /// <remarks/>
        public transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemQuantityQuantity quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestShipmentDetailShipmentPackageInfoShipmentPackageItemQuantityQuantity
    {

        private string unitOfMeasureField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummary
    {

        private transmissionMessageAmazonManifestManifestSummaryTotalShipmentQuantity totalShipmentQuantityField;

        private transmissionMessageAmazonManifestManifestSummaryTotalShipmentValue totalShipmentValueField;

        private transmissionMessageAmazonManifestManifestSummaryTotalDeclaredGrossWeight totalDeclaredGrossWeightField;

        private transmissionMessageAmazonManifestManifestSummaryTotalActualGrossWeight totalActualGrossWeightField;

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalShipmentQuantity totalShipmentQuantity
        {
            get
            {
                return this.totalShipmentQuantityField;
            }
            set
            {
                this.totalShipmentQuantityField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalShipmentValue totalShipmentValue
        {
            get
            {
                return this.totalShipmentValueField;
            }
            set
            {
                this.totalShipmentValueField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalDeclaredGrossWeight totalDeclaredGrossWeight
        {
            get
            {
                return this.totalDeclaredGrossWeightField;
            }
            set
            {
                this.totalDeclaredGrossWeightField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalActualGrossWeight totalActualGrossWeight
        {
            get
            {
                return this.totalActualGrossWeightField;
            }
            set
            {
                this.totalActualGrossWeightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalShipmentQuantity
    {

        private transmissionMessageAmazonManifestManifestSummaryTotalShipmentQuantityQuantity quantityField;

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalShipmentQuantityQuantity quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalShipmentQuantityQuantity
    {

        private string unitOfMeasureField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalShipmentValue
    {

        private string chargeOrAllowanceField;

        private transmissionMessageAmazonManifestManifestSummaryTotalShipmentValueMonetaryAmount monetaryAmountField;

        /// <remarks/>
        public string chargeOrAllowance
        {
            get
            {
                return this.chargeOrAllowanceField;
            }
            set
            {
                this.chargeOrAllowanceField = value;
            }
        }

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalShipmentValueMonetaryAmount monetaryAmount
        {
            get
            {
                return this.monetaryAmountField;
            }
            set
            {
                this.monetaryAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalShipmentValueMonetaryAmount
    {

        private string currencyISOCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currencyISOCode
        {
            get
            {
                return this.currencyISOCodeField;
            }
            set
            {
                this.currencyISOCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalDeclaredGrossWeight
    {

        private transmissionMessageAmazonManifestManifestSummaryTotalDeclaredGrossWeightWeightValue weightValueField;

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalDeclaredGrossWeightWeightValue weightValue
        {
            get
            {
                return this.weightValueField;
            }
            set
            {
                this.weightValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalDeclaredGrossWeightWeightValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalActualGrossWeight
    {

        private transmissionMessageAmazonManifestManifestSummaryTotalActualGrossWeightWeightValue weightValueField;

        /// <remarks/>
        public transmissionMessageAmazonManifestManifestSummaryTotalActualGrossWeightWeightValue weightValue
        {
            get
            {
                return this.weightValueField;
            }
            set
            {
                this.weightValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class transmissionMessageAmazonManifestManifestSummaryTotalActualGrossWeightWeightValue
    {

        private string unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }





}