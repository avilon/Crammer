using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crammer
{
    public class TestResult : IDictItem
    {
        public TestResult()
        {
            _tryCount = 0;
            _success = 0;
            _misses = 0;
            _name = "Default";
        }

        public int TryCount
        {
            get
            {
                return _tryCount;
            }
        }

        public int Success
        {
            get
            {
                return _success;
            }
        }

        public int Misses
        {
            get
            {
                return _misses;
            }
        }

        public void Read(XmlTextReader reader)
        {
            if (reader.HasAttributes)
            {
                _name = reader.GetAttribute("name");
                _tryCount = int.Parse(reader.GetAttribute("total"));
                _success = int.Parse(reader.GetAttribute("success"));
                _misses = int.Parse(reader.GetAttribute("misses"));
            }
        }

        public void Write(XmlTextWriter writer)
        {

        }

        private string _name;
        private int _tryCount;
        private int _success;
        private int _misses;
    }
}
