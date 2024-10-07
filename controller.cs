using BussinessLogic;
using DataAccessLayer;
using PowerObj;
using PresntationLayer;
namespace N_tier
{
    public class controller
    {
        public static void Main(string[] args)
        {
            List<Power> obj1 = new List<Power>();
            DataLayer dl = new DataLayer();
            BLogic bLogic = new BLogic();
            presnetationLayer presnetationLayer = new presnetationLayer();
            int num=0;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Enter new power station");
                Console.WriteLine("2. View Power stations");
                Console.WriteLine("3. Show power stations having output less that 50%");
                Console.WriteLine("4.Exit ");
                
                num=Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    try
                    {
                        dl.InsertData();
                    }
                    catch (Exception e) { Console.WriteLine("Error"); }
                }
                if (num == 2)
                {
                    try
                    {
                        Console.WriteLine("Reading data from data base...");
                        obj1 = dl.readData();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                    try
                    {
                        Console.WriteLine("\nCALLING PRESNETATION LAYER FUNCTION TO DISPLAY DATA");
                        presnetationLayer.Display(obj1);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
                if (num == 3)
                {
                    Console.WriteLine("\nQuestion-02- Calculating and returning data with  percentages less than 50% output");
                    try
                    {
                        obj1 = bLogic.CalculatePerc();
                        bLogic.LessPercData(obj1);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }

                }
                if (num == 4)
                {
                    break;
                }
            }
            while (num != 4);




            
           



            


            





        }


    }
}