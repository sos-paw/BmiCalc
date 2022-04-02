using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczenieSosnowski
{
    class Sprawdzaniejednostek
    {
        public List<string> Jednostkiwzrost { get; private set; }
        public List<string> Jednostkiwaga { get; private set; }
        public Sprawdzaniejednostek()
        {
            Jednostkiwzrost = new List<string>
            {
                "centymetry",
                "metry"
            };


            Jednostkiwaga = new List<string>
            {
                "kg",
                "gramy"
            };
        }

        

     

        public float Przeliczwzrost(string jakajednostka,float licz)
        {
            
           
            switch (jakajednostka)
            {
                case "centymetry":
                    {
                        licz = (float)(licz * 0.01);
                        break;
                    }
                case "metry":
                    {
                        licz *= 1;
                        break;
                    }
                
            }
            return licz;
        }

        //spr.przeliczwzrost(jakajednostka, float.Parse(poleWzrost.Text))

        public float Przeliczwaga(string jakajednostka, float licz)
        {


            switch (jakajednostka)
            {
                case "kg":
                    {
                        licz *= 1;
                        break;
                    }
                case "gramy":
                    {
                        licz = (float)(licz * 0.001);
                        break;
                    }
            }
            return licz;
        }

    }
}
