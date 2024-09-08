using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool_Pattern {
    internal class Database_Connection {
        DbConnection dbConnection { get; set; }

        public Database_Connection () {
            // Logic to connect to database
        }
    }
}
