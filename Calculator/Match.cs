using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Calculator
{
   public  class Match : INotifyPropertyChanged
    {
        private int[] table = new int[10];
        private int conter;
        private int returValue;
        public int ReturValue { get { return returValue; } 
            set {
                returValue = value;
                table[conter] = value;
                conter++;
                PropertyChanged(this, new PropertyChangedEventArgs("ReturValue"));
            }
        }

        public Match()
        {
            conter = 0;
            returValue = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

       public void add()
        {
            returValue = table[0] + table[1];
            conter = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("ReturValue"));
        }
    }
}
