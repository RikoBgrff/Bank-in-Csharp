using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
   
    class Instance
    {
        public Guid ID { get; set; }= Guid.NewGuid();
    }
    class Human: Instance
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        
    }
    interface IOrganize
    {
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
