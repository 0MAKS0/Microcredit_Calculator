namespace Microcredit_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Raschet = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.txProc = new System.Windows.Forms.TextBox();
            this.Summ = new System.Windows.Forms.TextBox();
            this.SummProc = new System.Windows.Forms.TextBox();
            this.EffStavk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма займа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ставка(%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок займа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма процентов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сумма выплаты : ";
            // 
            // Raschet
            // 
            this.Raschet.BackColor = System.Drawing.SystemColors.Highlight;
            this.Raschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raschet.ForeColor = System.Drawing.SystemColors.Control;
            this.Raschet.Location = new System.Drawing.Point(254, 183);
            this.Raschet.Name = "Raschet";
            this.Raschet.Size = new System.Drawing.Size(143, 34);
            this.Raschet.TabIndex = 5;
            this.Raschet.Text = "Рассчитать ";
            this.Raschet.UseVisualStyleBackColor = false;
            this.Raschet.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(208, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(209, 62);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Эффективная ставка:";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.SystemColors.Control;
            this.Save.Location = new System.Drawing.Point(254, 223);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 33);
            this.Save.TabIndex = 13;
            this.Save.Text = "Сохранить ";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // txProc
            // 
            this.txProc.Location = new System.Drawing.Point(56, 139);
            this.txProc.Multiline = true;
            this.txProc.Name = "txProc";
            this.txProc.Size = new System.Drawing.Size(154, 221);
            this.txProc.TabIndex = 14;
            this.txProc.TextChanged += new System.EventHandler(this.txProc_TextChanged);
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(208, 396);
            this.Summ.Multiline = true;
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(154, 20);
            this.Summ.TabIndex = 15;
            // 
            // SummProc
            // 
            this.SummProc.Location = new System.Drawing.Point(208, 424);
            this.SummProc.Multiline = true;
            this.SummProc.Name = "SummProc";
            this.SummProc.Size = new System.Drawing.Size(154, 20);
            this.SummProc.TabIndex = 16;
            // 
            // EffStavk
            // 
            this.EffStavk.Location = new System.Drawing.Point(209, 450);
            this.EffStavk.Multiline = true;
            this.EffStavk.Name = "EffStavk";
            this.EffStavk.Size = new System.Drawing.Size(154, 20);
            this.EffStavk.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 490);
            this.Controls.Add(this.EffStavk);
            this.Controls.Add(this.SummProc);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.txProc);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Raschet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Microcredit calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Raschet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox txProc;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.TextBox SummProc;
        private System.Windows.Forms.TextBox EffStavk;
    }
}

