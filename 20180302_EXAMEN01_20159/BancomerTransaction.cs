using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class BancomerTransaction : BankTransaction {

        String message = "";

        public BancomerTransaction() : base() {
            this.format = new CSV();
            this.protocol = new TCP();
            this.message = "Transferred " + quantity + " using " +
                this.format.response() + " " + this.protocol.transferInfo();
        }

        public override void doTransaction(string source, string target, double quantity) {
            message += "\n(Source: " + source + ", Target: " + target + ")";
            notify(message);
        }
    }
}
