using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using cafe_automation.Widgets;
namespace cafe_automation
{

    public class CRUD
    {
        static DataTable dt; 
        public static DataTable read(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, connectDB.connection);
            adtr.Fill(dt);
            return dt;
        }

        public static void connectDataBase()
        {
            connectDB.connection.Open();
        }
        public static List<Category> getCategories()
        {
            //connectDB.connection.Open();
            List<Category> categoryList = new List<Category>();
            string sql = "select * from Category";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connectDB.connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryList.Add(new Category(Convert.ToInt32(reader["id"]), reader["name"].ToString()));
                    }
                    //connectDB.connection.Close();
                    return categoryList;
                }
            }
        }
        public static List<Item> getItems()
        {
            //connectDB.connection.Open();
            string sql = "select * from Item";
            //connectDB.connection.Open();
            List<Item> itemList = new List<Item>();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connectDB.connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemList.Add(new Item(Convert.ToInt32(reader["id"]), reader["name"].ToString(), Convert.ToInt32(reader["category_id"]), float.Parse(reader["cost"].ToString()), reader["pic_name"].ToString()));
                    }
                    //connectDB.connection.Close();
                    return itemList;
                }
            }
        }
        public static List<table> getTables()
        {
            //connectDB.connection.Open();
            string sql = "select * from [Table]";
            List<table> tableList = new List<table>();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connectDB.connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        table tbl = new table();
                        tbl.TableName = reader["name"].ToString();
                        tbl.PosX = Convert.ToInt32(reader["posX"].ToString());
                        tbl.PosY = Convert.ToInt32(reader["posY"].ToString());
                        tableList.Add(tbl);
                    }  
                    //connectDB.connection.Close();
                    return tableList;
                }
            }
        }

        public static void addTable(table tbl)
        {
            //connectDB.connection.Open();
            string sql = "insert into [Table](name,posX,posY) VALUES(" + "'" + tbl.TableName + "'" + "," + tbl.PosX + "," + tbl.PosY + ");";
            using(SQLiteCommand cmd = new SQLiteCommand(sql, connectDB.connection))
            {
                cmd.ExecuteNonQuery();
            }
            //connectDB.connection.Close();
        }
        public static void deleteTable(table tbl)
        {
            string sql = "delete from [Table] where [Table].name = " + "'" + tbl.TableName + "';";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connectDB.connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
