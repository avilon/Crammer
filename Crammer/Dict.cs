using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crammer
{
    /// <summary>
    /// Варианты тестирования
    /// </summary>
    public enum TestType
    {
        Choice,
        Spelling,
        Compliance,
    }

    public class Dict
    {
        public Dict()
        {
            _testType = TestType.Choice;
            _items = new Dictionary<string, WordItem>();
            _rand = new Random();
            Load();
            _currentItem = _items.ElementAt(0).Value;
        }

        public TestType TestType
        {
            get
            {
                return _testType;
            }
        }

        /// <summary>
        /// Выбор нового слова
        /// </summary>
        public void NextItem()
        {
            string prev = _currentItem.Value;
            int n = _rand.Next(0, _items.Count);
            WordItem newItem = GetItem(n);
            while (newItem.Value == prev )
            {
                n = _rand.Next(0, _items.Count);
                newItem = GetItem(n);
            }
            _currentItem = newItem;
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public WordItem CurrentItem
        {
            get
            {
                return _currentItem;
            }
        }

        public WordItem GetItem(string word)
        {
            return _items[word];
        }

        public WordItem GetItem(int index)
        {
            return _items.ElementAt(index).Value;
        }

        public string GetTranslate(int index)
        {
            WordItem wi = _items.ElementAt(index).Value;
            return GetTranslate(wi);
        }
        public string GetValue(int index)
        {
            return _items.ElementAt(index).Value.Value;
        }

        public string GetTranslate(string word)
        {
            WordItem wi = _items[word];
            return GetTranslate(wi);
        }

        public string GetCurrentTranslate()
        {
            return GetTranslate(_currentItem.Value);
        }

        public string GetCurrentValue()
        {
            return _currentItem.Value;           
        }

        public void Load()
        {
            _items.Clear();
            XmlTextReader reader = new XmlTextReader(@"E:\WorkStudio\Crammer\words.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "item")
                    {
                        WordItem wi = new WordItem();
                        wi.Read(reader);
                        _items.Add(wi.Value, wi);
                    }
                }
            }
        }

        private string GetTranslate(WordItem wordItem)
        {
            string result = "";
            if (wordItem.Translates.Count > 0)
            {
                if (wordItem.Translates.Count > 1)
                {
                    int n = _rand.Next(wordItem.Translates.Count);
                    result = wordItem.Translates[n];
                }
                else
                {
                    result = wordItem.Translates[0];
                }
            }
            else
            {
                logger.Warn("Word {0} not have translates", wordItem.Value);
            }
            return result;
        }

        public void TrySuccess()
        {
        }

        public void TryMistake()
        {

        }

        public void NextTestType()
        {
            //TODO: Добавить поддержку новых вариантов тестирования
            if (_testType == TestType.Choice)
            {
                _testType = TestType.Spelling;
                return;
            }
            if (_testType == TestType.Spelling)
            {
                _testType = TestType.Choice;
                return;
            }
        }

        public void Save(string fileName)
        {
            //TODO:  
        }

        private Random _rand;
        private Dictionary<string, WordItem> _items;
        private WordItem _currentItem;
        private TestType _testType;
        private static Logger logger = LogManager.GetCurrentClassLogger();
    }
}
