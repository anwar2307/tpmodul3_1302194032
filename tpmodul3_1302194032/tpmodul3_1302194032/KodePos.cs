using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302194032
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos table_Kodepos = new KodePos();
            Console.WriteLine("Keluarahan       Kode Pos");
            table_Kodepos.getKodePos();
        }

    }
    class KodePos
    {

        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "        40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "        40274"},
            {"Samoja", "        40273"}
        };

        public void getKodePos()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t {1}", ele1.Key, ele1.Value);
            }
        }
    }
}
