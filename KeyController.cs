using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2024
{
    public class KeyController
    {
        public enum DirectMovement
        {
            Upward, Forward, Backward, Rightward, Leftward
        }

        public enum KeyMove
        {
            A = 65,
            D = 68,
            S = 83,
            W = 87,
            Space = 32
        }

        DirectMovement directUp = (DirectMovement)0;
        DirectMovement directW = (DirectMovement)1;
        DirectMovement directS = (DirectMovement)2;
        DirectMovement directD = (DirectMovement)3;
        DirectMovement directA = (DirectMovement)4;

        
        public void GetProperty(Player player)
        {           
            KeyMove keyMove = (KeyMove)Console.ReadKey().Key;

            foreach (KeyMove move in Enum.GetValues(typeof(KeyMove)))
            {
                //Console.WriteLine($"Енум: {move}, Значення: {(int)move}");
                if(keyMove == move)
                {
                    player.Move();
                   if (keyMove == KeyMove.Space) { player.Jump(); }
                }
               
            }
            Console.Write("DirectMovement:");
            switch (keyMove)
            {
                case KeyMove.W:
                    Console.WriteLine(directW);
                    break;
                case KeyMove.A:
                    Console.WriteLine(directA);
                    break;
                case KeyMove.S:
                    Console.WriteLine(directS);
                    break;
                case KeyMove.D:
                    Console.WriteLine(directD);
                    break;
                case KeyMove.Space:
                    Console.WriteLine(directUp);
                   // player.Jump();
                    break;
                default:
                    Console.WriteLine("Wrong Key!");
                    break;
            }
        }
    }
}
