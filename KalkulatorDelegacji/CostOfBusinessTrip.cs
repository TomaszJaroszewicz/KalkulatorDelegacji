using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//here you can modify cost of foreign business trip
namespace KalkulatorDelegacji
{
    class CostOfBusinessTrip
    {
        public double inPoland { get; }
        public double inItaly { get; }
        public double inLithuena { get; }
        public double Breakfast { get; }
        public double Dinner { get; }
        public double Supper { get; }

        public CostOfBusinessTrip()
        {
            inPoland = 30;//zł
            inItaly = 48;//euro
            inLithuena = 39;//euro
            Breakfast = 0.25;//-25%
            Dinner = 0.5;//-50%
            Supper = 0.25;//-25%
        }

        
    }
}
