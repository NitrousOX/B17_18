namespace B17_18
{
    partial class Polise
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.Upisi_btn = new System.Windows.Forms.Button();
            this.Obriis_btn = new System.Windows.Forms.Button();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "vrednost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vazi od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vazi do:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(288, 72);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(551, 72);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 7;
            // 
            // Upisi_btn
            // 
            this.Upisi_btn.Location = new System.Drawing.Point(12, 162);
            this.Upisi_btn.Name = "Upisi_btn";
            this.Upisi_btn.Size = new System.Drawing.Size(75, 23);
            this.Upisi_btn.TabIndex = 8;
            this.Upisi_btn.Text = "Upisi";
            this.Upisi_btn.UseVisualStyleBackColor = true;
            this.Upisi_btn.Click += new System.EventHandler(this.Upisi_btn_Click);
            // 
            // Obriis_btn
            // 
            this.Obriis_btn.Location = new System.Drawing.Point(121, 162);
            this.Obriis_btn.Name = "Obriis_btn";
            this.Obriis_btn.Size = new System.Drawing.Size(75, 23);
            this.Obriis_btn.TabIndex = 9;
            this.Obriis_btn.Text = "Obrisi";
            this.Obriis_btn.UseVisualStyleBackColor = true;
            this.Obriis_btn.Click += new System.EventHandler(this.Obriis_btn_Click);
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(12, 211);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(75, 23);
            this.izmeni_btn.TabIndex = 10;
            this.izmeni_btn.Text = "izmeni";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.Izmeni_btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(121, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "izadji";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Polise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.izmeni_btn);
            this.Controls.Add(this.Obriis_btn);
            this.Controls.Add(this.Upisi_btn);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Polise";
            this.Text = "Polise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button Upisi_btn;
        private System.Windows.Forms.Button Obriis_btn;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.Button button4;
    }
}