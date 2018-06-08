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
                var received = SuperdenseCodingTest.Run(sim, 2, 2).Result;

                if (received.Item1)
                { System.Console.WriteLine("Bit 1 succesfully sent \n\n"); }
                else
                { System.Console.WriteLine("Bit 1 not succesfully sent \n\n"); }
            }
            System.Console.WriteLine("\n \n Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}