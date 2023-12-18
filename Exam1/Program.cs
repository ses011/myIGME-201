using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * IGME-201 Final Q1-2
 * 
 * MyStack -  building own stack structure
 * 
 * MyQueue - building own queue structure
 * 
 */
namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /*
     * Rewriting a stack with push, pop, and peek methods 
     */
    class MyStack
    {
        List<int> list;

        public MyStack()
        {
            this.list = new List<int>();
        }

        public void Push(int n)
        {
            this.list.Add(n);
        }

        public int Pop()
        {
            int val = this.list.Last();
            this.list.RemoveAt(this.list.Count - 1);
            return val;
        }

        public int Peek() 
        { 
            return this.list[this.list.Count - 1]; 
        }
    }

    /*
     * Rewriting a queue with enqueue, dequeue, and peek methods 
     */
    class MyQueue
    {
        List<int> list;
        public MyQueue()
        {
            this.list= new List<int>();
        }

        public void Enqueue(int n)
        {
            this.list.Add(n);
        }

        public int Dequeue()
        {
            int val = this.list[0];
            this.list.RemoveAt(0);
            return val;
        }

        public int Peek()
        {
            return this.list[0];
        }
    }
}
