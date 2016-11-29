using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2800DAllanICA01
{
    public partial class Form1 : Form
    {
        // members
        Random _rng;
        RenderingList<CLine> _rlRedLines;
        RenderingList<CColourLine> _rlGreenLines;

        public Form1()
        {
            InitializeComponent();

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
            // random fill factors of 1 - 20, inclusive, and random shades of green
            _rlGreenLines.Add(new CColourLine(_rng.Next(1, 21), _rng.Next(50, 256)));
            _rlGreenLines.Render();
        }

        // add CColourLines in order of color and fill factor, ascending
        private void btn_InsertCColour_Click(object sender, EventArgs e)
        {
            // random fill factors (1 - 20, inclusive,) and random shades of green
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
