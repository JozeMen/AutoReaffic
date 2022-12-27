using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoTraffic
{
    public partial class Settings : Form
    {
        private int timeApeare;


        public int getTimeApeare
        {
            get { return timeApeare; }
        }

        public Settings()
        {
            InitializeComponent();
            comboBoxRand_SV.Items.AddRange(new string[] { "нормальное", "равномерное", "показательное" });

        }
        private void checkBoxDet_Click (object sender, EventArgs e)
        {
            groupBoxRand.Visible = false;
            groupBoxDet.Visible = true;
        }

        private void checkBoxRand_Click(object sender, EventArgs e)
        {
            groupBoxRand.Visible = true;
            groupBoxDet.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            timeApeare = (int)numericUpDown1.Value;
            this.Close();
        }

        private void comboBoxRand_SV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var law = comboBoxRand_SV.SelectedItem.ToString();

            switch (law)
            {
                case "нормальное":
                    SetUnvisibleTextBoxes();

                    label2.Text = "Укажите значение дисперсии";
                    label3.Text = "Укажите значение математического ожидания";

                    textBox_Rand_D.Visible = true;
                    textBoxRand_MO.Visible = true;
                    break;
                case "равномерное":
                    SetUnvisibleTextBoxes();

                    label2.Text = "Начальное значение интервала";
                    label3.Text = "Конечное значение интервала";

                    textBoxStartInterval.Visible = true;
                    textBoxEndInterval.Visible = true;
                    break;
                case "показательное":
                    SetUnvisibleTextBoxes();

                    label2.Text = "Укажите значение интенсивности";
                    
                    label3.Visible = false;

                    textBoxIntensity.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Скрыть все textBox'ы в группе со случайным распределением.
        /// </summary>
        private void SetUnvisibleTextBoxes()
        {
            label2.Visible = true;
            label3.Visible = true;

            textBoxIntensity.Visible = false;
            textBoxStartInterval.Visible = false;
            textBoxEndInterval.Visible = false;
            textBox_Rand_D.Visible = false;
            textBoxRand_MO.Visible = false;
        }
    }
}
