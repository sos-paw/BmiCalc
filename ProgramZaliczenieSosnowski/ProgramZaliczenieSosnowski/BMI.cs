using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczenieSosnowski
{
    class BMI
    {
        
        public float Liczbmi(float waga,float wzrost)
        {
            float bmii;
            bmii = waga / (wzrost*wzrost);
            return bmii;
        }
        
        public string Katogkategoryzuj(float bmi)
        {

            if (bmi < 16.0)
                return "Jesteś wygłodzony!";
            else if (bmi >= 16 && bmi < 17)
                return "Jesteś wychudzony!";
            else if (bmi >= 17 && bmi < 18.5)
                return "Masz niedowagę!";
            else if (bmi >= 18.5 && bmi < 25)
                return "Mieścisz się w normie!";
            else if (bmi >= 25 && bmi < 30)
                return "Masz nadwagę";
            else if (bmi >= 30 && bmi < 35)
                return "Masz I stopień otyłości";
            else if (bmi >= 35 && bmi < 40)
                return "Masz II stopień otyłości(otyłość kliniczna)";
            else 
                return "Masz III stopień otyłości(otyłość skrajna)";
            
        }

    }

}
