using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Model_me_this___Football
{
    public interface IPlayer : IPerson
    {
        int Number { get; set; }
        double Height { get; set; }
    }
}
