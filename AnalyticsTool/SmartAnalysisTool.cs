using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticsTool
{
    public class SmartAnalysisTool : ISmartAnalysisTool
    {
        Random random = new Random();
        public int Analysis(Format format, string storeData)
        {
            Validate();

            return random.Next(15);
        }

        private void Validate()
        {
            Console.WriteLine("Start validating the format");

            Console.WriteLine("It's Valid format");
        }

    }

    public enum Format
    {
        PlainText,

        JSON
    }
}
