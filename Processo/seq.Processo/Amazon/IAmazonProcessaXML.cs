using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace seq.Processo
{
    public interface IAmazonProcessaXML
    {
        Task<int> ProcessaXML(string value);
    }
}
