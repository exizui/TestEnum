using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2024
{
    public class KeyController
    {
        public static ConsoleKey[] keys = new ConsoleKey[5];
        public enum DirectMovement
        {
            Upward, Forward, Backward, Rightward, Leftward
        }
        public KeyController()
        {
            keys[0] = ConsoleKey.Spacebar;
            keys[1] = ConsoleKey.W;
            keys[2] = ConsoleKey.S;
            keys[3] = ConsoleKey.D;
            keys[4] = ConsoleKey.A;
        }

        public void KeyScan()
        {
            Player player = new Player();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            foreach (var key in keys)
            {
                if (keyInfo.Key == key)
                {
                    player.Move();
                    break;
                }
            }

            if (keyInfo.Key == keys[4])
                player.Jump();

            GetProperty(keyInfo);
        }

        DirectMovement directUp = (DirectMovement)0;
        DirectMovement directW = (DirectMovement)1;
        DirectMovement directS = (DirectMovement)2;
        DirectMovement directD = (DirectMovement)3;
        DirectMovement directA = (DirectMovement)4;

        
        private void GetProperty(ConsoleKeyInfo key)
        {
            Console.Write("направление движения: ");
            if (key.Key == keys[0])
            {
                Console.WriteLine(directUp);
            }
            else if (key.Key == keys[1])
            {              
                Console.WriteLine(directW);
            }
            else if(key.Key == keys[2])
            {
                Console.WriteLine(directS);
            }
            else if(key.Key == keys[3])
            {
                Console.WriteLine(directD);
            }
            else if(key.Key == keys[4])
            {
                Console.WriteLine(directA);
            }
            
         
        }

        
    }
}
