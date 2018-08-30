using System;

namespace dotnet
{
    public class Stack
    {
        private class Node {
            public Node(int val) {
                Value = val;
            }
            public int Value { get; set;}
            public Node Next { get;set; }
        } 

        private Node _top;
        public Stack() {

        }

        public void Push(int val) {
            var node = new Node(val);
            node.Next = _top;
            _top = node;
        }


        public int Peek() {
            if (_top == null)
                throw new Exception("Empty stack");

            return _top.Value;
        }

        public int Pop() {
            var temp = _top.Value;
            _top = _top.Next;
            return temp;
        }

        public static void Test() {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());
        }

    }
}