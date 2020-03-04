using seq.Domain.Interface.Entities.Amazon;
using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Entities.Amazon
{
    public class AmazonLUFTHeaderModel : IAmazonLUFTHeaderModel
    {
        public string cnpjRemetente { get; set;}
        public string inscricaoestadual { get; set;}
        public string razaosocial { get; set;}
        public string endereco { get; set;}
        public string bairro { get; set;}
        public string cidade { get; set;}
        public string uf { get; set;}
        public string cep { get; set;}
    }
}
