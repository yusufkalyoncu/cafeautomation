using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace cafe_automation
{
    public class connectDB
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\cafe.db;Version=3");
        
    }
}
