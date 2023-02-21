using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework 
{
    public class MyStack<T>
    {
        Stack<T> stack;
        public void Push(T item)
        {
            stack.Push(item);
        }

        public T Pop()
        {
            return stack.Pop();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> temp = new MyStack<int> ();

            temp.Push (1);
            Console.WriteLine(temp.Pop);
        }
    }

}
