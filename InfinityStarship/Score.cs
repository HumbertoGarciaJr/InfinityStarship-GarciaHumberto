/* Description: Score Class focusing on games scoring system and its rules accessed globally by the rest of the game, Author: Humberto Garcia */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Using namespace System.Windows.Forms allows use of Windows.Forms controls/properties

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

        //Function calculateScore to Accumulate/Collect points that are to be stored in the Scoring System.
        public static void calculateScore(PictureBox enemy, playScreenForm form)//2 parameter
        {
            //If Statement if "Enemy" is Tag of enemy(PictureBox parameter).
            if (enemy.Tag == "Enemy")
            {
                //Store compound addition of 25 value into totalScore
                totalScore += 25;
            }
        }
    }
}
