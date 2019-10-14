﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Key : Tiles, IInteractable
    {
        public Key(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'K';
        }
        public override void PrintCharToMap()
        {
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.Write("K");
         Console.ResetColor(); 
        }

        public void PlayerInteract()
        {
            Player.HasKey = true;
            DungeonMap.roomObjectList.Remove(this);
            DungeonMap.roomObjectList.Add(new Floor(Xpos, Ypos));
            Console.WriteLine("You pick up a key.");
            Console.ReadKey(true);
        }
    }
}
