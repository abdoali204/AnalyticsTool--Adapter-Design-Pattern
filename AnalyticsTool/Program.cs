// See https://aka.ms/new-console-template for more information
using AnalyticsTool;

#region Current System Using XML formated data 
var XMLStoreData = "xml";
IAnalysisTool analysisTool = new XMLAnalaysisTool();
Console.WriteLine(analysisTool.StoreAnalysis(XMLStoreData));
#endregion

#region New Tool with JSON/Text formats without adapter
var xmlStoredDatav2 = "xml";
var parsedToJsonData = ParseToJson(xmlStoredDatav2);
SmartAnalysisTool smartAnalysisTool = new SmartAnalysisTool();
Console.WriteLine(smartAnalysisTool.Analysis(Format.JSON,parsedToJsonData));

string ParseToJson(string xmlData)
{
    return xmlData + " parsed";
}
#endregion
// Did you noticed that in the previous solution we had to entirely change the current implementation

#region New Tool with adapter pattern -- Please note if the service is injected using DI you wouldn't change any only which implementation to be used
var XMLStoreData3 = "xml";
IAnalysisTool analysisTool3 = new SmartAnalysisAdapter(new SmartAnalysisTool());
Console.WriteLine(analysisTool.StoreAnalysis(XMLStoreData));
#endregion

Console.ReadLine();





