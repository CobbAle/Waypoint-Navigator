using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Documents;

namespace WaypointNavigator
{
    public class WayPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color PinColor { get; set; }
        public int PinWidth { get; set; }
        public int PinHeight { get; set; }
        public int distanceFromStart;
        public int distanceFromEnd;
        public int totalDistance;

        
        public WayPoint(int x, int y)
        {
            X = x;
            Y = y; //takes the x and y of the click location on the graph
            PinColor = Color.Red; //sets the colour of the pin to be made (in this case red)
            PinWidth = 20; //sets pin width (x)
            PinHeight = 30; //sets pin height (y)
        }

        public WayPoint(int x, int y, Color color)
        {
            X = x;
            Y = y;
            PinColor = color; //does the same as previous constructor, but allows for a custom colour
            PinWidth = 20;
            PinHeight = 30;
        }

        public void Draw(Graphics g, bool isHighlighted = false)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color drawColor = isHighlighted ? Color.Yellow : PinColor; //if the selected pin is highlighted, sets the colour to yellow

            // Draw the pin head (circle) 
            using (Pen pinPen = new Pen(drawColor, 4))
            {
                g.DrawEllipse(pinPen, X - PinWidth / 2, Y - PinHeight, PinWidth, PinWidth); //using the graphics (g) it draws a pin at the given X,Y with the pin height
                // Has X - Pindwidth and Y - Pinheight so that the pin is drawn correctly and actually points to the x,y
            }

            // Draw the pin point (triangle)
            using (Pen pinPen = new Pen(drawColor, 4))
            {
                Point[] pinPoint = new Point[]
                {
                    new Point(X - 6, Y - PinHeight + PinWidth),
                    new Point(X + 6, Y - PinHeight + PinWidth),
                    new Point(X, Y)
                };

                g.DrawPolygon(pinPen, pinPoint); //Uses a graphics feature called "DrawPolygon" and then draws it with the pinpoint declared previously and the pinPen being the colour
            }
        }
    }
}
