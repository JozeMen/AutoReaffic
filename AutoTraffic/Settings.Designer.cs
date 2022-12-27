namespace AutoTraffic
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.labelDet_Time = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox_Rand_D = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRand_MO = new System.Windows.Forms.TextBox();
            this.comboBoxRand_SV = new System.Windows.Forms.ComboBox();
            this.groupBoxRand = new System.Windows.Forms.GroupBox();
            this.checkBoxDet = new System.Windows.Forms.RadioButton();
            this.checkBoxRand = new System.Windows.Forms.RadioButton();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.textBoxStartInterval = new System.Windows.Forms.TextBox();
            this.textBoxEndInterval = new System.Windows.Forms.TextBox();
            this.textBoxIntensity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxRand.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Выберите тип транспортного потока";
            // 
            // labelDet_Time
            // 
            this.labelDet_Time.AutoSize = true;
            this.labelDet_Time.Location = new System.Drawing.Point(9, 19);
            this.labelDet_Time.Name = "labelDet_Time";
            this.labelDet_Time.Size = new System.Drawing.Size(261, 16);
            this.labelDet_Time.TabIndex = 23;
            this.labelDet_Time.Text = "Укажите время появления автомобиля";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(306, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 24;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(510, 166);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(110, 30);
            this.buttonOK.TabIndex = 26;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBox_Rand_D
            // 
            this.textBox_Rand_D.Location = new System.Drawing.Point(401, 47);
            this.textBox_Rand_D.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Rand_D.Name = "textBox_Rand_D";
            this.textBox_Rand_D.Size = new System.Drawing.Size(132, 22);
            this.textBox_Rand_D.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Выберите закон распределения случайной величины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Укажите значение дисперсии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Укажите значение математического ожидания";
            // 
            // textBoxRand_MO
            // 
            this.textBoxRand_MO.Location = new System.Drawing.Point(401, 82);
            this.textBoxRand_MO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRand_MO.Name = "textBoxRand_MO";
            this.textBoxRand_MO.Size = new System.Drawing.Size(132, 22);
            this.textBoxRand_MO.TabIndex = 30;
            // 
            // comboBoxRand_SV
            // 
            this.comboBoxRand_SV.FormattingEnabled = true;
            this.comboBoxRand_SV.Location = new System.Drawing.Point(401, 4);
            this.comboBoxRand_SV.Name = "comboBoxRand_SV";
            this.comboBoxRand_SV.Size = new System.Drawing.Size(132, 24);
            this.comboBoxRand_SV.TabIndex = 31;
            this.comboBoxRand_SV.SelectedIndexChanged += new System.EventHandler(this.comboBoxRand_SV_SelectedIndexChanged);
            // 
            // groupBoxRand
            // 
            this.groupBoxRand.Controls.Add(this.comboBoxRand_SV);
            this.groupBoxRand.Controls.Add(this.textBoxRand_MO);
            this.groupBoxRand.Controls.Add(this.label3);
            this.groupBoxRand.Controls.Add(this.label2);
            this.groupBoxRand.Controls.Add(this.label1);
            this.groupBoxRand.Controls.Add(this.textBoxEndInterval);
            this.groupBoxRand.Controls.Add(this.textBox_Rand_D);
            this.groupBoxRand.Controls.Add(this.textBoxStartInterval);
            this.groupBoxRand.Controls.Add(this.textBoxIntensity);
            this.groupBoxRand.Location = new System.Drawing.Point(527, 42);
            this.groupBoxRand.Name = "groupBoxRand";
            this.groupBoxRand.Size = new System.Drawing.Size(544, 115);
            this.groupBoxRand.TabIndex = 32;
            this.groupBoxRand.TabStop = false;
            // 
            // checkBoxDet
            // 
            this.checkBoxDet.AutoSize = true;
            this.checkBoxDet.Location = new System.Drawing.Point(310, 25);
            this.checkBoxDet.Name = "checkBoxDet";
            this.checkBoxDet.Size = new System.Drawing.Size(165, 20);
            this.checkBoxDet.TabIndex = 32;
            this.checkBoxDet.TabStop = true;
            this.checkBoxDet.Text = "детерминированный";
            this.checkBoxDet.UseVisualStyleBackColor = true;
            this.checkBoxDet.Click += new System.EventHandler(this.checkBoxDet_Click);
            // 
            // checkBoxRand
            // 
            this.checkBoxRand.AutoSize = true;
            this.checkBoxRand.Location = new System.Drawing.Point(542, 23);
            this.checkBoxRand.Name = "checkBoxRand";
            this.checkBoxRand.Size = new System.Drawing.Size(100, 20);
            this.checkBoxRand.TabIndex = 33;
            this.checkBoxRand.TabStop = true;
            this.checkBoxRand.Text = "случайный";
            this.checkBoxRand.UseVisualStyleBackColor = true;
            this.checkBoxRand.Click += new System.EventHandler(this.checkBoxRand_Click);
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.numericUpDown1);
            this.groupBoxDet.Controls.Add(this.labelDet_Time);
            this.groupBoxDet.Location = new System.Drawing.Point(4, 56);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(450, 54);
            this.groupBoxDet.TabIndex = 34;
            this.groupBoxDet.TabStop = false;
            // 
            // textBoxStartInterval
            // 
            this.textBoxStartInterval.Location = new System.Drawing.Point(401, 47);
            this.textBoxStartInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartInterval.Name = "textBoxStartInterval";
            this.textBoxStartInterval.Size = new System.Drawing.Size(132, 22);
            this.textBoxStartInterval.TabIndex = 22;
            // 
            // textBoxEndInterval
            // 
            this.textBoxEndInterval.Location = new System.Drawing.Point(401, 82);
            this.textBoxEndInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEndInterval.Name = "textBoxEndInterval";
            this.textBoxEndInterval.Size = new System.Drawing.Size(132, 22);
            this.textBoxEndInterval.TabIndex = 22;
            // 
            // textBoxIntensity
            // 
            this.textBoxIntensity.Location = new System.Drawing.Point(401, 47);
            this.textBoxIntensity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIntensity.Name = "textBoxIntensity";
            this.textBoxIntensity.Size = new System.Drawing.Size(132, 22);
            this.textBoxIntensity.TabIndex = 22;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 219);
            this.Controls.Add(this.groupBoxDet);
            this.Controls.Add(this.checkBoxRand);
            this.Controls.Add(this.checkBoxDet);
            this.Controls.Add(this.groupBoxRand);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label5);
            this.Name = "Settings";
            this.Text = "Тип транспортного потока";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxRand.ResumeLayout(false);
            this.groupBoxRand.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDet_Time;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox_Rand_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRand_MO;
        private System.Windows.Forms.ComboBox comboBoxRand_SV;
        private System.Windows.Forms.GroupBox groupBoxRand;
        private System.Windows.Forms.RadioButton checkBoxDet;
        private System.Windows.Forms.RadioButton checkBoxRand;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.TextBox textBoxStartInterval;
        private System.Windows.Forms.TextBox textBoxEndInterval;
        private System.Windows.Forms.TextBox textBoxIntensity;
    }
}