namespace OverRideText_ex
{
    class DataSummary
    {
        public virtual void printSummary(double x, double y, double z)
        {
            double m = (x + y + z)/3;
            Console.WriteLine("데이터 평균은{0}",m);
        }
    }
    class DataSummary2 : DataSummary 
    {
        public override void printSummary(double x, double y, double z)
        {
            double max = x, min = x;
            if (y>max)max = y;
            if (z>max)max = z;
            if (y<min)min = y;
            if (z<min)min = z;
            Console.WriteLine("최대값은{0}이고, 최소값은 {1}",max,min);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            DataSummary obj01 = new DataSummary();
            obj01.printSummary(3, 5, 4);
            DataSummary2 obj02 = new DataSummary2();
            obj02.printSummary(3, 5, 4);
            Console.Read();
        }
    }
}
