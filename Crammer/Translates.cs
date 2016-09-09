using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crammer
{
    public class Translates : IDictItem
    {
        public int Count 
        { 
            get 
            { 
                return _count; 
            } 
        }

        public void Read(XmlTextReader reader)
        {

        }

        public void Write(XmlTextWriter writer)
        {

        }

        private int _count;
    }
}
