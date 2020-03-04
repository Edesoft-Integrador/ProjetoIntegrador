using seq.Domain.Interface.Entities.Amazon;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Amazon
{
    public class AmazonGRU5DetalheModel : IAmazonGRU5DetalheModel
    {
        public string sellerCnpj {get; set;}
        public string customerCnpjCpf {get; set;}
        public string name {get; set;}
        public string addressLine1 {get; set;}
        public string addressLine2 {get; set;}
        public string city {get; set;}
        public string stateProvince {get; set;}
        public string zip {get; set;}
        public string countryCode {get; set;}
        public string countryName {get; set;}
        public string contactPhone {get; set;}
        public string contactEmail {get; set;}
        public string nfeNumber {get; set;}
        public string nfeSerie {get; set;}
        public string nfeAccessCode {get; set;}
        public string commercialInvoiceDate {get; set;}
        public string shipmentPackageItemQuantity {get; set;}
        public string weightValue {get; set;}
        public string trackingID {get; set;}
        public string encryptedShipmentID {get; set;}
        public string nfeTotalValue {get; set;}
        public string amazonTechnicalName {get; set;}
        public DateTime? DataAlteracao {get; set;}
        public long? UsuarioIdAlteracao {get; set;}
        public DateTime DataInclusao {get; set;}
        public long UsuarioIdInclusao {get; set;}
    }
}
