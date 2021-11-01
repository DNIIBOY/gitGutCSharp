using System;
using System.Collections.Generic;
using System.Text;

namespace Dato
{
    class MinDato
    {
        public int day;
        public int month;
        public int year;
        
        private int[] monthLen = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        public MinDato(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Next()
        {
            day += 1;
            
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                monthLen[1] = 29;
            }
            else {
                monthLen[1] = 28;
            }
            
            if (day > monthLen[month - 1]) {
                day = 1;
                month += 1;
            }
            
            if (month > 12) {
                month = 1;
                year += 1;
            }
        }

        public void Previous()
        {
            day -= 1;
            
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                monthLen[1] = 29;
            }
            else {
                monthLen[1] = 28;
            }
            
            if (day < 1) {
                month -= 1;
                day = monthLen[month - 1];
            }
            
            if (month < 1) {
                month = 12;
                year -= 1;
            }
        }
        
        public string Dato_String()
        {
            return day.ToString() + "-" + month.ToString() + "-" + year.ToString();
        }
    }
}
