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
            _mistake = 0;
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

        public int Mistake
        {
            get
            {
                return _mistake;
            }
        }

        public void Read(XmlTextReader reader)
        {

        }

        public void Write(XmlTextWriter writer)
        {

        }

        private string _name;
        private int _tryCount;
        private int _success;
        private int _mistake;
    }
}
