using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Elevator
   
    
    
    
    {
      
        private double MaxWeight;
        private Passenger [] Occupants; 

        public Elevator (int maxOccupants, double maxWeight)
        { 

            this.MaxWeight = maxWeight;
            this.Occupants = new Passenger [maxOccupants]; 
        }

      
        
        public void AddOccupants(Passenger passenger, int index)
        {
            this.Occupants [index] = passenger;
        }

       
        
        
        public double GetCurrentWeight()
       
        {
            double CurrentWeight = 0;

            for (int index = 0; index < Occupants.Length; index++)
           
            {
               
                CurrentWeight += this.Occupants [index].GetWeight();
           
            }
         
            return CurrentWeight;
       
        
        }

        public bool IsOverMaxCapacity()
       
        {
           
            return this.GetCurrentWeight() > this.MaxWeight;
       
        }
    }
}
