using System;
using System.Collections;
using System.Collections.Generic;

namespace Delegare
{

    class Program
    {
     
        static void Main(string[] args)
        {

        //

            AlphaNumericCollector alphaNumericCollector = new AlphaNumericCollector();
            StringCollector stringCollector = new StringCollector();
            WriteLine writeLine = new WriteLine();

            writeLine.collectorDelegate += stringCollector.Collector;
            writeLine.collectorDelegate += alphaNumericCollector.Collector;

            writeLine.WriteLineFunc();

            Console.ReadKey();
        }

    }
}
