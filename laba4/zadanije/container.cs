using System;
using System.Collections.Generic;
using System.Text;

namespace zadanije
{
    class HrDepartament
    {
        private static HrDepartament IntInstance;
        private Num IntCompany;

       
        public HrDepartament()
        {
            IntCompany = new Num(0,0,0,0);
        }
        public static HrDepartament GetInstanceCom() {
            if (IntInstance == null)
                IntInstance = new HrDepartament();
            return IntInstance;
        }
        private string nameAuto;
        public string NameAuto {
            get {
                return nameAuto;
            }
            set {
                nameAuto = value;
            }
        }
        
        public int CompanyCurrentHours {
            get {
                return IntCompany.CurrentHours;
            }
        }
        public void CompanyHoursUp(int d) {
            IntCompany.HoursUp(d);
        }
        public void CompanyHoursDown(int d) {
            IntCompany.HoursDown(d);
        }

        public int CompanyCurrentWorkers {
            get {
                return IntCompany.CurrentWorkers;
            }
        }
        public void CompanyWorkersUp(int d) {
            IntCompany.WorkersUp(d);
        }
        public void CompanyWorkersDown(int d) {
            IntCompany.WorkersDown(d);
        }
        public int CompanyCurrentWage
        {
            get
            {
                return IntCompany.CurrentWage;
            }
        }
        public int NewWage (int d)
        {
            return IntCompany.MethWage(d);
        }


        public int CompanyCurrentTax
        {
            get
            {
                return IntCompany.CurrentTax;
            }
        }
        public int NewTax(int d)
        {
            return IntCompany.MethTax(d);
        }

        public double ResWage()
        {
            return IntCompany.RW;
        }
        public double CompanyCurrentResWage
        {
            get
            {
                return IntCompany.CurrentResWage;
            }
        }
    }
}
