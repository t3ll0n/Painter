//-----------------------------------------------------------------------------------------------------
//
// Name: Tellon Smith
//
// Course: CS 4143 - Contemporary Programming Lang, Fall 16, Dr. Stringfellow
//
// Program Assignment : #6
//
// Due Date: Thursday, Nov. 3rd, 2016, 11AM
//
// Purpose: This program is an enchanced version of the painter program found in the textbook. It uses
//          radio buttons to select different colors and sizes. Users can also select custom colors
//          from a color palette and custom sizes from a dialog. The program also features an erase
//          button.
//
//-----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    public partial class PainterForm : Form
    {
        //variables
        private Color color = Color.Red; //color object with red as default
        private int brushSize = 4; //default brush size
        private CustomSizeForm customSize = new CustomSizeForm(); //instance of custom size form
        private Cursor eraseCursor = new Cursor(@"..\..\images\eraser.cur"); //erase cursor
        private Cursor paintCursor = new Cursor(@"..\..\images\paint.cur"); // paint cursor
        private bool shouldPaint = false; //controls if program should paint
        private bool shouldErase = false; //controls if program should erase

        public PainterForm()
        {
            InitializeComponent();
            color_pictureBox.BackColor = color; //set initial color for color box
            size_textBox.Text = brushSize.ToString(); //set initial size for size text box
        }

        //mouse down event
        private void paint_panel_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        //mouse up event
        private void paint_panel_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        //mouse move event
        private void paint_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            //if paint button is selected
            if (shouldPaint && !shouldErase)
            {
                using (Graphics graphics = paint_panel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(color), e.X, e.Y, brushSize, brushSize);
                }
            }
            //if erase button is selected
            else if (shouldPaint && shouldErase)
            {
                using (Graphics graphics = paint_panel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, brushSize, brushSize);
                }
            }
        }

        //click event for radio buttons in color groupbox
        private void color_radioButtons_Click(object sender, EventArgs e)
        {

            //if red
            if (colorRed_radioButton.Checked)
            {
                color = Color.Red;
            }
            //if blue
            if (colorBlue_radioButton.Checked)
            {
                color = Color.Blue;
            }
            //if green
            if (colorGreen_radioButton.Checked)
            {
                color = Color.Green;
            }
            //if black
            if (colorBlack_radioButton.Checked)
            {
                color = Color.Black;
            }
            //if custom color
            if (colorCustom_radioButton.Checked)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    color = colorDialog1.Color;
                }
            }
            //update picture box back color
            color_pictureBox.BackColor = color;
        }

        //click event for radio buttons in size groupbox
        private void size_radioButtons_Click(object sender, EventArgs e)
        {

            //if small
            if (sizeSmall_radioButton.Checked)
            {
                brushSize = 4;
            }
            //if medium
            if (sizeMedium_radioButton.Checked)
            {
                brushSize = 8;
            }
            //if large
            if (sizeLarge_radioButton.Checked)
            {
                brushSize = 16;
            }
            //if custom size
            if (sizeCustom_radioButton.Checked)
            {
                if (customSize.ShowDialog() == DialogResult.OK)
                {
                    brushSize = customSize._Size;
                }
            }
            //update size text box
            size_textBox.Text = brushSize.ToString();
        }

        //exit menu item click event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_button.PerformClick();
        }

        //custom color menu item click event
        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorCustom_radioButton.PerformClick();
        }

        //clear button click event
        private void clear_button_Click(object sender, EventArgs e)
        {
            paint_panel.Invalidate();
        }

        //clear menu item click event
        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clear_button.PerformClick();
        }

        //red menu item click event
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorRed_radioButton.PerformClick();
        }

        //blue menu item click event
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorBlue_radioButton.PerformClick();
        }

        //green menu item click event
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorGreen_radioButton.PerformClick();
        }

        //black menu item click event
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorBlack_radioButton.PerformClick();
        }

        //exit button click event
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //paint button click event
        private void paint_button_Click(object sender, EventArgs e)
        {
            paint_button.BackColor = SystemColors.ActiveCaption; //highlight paint button
            erase_button.BackColor = SystemColors.Control; //de-highlight erase button
            shouldErase = false;
        }

        //erase button click event
        private void erase_button_Click(object sender, EventArgs e)
        {
            paint_button.BackColor = SystemColors.Control; //de-highlight paint button
            erase_button.BackColor = SystemColors.ActiveCaption; //highlight erase button
            shouldErase = true;
        }

        //panel mouse hover event 
        private void paint_panel_MouseHover(object sender, EventArgs e)
        {
            //if paint button is clicked
            if (!shouldErase)
            {
                this.Cursor = paintCursor; //change cursor to paint icon
            }
            //if erase button is clicked
            else
            {
                this.Cursor = eraseCursor; //change cursor to erase icon
            }
        }

        //mouse leave  event
        private void paint_panel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default; //change cursor to default
        }

        //small menu item click event
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeSmall_radioButton.PerformClick();
        }

        //medium menu item click event
        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeMedium_radioButton.PerformClick();
        }

        //large menu item click event
        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeLarge_radioButton.PerformClick();
        }

        //custom size menu item click event
        private void customToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sizeCustom_radioButton.PerformClick();
        }
    }
}
