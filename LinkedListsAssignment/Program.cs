using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsAssignment
{
    class Program

    {
        static void Main(string[] args)
        {

            string[] sentence = {  };
            LinkedList<string> list = new LinkedList<string>(sentence);
            foreach(var sent in list)
            {
                Console.WriteLine(sent);
            }
            Console.WriteLine("adding a node at the top of the element");



            var Node=list.AddFirst("over");
            list.AddAfter(Node, "the"); 
            list.AddFirst("jumps");
            list.AddFirst("fox");
            list.AddFirst("brown");
            list.AddFirst("quick");
            list.AddFirst("the");
            var newNode = list.AddLast("fox");
             
            list.AddBefore(newNode, "lazy");
            
          
            Console.WriteLine("----------------------finding the element");
            Console.WriteLine(list.Find("FOX"));
            
            foreach (var sent in list)
            {
                Console.WriteLine(sent);
            }
            Console.ReadLine();
           
        }
    }
}
