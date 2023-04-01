using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Threading.Tasks;

namespace Asc
{
    public class CsvWriter
    {
        public CsvWriter()
        {

        }

        public void WriteRecords(string[] Col1Arr, double[] Col2Arr, string OutputFilePath)
        {
            FileInfo FI = new FileInfo(OutputFilePath);
            FI.Directory.Create();  // If the directory already exists, this method does nothing.
            using (var file = new StreamWriter(OutputFilePath, false))
            {
                int len = Col2Arr.Length;
                for (int i = 0; i < len; i++)
                {
                    file.WriteLine(string.Format("{0},{1}", Col1Arr[i], Col2Arr[i]));
                }
            }
        }

        public void WriteRecords(string[] Col1Arr, double[] Col2Arr, string[] HeaderArr, string OutputFilePath)
        {
            FileInfo FI = new FileInfo(OutputFilePath);
            FI.Directory.Create();  // If the directory already exists, this method does nothing.
            using (var file = new StreamWriter(OutputFilePath, false))
            {
                // Write Header
                file.WriteLine(string.Format("{0}", string.Join(",", HeaderArr)));
                // Write Content
                int len = Col2Arr.Length;
                for (int i = 0; i < len; i++)
                {
                    file.WriteLine(string.Format("{0},{1}", Col1Arr[i], Col2Arr[i]));
                }
            }
        }
    }
}
