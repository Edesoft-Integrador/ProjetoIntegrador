using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Amazon
{
    public interface IAmazonGRU5DetalheModel : IBaseMovimentoDb
    {
        string sellerCnpj { get; set; } //campo001
        string customerCnpjCpf { get; set; } //campo002
        string name { get; set; } //Campo003
        string addressLine1 { get; set; } //Campo004
        string addressLine2 { get; set; } //Campo005
        string city { get; set; } //Campo006
        string stateProvince { get; set; } //Campo007
        string zip { get; set; } //Campo008
        string countryCode { get; set; } //Campo009
        string countryName { get; set; } //Campo010
        string contactPhone { get; set; } //Campoa011
        string contactEmail { get; set; } //Campo012
        string nfeNumber { get; set; } //campo013
        string nfeSerie { get; set; } //campo014
        string nfeAccessCode { get; set; } //campo015
        string commercialInvoiceDate { get; set; } //campo016
        string shipmentPackageItemQuantity { get; set; } //campo017
        string weightValue { get; set; } //campo018
        string trackingID { get; set; } //campo019
        string encryptedShipmentID { get; set; } //campo020
        string nfeTotalValue { get; set; } //021
        string amazonTechnicalName { get; set; } //025
    }
}
