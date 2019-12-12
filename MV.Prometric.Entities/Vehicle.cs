using System.Text;

namespace MV.Prometric.Entities
{
    public abstract class Vehicle
    {
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual int Max { get; set; }
        public virtual int Passengers { get; set; }

        public virtual int Noofwheels { get; set; }

        public virtual int VehicleType {get;set;}

        public virtual double? FuelEfficiency {get;set;}

        // return  vehicle details in string format
        public virtual string Details()
        {
            StringBuilder result = new StringBuilder("");

            result.AppendFormat("{0}                {1}         {2}             {3}                 {4}                          {5}                      {6}",
                Make, Model,Max, Passengers,Noofwheels, FuelEfficiencyText(), FuelEfficientPerPassenger);

            return result.ToString() ;

        }

        // return fuel efficiency display text
        public virtual string FuelEfficiencyText()
        {
            return FuelEfficiency.ToString();
        }

        public virtual bool Validate()
        {
           return (VehicleType == 3 || VehicleType == 4) && Noofwheels < 4 ? false : true;
        }

        // return fuel efficiency per passanger
        public virtual double FuelEfficientPerPassenger
        {
            get
            {
                return (FuelEfficiency.HasValue && FuelEfficiency.Value>0 && Passengers >0) ? FuelEfficiency.Value / Passengers : 0d;
            }
        }

    }
}
