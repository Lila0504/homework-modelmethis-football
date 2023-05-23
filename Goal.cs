using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Model_me_this___Football
{
    public class Goal
    {
        public int Minute { get; set; }
        public IPlayer Player { get; set; }

        public Goal(int minute, IPlayer player) 
        {
            Minute = minute;
            Player = player;
        }
    }
}
