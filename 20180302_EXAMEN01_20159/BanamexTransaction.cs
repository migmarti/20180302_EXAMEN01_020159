using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class BanamexTransaction : BankTransaction {

        String message;

        public BanamexTransaction() : base() {
            this.format = new XML();
            this.protocol = new HTTP();
            this.message = "Transferred using " + 
                this.format.response() + " " + this.protocol.transferInfo();
        }

        public override void doTransaction(string source, string target, double quantity) {
            message += "\n(Source: " + source + ", Target: " + target + ", Quantity: " + quantity + ")";
            notify(message);
        }
    }
}
