using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crammer
{
    public class WordItem : IDictItem
    {
        public WordItem()
        {
            _translates = new Translates();
            _testResult = new TestResult();
        }

        public string Value
        {
            get 
            { 
                return _value; 
            }
        }

        public Translates Translates
        {
            get { return _translates; }
        }

        public void TrySuccess()
        {
        }

        public void TryMistake()
        {

        }

        public void Read(XmlTextReader reader)
        {
            do
            {
                if (reader.HasAttributes)
                {
                    _value = reader.GetAttribute("caption");
                    _translates.Read(reader);
                    break;
                }
            } while (reader.Read());
        }

        public void Write(XmlTextWriter writer)
        {

        }

        private string _value;
        private Translates _translates;
        private TestResult _testResult;
    }
}
