using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Labyrinth
{
    class LabyrinthRunner
    {
        public Labyrinth lab;
        public int countW = 0;
        public Vector playerVector;
        public Vector currentCoord;
        public Vector exitVector;
        public Vector exitCoord;

        public LabyrinthRunner()
        {

        }

        public void Generate(string firstFlank, string secondFlank)
        {
            this.countW = firstFlank.Count(x => x == 'W') + secondFlank.Count(x => x == 'W');
            lab = new Labyrinth(this.countW);
            playerVector = new Vector(0, 1);
            currentCoord = new Vector(lab.size / 2, 0);
            RunnerGenerator(firstFlank.Substring(1));
            playerVector = exitVector;
            currentCoord = exitCoord;
            RunnerGenerator(secondFlank);
        }

        public void RunnerGenerator(string flank)
        {
            while (flank.Length > 0)
            {
                var isRotation = false;
                var reversedVector = new Vector(-playerVector.X, -playerVector.Y);
                CLoseSideByDirection(lab.arr[currentCoord.Y, currentCoord.X], reversedVector, newValue: true);

                while (flank[0] != 'W')
                {
                    isRotation = true;
                    switch (flank[0])
                    {
                        case 'R':
                            RotateCellRight(lab.arr[currentCoord.Y, currentCoord.X], playerVector);
                            playerVector.ToTheRight();
                            break;
                        case 'L':
                            RotateCellLeft(lab.arr[currentCoord.Y, currentCoord.X], playerVector);
                            playerVector.ToTheLeft();
                            break;
                    }
                    flank = flank.Substring(1);
                }

                if (!isRotation)
                {
                    RotateCellForward(lab.arr[currentCoord.Y, currentCoord.X], playerVector);
                }

                currentCoord.X = currentCoord.X + playerVector.X;
                currentCoord.Y = currentCoord.Y + playerVector.Y;

                if (flank.Length == 1)
                {
                    exitCoord = new Vector(currentCoord.X, currentCoord.Y);
                    exitVector = new Vector(-playerVector.X, -playerVector.Y);
                    break;
                }

                flank = flank.Substring(1);
            }
        }

        public string GetLabyrinthEncryption()
        {
            return lab.Encrypting_Cells();
        }

        private void RotateCellRight(Cell cell, Vector directionVector)
        {
            CLoseSideByDirection(cell, directionVector);
            RotateCellForward(cell, directionVector);
        }

        private void RotateCellLeft(Cell cell, Vector directionVector)
        {
        }

        private void RotateCellForward(Cell cell, Vector directionVector)
        {
            var bufVector = new Vector(directionVector.X, directionVector.Y);
            bufVector.ToTheLeft();
            CLoseSideByDirection(cell, bufVector);
        }

        private void CLoseSideByDirection(Cell cell, Vector directionVector, bool newValue = false)
        {
            if (directionVector.Y == 1 && directionVector.X == 0)
                cell.bottomWall = newValue;
            else if (directionVector.Y == -1 && directionVector.X == 0)
                cell.topWall = newValue;
            else if (directionVector.Y == 0 && directionVector.X == 1)
                cell.rightWall = newValue;
            else if (directionVector.Y == 0 && directionVector.X == -1)
                cell.leftWall = newValue;
        }
    }
}