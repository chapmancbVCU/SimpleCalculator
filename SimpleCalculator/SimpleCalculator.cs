using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namespace for Simple Calculator Class
/// </summary>
namespace SimpleCalculator
{
    /// <summary>
    /// This class defines the event handlers for each of
    /// the buttons.
    /// </summary>

    public partial class SimpleCalculator: UserControl
    {
        // INSTANCE VARIABLES
        float answer;
        DataTable data;
        int opCount;
        float num1;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleCalculator()
        {
            InitializeComponent();
            data = new DataTable();
        }

        /// <summary>
        /// Event handler for numberZeroButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberZeroButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        /// <summary>
        /// Event handler for numberOneButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberOneButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        /// <summary>
        /// Event handler for numberTwoButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        /// <summary>
        /// Event handler for numberThreeButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        /// <summary>
        /// Event handler for numberFourButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberFourButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        /// <summary>
        /// Event handler for numberFiveButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        /// <summary>
        /// Event handler for numberSixButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberSixButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        /// <summary>
        /// Event handler for numberSevenButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        /// <summary>
        /// Event handler for numberEightButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberEightButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        /// <summary>
        /// Event handler for numberNineButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberNineButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        /// <summary>
        /// Event handler for additionOpButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void additionOpButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            opCount = 2;
        }

        /// <summary>
        /// Event handler for subtractionOpButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractionOpButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                opCount = 1;
            }
        }

        /// <summary>
        /// Event handler for multiplicationOpButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiplicationOpButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            opCount = 3;
        }

        /// <summary>
        /// Event handler for divisionOpButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divisionOpButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            opCount = 4;
        }

        /// <summary>
        /// Event handler for equalsButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalsButton_Click(object sender, EventArgs e)
        {
            compute(opCount);
        }

        /// <summary>
        /// Calculates answer.
        /// </summary>
        /// <param name="opCount"></param>
        public void compute(int opCount)
        {
            string sign = "";
            switch(opCount)
            {
                case 1:
                    answer = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    sign = "-";
                    break;
                case 2:
                    answer = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    sign = "+";
                    break;
                case 3:
                    answer = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    sign = "*";
                    break;
                case 4:
                    answer = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    sign = "/";
                    break;
                default:
                    break;
            }


            foreach (DataRow row in data.Rows)
            {
                string newRow = num1 + "sign" + textBox1.Text.ToString() + "=" + answer;
                ListViewItem item = new ListViewItem(newRow);
                for(int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Event handler for decimalButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decimalButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        /// <summary>
        /// Event handler for changeSignButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeSignButton_Click(object sender, EventArgs e)
        {
            // We just multiply the value by -1.
            answer = -1 * float.Parse(textBox1.Text);
            textBox1.Text = answer.ToString();
        }

        /// <summary>
        /// Event handler for clearButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            opCount = 0;
        }
    }
}
