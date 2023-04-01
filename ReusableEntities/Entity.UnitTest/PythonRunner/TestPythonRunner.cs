

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace Asc
{
    class TestPythonRunner
    {
        [Test]
        public void UC01_TestPythonRunner()
        {
            PythonRunner pr = new PythonRunner();
            //for (int i = 0; i < 100; i++)
            //{
            //    pr.run_cmd("code.py", i.ToString());
            //}
            pr.run_cmd("D:\\ts_decompose.py", "TestOnce");
        }
    }
}
