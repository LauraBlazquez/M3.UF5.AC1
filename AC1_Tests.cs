using AC1;

namespace AC1_Tests
{
    [TestClass]
    public class AC1_Tests
    {
        [TestMethod]
        public void ValidatePlayerNumbersKO()
        {
            string player = "Laur4";
            Assert.IsFalse(Program.ValidatePlayer(player));
        }

        [TestMethod]
        public void ValidatePlayerSpecialCharKO()
        {
            string player = "Laura_";
            Assert.IsFalse(Program.ValidatePlayer(player));
        }

        [TestMethod]
        public void ValidatePlayerAccentKO ()
        {
            string player = "Láura";
            Assert.IsFalse (Program.ValidatePlayer (player));
        }

        [TestMethod]
        public void ValidateMissionSeparatorKO()
        {
            string mission = "ALFA,001";
            Assert.IsFalse(Program.ValidateMission(mission));
        }

        [TestMethod]
        public void ValidateMissionNumbersKO()
        {
            string mission = "ALFA-01";
            Assert.IsFalse(Program.ValidateMission(mission));
        }

        [TestMethod]
        public void ValidateScoreMaxKO()
        {
            int score = 600;
            Assert.IsFalse(Program.ValidateScore(score));
        }

        [TestMethod]
        public void ValidateScoreMinKO()
        {
            int score = -1;
            Assert.IsFalse(Program.ValidateScore(score));
        }
    }
}