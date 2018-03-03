using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class Program {
        static void Main(string[] args) {
            ClientA clientA = new ClientA("12345");
            ClientB clientB = new ClientB("09876");

            BanamexTransaction banamex = new BanamexTransaction();
            banamex.add(clientB);

            banamex.doTransaction(clientB.account, clientA.account, 100.0);

            Console.ReadLine();
        }
    }
}
