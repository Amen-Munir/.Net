using DataAccessLayer;
using PowerObj;

namespace BussinessLogic
{
    public class BLogic
    {
        public List<Power> CalculatePerc()
        {
            List<Power> result = new List<Power>();
            List<Power> temp = new List<Power>();
            DataLayer obj = new DataLayer();
            temp = obj.readData();
            try {
                foreach (Power power in temp)
                {
                    int calOut = Convert.ToInt32(power.Capacity * 0.5);
                    if (power.Output < calOut)
                    {
                        result.Add(power);

                    }
                    else
                    {
                        continue;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
           
             


            

            return result;
        }

        public void LessPercData(List<Power> obj1)
        {
            try
            {
                if (obj1.Count > 0)
                {

                    Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-40} ", "Station Name", "Total Capacity", "Output", "Type");

                    foreach (Power obj in obj1)
                    {
                        Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-40}", obj.StationName, obj.Capacity, obj.Output, obj.Type);
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
          }
    }
}