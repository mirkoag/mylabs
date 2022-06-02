using System;
using System.Collections.Generic;
using System.Text;

namespace zadanije
{
    class Num
    {
        
        public Num(int W, int H, int Wa, int T) {
            Workers = W;
            NormOfHours = H;
            Wage = Wa;
            Tax = T;
        }
        private int NormOfHours;
        public void HoursUp(int d)
        {
            NormOfHours += d;
            Result();
        }
        public void HoursDown(int d)
        {
            NormOfHours -= d;
            Result();
        }

        public int CurrentHours
        {
            get
            {
                return NormOfHours;
            }
        }

        private int Workers;
        public void WorkersUp(int d)
        {
            Workers += d;
            Result();
        }
        public void WorkersDown(int d)
        {
            Workers -= d;
            Result();
        }

        public int CurrentWorkers {
            get {
                return Workers;
            }
        }

        

        private int Wage;
        public int MethWage(int d)
        {
            Wage = d;
            return Wage;
        }
        public int CurrentWage
        {
            get
            {
                return Wage;
            }
        }
        private int Tax;
        public int MethTax(int d)
        {
            Tax = d;
            return Tax;
        }
        public int CurrentTax
        {
            get
            {
                return Tax;
            }
        }
        private double ResWage;
        public double CurrentResWage
        {
            get
            {
                return ResWage;
            }
        }
        public double RW
        {
            get
            {
                Result();
                
                return ResWage;
            }
        }
        private void Result() {
            double WmT = (double)(100 - Tax) / 100;
            ResWage = Wage * WmT * Workers * CurrentHours;
            
        }
    }
}
