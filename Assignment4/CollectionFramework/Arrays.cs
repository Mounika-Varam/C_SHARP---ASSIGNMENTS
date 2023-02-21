using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 67, 28, 43, 14, 95, 6 };
            string[] stringArray = new string[] { "Apple", "Pears", "Mango", "Banana", "Kiwi", "Muskmelon" };
            int[] intArray2 = new int[6];
            string[] stringArray2 = new string[6];

            Console.WriteLine("------------Copy----------");
            Array.Copy(intArray, intArray2, 6);
            Console.WriteLine("Array1 : {0} \nArray2(copy of Array1) : {1}", string.Join(", ", intArray), string.Join(", ", intArray2));

            Console.WriteLine("------------Sort-----------");
            Console.WriteLine("Before sorting {0}", string.Join(", ", intArray));
            Array.Sort(intArray);
            Console.WriteLine("After sorting {0}", string.Join(", ", intArray));

            Console.WriteLine("----------clear-------------");
            Console.WriteLine("Before clear {0}", string.Join(", ", intArray));
            Array.Clear(intArray);
            Console.WriteLine("After clear {0}", string.Join(", ", intArray));

            Console.WriteLine("-----------Reverse------------");
            Console.WriteLine("Before Reverse {0}", string.Join(", ", intArray2));
            Array.Reverse(intArray2);
            Console.WriteLine("After Reverse {0}", string.Join(", ", intArray2));

            Console.WriteLine();

            Console.WriteLine("------------Copy----------");
            Array.Copy(stringArray, stringArray2, 6);
            Console.WriteLine("Array1 : {0} \nArray2(copy of Array1) : {1}", string.Join(", ", stringArray), string.Join(", ", stringArray2));

            Console.WriteLine("------------Sort-----------");
            Console.WriteLine("Before sorting {0}", string.Join(", ", stringArray));
            Array.Sort(stringArray);
            Console.WriteLine("After sorting {0}", string.Join(", ", stringArray));

            Console.WriteLine("----------clear-------------");
            Console.WriteLine("Before clear {0}", string.Join(", ", stringArray));
            Array.Clear(stringArray);
            Console.WriteLine("After clear {0}", string.Join(", ", stringArray));

            Console.WriteLine("-----------Reverse------------");
            Console.WriteLine("Before Reverse {0}", string.Join(", ", stringArray2));
            Array.Reverse(stringArray2);
            Console.WriteLine("After Reverse {0}", string.Join(", ", stringArray2));
        }

    }
}
