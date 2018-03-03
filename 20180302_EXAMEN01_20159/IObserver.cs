using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180302_EXAMEN01_20159 {
    interface IObserver {
        void update(BankTransaction observable, object o); 
    }
}
