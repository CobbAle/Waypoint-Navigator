using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaypointNavigator.Classes
{
    internal class aStarPath
    {
        private int previousX,previousY,currentX,currentY;
        private double distanceStrightLine;
        private int countX,countY;
        private double[,] waypointGraph;

        //Get distance between each node

        //G is the distance between current node and the start node
        //H is the heuristic, estimated distance from current node to end node
        //F is the total cost of the node (G + H = F)

        //Look for the lowest F cost square on the open list
        //Switch it to the closed list
        //For each of the 8 squares accessible, if its not on a list add it to the open list
        // -- Make the current square the parent of this square, record the F,G,H of the square
        // If its on the open list already, check to see if this path to that square is better using G cost. A lower G cost means that this is a better path.
        // 

        public aStarPath(List<WayPoint> waypoints)
        {
            int changeX, changeY;

            foreach (WayPoint waypointA in waypoints)
            {
                

                foreach  (WayPoint waypointB in waypoints)
                {
                    changeX = waypointA.X - waypointB.X;
                    changeY = waypointA.Y - waypointB.Y;
                    distanceStrightLine = Math.Sqrt(changeY * changeY + changeX * changeX);


                    waypointGraph[countX, countY] = distanceStrightLine;
                    countY++;
                }

                countX++;
            }

        }
        
    }
}

