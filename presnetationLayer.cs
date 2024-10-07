using PowerObj;
namespace PresntationLayer
{
    public class presnetationLayer { 

        public void Display(List<Power>l1)
        {
            try
            {
                if (l1.Count > 0)
                {
                   
                    Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-40} ", "Station Name", "Total Capacity", "Output", "Type");

                    foreach (Power obj in l1)
                    {
                        Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-40}", obj.StationName, obj.Capacity, obj.Output, obj.Type);
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
