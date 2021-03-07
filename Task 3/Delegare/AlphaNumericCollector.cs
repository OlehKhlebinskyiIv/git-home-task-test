using System;
using System.Collections.Generic;
using System.Text;

namespace Delegare
{
    class AlphaNumericCollector
    {
        List<string> collection = new List<string>();
        public void Collector(string item)
        {

            if (item.Contains('0') ||
                item.Contains('1') ||
                item.Contains('2') ||
                item.Contains('3') ||
                item.Contains('4') ||
                item.Contains('5') ||
                item.Contains('6') ||
                item.Contains('7') ||
                item.Contains('8') ||
                item.Contains('9'))
            {
                collection.Add(item);
            }
        }
    }
}
