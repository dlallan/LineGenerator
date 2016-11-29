using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CMPE2800DAllanICA01
{
    // base class for red lines
    class CLine : IComparable, IRenderable
    {
        float _fFillRatio; // ratio for setting line's color height

        // default CTOR - initialize the fill ratio
        public CLine(int factor)
        {
            _fFillRatio = (float)factor / 20;
        }

        // custom CompareTo to sort CLine objects by ascending order of fill ratio
        public virtual int CompareTo(object obj)
        {
            if (!(obj is CLine)) // type check
                throw new InvalidOperationException("obj is not a CLine!");
            CLine arg = (CLine)obj;
            return _fFillRatio.CompareTo(arg._fFillRatio);
        }

        // returns effective height of rectangle color
        internal int getFillHeight(int rectHeight)
        {
            return (int)(rectHeight * _fFillRatio);
        }

        // leverage subordinate fct to draw rectangle in red
        public void Render(CDrawer cr, Rectangle rect)
        {
            SubRender(cr, rect, Color.Red);
        }

        // render as vertical bar in drawer
        protected void SubRender(CDrawer cr, Rectangle rect, Color col)
        {
            int iFillHeight = getFillHeight(rect.Height); // set color height
            // draw rectangles on the bottom of the canvas
            cr.AddRectangle(rect.X, rect.Y + (cr.m_ciHeight - iFillHeight),
                rect.Width, iFillHeight, col, 1, Color.Black);
        }
    }
}
