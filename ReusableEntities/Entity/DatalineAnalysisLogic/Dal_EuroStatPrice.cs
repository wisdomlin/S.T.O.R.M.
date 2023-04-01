using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Asc
{
    public class Dal_EuroStatPrice : DatalineAnalysisLogic
    {
        // TODO: Unified with QuickMixTank and by List<T> common structure in Qmt 
        public ConcurrentDictionary<string, List<double>> dicListFpi
            = new ConcurrentDictionary<string, List<double>>();

        public ConcurrentDictionary<string, List<string>> dicListDate
            = new ConcurrentDictionary<string, List<string>>();

        public Dictionary<string, string> Dic_CoicopCode2Label = new Dictionary<string, string>()
        {
            {"CP011","Food"},
            {"CP01121","Beef and veal"},
            {"CP0213","Beer"},
            {"CP01113","Bread"},
            {"CP0111","Bread and cereals"},
            {"CP01151","Butter"},
            {"CP01145","Cheese and curd"},
            {"CP0121","Coffee, tea, and cocoa"},
            {"CP01147","Eggs"},
            {"CP0113","Fish and seafood"},
            {"CP01141","Fresh whole milk"},
            {"CP0116","Fruit"},
            {"CP01223","Fruit and vegetables juices"},
            {"CP01123","Lamb and goat"},
            {"CP0112","Meat"},
            {"CP0114","Milk, cheese, and eggs"},
            {"CP0115","Oils and fats"},
            {"CP01153","Olive oil"},
            {"CP01154","Other edible oils"},
            {"CP01122","Pork"},
            {"CP01174","Potatoes"},
            {"CP01124","Poultry"},
            {"CP01181","Sugar"},
            {"CP0117","Vegetables"},
            {"CP02121","Wine from grapes"},
            {"CP01144","Yoghurt"}
        };

        public Dal_EuroStatPrice(DatalineEntityFormat _Def) : base(_Def)
        {

        }

        internal override void CustomizedAnalyze(string Line)
        {
            string[] LineSplits = Line.Split(Def.Delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Address Linking
            int AddrTIME = Def.GetValueAddress("TIME_PERIOD");  // YYYY-MM (e.g., 2005-01)
            int AddrCOICOP = Def.GetValueAddress("coicop");
            int AddrValue = Def.GetValueAddress("OBS_VALUE");

            // Value String Accessing
            string sValTIME = LineSplits[AddrTIME].Trim();
            string sValCoicopCode = LineSplits[AddrCOICOP].Trim();
            string sValValue = LineSplits[AddrValue].Trim();

            Dic_CoicopCode2Label.TryGetValue(sValCoicopCode, out string sCoicopLabel);
            if (dicListFpi.TryGetValue(sCoicopLabel, out List<double> _ListFpi))
            {
                // If key found, directly add
                Double.TryParse(sValValue, out double ParseResult);
                _ListFpi.Add(ParseResult);
            }
            else
            {
                // If key not found, create and add
                List<double> _NewListFpi = new List<double>();
                dicListFpi.TryAdd(sCoicopLabel, _NewListFpi);
                Double.TryParse(sValValue, out double ParseResult);
                _NewListFpi.Add(ParseResult);
            }

            if (dicListDate.TryGetValue(sCoicopLabel, out List<string> _ListDate))
            {
                // If key found, directly add
                _ListDate.Add(sValTIME);
            }
            else
            {
                // If key not found, create and add
                List<string> _NewListDate = new List<string>();
                dicListDate.TryAdd(sCoicopLabel, _NewListDate);
                _NewListDate.Add(sValTIME);
            }
        }
    }
}
