using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekataBowlingGame
{
    public class BowlingGame
    {
        private int Frame;
        private int Roll;
        private int Adder;
        private int RollScore;
        private int TotalScore;

        public BowlingGame() // constructor
        {
            Frame = 1;
            Roll = 1;
            Adder = 0;
            RollScore = 0;
            TotalScore = 0;
        }

        public void roll(int pins) // throw of a bowling ball
        {
            TotalScore += pins;

            if (Adder > 0)
            {
                TotalScore += pins;
                Adder--;
            }

            switch (Roll)
            {
                case 1:
                    if (Frame != 10)
                    {
                        if (pins == 10) // strike
                        {
                            Adder += 2;
                            Frame++;
                            Roll = 1;
                            RollScore = 0;
                        }
                        else
                        {
                            RollScore += pins;
                            Roll++;
                        }
                    }
                    else
                        Roll++;
                    break;
                case 2:
                    if (Frame != 10)
                    {
                        if (RollScore + pins == 10) // spare
                            Adder++;
                        Frame++;
                        Roll = 1;
                        RollScore = 0;
                    }
                    else
                        Roll++;
                    break;
                case 3:
                    for (int i = 0; i < Adder; i++)
                        TotalScore += pins;
                    break;
            }
        }

        public int score() // returns the total score
        {
            return TotalScore;
        }
    }
}
