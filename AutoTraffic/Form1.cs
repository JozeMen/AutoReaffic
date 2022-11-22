using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTraffic
{
    public partial class Form1 : Form
    {
        Modeling form2;
        private int CountWays;
        private int CountLines;

        public int getCountWays
        {
            get { return CountWays; }
        }

        public int getCountLines
        {
            get { return CountLines; }
        }
        public Form1()
        {
            InitializeComponent();
            numericUpDownWay.Minimum = 1;
            numericUpDownWay.Maximum = 2;
            numericUpDownWay.ReadOnly = true;
            numericUpDownLines.Minimum = 1;
            numericUpDownLines.Maximum = 4;
            numericUpDownLines.ReadOnly = true;
/*            numericUpDownLights.Minimum = 0;
            numericUpDownLights.Maximum = 2;
            numericUpDownLights.ReadOnly = true;
*/            comboBox1.Items.AddRange(new string[] { "город", "загород", "тоннель" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountLines = (int)numericUpDownLines.Value;
            form2 = new Modeling();

            form2.setCountLines = CountLines;
            form2.ShowDialog();
        }
        private void pictureBoxDev_MouseEnter (object sender, EventArgs e)
        {
            MessageBox.Show("Создатели: \nПоздеев Сергей \nЖучков Константин \nПетропавловская Антонина");
        }
        private void pictureBoxSys_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Система моделирования движения транспорта \nна автодороге (в тоннеле / на автостраде) ");
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "тоннель")
            {
                label2.Visible = false;
                label3.Visible = false;
                numericUpDownLines.Visible = false;
                numericUpDownWay.Visible = false;
                labelLights.Visible = true;
                textBoxLights.Visible = true;
                MessageBox.Show("ДА!");
            }
            else
            {
                label2.Visible = true;
                label3.Visible = true;
                numericUpDownLines.Visible = true;
                numericUpDownWay.Visible = true;
                labelLights.Visible = false;
                textBoxLights.Visible = false;
            }
        }
    }
}
