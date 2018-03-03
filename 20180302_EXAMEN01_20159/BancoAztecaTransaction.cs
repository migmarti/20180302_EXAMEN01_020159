using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    class BancoAztecaTransaction : BankTransaction {

        String message;

        public BancoAztecaTransaction() : base() {
            this.format = new JSON();
            this.protocol = new HTTP();
        }

        public override void doTransaction(Client source, Client target, double quantity) {
            Boolean notifyTarget = false;
            if (!this.observers.Contains(target)) {
                this.observers.Add(target);
                notifyTarget = true;
            }
            message = "(BANCOAZTECA) Transferred using " + this.format.response() + " " + this.protocol.transferInfo();
            message += "\nSource: " + source.account + " - " + source.name + " - " + source.bank;
            message += "\nTarget: " + target.account + " - " + target.name + " - " + target.bank;
            message += "\nQuantity: " + quantity + "\n";
            notify(message);
            if (notifyTarget) {
                this.observers.Remove(target);
            }
        }
    }
}
