using System;

namespace EmployeeManagementSystem
{
    internal class MyStack
    {
        int size = 10;
        int[] numArray = new int[10];
        int top = -1;

        public void Push(int value)
        {
            numArray[top] = value;
            top++;
        }

        public int Pop()
        {
            top--;
            return numArray[top+1];
        }
        

    }
}
