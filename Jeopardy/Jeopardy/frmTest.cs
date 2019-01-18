﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        int rows = 5;
        int columns = 6;

        private List<Button> ButtonList = new List<Button>();

        private void frmTest_Load(object sender, EventArgs e)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            pnlGameBoard.Height = formHeight -70;
            pnlGameBoard.Width = formWidth -50;
            pnlGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // rows and columns, will be passed in later
            // Just some defaults for now


            // Some default options, can change later
            int ButtonWidth = (this.Width - 220) / rows;
            int ButtonHeight = (this.Height - 50) / columns;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;


            // For each row..
            for (int x = 0; x < rows; x++)
            {
                // Create that many columns until you break out of for loop
                // Which in turn starts the next row
                for (int y = 0; y < columns; y++)
                {
                    Button tmpButton = new Button();
                    ButtonList.Add(tmpButton);
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    tmpButton.Click += new EventHandler(button_Click);
                    // Possible add Buttonclick event etc..
                    //this.Controls.Add(tmpButton);

                    // Add the buttons to the panel, not the form itself
                    pnlGameBoard.Controls.Add(tmpButton);
                }

            }
            //this.Load += new System.EventHandler(this.Resize);

            // this.Width = 300;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text.ToString() + " got clicked");
        }

        private void frmTest_Resize(object sender, System.EventArgs e)
        {
            foreach(Button b in ButtonList)
            {
                pnlGameBoard.Controls.Remove(b);
            }
            ButtonList.Clear();
            int formWidth = this.Width;
            int formHeight = this.Height;
            pnlGameBoard.Width = formWidth - 50;
            pnlGameBoard.Height = formHeight - 70;

            //// rows and columns, will be passed in later
            //// Just some defaults for now
            //int rows = 5;
            //int columns = 6;

            // Some default options, can change later
            int ButtonWidth = (this.Width - 220) / (rows + 1);
            int ButtonHeight = (this.Height - 50) / columns;
            int Distance = 20;
            int start_x = 10;
            int start_y = 10;


            // For each row..
            for (int x = 0; x < rows; x++)
            {
                // Create that many columns until you break out of for loop
                // Which in turn starts the next row
                for (int y = 0; y < columns; y++)
                {
                    Button tmpButton = new Button();
                    ButtonList.Add(tmpButton);
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Click += new EventHandler(button_Click);
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();

                    // Possible add Buttonclick event etc..
                    //this.Controls.Add(tmpButton);

                    // Add the buttons to the panel, not the form itself
                    pnlGameBoard.Controls.Add(tmpButton);
                }

            }
        }

    }
}