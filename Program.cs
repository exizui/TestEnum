
namespace Test2024
{
    class Program
    {      
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажми WASD или Spacebar");
                KeyController keycontroller = new KeyController();
                keycontroller.KeyScan();
            }
           
        }    
    }

}