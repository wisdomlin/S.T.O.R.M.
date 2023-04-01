using System;
using System.Collections.Generic;

namespace Asc
{
    public class Def_EcadWeather : DatalineEntityFormat
    {
        /// <summary>
        /// 1 Csv File Format  for CSV File
        /// </summary>
        public Def_EcadWeather(char[] _Delimiters) : base(_Delimiters)
        {
            // Specify (FieldName, ValueAddress, ValueType) Here:
            LookUpTable.Add("STAID", (ValueAddress: 0, ValueType: "UInt16"));
            LookUpTable.Add("SOUID", (ValueAddress: 1, ValueType: "UInt16"));
            LookUpTable.Add("DATE", (ValueAddress: 2, ValueType: "DateTime"));
            LookUpTable.Add("VAL", (ValueAddress: 3, ValueType: "Int16"));
            LookUpTable.Add("Q_VAL", (ValueAddress: 4, ValueType: "SByte"));
        }
    }
}
