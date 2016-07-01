using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    //Implement IPlayer
    class StubbornAI : IPlayer
    {
        //Make a constructor that takes one parameter: favoriteMove
        int FavoriteMove;
        public StubbornAI(int favoriteMove)
        {
            FavoriteMove = favoriteMove;
        }
        ////NextMove() always plays favoriteMove
        public int NextMove()
        {
            return FavoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {

        }
    }
}

