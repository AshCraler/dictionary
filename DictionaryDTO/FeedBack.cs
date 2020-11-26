using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDTO
{
    public class FeedBack
    {
        public string email;
        public string fullName;
        public string phoneNumber;
        public string content;

        public FeedBack() { }

        public FeedBack(string e, string name, string number, string cont)
        {
            email = e;
            fullName = name;
            phoneNumber = number;
            content = cont;
        }
    }
}
