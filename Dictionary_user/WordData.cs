﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_user
{
    public class WordData
    {
        #region properties

        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        private string meaning;

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }

        private string explaination;

        public string Explaination
        {
            get { return explaination; }
            set { explaination = value; }
        }
        #endregion
    }
}
