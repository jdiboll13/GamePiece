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
            Random randomNumber = new Random();

            public int Move()
            {
                if (Frozen == false)
                {
                    PositionX = randomNumber.Next(0, 100);
                    PositionY = randomNumber.Next(0, 500);
                    return PositionX;
                }
                else
                {
                    return PositionX;
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
                if (Frozen == false)
                {
                    return $"{Color} {Name} is located at X:{PositionX} and Y:{PositionY}.";
                }
                else
                {
                    return "You are Frozen!";
                }


            }
            static void Main(string[] args)
            {
                var piece1 = new GamePiece();

                piece1.Color = "Red";
                piece1.Name = "Bertha";

                piece1.Move();
                Console.WriteLine(piece1);

                piece1.Freeze();

                piece1.Move();
                Console.WriteLine(piece1);

                piece1.Unfreeze();

                piece1.Move();
                Console.WriteLine(piece1);

                piece1.Move();
                Console.WriteLine(piece1);

            }
        }
    }
}
