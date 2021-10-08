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
    public partial class Form1 : Form
    {
        private List<int> listValue = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var enter = new FormEnterNumber(labelUserNamber);
            enter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelUserNamber.Text == "0000")
                {
                    throw new Exception("Вы не ввели число!");
                }
                timer1.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Game()
        {
          
            button1.Enabled = false;
            button2.Enabled = false;
            if (labelUserNamber.Text == labelPCNumber.Text)
            {
                timer1.Enabled = false;
                var result = MessageBox.Show($"Компьютер угадал, загаданное Вами число!\n" +
                                             $"Число затраченых попыток: {listValue.Count}\n" +
                                             $"\nЖелаете попробовать снова?", "Победа!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listValue.Clear();
                    button1.Enabled = true;
                    button2.Enabled = true;
                    return;
                }
                else 
                {
                    Application.Exit();
                }

            }
        }
       
        private void GuessNum()
        {
            int rnd = new Random().Next(1, 2000);
            if (!listValue.Contains(rnd))
            {
                listValue.Add(rnd);
                labelPCNumber.Text = rnd.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GuessNum();
            Game();
        }
    }
}
