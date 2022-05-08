using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel8086Emulator
{
    public partial class Form1 : Form
    {
        public bool allTextBoxValid = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAX.Text = "0000";
            textBoxAX.MaxLength = 4;
            
            textBoxBX.Text = "0000";
            textBoxBX.MaxLength = 4;
            
            textBoxCX.Text = "0000";
            textBoxCX.MaxLength = 4;

            textBoxDX.Text = "0000";
            textBoxDX.MaxLength = 4;
        }

        private void RandomInputs_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBoxAX.Text = rnd.Next(0, 65535).ToString("X");
            textBoxBX.Text = rnd.Next(0, 65535).ToString("X");
            textBoxCX.Text = rnd.Next(0, 65535).ToString("X");
            textBoxDX.Text = rnd.Next(0, 65535).ToString("X");

        }

        private void MOV_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isFromValueChecked = false;
            
            if(allTextBoxValid)
            {

                if (FromAX.Checked)
                {
                    value = textBoxAX.Text;
                    isFromValueChecked = true;
                }
                else if (FromBX.Checked)
                {
                    value = textBoxBX.Text;
                    isFromValueChecked = true;
                }
                else if (FromCX.Checked)
                {
                    value = textBoxCX.Text;
                    isFromValueChecked = true;
                }
                else if (FromDX.Checked)
                {
                    value = textBoxDX.Text;
                    isFromValueChecked = true;
                }
                else
                {
                    MessageBox.Show("Please check the radio values");
                }

                if (ToAX.Checked && isFromValueChecked)
                {
                    textBoxAX.Text = value;
                }
                else if (ToBX.Checked && isFromValueChecked)
                {
                    textBoxBX.Text = value;
                }
                else if (ToCX.Checked && isFromValueChecked)
                {
                    textBoxCX.Text = value;
                }
                else if (ToDX.Checked && isFromValueChecked)
                {
                    textBoxDX.Text = value;
                }
                else if (isFromValueChecked)
                {
                    MessageBox.Show("Please check the radio values");
                }

            }
            else
            {
                MessageBox.Show("Not all values are valid!");
            }
            
        }

        private void XCHG_Click(object sender, EventArgs e)
        {
            string value = "";

            if (allTextBoxValid)
            {

                if (FromAX.Checked)
                {
                    if (ToAX.Checked)
                    {
                        MessageBox.Show("Can't copy from AX to AX");
                    }
                    else if (ToBX.Checked)
                    {
                        value = textBoxAX.Text;
                        textBoxAX.Text = textBoxBX.Text;
                        textBoxBX.Text = value;
                    }
                    else if (ToCX.Checked)
                    {
                        value = textBoxAX.Text;
                        textBoxAX.Text = textBoxCX.Text;
                        textBoxCX.Text = value;
                    }
                    else if (ToDX.Checked)
                    {
                        value = textBoxAX.Text;
                        textBoxAX.Text = textBoxDX.Text;
                        textBoxDX.Text = value;
                    }
                    else
                    {
                        MessageBox.Show("Please check the radio values");
                    }

                }
                else if (FromBX.Checked)
                {
                    if (ToAX.Checked)
                    {
                        value = textBoxBX.Text;
                        textBoxBX.Text = textBoxAX.Text;
                        textBoxAX.Text = value;
                    }
                    else if (ToBX.Checked)
                    {
                        MessageBox.Show("Can't copy from BX to BX");
                    }
                    else if (ToCX.Checked)
                    {
                        value = textBoxBX.Text;
                        textBoxBX.Text = textBoxCX.Text;
                        textBoxCX.Text = value;
                    }
                    else if (ToDX.Checked)
                    {
                        value = textBoxBX.Text;
                        textBoxBX.Text = textBoxDX.Text;
                        textBoxDX.Text = value;
                    }
                    else
                    {
                        MessageBox.Show("Please check the radio values");
                    }
                }
                else if (FromCX.Checked)
                {
                    if (ToAX.Checked)
                    {
                        value = textBoxCX.Text;
                        textBoxCX.Text = textBoxAX.Text;
                        textBoxAX.Text = value;
                    }
                    else if (ToBX.Checked)
                    {
                        value = textBoxCX.Text;
                        textBoxCX.Text = textBoxBX.Text;
                        textBoxBX.Text = value;
                    }
                    else if (ToCX.Checked)
                    {
                        MessageBox.Show("Can't copy from CX to CX");
                    }
                    else if (ToDX.Checked)
                    {
                        value = textBoxCX.Text;
                        textBoxCX.Text = textBoxDX.Text;
                        textBoxDX.Text = value;
                    }
                    else
                    {
                        MessageBox.Show("Please check the radio values");
                    }
                }
                else if (FromDX.Checked)
                {
                    if (ToAX.Checked)
                    {
                        value = textBoxDX.Text;
                        textBoxDX.Text = textBoxAX.Text;
                        textBoxAX.Text = value;
                    }
                    else if (ToBX.Checked)
                    {
                        value = textBoxDX.Text;
                        textBoxDX.Text = textBoxBX.Text;
                        textBoxBX.Text = value;
                    }
                    else if (ToCX.Checked)
                    {
                        value = textBoxDX.Text;
                        textBoxDX.Text = textBoxCX.Text;
                        textBoxCX.Text = value;
                    }
                    else if (ToDX.Checked)
                    {
                        MessageBox.Show("Can't copy from DX to DX");
                    }
                    else
                    {
                        MessageBox.Show("Please check the radio values");
                    }
                }
                else
                {
                    MessageBox.Show("Please check the radio values");
                }

            }
            else
            {
                MessageBox.Show("Not all values are valid!");
            }


        }

        #region Validating TextBoxes
        private void textBoxAX_TextChanged(object sender, EventArgs e)
        {
            char[] textToChar = textBoxAX.Text.ToCharArray();
            foreach (var t in textToChar)
            {
                if ((t < '0' || t > '9') &&
                    (t < 'A' || t > 'F') &&
                    (t < 'a' || t > 'f'))
                {
                    textBoxAX.ForeColor = Color.Red;
                    allTextBoxValid = false;
                    return;
                }

                textBoxAX.ForeColor = Color.Black;
                allTextBoxValid = true;
            }
        }

        private void textBoxBX_TextChanged(object sender, EventArgs e)
        {
            char[] textToChar = textBoxBX.Text.ToCharArray();
            foreach (var t in textToChar)
            {
                if ((t < '0' || t > '9') &&
                    (t < 'A' || t > 'F') &&
                    (t < 'a' || t > 'f'))
                {
                    textBoxBX.ForeColor = Color.Red;
                    allTextBoxValid = false;
                    return;
                }

                textBoxBX.ForeColor = Color.Black;
                allTextBoxValid = true;
            }
        }

        private void textBoxCX_TextChanged(object sender, EventArgs e)
        {
            char[] textToChar = textBoxCX.Text.ToCharArray();
            foreach (var t in textToChar)
            {
                if ((t < '0' || t > '9') &&
                    (t < 'A' || t > 'F') &&
                    (t < 'a' || t > 'f'))
                {
                    textBoxCX.ForeColor = Color.Red;
                    allTextBoxValid = false;
                    return;
                }

                textBoxCX.ForeColor = Color.Black;
                allTextBoxValid = true;
            }
        }

        private void textBoxDX_TextChanged(object sender, EventArgs e)
        {
            char[] textToChar = textBoxDX.Text.ToCharArray();
            foreach (var t in textToChar)
            {
                if ((t < '0' || t > '9') &&
                    (t < 'A' || t > 'F') &&
                    (t < 'a' || t > 'f'))
                {
                    textBoxDX.ForeColor = Color.Red;
                    allTextBoxValid = false;
                    return;
                }

                textBoxDX.ForeColor = Color.Black;
                allTextBoxValid = true;
            }
        }

        #endregion
    }
}
