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
        private int returnValue;
        private string equal;
        public string Equal
        {
            get { return equal; }
            set { 
                equal = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Equal")); // co zmieniło i nazwa musi być taka sama ja patch
            }
        }
       
        public int ReturnValue { get { return returnValue; } 
            set {
                if(conter == 9) { conter = 0; }
                returnValue = value;
                table[conter] = value;
                conter++;
                Equal += value.ToString();


                
                PropertyChanged(this, new PropertyChangedEventArgs("ReturnValue"));
            }
        }

        public Match()
        {
            conter = 0;
            returnValue = 0;
            equal = "";
        }

        public event PropertyChangedEventHandler PropertyChanged;

       public void add()
        {
            Equal += "+";
            returnValue = table[0] + table[1];
            conter = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("Equal"));
            PropertyChanged(this, new PropertyChangedEventArgs("ReturnValue"));
        }
    }
}
