using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class Cell
    {
        public bool Top = false;
        public bool Right = false;
        public bool Bottom = false;
        public bool Left = false;
        public bool Visited = false;
        public int Neighbours = 0;
        public int[] Neighbour= {0,0,0,0 };
        public int pos;

        //top
        public float xtop;
        public float ytop;
        public float x2top;
        public float y2top;

        //right
        public float xright;
        public float yright;
        public float x2right;
        public float y2right;

        //bottom
        public float xbottom;
        public float ybottom;
        public float x2bottom;
        public float y2bottom;

        //left
        public float xleft;
        public float yleft;
        public float x2left;
        public float y2left;



        public Cell(/*bool Toppos, bool Rightpos, bool Bottompos, bool Leftpos, bool Visitedstatus,*/ float x1top, float y1top, float xtwotop, float ytwotop, float x1right, float y1right, float xtworight, float ytworight, float x1bottom, float y1bottom, float xtwobottom, float ytwobottom, float x1left, float y1left, float xtwoleft, float ytwoleft)
        {
            /*Top = Toppos;
            Right = Rightpos;
            Bottom = Bottompos;
            Left = Leftpos;
            Visited = Visitedstatus;
            */
            xtop = x1top;
            ytop = y1top;
            x2top = xtwotop;
            y2top = ytwotop;

            xright = x1right;
            yright = y1right;
            x2right = xtworight;
            y2right = ytworight;

            xbottom = x1bottom;
            ybottom = y1bottom;
            x2bottom = xtwobottom;
            y2bottom = ytwobottom;

            xleft = x1left;
            yleft = y1left;
            x2left = xtwoleft;
            y2left = ytwoleft;
        }
       
        public int GetNeighbours()
        {
            return Neighbours;
        }

        public string GetNeighbour()
        {
            var val = String.Join(",", Neighbour.ToArray());
            return val;
        }
    }
}
