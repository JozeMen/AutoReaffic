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

        /// <summary>
        /// Детерминированное ли распределение.
        /// </summary>
        public bool IsDeterminate
        {
            get => checkBoxDet.Checked;
        }

        /// <summary>
        /// Случайное ли распределение.
        /// </summary>
        public bool IsRandom
        {
            get => checkBoxRand.Checked;
        }

        /// <summary>
        /// Детерминированный интервал генерации авто.
        /// </summary>
        public int DeterminateInterval
        {
            get => (int)numericUpDown1.Value;
        }

        /// <summary>
        /// Выбранный закон распределения.
        /// </summary>
        public string Law
        {
            get => comboBoxRand_SV.SelectedItem.ToString();
        }

        /// <summary>
        /// Интенсивность.
        /// </summary>
        public float Intensity
        {
            get
            {
                if (string.IsNullOrEmpty(textBoxIntensity.Text))
                {
                    return float.NaN;
                }

                return float.Parse(textBoxIntensity.Text);
            }
        }

        /// <summary>
        /// Начальное значение интервала.
        /// </summary>
        public float StartInterval
        {
            get
            {
                if (string.IsNullOrEmpty(textBoxStartInterval.Text))
                {
                    return float.NaN;
                }

                return float.Parse(textBoxStartInterval.Text);
            }
        }

        /// <summary>
        /// Конечное значение интервала.
        /// </summary>
        public float EndInterval
        {
            get
            {
                if (string.IsNullOrEmpty(textBoxEndInterval.Text))
                {
                    return float.NaN;
                }

                return float.Parse(textBoxEndInterval.Text);
            }
        }

        /// <summary>
        /// Дисперсия.
        /// </summary>
        public float RandomDispersion
        {
            get
            {
                if (string.IsNullOrEmpty(textBox_Rand_D.Text))
                {
                    return float.NaN;
                }

                return float.Parse(textBox_Rand_D.Text);
            }
        }

        /// <summary>
        /// Математическое ожидание.
        /// </summary>
        public float MathExpectation
        {
            get
            {
                if (string.IsNullOrEmpty(textBoxRand_MO.Text))
                {
                    return float.NaN;
                }

                return float.Parse(textBoxRand_MO.Text);
            }
        }

        public Settings()
        {
            InitializeComponent();
            comboBoxRand_SV.Items.AddRange(new string[] { "нормальное", "равномерное", "показательное" });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
