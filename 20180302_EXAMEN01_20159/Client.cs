using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class Client : IObserver {

        public String account { get; set; }
        public String name { get; set; }
        public String bank { get; set; }

        public Client(String account, String name, String bank) {
            this.account = account;
            this.name = name;
            this.bank = bank;
        }

        public void update(BankTransaction bt, object o) {
           Console.WriteLine(this.name + " received: " + o.ToString());
        }
    }
}
