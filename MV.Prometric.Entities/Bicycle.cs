using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MV.Prometric.Entities
{
    public class Bicycle: Vehicle
    {

        public string Name 
        { get
            {
                return GetBicycleName(Noofwheels);
            }
          }

        private string GetBicycleName(int noOfWheels)
        {
            var result = String.Empty;
            switch (noOfWheels)
            {
                case 2:
                    {
                        result = "Regular";
                        break;
                    }
                case 3:
                    {
                        result = "Tricycle";
                        break;
                    }
                case 1:
                    {
                        result = "UniCycle";
                        break;
                    }
            }

            return result;
        }

        // return bicycle details
        public override string Details()
        {
            var vehicleDetails = base.Details();
            StringBuilder result = new StringBuilder("");

            result.AppendFormat("{0}                     {1}", vehicleDetails, Name);

            return result.ToString();

        }

        // override to display proper since fuel efficiency is not applicable
        public override string FuelEfficiencyText()
        {
            return "N/A";
        }
    }
}
