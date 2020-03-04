using eim.Domain.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Amazon
{
    public interface IAmazonGRU5HeaderModel : IBaseMovimentoDb
    {
        string receivingPartyID { get; set; }//Campo002
        string sendingPartyID { get; set; } //Campo002
        string transmissionCreationDate { get; set; }//Campo003
        string transmissionSchemaVersionNumber { get; set; }
        string warehouseLocationID { get; set; }
        string manifestCreateDateTime { get; set; }
        string loadReferenceID { get; set; }
        string trailerName { get; set; }
        string carrierInternalID { get; set; }
        string amazonTechnicalName01 { get; set; }
        string amazonTechnicalName02 { get; set; }
        string manifestNumber { get; set; }
        string carrierAccountID { get; set; }
        string shipmentDate { get; set; }
        string shipmentDay { get; set; }
        string currencyCode { get; set; }
        string AddressType { get; set; }
        string name { get; set; } //Campo005
        string addressLine1 { get; set; } //Campo006
        string addressLine2 { get; set; } //Campo007
        string city { get; set; } //Campo008
        string stateProvince { get; set; } //Campo009
        string zip { get; set; } //Campo010
        string countryCode { get; set; } //Campo011
        string countryName { get; set; } //Campo012
        string amazonTaxID { get; set; }
        string prepaidCollect { get; set; }
    }
}
