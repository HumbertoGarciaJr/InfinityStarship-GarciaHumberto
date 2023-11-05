/* Description: Score Class focusing on games scoring system and its rules accessed globally by the rest of the game, Author: Humberto Garcia */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Project/Namespace Infinity Starship
namespace InfinityStarship
{
    //Class Score
    class Score
    {
        //Static(Global) Attribute Properties Function(Declarations)
        public static int totalScore { get; set; }
        public static int getScore { get { return totalScore; } }
        public static bool gameOver { get; set; }

        //TODO
    }
}
