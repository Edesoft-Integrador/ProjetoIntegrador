using seq.Domain.Interface.Entities.Amazon;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Amazon
{
    public class AmazonGRU5HeaderModel : IAmazonGRU5HeaderModel
    {
        public string receivingPartyID {get; set;}
        public string sendingPartyID {get; set;}
        public string transmissionCreationDate {get; set;}
        public string transmissionSchemaVersionNumber {get; set;}
        public string warehouseLocationID {get; set;}
        public string manifestCreateDateTime {get; set;}
        public string loadReferenceID {get; set;}
        public string trailerName {get; set;}
        public string carrierInternalID {get; set;}
        public string amazonTechnicalName01 {get; set;}
        public string amazonTechnicalName02 {get; set;}
        public string manifestNumber {get; set;}
        public string carrierAccountID {get; set;}
        public string shipmentDate {get; set;}
        public string shipmentDay {get; set;}
        public string currencyCode {get; set;}
        public string AddressType {get; set;}
        public string name {get; set;}
        public string addressLine1 {get; set;}
        public string addressLine2 {get; set;}
        public string city {get; set;}
        public string stateProvince {get; set;}
        public string zip {get; set;}
        public string countryCode {get; set;}
        public string countryName {get; set;}
        public string amazonTaxID {get; set;}
        public string prepaidCollect {get; set;}
        public DateTime? DataAlteracao {get; set;}
        public long? UsuarioIdAlteracao {get; set;}
        public DateTime DataInclusao {get; set;}
        public long UsuarioIdInclusao {get; set;}
    }
}
