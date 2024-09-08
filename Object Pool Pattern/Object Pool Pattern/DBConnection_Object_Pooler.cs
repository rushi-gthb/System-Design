using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool_Pattern {
    internal class DBConnection_Object_Pooler {

        private static readonly object _lock = new object();

        public readonly int Max_Connection = 3;

        public List<Database_Connection> freeList { get; set; }

        public List<Database_Connection> inUseList { get; set; }

        public DBConnection_Object_Pooler() {
            for (int i = 0; i < Max_Connection; i++) {
                freeList.Add(new Database_Connection());
            }
        }

        public Database_Connection? GetInstance() {
            if (freeList.Count > 0) {
                lock (_lock) {
                    var obj = freeList.ElementAt(freeList.Count - 1);
                    inUseList.Add(obj);
                    freeList.Remove(obj);
                    return obj;
                }
            }
            Console.WriteLine("All objects are busy...Please wait for while.");
            return null;
        }

        public void ReleaseInstance(Database_Connection obj) {
            lock(_lock) {
                inUseList.Remove(obj);
                freeList.Add(obj);
            }
        }
    }
}
