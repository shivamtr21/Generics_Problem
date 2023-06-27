using GenericsAssignment;

namespace GenericsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------ UC 1----------------------
            //int result = MaximumInteger.FindMaxInt(22, 45, 60);
            //Console.WriteLine("Maximum number is:" + result);



            // -----------------------UC2-------------------------
            //float result1 = MaximumFloat.FindMaxFloat(22.4f, 44.6f, 63.6f);
            //Console.WriteLine("Maximum Float Number is: " + result1);



            // ---------------------------UC3 --------------------------

            string Result2 = MaximumString.FindMaxString("Shivam", "Divya", "Aakanksha");
            Console.WriteLine("Maximum String is:" + Result2);
        }
    }
}
