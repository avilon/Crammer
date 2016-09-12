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
        public Translates()
        {
            _items = new List<string>();
            _count = 0;
        }

        public int Count 
        { 
            get 
            { 
                return _count; 
            } 
        }

        public string this[int index]
        {
            get
            {
                return _items[index];
            }
        }

        public void Read(XmlTextReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "translates")
                        continue;

                    if (reader.Name == "translate")
                    {
                        _items.Add(reader.GetAttribute("value"));
                        _count++;
                    }

                    else
                    {
                        break;
                    }
                }
            }
        }

        public void Write(XmlTextWriter writer)
        {

        }

        private int _count;
        private List<string> _items;
    }
}
