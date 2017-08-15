﻿using System;

namespace GamePiece
{
    class Program
    {
        public class GamePiece
        {
            public int PositionX { get; set; } = 0;
            public int PositionY { get; set; } = 0;
            public bool Frozen { get; set; } = false;
            public string Color { get; set; }
            public string Name { get; set; }

            public int Move(int posx, int posy)
            {
                if (Frozen == false)
                {
                    PositionX++;
                    PositionY++;
                }

            
            }
            public Boolean Freeze()
            {
                Frozen = true;
                return Frozen;
            }
            public Boolean Unfreeze()
            {
                Frozen = false;
                return Frozen;
            }

        }
        static void Main(string[] args)
        {
            var piece1 = new GamePiece();

            piece1.Color = "Red";
            piece1.Name = "Bertha";

            piece1.Freeze();
            Console.WriteLine($"{piece1.Color} {piece1.Name} is frozen.");

            piece1.Unfreeze();
            Console.WriteLine($"{piece1.Color} {piece1.Name} is frozen.");

        }
    }
}