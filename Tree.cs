using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet
{
    
    public class Node {
        public int value;
        public Node left;
        public Node right;
        public Node(int val) {
            value = val;
        }
    }

    public class BinaryTree
    {

        public static void Test() {

            BinaryTree bt = new BinaryTree();
            bt.add(6);
            bt.add(4);
            bt.add(8);
            bt.add(3);
            bt.add(5);
            bt.add(7);
            bt.add(9);

            Console.WriteLine(bt.containsNode(5));
            Console.WriteLine(bt.containsNode(1));
            
            bt.traverseInOrder(bt.root);
            bt.traverseLevelOrder();
            

        }

        private Node root;

        public BinaryTree() {
        }

        public void add(int value) {
            root = addRecursive(root, value);
        }

        public bool containsNode(int value) {
            return containsNodeRecursive(root, value);
        }
        

        private Node addRecursive(Node current, int value) {
            if (current == null) {
                return new Node(value);
            }
            if (value < current.value) {
                current.left = addRecursive(current.left, value);
            } else if (value > current.value) {
                current.right = addRecursive(current.right, value);
            } else {
                // value already exists
                return current;
            }
            return current;
        }

        private bool containsNodeRecursive(Node current, int value) {
            if (current == null) {
                return false;
            } 
            if (value == current.value) {
                return true;
            } 
            return value < current.value
            ? containsNodeRecursive(current.left, value)
            : containsNodeRecursive(current.right, value);
        }

        public void traverseInOrder(Node node) {
        if (node != null) {
            traverseInOrder(node.left);
            Console.WriteLine(node.value);
            traverseInOrder(node.right);
        }
        }
        
        public void traversePreOrder(Node node) {
            if (node != null) {
                Console.WriteLine(node.value);
                traversePreOrder(node.left);
                traversePreOrder(node.right);
            }
        }

        public void traversePostOrder(Node node) {
            if (node != null) {
                traversePostOrder(node.left);
                traversePostOrder(node.right);
                Console.WriteLine(node.value);
            }
        }

        public void traverseLevelOrder() {
            
            if (root == null) {
                return;
            }
        
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);
        
            while (!(nodes.Count == 0)) {
        
                Node node = nodes.Dequeue();
        
                Console.WriteLine(node.value);
        
                if (node.left != null) {
                    nodes.Enqueue(node.left);
                }
        
                if (node.right!= null) {
                    nodes.Enqueue(node.right);
                }
            }
        }


    }


}