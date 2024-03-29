﻿using System;

namespace CustomDataStructures
{
    internal class StartUp
    {
        static void Main()
        {
            MyList list = new MyList();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.RemoveAt(2);

            list.Insert(2, 9);
            Console.WriteLine($"{list.Contains(9)}");
            list.Swap(1,2);
            int value = list[2];
            MyStack stack = new MyStack();
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Peek());
            int value2 = stack.Pop();
            Console.WriteLine(value2);


            MyQueue queue = new MyQueue();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"{queue.Peek()}");


        }
    }
}
