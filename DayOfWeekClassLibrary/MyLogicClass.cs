﻿using System;
using System.Collections.Generic;

namespace DayOfWeekClassLibrary
{
    public class MyLogicClass
    {
        private List<DateexClass>  ExclusionDates;
        //constructor 
        public  MyLogicClass (List<DateexClass> exclusiondates) 
        { 
            this.ExclusionDates = exclusiondates;

        }
        public Boolean DayCalc(DateTime indata)
        {
  //проверяем исключения
  Boolean BoolResult;
                for (int i =0 ;i<3;i++)
                { if (this.ExclusionDates[i].dayexcl==Dt)
                    {
                        if (this.ExclusionDates[i].flag)
                            BoolResult =this.ExclusionDates[i].flag;
                         else BoolResult=BoolResult&&this.ExclusionDates[i].flag;
                    }
                }            
DayOfWeek x = indata.DayOfWeek;
            if ((x == DayOfWeek.Sunday) || (x == DayOfWeek.Saturday))
            { return false; }
            else { return true; }
        }
    }
    public class DateexClass
    {
       public  DateTime dayexcl;
        public Boolean flag;
    }
   
}
