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
        public void Read(XmlTextReader reader)
        {

        }

        public void Write(XmlTextWriter writer)
        {

        }

        private string _name;
        private int _tryCount;
        private int _rightCount;
    }
}
