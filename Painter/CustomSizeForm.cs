//Tellon Smith
//CustomSize.cs
//Holds custom size input information

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
    public partial class CustomSizeForm : Form
    {
        //variables
        private int size = 0; //stores custom size

        public CustomSizeForm()
        {
            InitializeComponent();
        }

        //purpose: returns the value of size
        //requires: none
        //returns: int, size 
        public int _Size
        {
            get
            {
                return size;
            }
        }

        //OK button click event
        private void customSize_okButton_Click(object sender, EventArgs e)
        {
            bool error = false; //for if errors are detected with user input

            try
            {
                //assign user input to variable
                size = Convert.ToInt32(customSize_textBox.Text);

                //validate size and throw exception if necessary
                if (size < 1 || size > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\nPlease only enter numbers in the textbox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                error = true; //error detected
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message + "\nPlease enter a value between 1 and 100", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                error = true; //error detected
            }
            //if no exceptions thrown, close dialog box
            if (!error)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void customSize_cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //set dialog result
            this.Close(); //close form
        }
    }
}
