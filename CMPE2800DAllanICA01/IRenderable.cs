/************************************************************ 
 * File: Interfaces.cs                                      *
 * Author: Dillon Allan                                     *
 * Description: File containing the IRenderable interface.  *
 ***********************************************************/
using GDIDrawer;
using System.Drawing;

namespace CMPE2800DAllanICA01
{
    interface IRenderable
    {
        // method for rendering
        void Render(CDrawer dr, Rectangle rect);
    }
}
