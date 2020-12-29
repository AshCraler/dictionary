using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDTO
{
    [Serializable]
    public class VN_EN_History
    {
        public List<VN_EN_Word> data = new List<VN_EN_Word>();

        public void push(VN_EN_Word w)
        {
            data.Insert(0, w);
        }
        
        
    }
}
