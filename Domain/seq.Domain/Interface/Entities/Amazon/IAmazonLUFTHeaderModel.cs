using System;
using System.Collections.Generic;
using System.Text;

namespace seq.Domain.Interface.Entities.Amazon
{
    public interface IAmazonLUFTHeaderModel
    {
        string cnpjRemetente {get; set;}//Campo011 
        string inscricaoestadual {get; set;} //Campo012
        string razaosocial {get; set;} //Campo001
        string endereco {get; set;} //Campo002
        string bairro {get; set;} //Campo010
        string cidade {get; set;} //Campo004
        string uf {get; set;} //Campo008
        string cep {get; set;} //Campo006
    }    
}
