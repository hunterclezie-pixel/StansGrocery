/* 
Hunter Clezie 
Spring 2026
RCET2265
StansGrocery
github url: https://github.com/hunterclezie-pixel/StansGrocery.git
*/
namespace StansGrocery
{
    public partial class StansGroceryForm : Form
    {
        public StansGroceryForm()
        {
            InitializeComponent();
            FileToArray(this.filePath);
        }

        string[,] customerData = new string[0, 0]; // persistent customer data
        string filePath = @"C:\Users\clezh\OneDrive\Documents\Robotics\4th Semester\Github Assignments\StansGrocery\Grocery.txt";

        // Custom Methods Below Here ---------------------------------------------------

        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }

        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\"", "");
                        _customerData[0, counter] = temp[0];
                        _customerData[1, counter] = temp[1];
                        _customerData[2, counter] = temp[2];
                        _customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            this.customerData = _customerData;
        }

        void DisplayData()
        {
            string[,] data = this.customerData;
            string formattedRow = "";
            int filterColumn = 2;

            DisplayListBox.Items.Clear();

            switch (true)
            {
                case bool when FilterByAisleRadioButton.Checked:
                    filterColumn = 1;
                    break;
                case bool when FilterByCategoryRadioButton.Checked:
                    filterColumn = 0;
                    break;
                    //default:
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == FilterComboBox.SelectedItem.ToString() || FilterComboBox.SelectedIndex == 0))
                    {
                        formattedRow += data[column, row].PadRight(14);
                    }
                }
                if (formattedRow != "")
                {
                    //System.String.
                    if (formattedRow.Contains(SearchTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayListBox.Items.Add(formattedRow);
                    }
                    else
                    {

                    }

                }
                formattedRow = "";
            }
        }

        void LoadFilterComboBox()
        {
            int column = 1;
            FilterComboBox.Items.Clear();

            switch (true)
            {
                case bool when FilterByAisleRadioButton.Checked:
                    column = 1;
                    break;
                case bool when FilterByCategoryRadioButton.Checked:
                    column = 0;
                    break;
                    //default:
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] != null && FilterComboBox.Items.Contains(this.customerData[column, row]) != true)
                {

                    FilterComboBox.Items.Add(this.customerData[column, row]); //add city 
                }
            }
            FilterComboBox.Items.Add("~Select~");
            FilterComboBox.Sorted = true;
            FilterComboBox.SelectedIndex = 0;

        }

        // Event Handlers Below Here ---------------------------------------------------

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void FilterByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void FilterComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
