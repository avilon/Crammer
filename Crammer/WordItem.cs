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
            _testResults = new List<TestResult>();
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
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "item")
                    {
                        if (reader.HasAttributes)
                        {
                            _value = reader.GetAttribute("caption");
                            _translates.Read(reader);
                        }
                    }
                    else if (reader.Name == "tests")
                    {
                        ReadTestStatistic(reader);
                    }
                    else
                    {
                        break;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (reader.Name == "item")
                    {
                        break;
                    }
                }

            } while (reader.Read());
        }

        public void Write(XmlTextWriter writer)
        {

        }

        private void ReadTestStatistic(XmlTextReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "test")
                    {
                        TestResult tr = new TestResult();
                        tr.Read(reader);
                        _testResults.Add(tr);
                    }
                }
                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (reader.Name == "tests")
                    {
                        break;
                    }
                }
            }
        }

        private string _value;
        private Translates _translates;
        private List<TestResult> _testResults;
    }
}
