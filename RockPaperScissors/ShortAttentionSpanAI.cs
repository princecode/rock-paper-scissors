using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
       
        public int NextMove()
        {
            return playersPreviousMove;
        }
        int playersPreviousMove;
        public void SaveResult(int myMove, int otherMove)
        {
            playersPreviousMove = myMove;     
                        
        }
    }


   
    }

