using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_automation
{
    public class Item
    {
        private int id;
        private string name;
        private int category_id;
        private float cost;
        private string pic_name;

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
        public int getCategoryID()
        {
            return category_id;
        }
        public void setCategoryID(int value)
        {
            category_id = value;
        }
        public float getCost()
        {
            return cost;
        }
        public void setCost(float value)
        {
            cost = value;
        }
        public string getPicName()
        {
            return pic_name;
        }
        public void setPicName(string value)
        {
            pic_name = value;
        }

        public Item(int _id, string _name, int _category_id, float _cost, string _pic_name)
        {
            id = _id;
            name = _name;
            category_id = _category_id;
            cost = _cost;
            pic_name = _pic_name;
        }
        public string ToString()
        {
            return "" + id + " " + name + " " + category_id + " " + cost + " " + pic_name;
        }
    }
}
