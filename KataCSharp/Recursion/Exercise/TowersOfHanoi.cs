using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsSoftuni.Recursion.Exercise
{
    public class TowersOfHanoi
    {

        static IEnumerable<int> range = Enumerable.Range(1, 3);

        static Stack<int> sourceRod = new Stack<int>(range);
        static Stack<int> destinationRod = new Stack<int>();
        static Stack<int> spareRod = new Stack<int>();

        private static int stepsTaken = 0;

        public static void Solve(int numDisks)
        {
            PrintRods();
            MoveDisks(numDisks, sourceRod, destinationRod, spareRod);
        }

        public static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)// A,B,C
        {

            if (bottomDisk == 1)
            {
                stepsTaken++;

                destination.Push(source.Pop());

                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintRods();
            }
            else
            {
                // 1) move all disks from bottomDisk - 1 from source to spare;
                // Shift first disk from 'A' to 'B'.
                MoveDisks(bottomDisk - 1, source, spare, destination);// A,C,B
                stepsTaken++;
                destination.Push(source.Pop());  // 2) move the bottomDisk from source to destination; Shift second disk from 'A' to 'C'.
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintRods();
                // 3) move all disks previously moved to spare to destination.
                //  Shift first disk from 'B' to 'C'.
                MoveDisks(bottomDisk - 1, spare, destination, source);// C,B,A
            }
        }

        private static void PrintRods()
        {
            Console.WriteLine($"Source: {String.Join(", ", sourceRod.Reverse())}");
            Console.WriteLine($"Destination: {String.Join(", ", destinationRod.Reverse())}");
            Console.WriteLine($"Spare: {String.Join(", ", spareRod.Reverse())}");
            Console.WriteLine();
        }
    }
}

//Error MSB4018: The "ResolvePackageAssets" task failed unexpectedly