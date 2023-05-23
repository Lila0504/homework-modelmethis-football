using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Model_me_this___Football
{
    public class Referee : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Referee(string name, int age) 
        {
            Name = name;
            Age = age;
        }
    }
}
