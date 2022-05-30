using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_automation
{
    public class Category
    {
        private int id;
        private string name;
        
        // Get Set methods
        public int getID()
        {
            return id;
        }
        public void setID(int value)
        {
            id = value;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string value)
        {
            name = value;
        }

        public string ToString()
        {
            return "Category id = " + id + " Category name = " + name;
        }
        // Construtor
        public Category(int _id, string _name)
        {
            id = _id;
            name = _name;
        }


    }
}
