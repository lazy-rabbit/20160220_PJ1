using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tt = "123";
    ////[條件式註解語法]
    //‪#‎if‬ DEBUG && STAGE
    //var tt = new RuntimeTextTemplate1().TransformText();
    //‪#‎elif‬ !DEBUG
    //var tt = "Not Debug"
    //‪#‎else‬
    //var tt = "123";
    //‪#‎endif‬

            Debug.WriteLine("Start");

            Trace.WriteLine("Start");

            Debug.Assert(tt == "123", "Assert");
            

            Trace.TraceInformation("--->TraceInformation");
            Trace.TraceWarning("--->TraceWarning");
            Trace.TraceError("--->TraceError");
                      

            //Debug.Fail();

            DoSomething(tt);
            //throw new Exception(tt);

            Debug.WriteLine("END");

            Debug.WriteLine("END");

            Console.WriteLine(tt);

//自動將偵錯資訊寫入到輸出
//Debug.AutoFlush = true;
//將偵錯資訊輸出到主控台輸出(Console Output)
//TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
//Debug.Listeners.Add(tr1);
//將偵錯資訊輸出到文字檔案(Text File)
//TextWriterTraceListener tr2 = new TextWriterTraceListener(File.CreateText("Out.txt"));
//Debug.Listeners.Add(tr2);



        }

        private static string DoSomething(string tt)
        { return tt; }
    }
}
