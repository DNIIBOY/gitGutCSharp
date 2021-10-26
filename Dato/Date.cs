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

        public MinDato(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Next()
        {
            day += 1;
        }

        public string Dato_String()
        {
            return day.ToString() + "-" + month.ToString() + "-" + year.ToString();
        }
    }
}
