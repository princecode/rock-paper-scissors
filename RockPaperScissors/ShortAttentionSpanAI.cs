using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {

        int opponentMove;
        Random aiRandom = new Random();

        public int NextMove()
        {


            int aiMove;

            if (opponentMove == 0)
            {
                aiMove = 1;
            }
            else if (opponentMove == 1)
            {
                aiMove = 2;
            }
            else if (opponentMove == 2)
            {
                aiMove = 0;
            }
            else
            {
                aiMove = aiRandom.Next(0, 3); ;
            }

            return aiMove;


        }


        
        public void SaveResult(int myMove, int otherMove)
        {
            opponentMove = otherMove;              
                        
        }
    }


   
    }

