using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class Program {
        static void Main(string[] args) {
            Client banamexClient = new Client("12345", "Cliente 1", "Banamex");
            Client aztecaClient = new Client("09876", "Cliente 2", "BancoAzteca");
            Client bancomerClient = new Client("36731", "Cliente 3", "Bancomer");

            BanamexTransaction banamex = new BanamexTransaction();
            BancoAztecaTransaction azteca = new BancoAztecaTransaction();
            BancomerTransaction bancomer = new BancomerTransaction();

            banamex.doTransaction(banamexClient, aztecaClient, 100.0);
            banamex.doTransaction(banamexClient, bancomerClient, 160.25);

            azteca.doTransaction(aztecaClient, banamexClient, 100.0);
            azteca.doTransaction(aztecaClient, bancomerClient, 160.25);

            bancomer.doTransaction(bancomerClient, aztecaClient, 100.0);
            bancomer.doTransaction(bancomerClient, banamexClient, 160.25);

            Console.ReadLine();
        }
    }
}
