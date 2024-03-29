﻿namespace AdventCalendarC_.daytwo {
    public class Game(int gameIndex) {

        private int maxNumberOfGreenNeeded;
        private int maxNumberOfBlueNeeded;
        private int maxNumberOfRedNeeded;
        private readonly int gameIndex = gameIndex;

        public bool CanGameBePlayedWithFollowingBalls(int allowedGreen, int allowedBlue, int allowedRed) { 
            return MaxNumberOfGreenNeeded <= allowedGreen && MaxNumberOfBlueNeeded <= allowedBlue && MaxNumberOfRedNeeded <= allowedRed;
        }

        public void MaxNumberOfBall(Round currentCound, string color) {
            if (color.Equals("blue")) {
                if (MaxNumberOfBlueNeeded < currentCound.NumberOfBlue) {
                    MaxNumberOfBlueNeeded = currentCound.NumberOfBlue;
                }
            }

            if (color.Equals("green")) {
                if (MaxNumberOfGreenNeeded < currentCound.NumberOfGreen) {
                    MaxNumberOfGreenNeeded = currentCound.NumberOfGreen;
                }
            }

            if (color.Equals("red")) {
                if (MaxNumberOfRedNeeded < currentCound.NumberOfRed) {
                    MaxNumberOfRedNeeded = currentCound.NumberOfRed;
                }
            }
        }

        public int MaxNumberOfGreenNeeded { 
            get => maxNumberOfGreenNeeded; 
            set => maxNumberOfGreenNeeded = value; 
        }

        public int MaxNumberOfBlueNeeded { 
            get => maxNumberOfBlueNeeded; 
            set => maxNumberOfBlueNeeded = value; 
        }

        public int MaxNumberOfRedNeeded { 
            get => maxNumberOfRedNeeded; 
            set => maxNumberOfRedNeeded = value; 
        }

        public int GameIndex => gameIndex;
    }
}
