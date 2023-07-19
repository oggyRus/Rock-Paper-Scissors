using System;
using System.Linq;

namespace RockPaperScissors
{
    public class Game
    {
        private Random random = new Random();
        private GameType gameType;

        public void Start()
        {
            gameType = Input.GetGameTypeCorrectly();
            if (gameType == GameType.PlayerToPlayer)
            {
                PlayWithPlayer();
            }
            if (gameType == GameType.BotToPlayer)
            {
                PlayWithBot();
            }
        }

        private void PlayWithBot()
        {
            Choise botChoise = (Choise)random.Next(0, 3);
            Console.WriteLine("Выберите предмет (камень , ножницы, бумага): ");
            string input = Console.ReadLine();
            Choise playerChoise = input == "камень" ? Choise.rock
                : input == "бумага" ? Choise.paper
                : Choise.scissors;
            Tuple<Choise, Choise> result = new Tuple<Choise, Choise>(botChoise, playerChoise);
            Console.WriteLine($"Выбор бота: {botChoise}");
            GetGameResult(result);
        }

        private void PlayWithPlayer()
        {
            Choise firstPlayerChoise = Input.GetChoiseCorrectly();
            Console.Clear();
            Choise secondPlayerChoise = Input.GetChoiseCorrectly();
            Console.Clear();
            Tuple<Choise, Choise> result = new Tuple<Choise, Choise>(firstPlayerChoise, secondPlayerChoise);
            GetGameResult(result);
        }

        private void GetGameResult(Tuple<Choise, Choise> result)
        {
            if (Situations.Win.Contains(result))
            {
                if (gameType == GameType.BotToPlayer)
                    Console.WriteLine($"Победил бот!");
                if (gameType == GameType.PlayerToPlayer)
                    Console.WriteLine($"Победил первый игрок!");
            }
            if (Situations.Lose.Contains(result))
            {
                Console.WriteLine($"Победил второй игрок!");
            }
            if (Situations.Draw.Contains(result))
            {
                Console.WriteLine("Ничья!");
                if (gameType == GameType.BotToPlayer)
                    PlayWithBot();
                if (gameType == GameType.PlayerToPlayer)
                    PlayWithPlayer();
            }
        }
    }
}