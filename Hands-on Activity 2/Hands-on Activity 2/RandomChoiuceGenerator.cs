using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on_Activity_2
{
    public class RandomChoiceGenerator
    {
        public string GetChoice()
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();
            int choiceIndex = random.Next(choices.Length);
            return choices[choiceIndex];
        }
    }
}
