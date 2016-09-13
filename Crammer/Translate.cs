using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crammer
{
    class Translate : IDictItem
    {
        public string Value 
        { 
            get 
            { 
                return _value; 
            } 
        }
        
        public void Read(XmlTextReader reader)
        {
            _value = "";
        }

        public void Write(XmlTextWriter writer)
        {

        }

        private string _value;
    }
}
