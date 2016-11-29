/******************************************************** 
 * File: Form1.cs                                       *
 * Author: Dillon Allan                                 *
 * Description: Main form file for ICA01.               *
 *******************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CMPE2800DAllanICA01
{
    public partial class Form1 : Form
    {
        // members
        Random _rng; // for random line heights
        RenderingList<CLine> _rlRedLines; // collection of the base class
        RenderingList<CColourLine> _rlGreenLines; //collection of the derived class
        
        // initialize members and position canvases in default CTOR
        public Form1()
        {
            InitializeComponent();

            // initialize members
            _rng = new Random(); 
            _rlRedLines = new RenderingList<CLine>();
            _rlGreenLines = new RenderingList<CColourLine>();
            
            // place redlines canvas above greenlines
            _rlRedLines.canvas.Position = new Point(_rlRedLines.canvas.Position.X, 
                _rlRedLines.canvas.Position.Y - _rlRedLines.canvas.m_ciHeight - 50);
        }

        // add CLines to the end, having random fill factors
        private void btn_AddRed_Click(object sender, EventArgs e)
        {
            _rlRedLines.Add(new CLine(_rng.Next(1, 21))); // fill factor between 1 - 20 inclusive
            _rlRedLines.Render();
        }

        // add CLines in order, with random fill factors
        private void btn_InsertRed_Click(object sender, EventArgs e)
        {
            _rlRedLines.Insert(new CLine(_rng.Next(1, 21))); // 1 - 20 inclusive
            _rlRedLines.Render();
        }

        // sort CLines by fill factor, ascending
        private void btn_SortRed_Click(object sender, EventArgs e)
        {
            _rlRedLines.Sort(); 
            _rlRedLines.Render();
        }

        // add CColourLines to the end, having random greens and fill factors
        private void btn_AddColour_Click(object sender, EventArgs e)
        {
            // random fill factors of 1 - 20, inclusive, and random shades of green (50+ because it gets too dark to see)
            _rlGreenLines.Add(new CColourLine(_rng.Next(1, 21), _rng.Next(50, 256)));
            _rlGreenLines.Render();
        }

        // add CColourLines in order of color and fill factor, ascending
        private void btn_InsertCColour_Click(object sender, EventArgs e)
        {
            // random fill factors (1 - 20, inclusive,) and random shades of green (50+ because it gets too dark to see)
            _rlGreenLines.Insert(new CColourLine(_rng.Next(1, 21), _rng.Next(50, 256)));
            _rlGreenLines.Render();
        }

        // sort CColourLines in order of color and fill factor, ascending
        private void btn_SortCColour_Click(object sender, EventArgs e)
        {
            _rlGreenLines.Sort();
            _rlGreenLines.Render();
        }
    }
}
