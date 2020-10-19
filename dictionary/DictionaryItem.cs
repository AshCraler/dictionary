using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    [Serializable]

    public class DictionaryItem
    {
        private List<WordData> data;

        public List<WordData> Data
        {
            get { return data; }
            set { data = value; }
        }
        
    }
}
