﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2024
{
    public class Player : IController
    { 
        public void Move() 
        {
            Console.WriteLine("\nДвигаюсь!");
        }
        public void Jump()
        {
            Console.WriteLine("\nПрыгаю!");
        }
    }
}
