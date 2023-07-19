using System.Globalization;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace RockPaperScissors
{
    public static class Input
    {
        public static GameType GetGameTypeCorrectly()
        {
            Console.WriteLine("Выберите тип игры: ");
            Console.WriteLine("-> bot");
            Console.WriteLine("-> 1vs1");
            string[] choise = { "bot", "1vs1" };
            string input = " ";
            Label:
            input = Console.ReadLine();
            if (!choise.Contains(input))
            {
                Console.WriteLine("Такой режим игры еще не добавили");
                Console.WriteLine("Выберите тип игры: ");
                Console.WriteLine("-> bot");
                Console.WriteLine("-> 1vs1");
                goto Label;
            }
            return input == "bot" ? GameType.BotToPlayer : GameType.PlayerToPlayer;
        }
        public static Choise GetChoiseCorrectly()
        {
            Console.WriteLine("Выберите предмет (камень , ножницы, бумага): ");
            string[] choiseObject = { "камень", "ножницы", "бумага" };
            string secondInput = " ";
            Label:
            secondInput = Console.ReadLine();
            if (!choiseObject.Contains(secondInput))
            {
                Console.WriteLine("Такого предмета нет в игре!");
                Console.WriteLine("Выберите предмет (камень , ножницы, бумага): ");
                goto Label;
            }
            return secondInput == "камень" ? Choise.rock
                : secondInput == "бумага" ? Choise.paper
                : Choise.scissors;
        }
    }
}