using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class ClientB : IObserver {

        public String account { get; set; }

        public ClientB(String account) {
            this.account = account;
        }

        public void update(BankTransaction bt, object o) {
            Console.WriteLine("Client B received: " + o.ToString());
        }
    }
}
