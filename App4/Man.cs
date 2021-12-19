using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Man
    {
        string name;
        int bithdayDate;
        string city;

        int BithdayDate
        {
            get
            {
                return bithdayDate;
            }
            set
            {
                if (value > 2021)
                    bithdayDate = 2021;
                else if (value<1900)
                    bithdayDate = 1900;
                else
                    bithdayDate = value;
            }
        }

        public Man(string name, int bithdayDate, string city)
        {
            this.name = name;
            this.BithdayDate = bithdayDate;
            this.city = city;
        }
        public string Print()
        {
            return $"{name} {bithdayDate} {city}";
        }
    }
}
