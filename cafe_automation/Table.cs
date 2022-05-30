using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_automation
{
    public class Table
    {
        private int id;
        private float cost;
        private List<Item> orders = new List<Item>();

        public int getID()
        {
            return id;
        }
        public void setID(int value)
        {
            id = value;
        }
        public float getCost()
        {
            return cost;
        }
        public void setCost(float value)
        {
            cost = value;
        }
        public List<Item> getOrders()
        {
            return orders;
        }
        public void setOrders(List<Item> value)
        {
            orders = value;
        }

        public string ToString()
        {
            return "Table " + id + " Orders : " + orders.ToString();
        }

    }
}
