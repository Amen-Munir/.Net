namespace PowerObj
{
    public class Power
    {
        public string StationName { get; set; }
        public int Capacity { get; set; }
        public int Output { get; set; }
        public string Type { get; set; }
        public Power()
        {

        }
        public Power(string name, int cap, int outp, string typ)
        {
            StationName = name;
            Capacity = cap;
            Output = outp;
            Type = typ;
        }
    }
}