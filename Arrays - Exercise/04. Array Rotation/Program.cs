using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select
                (int.Parse)
                .ToArray(); // ==  Console.ReadLine().Split().Select(int.Parse) .ToArray(); => вземи входа от конзолата, сплитни го с разтояние,от текст ги превърни в интидбъри и изкарай всичко като масив
            int rotations = int.Parse(Console.ReadLine());
            for (int rotatiton = 0; rotatiton < rotations; rotatiton++)
            {
                int tempEl = arr[0];
                for (int operations = 0; operations < arr.Length - 1; operations++)
                {
                    arr[operations] = arr[operations + 1];
                }

                arr[arr.Length - 1] = tempEl;
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
