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
        private int[] Table_of_numbers = new int[10];
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
                Table_of_numbers[conter] = value;
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
            if (Table_of_numbers[conter] != -1)
            {
                Equal += "+";
                Table_of_numbers[conter] = -1;
                conter++;
            }
            PropertyChanged(this, new PropertyChangedEventArgs("Equal"));
            PropertyChanged(this, new PropertyChangedEventArgs("ReturnValue"));
        }
        public void End()
        {
            int x = Make_Number();
            int y = Make_Number();
            

            PropertyChanged(this, new PropertyChangedEventArgs("Equal"));
        }
        private int Make_Number()
        {
            int x = 0;
            for (int i = 0; i < conter; i++)
            {
                if(Table_of_numbers[i] < 0) { break; }
                x = x * 10;
                x = x + Table_of_numbers[i];
            }
           
            return x;
        }

    }
}
