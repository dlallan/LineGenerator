using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CMPE2800DAllanICA01
{
    // derived class for green lines.
    // N.B. derived class MUST support IRenderable to force the compiler
    // to be aware of its new Render method below...
    class CColourLine : CLine, IRenderable
    {
        Color _cColor; // line color

        // default CTOR that passes on iFactor arg to parent CTOR
        public CColourLine(int iFactor, int green) : base(iFactor)
        {
            _cColor = Color.FromArgb(0, green, 0);
        }

        // sort by color in fill ratio
        public override int CompareTo(object obj)
        {
            if (!(obj is CColourLine)) // type check
                throw new InvalidOperationException("obj is not a CColourLine!");
            CColourLine arg = (CColourLine)obj;

            // check if fill ratio is the same
            if (base.CompareTo(obj) == 0)
                return this._cColor.G.CompareTo(arg._cColor.G); // color (green) sort
            // fill ratio is different -- sort by height
            return base.CompareTo(obj);
        }

        // leverage sub render to draw green rectangle
        public new void Render(CDrawer cr, Rectangle rect)
        {
            SubRender(cr, rect, _cColor);
        }
    }
}
