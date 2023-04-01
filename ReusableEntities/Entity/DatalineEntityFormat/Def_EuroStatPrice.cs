using System;
using System.Collections.Generic;

namespace Asc
{
    public class Def_EuroStatPrice : DatalineEntityFormat
    {
        /// <summary>
        /// Csv File Format for CSV File
        /// </summary>
        public Def_EuroStatPrice(char[] _Delimiters) : base(_Delimiters)
        {
            // Specify (FieldName, ValueAddress, ValueType) Here:
            // DATAFLOW,LAST UPDATE,freq,unit,indx,coicop,geo,TIME_PERIOD,OBS_VALUE,OBS_FLAG
            LookUpTable.Add("DATAFLOW", (ValueAddress: 0, ValueType: "String"));
            LookUpTable.Add("LAST UPDATE", (ValueAddress: 1, ValueType: "DateTime"));
            LookUpTable.Add("freq", (ValueAddress: 2, ValueType: "String"));
            LookUpTable.Add("unit", (ValueAddress: 3, ValueType: "String"));
            LookUpTable.Add("indx", (ValueAddress: 4, ValueType: "String"));
            LookUpTable.Add("coicop", (ValueAddress: 5, ValueType: "String"));
            LookUpTable.Add("geo", (ValueAddress: 6, ValueType: "String"));
            LookUpTable.Add("TIME_PERIOD", (ValueAddress: 7, ValueType: "DateTime"));
            LookUpTable.Add("OBS_VALUE", (ValueAddress: 8, ValueType: "Double"));
            LookUpTable.Add("OBS_FLAG", (ValueAddress: 9, ValueType: "String"));

            // old format (to be deleted)
            //LookUpTable.Add("TIME", (ValueAddress: 0, ValueType: "DateTime"));
            //LookUpTable.Add("GEO", (ValueAddress: 1, ValueType: "String"));
            //LookUpTable.Add("UNIT", (ValueAddress: 2, ValueType: "String"));
            //LookUpTable.Add("INDX", (ValueAddress: 3, ValueType: "String"));
            //LookUpTable.Add("COICOP", (ValueAddress: 4, ValueType: "String"));
            //LookUpTable.Add("Value", (ValueAddress: 5, ValueType: "Double"));
            //LookUpTable.Add("Flag and Footnotes", (ValueAddress: 6, ValueType: "String"));
        }
    }
}
