using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Model_me_this___Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<IPlayer> Players { get;set; }

        public double AveragePlayerAge
        {
            get
            {
                int totalAge = 0;
                foreach (IPlayer player in Players) 
                {
                    totalAge+= player.Age;
                }
                return (double)totalAge / Players.Count;
            }
        }
                public Team(Coach coach, List<IPlayer> players) 
                {
                     Coach= coach;
                    Players= players;
                }
    }
}
