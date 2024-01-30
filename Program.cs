
namespace Test2024
{
    class Program
    {      
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Tap WASD or Spacebar");
                KeyController keycontroller = new KeyController();
                Player player = new Player();
                keycontroller.GetProperty(player);
            }
           
        }    
    }

}