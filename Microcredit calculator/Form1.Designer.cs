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
            this.label6 = new System.Windows.Forms.Label();
            this.Proc = new System.Windows.Forms.TextBox();
            this.TotalSum = new System.Windows.Forms.TextBox();
            this.SumProc = new System.Windows.Forms.TextBox();
            this.EffStav = new System.Windows.Forms.TextBox();
            this.SummZayma = new System.Windows.Forms.TextBox();
            this.Period = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(168, 103);
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
            this.Raschet.Location = new System.Drawing.Point(133, 238);
            this.Raschet.Name = "Raschet";
            this.Raschet.Size = new System.Drawing.Size(154, 43);
            this.Raschet.TabIndex = 5;
            this.Raschet.Text = "Рассчитать ";
            this.Raschet.UseVisualStyleBackColor = false;
            this.Raschet.Click += new System.EventHandler(this.button1_Click);
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
            // Proc
            // 
            this.Proc.Location = new System.Drawing.Point(133, 126);
            this.Proc.Multiline = true;
            this.Proc.Name = "Proc";
            this.Proc.Size = new System.Drawing.Size(154, 60);
            this.Proc.TabIndex = 14;
            this.Proc.TextChanged += new System.EventHandler(this.txProc_TextChanged);
            // 
            // TotalSum
            // 
            this.TotalSum.Location = new System.Drawing.Point(208, 396);
            this.TotalSum.Multiline = true;
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.Size = new System.Drawing.Size(154, 20);
            this.TotalSum.TabIndex = 15;
            // 
            // SumProc
            // 
            this.SumProc.Location = new System.Drawing.Point(208, 424);
            this.SumProc.Multiline = true;
            this.SumProc.Name = "SumProc";
            this.SumProc.Size = new System.Drawing.Size(154, 20);
            this.SumProc.TabIndex = 16;
            // 
            // EffStav
            // 
            this.EffStav.Location = new System.Drawing.Point(209, 450);
            this.EffStav.Multiline = true;
            this.EffStav.Name = "EffStav";
            this.EffStav.Size = new System.Drawing.Size(154, 20);
            this.EffStav.TabIndex = 17;
            // 
            // SummZayma
            // 
            this.SummZayma.Location = new System.Drawing.Point(208, 34);
            this.SummZayma.Multiline = true;
            this.SummZayma.Name = "SummZayma";
            this.SummZayma.Size = new System.Drawing.Size(154, 20);
            this.SummZayma.TabIndex = 18;
            // 
            // Period
            // 
            this.Period.Location = new System.Drawing.Point(208, 60);
            this.Period.Multiline = true;
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(154, 20);
            this.Period.TabIndex = 19;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Highlight;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.SystemColors.Control;
            this.Save.Location = new System.Drawing.Point(133, 287);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(154, 43);
            this.Save.TabIndex = 20;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 490);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.SummZayma);
            this.Controls.Add(this.EffStav);
            this.Controls.Add(this.SumProc);
            this.Controls.Add(this.TotalSum);
            this.Controls.Add(this.Proc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Raschet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Microcredit calculator";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Proc;
        private System.Windows.Forms.TextBox TotalSum;
        private System.Windows.Forms.TextBox SumProc;
        private System.Windows.Forms.TextBox EffStav;
        private System.Windows.Forms.TextBox SummZayma;
        private System.Windows.Forms.TextBox Period;
        private System.Windows.Forms.Button Save;
    }
}

