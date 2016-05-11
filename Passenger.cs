using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Passenger
   
    
    {

        private string Name;
        private double Weight;

        public Passenger(string n, double w)
       
        {  

            this.Name = n;
            this.Weight = w;

        } 

        public string GetName()
       
        { 
            return Name;
        }

        public double GetWeight()
        
        { 
            return Weight;
        }

    }
}
