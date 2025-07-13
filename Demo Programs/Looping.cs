using System.Threading.Tasks;

namespace Demo_Programs
{
    public class Looping
    {
        public string name;
        public void loopingGet() 
        { 
            Console.WriteLine("Enter Your Name :");
           name=Console.ReadLine();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
