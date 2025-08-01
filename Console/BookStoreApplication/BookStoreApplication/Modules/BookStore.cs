using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Modules
{
    public class Book
    {
        public string Name { get; set; }
                
        public string Description { get; set; }

        public int Amount { get; set; }

        public Book(string name, string description, int amount)
        { 
            Name = name;
            Description = description;
            Amount = amount;
        }
        
    }
}
