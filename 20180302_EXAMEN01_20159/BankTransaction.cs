using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    abstract class BankTransaction {
        List<IObserver> observers;
        public String originAccount { get; set; }
        public String destinationAccount { get; set; }
        public double quantity { get; set; }
        public IFormat format { get; set; }
        public IProtocol protocol { get; set; }

        public BankTransaction() {
            this.observers = new List<IObserver>();
        }

        abstract public void doTransaction(String source, String target, double quantity);

        public void add(IObserver observer) {
            this.observers.Add(observer);
        }
        public void remove(IObserver observer) {
            this.observers.Remove(observer);
        }
        public void notify(Object o) {
            foreach (IObserver observer in observers) {
                observer.update(this, o);
            }
        }

    }
}
