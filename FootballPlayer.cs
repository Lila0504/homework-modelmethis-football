using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Model_me_this___Football
{
    public class FootballPlayer : Person, IPlayer
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public FootballPlayer(string name, int age, int number, double height)
            :base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
