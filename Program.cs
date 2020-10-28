using System;
using ClassLib;
//using Hangfire.Server;

namespace pr3_1
{
    class Program2
    {
        static void Main(string[] args)
        {
            ClassLib.Worker[] x = new ClassLib.Worker[5];
            Company y = new ClassLib.Company();
            x = Program.ReadWorkersArray();
            Program.Menub(x);
        }
    }
}
