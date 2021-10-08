using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class FormEnterNumber : Form
    {
        private Label _label;
        public FormEnterNumber(Label label)
        {
            InitializeComponent();
            _label = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (new Random().Next(1, 2000)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Поле не может быть пустым!");
                }
                else if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 2000)
                {
                    MessageBox.Show("Вводите только цифры в диапазоне от 1 до 2000!");
                }
                else
                {
                    _label.Text = textBox1.Text;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вводите только цифры!");
            }
        }
    }
}
