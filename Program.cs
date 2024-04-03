
using System.Text.RegularExpressions;

namespace AC1
{
    public class Program
    {
        public static void Main()
        {
            const string PlayerMsg = "Introdueix una puntuació: (Jugador,Codi Missió,Puntuació[0-500])\n";
            const string InputError = "La puntuació inserida no es correcta. Un format correcta és el següent:\nLaura,Delta-001,200\n";
            const int numberPlayers = 10;
            bool validScore;
            List<Score> ranking = new List<Score>();

            for (int i = 0; i < numberPlayers; i++) 
            {
                do
                {
                    Console.WriteLine(PlayerMsg);
                    string? input = Console.ReadLine();
                    string[] inputParts = input.Split(',');
                    if (ValidatePlayer(inputParts[0]) && ValidateMission(inputParts[1]) && ValidateScore(int.Parse(inputParts[2])))
                    {
                        ranking.Add(new Score(inputParts[0], inputParts[1], int.Parse(inputParts[2])));
                        validScore = true;
                    }
                    else
                    {
                        validScore = false;
                        if (ValidateScore(int.Parse(inputParts[2])))
                            Console.WriteLine(InputError);
                    }
                } while (!validScore);
            }

            var sortedRanking = GenerateUniqueRanking(ranking);
            foreach (Score score in sortedRanking)
                Console.WriteLine(score);
        }

        public static bool ValidatePlayer(string player)
        {
            Regex valid = new Regex(@"[a-z]",RegexOptions.IgnoreCase);
            if (valid.IsMatch(player))
            {
                Console.WriteLine("Format de nom incorrecte, només pot contenir lletres, sense accents.\n");
                return false;
            }
            return true;
        }

        public static bool ValidateMission(string mission)
        {
            const int MinDigits = 3;
            string[] greekAlphabet = { "alfa", "beta", "gamma", "delta", "epsilon", 
                "zeta", "eta", "theta", "iota", "kappa", "lambda", "mi", "ni", "ksi", 
                "omicron", "pi", "ro", "sigma", "tau", "ipsilon", "fi", "khi", "psi", "omega" };
            mission = mission.ToLower();
            string[] inputParts = mission.Split("-");
            if (!greekAlphabet.Contains(inputParts[0]) || inputParts[1].Length != MinDigits)
            {
                Console.WriteLine("Format de nom de missió incorrecte, ha de seguir el segënt format: Delta-002.\n");
                return false;
            }
            return true;
        }

        public static bool ValidateScore(int score)
        {
            const int Min = 0, Max = 500;
            return score >= Min && score <= Max;
        }

        public static List<Score> GenerateUniqueRanking(List<Score> scores)
        {
            scores.OrderByDescending(x => x.Scoring).ToList();
            List<Score> ranking = scores;
            
            for (int i = 0; i < scores.Count; i++)
            {
                for  (int j = 1; j < ranking.Count; j++)
                {
                    if (scores[i].Player == ranking[j].Player && scores[i].Mission == ranking[j].Mission)
                    {
                        if (scores[i].Scoring > ranking[j].Scoring)
                        {
                            ranking.Remove(ranking[j]);
                            j--;
                        }
                    }
                }
            }
            return ranking.OrderByDescending(x => x.Scoring).ToList();
        }
    }
}