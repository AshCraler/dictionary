using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDTO
{
    public class FeedBackDTO
    {
        public int Id;
        public DateTime time;
        public string title;
        public string email;
        public string fullName;
        public string phoneNumber;
        public string content;

        public FeedBackDTO() { }

        public FeedBackDTO(int id, DateTime tim, string t,string e, string name, string number, string cont)
        {
            Id = id;
            time = tim;
            title = t;
            email = e;
            fullName = name;
            phoneNumber = number;
            content = cont;
        }
    }
}
