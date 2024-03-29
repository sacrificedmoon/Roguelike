﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class RedKey : Tiles, IInteractable
    {
        public RedKey(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'r';
        }
       
        public void PlayerInteract()
        {
            Console.SetCursorPosition(0, 11);
            Player.HasRedKey = true;
            GameEngine.roomObjectList.Remove(this);
            GameEngine.roomObjectList.Add(new Floor(Xpos, Ypos, true));
            Console.ReadKey(true);
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("Red Key");
        }
    }
}
