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
            $"This program is designed to help you manage your grocery store efficiently." + "\n" +
            $"You can sort by either the aisle or the category of food." + "\n" +
            $"You can also use the search feature to quickly find specific items." + "\n" +
            $"Thank you for using StansGrocery! Press the \"OK\" button to continue.";
        }
    }
}
