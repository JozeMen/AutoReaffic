
namespace AutoTraffic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownWay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLines = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxDev = new System.Windows.Forms.PictureBox();
            this.pictureBoxSys = new System.Windows.Forms.PictureBox();
            this.labelLights = new System.Windows.Forms.Label();
            this.textBoxLights = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSys)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Смоделировать дорогу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите тип дороги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите количество направлений движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Укажите количество полос";
            // 
            // numericUpDownWay
            // 
            this.numericUpDownWay.Location = new System.Drawing.Point(428, 138);
            this.numericUpDownWay.Name = "numericUpDownWay";
            this.numericUpDownWay.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWay.TabIndex = 17;
            // 
            // numericUpDownLines
            // 
            this.numericUpDownLines.Location = new System.Drawing.Point(428, 174);
            this.numericUpDownLines.Name = "numericUpDownLines";
            this.numericUpDownLines.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLines.TabIndex = 18;
            // 
            // pictureBoxDev
            // 
            this.pictureBoxDev.Image = global::AutoTraffic.Properties.Resources.Безымянный21;
            this.pictureBoxDev.Location = new System.Drawing.Point(537, 31);
            this.pictureBoxDev.Name = "pictureBoxDev";
            this.pictureBoxDev.Size = new System.Drawing.Size(47, 37);
            this.pictureBoxDev.TabIndex = 20;
            this.pictureBoxDev.TabStop = false;
            this.pictureBoxDev.Click += new System.EventHandler(this.pictureBoxDev_MouseEnter);
            // 
            // pictureBoxSys
            // 
            this.pictureBoxSys.Image = global::AutoTraffic.Properties.Resources.Безымянный2;
            this.pictureBoxSys.Location = new System.Drawing.Point(12, 31);
            this.pictureBoxSys.Name = "pictureBoxSys";
            this.pictureBoxSys.Size = new System.Drawing.Size(42, 37);
            this.pictureBoxSys.TabIndex = 19;
            this.pictureBoxSys.TabStop = false;
            this.pictureBoxSys.Click += new System.EventHandler(this.pictureBoxSys_MouseEnter);
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Location = new System.Drawing.Point(35, 138);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(261, 16);
            this.labelLights.TabIndex = 21;
            this.labelLights.Text = "Укажите значение светофорной фазы";
            this.labelLights.Visible = false;
            // 
            // textBoxLights
            // 
            this.textBoxLights.Location = new System.Drawing.Point(448, 134);
            this.textBoxLights.Name = "textBoxLights";
            this.textBoxLights.Size = new System.Drawing.Size(100, 22);
            this.textBoxLights.TabIndex = 22;
            this.textBoxLights.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 338);
            this.Controls.Add(this.textBoxLights);
            this.Controls.Add(this.labelLights);
            this.Controls.Add(this.pictureBoxDev);
            this.Controls.Add(this.pictureBoxSys);
            this.Controls.Add(this.numericUpDownLines);
            this.Controls.Add(this.numericUpDownWay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Настройка параметров";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWay;
        private System.Windows.Forms.NumericUpDown numericUpDownLines;
        private System.Windows.Forms.PictureBox pictureBoxSys;
        private System.Windows.Forms.PictureBox pictureBoxDev;
        private System.Windows.Forms.Label labelLights;
        private System.Windows.Forms.TextBox textBoxLights;
    }
}

