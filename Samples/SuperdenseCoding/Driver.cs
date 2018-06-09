using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Microsoft.Quantum.Samples.SuperdenseEx
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                int bit1 = 0;
                int bit2 = 0;
                for (int i = 0; i <= 3; i++)
                {
                  
                    bit1 = i % 2;
                    bit2 = i / 2;

                    System.Console.WriteLine("\n\nSending {{{0}, {1}}}  \r", bit1, bit2);

                    var received = SuperdenseCodingTest.Run(sim, bit1, bit2).Result;

                    if (received.Item1)
                    { System.Console.WriteLine("Bit 1 succesfully sent \r"); }
                    else
                    { System.Console.WriteLine("Bit 1 not succesfully sent \r"); }
                    if (received.Item2)
                    { System.Console.WriteLine("Bit 2 succesfully sent \n"); }
                    else
                    { System.Console.WriteLine("Bit 2 not succesfully sent \n"); }
                }
            }
            System.Console.WriteLine("\n \n Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}