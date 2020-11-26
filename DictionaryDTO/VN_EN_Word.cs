using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDTO
{
    public class VN_EN_Word
    {
        public string VNKey;
        public string VNSuggestion;
        public string WordType;
        public string Means;
        public string Example;

        public VN_EN_Word()
        {
            VNKey = "";
            VNSuggestion = "";
            WordType = "";
            Means = "";
            Example = "";
        }

    }
}
