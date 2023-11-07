using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticsTool
{
    public class XMLAnalaysisTool : IAnalysisTool
    {
        Random random = new Random();
        public int StoreAnalysis(string xmlSotreData)
        {
            TryParseToXML(xmlSotreData);
            return random.Next(10);
        }
        private void TryParseToXML(string text)
        {
            Console.WriteLine("Validating!");

            if (text != "xml")
                throw new NotSupportedException();
        }
    }
}
