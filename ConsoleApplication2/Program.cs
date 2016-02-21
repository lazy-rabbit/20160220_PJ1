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

            throw new Exception(tt);

            Debug.WriteLine("END");

        }

        private string DoSomething(string tt)
        { return tt; }
    }
}
