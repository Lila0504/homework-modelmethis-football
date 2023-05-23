using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Model_me_this___Football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<IPerson> AssistantReferees { get; set;}
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee, List<IPerson> assistantReferees ) 
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees = assistantReferees;
            Goals = new List<Goal>();

        }

            public void SimulateGame()
        {
            //Game logic simulate
            //Randomly generate goals, calculate result, and determine winner
            
            //Simulate goals
            Random random = new Random();
            int totalGoals = random.Next(0, 8); //Randomly generate a number of goals (0 to 7)
            List<IPlayer> allPlayers = Team1.Players.Concat(Team2.Players).ToList();
            
            for (int i = 0; i < totalGoals; i++) 
            {
                int minute = random.Next(1, 91); //Randomly generate a minute (1 to 90)
                IPlayer scorer = allPlayers[random.Next(allPlayers.Count)];
                Goals.Add(new Goal(minute, scorer));
            }
            //Calculate result
            int team1Goals = Goals.Count(goal => goal.Player is IPlayer && Team1.Players.Contains(goal.Player));
            int team2Goals = Goals.Count(goal => goal.Player is IPlayer && Team2.Players.Contains(goal.Player));
            Result = $"{team1Goals} - {team2Goals}";

            //Determine the winner
            if (team1Goals > team2Goals)
            {
                Winner = Team1;
            }
            else if (team2Goals > team1Goals)
            {
                Winner = Team2;
            }
            else
            {
                Winner = null; //Draw
            }
        }
    }
}
