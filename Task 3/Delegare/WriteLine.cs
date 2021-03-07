using System;
using System.Collections.Generic;
using System.Text;

namespace Delegare
{
    public delegate void CollectorDelegate(string text); // for task 2.1, 2.2
    class WriteLine
    {
        // public CollectorDelegate collectorDelegate; // task 2.1
        // public event CollectorDelegate collectorDelegate; // task 2.2
        public event Action<string> collectorDelegate; // task 2.3

        private string buf;

        public void WriteLineFunc()
        {
            do
            {
                Console.WriteLine(@"Enter line or enter 'exit' to exit:");

                buf = Console.ReadLine();

                collectorDelegate(buf);

            }
            while (buf != "exit");

            Console.WriteLine(@"End");
        }

    }
}
