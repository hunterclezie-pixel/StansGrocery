using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StansGrocery
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            UpdateLabel();
        }

        void UpdateLabel()
        {
            AboutLabel.Text = $"Welcome to StansGrocery!" + "\n" +
            $"This program loads grocery item data from a file and allows users to search and filter items by name, aisle, or category using multiple interface options. " + 
            $"It dynamically updates the displayed results and provides clear feedback, ensuring users can easily locate items or be informed when no matches are found.";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
