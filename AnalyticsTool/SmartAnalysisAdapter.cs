using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticsTool
{
    public class SmartAnalysisAdapter : IAnalysisTool
    {
        private ISmartAnalysisTool _smartAnalysisTool;
        public SmartAnalysisAdapter(ISmartAnalysisTool smartAnalysisTool)
        {
            _smartAnalysisTool = smartAnalysisTool;
        }
        public int StoreAnalysis(string soldItems)
        {
            var textFormat = GetTextFormat(soldItems);
            return _smartAnalysisTool.Analysis(textFormat, soldItems);
        }

        private Format GetTextFormat(string text)
        {
            if (text == "xml")
                return Format.PlainText;

            return Format.JSON;
        }
    }
}
