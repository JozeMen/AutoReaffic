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
    }
}
