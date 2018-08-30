using System;

namespace dotnet
{
    public class Queue
    {
         private class Node {
            public Node(int val) {
                Value = val;
            }
            public int Value { get; set;}
            public Node Next { get;set; }
        } 

        private Node _head;
        private Node _tail;

        public Queue() {
        }

        public void Enqueue(int val) {
            var node = new Node(val);
            if (_tail == null && _head == null) {
                _head = node;
                _tail = node;
            } else {
               _tail.Next = node;
                _tail = _tail.Next;
            }
        }

        public int Peek() {
            if (_head == null)
                throw new Exception("Empty stack");

            return _head.Value;
        }

        public int Dequeue() {
            var temp = _head.Value;
            _head = _head.Next;
            if (_head == null) {
                _tail = null;
            }
            return temp;
        }

        
        public static void Test() {
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Pop: " + queue.Dequeue());
            Console.WriteLine("Pop: " + queue.Dequeue());
            Console.WriteLine("Pop: " + queue.Dequeue());
            Console.WriteLine("Pop: " + queue.Dequeue());
        }

    }
}