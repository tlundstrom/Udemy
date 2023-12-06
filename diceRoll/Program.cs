namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random rnd =new Random();
            var dice = new Dice(rnd);
            var game = new Game(dice);

            game.Play();
        }
        public class Game
        {
            private readonly Dice _dice;
            private const int InitialTries = 3;

            public Game(Dice dice)
            {
                _dice = dice;
            }

            public void Play()
            {
                var diceRollResult = _dice.Roll();
                Console.WriteLine($"Dice rolled/ Guess what number it shows in {InitialTries} tries.");

                var triesLeft = InitialTries;
                while (triesLeft > 0)
                {
                    var guess = ReadInteger("Enter a number:");
                    --triesLeft;
                }
            }

            private int ReadInteger(string message)
            {
                int result;
                do
                {
                    Console.WriteLine(message);
                }
                while (!int.TryParse(Console.ReadLine(), out result));
                return result;
            }
        }
        public class Dice
        {
            private readonly Random _random;
            private const int SidesCount = 6;

            public Dice(Random random)
            {
                _random = random;
            }

            public int Roll()
            {
                return _random.Next(1, SidesCount + 1);
            }

            public void Describe() => Console.WriteLine($"this is a dice with {SidesCount} sides.");

        }
    }

}




