using System;

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

            public int MoveRight()
            {
                if (Frozen == false)
                {
                    PositionX++;
                    return PositionX;
                }
                else
                {
                    return PositionX;
                }
            }
            public int MoveLeft()
            {
                if (Frozen == false)
                {
                    PositionX--;
                    return PositionX;
                }
                else
                {
                    return PositionX;
                }
            }
            public int MoveUp()
            {
                if (Frozen == false)
                {
                    PositionY++;
                    return PositionY;
                }
                else
                {
                    return PositionY;
                }
            }
            public int MoveDown()
            {
                if (Frozen == false)
                {
                    PositionY--;
                    return PositionY;
                }
                else
                {
                    return PositionY;
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
            public override string ToString()
            {
                return $"{Color} {Name} is located at X:{PositionX} and Y:{PositionY} and frozen is {Frozen}.";
            }

        }
        static void Main(string[] args)
        {
            var piece1 = new GamePiece();

            piece1.Color = "Red";
            piece1.Name = "Bertha";

            piece1.MoveRight();
            Console.WriteLine(piece1);

            piece1.Freeze();
            Console.WriteLine(piece1);

            piece1.MoveUp();
            Console.WriteLine(piece1);

            piece1.Unfreeze();
            Console.WriteLine(piece1);

            piece1.MoveLeft();
            Console.WriteLine(piece1);

            piece1.MoveDown();
            Console.WriteLine(piece1);

        }
    }
}
