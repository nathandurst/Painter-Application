/*********************************************************
 * Nathan Durst
 * November 3, 2016
 * CPL - Program 6
 * *******************************************************
 * This form application utilizes a panel, groupboxes, and
 * radiobuttons to allow the user to draw on
 * the panel with a variety of colors and brush sizes
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_6___Painter
{
    public partial class painterForm : Form
    {
        //VARIABLES
        bool shouldPaint = false;
        SolidBrush color = new SolidBrush(Color.Black);
        int width = 5, height = 5;
        int size = 5;
        ColorDialog dialog = new ColorDialog();

        public painterForm()
        {
            InitializeComponent();
        }

        //Sets the boolean variable to false when the mouse button
        // is not being pressed, so the user can move without drawing
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        //Sets the boolean variable to true so when the mouse button
        // is moved, the user can draw on the panel
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        //When the mouse moves, it determines if it should draw as it moves
        // or not by the use of the mouse down and mouse up handlers
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //setBrush();
            if (shouldPaint)
            {
                //leaves a trail behind on the canvas
                Graphics graphics = canvas.CreateGraphics();
                graphics.FillEllipse(color, e.X, e.Y, width, height);
                graphics.Dispose();
            }
        }

        //if any radio button is pressed, this handler is called
        // it sets the color and the size of the marker
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            //COLORS
            customButton.BackColor = Color.LightGray;
            if (blackRadButton.Checked == true)
                color = new SolidBrush(Color.Black);
            else if (redRadButton.Checked == true)
                color = new SolidBrush(Color.Red);
            else if (greenRadButton.Checked == true)
                color = new SolidBrush(Color.Green);
            else if (blueRadButton.Checked == true)
                color = new SolidBrush(Color.Blue);
            else if (whiteRadButton.Checked == true)
                color = new SolidBrush(Color.White);
            else
                color = new SolidBrush(dialog.Color);
            
            //SIZE
            if (smallRadButton.Checked == true)
                size = 5;
            else if (mediumRadButton.Checked == true)
                size = 15;
            else if (largeRadButton.Checked == true)
                size = 25;

            width = size;
            height = size;
        }

        //THis is the clear button and it resets the entire canvas
        // when pressed
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = canvas.CreateGraphics();
            graphics.Clear(canvas.BackColor);
        }

        //This displays a dialog box so the user can select other colors
        // that may not be present options on the form
        private void customButton_Click(object sender, EventArgs e)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                color = new SolidBrush(dialog.Color);
            //uncheck all radiobuttons that hve to do with color
            whiteRadButton.Checked = false; redRadButton.Checked = false;
            blackRadButton.Checked = false; blueRadButton.Checked = false;
            greenRadButton.Checked = false;
            customButton.BackColor = dialog.Color;
        }
    }
}
