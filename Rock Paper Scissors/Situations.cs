namespace RockPaperScissors
{
    public static class Situations
    {
        public static readonly Tuple<Choise, Choise>[] Win = {
                new Tuple<Choise, Choise>(Choise.rock, Choise.scissors),
                new Tuple<Choise, Choise>(Choise.scissors, Choise.paper),
                new Tuple<Choise, Choise>(Choise.paper, Choise.rock),
            };
        public static readonly  Tuple<Choise, Choise>[] Lose = {
                new Tuple<Choise, Choise>(Choise.scissors, Choise.rock),
                new Tuple<Choise, Choise>(Choise.paper, Choise.scissors),
                new Tuple<Choise, Choise>(Choise.rock, Choise.paper),
            };
        public static readonly Tuple<Choise, Choise>[] Draw = {
                new Tuple<Choise, Choise>(Choise.rock, Choise.rock),
                new Tuple<Choise, Choise>(Choise.scissors, Choise.scissors),
                new Tuple<Choise, Choise>(Choise.paper, Choise.paper),
            };
    }
}