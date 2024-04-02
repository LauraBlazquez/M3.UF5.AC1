
namespace AC1
{
    public class Score
    {
        public string? Player { get; set; }
        public string? Mission { get; set; }
        public int Scoring { get; set; }

        public Score(string player, string mission, int scoring)
        {
            Player = player;
            Mission = mission;
            Scoring = scoring;
        }

        public override string ToString()
        {
            return $"{Player} - {Mission} - {Scoring}";
        }
    }
}
