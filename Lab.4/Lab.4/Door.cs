﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Door : Tiles, IInteractable
    {
        public bool isOpen { get; private set; } = false;
        public Door(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'D';
        }
         
        public void PlayerInteract()
        {
            if (isOpen == false && Player.HasKey)
            {
                isOpen = true;
                Player.HasKey = false;
                Console.SetCursorPosition(0, 13);
                Console.WriteLine("You unlock the door with your key");
            }
            else if (Player.HasKey == false && isOpen == false)
            {
                Console.SetCursorPosition(0, 13);
                Console.WriteLine("You need a key, look for a 'K' on the map!");
            }
            Console.ReadKey(true);
            Console.Clear();
        }
    }
        
            
        
    
}
