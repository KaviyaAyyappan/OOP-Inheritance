using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfString stack = new StackOfString();
            stack.Push("hello");
            stack.Push("vi");
            stack.Push("Lexicon");
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.peek());
            Console.ReadLine();
            
            
        }
    }
}
