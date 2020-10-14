using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedSoftwareParadigms
{
    class AbstractQueueDataType
    {
        static void QueueMain(string[] args)
        {
            Console.WriteLine("Please Enter Input Parameter To Initialize Queue:");

            var val = Console.ReadLine();
            var queue = new QueueAbstractDataType<object>(val);

            bool finished = false;

            while (!finished)
            {
                PrintMenu();

                var newVal = Console.ReadLine();

                switch (newVal)
                {
                    case "a":
                        Console.WriteLine("a selected. please enter a new element for queue insertion:");
                        var pushVal = Console.ReadLine();
                        queue.push(pushVal);
                        break;

                    case "b":
                        Console.WriteLine("b selected. attempting to pop.");
                        queue.pop();
                        break;

                    case "c":
                        Console.WriteLine("c selected. total number of elements in queue:");
                        queue.count();
                        break;

                    case "d":
                        Console.WriteLine("d selected. program terminating.");
                        finished = true; //terminate program
                        break;

                    default: //input not understood. prompt user to try againr
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Please type 'a', 'b', 'c', or 'd'.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        protected class QueueAbstractDataType<T>
        {
            private Node<T> Head;
            private Node<T> Tail;
            private int Count = 0;

            public QueueAbstractDataType(T inputParameter)
            {
                push(inputParameter);
            }

            public void push(T newValue)
            {
                Node<T> tmp = new Node<T>(newValue);
                if (Head == null)
                {
                    Head = tmp;
                    Tail = tmp;
                }
                else
                {
                    Tail.Next = tmp;
                    Tail = Tail.Next;
                }
                Count++;
                Console.WriteLine("Success");
            }

            public void pop()
            {
                if (Count == 0)
                {
                    Console.WriteLine("There is no element in the queue");
                }
                else
                {
                    Console.WriteLine(Head.Datum.ToString());
                    Head = Head.Next;
                    Count--;
                }
            }

            public void count() { Console.WriteLine($"Total Number Of Elements In Queue: {Count}"); }
        }

        private class Node<T>
        {
            public T Datum { get; set; }
            public Node<T> Next { get; set; }

            public Node(T datum)
            {
                this.Datum = datum;
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Please Select One Of The Following Options By Typing The Corresponding Letter & Hitting Enter:");
            Console.WriteLine("a. push");
            Console.WriteLine("b. pop");
            Console.WriteLine("c. count");
            Console.WriteLine("d. end");
            Console.WriteLine();
        }
    }
}

