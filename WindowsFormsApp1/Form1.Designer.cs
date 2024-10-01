namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnHodKostkou = new System.Windows.Forms.Button();
            this.txtBoxCelkHodKostkou = new System.Windows.Forms.TextBox();
            this.lblKostkaCislo = new System.Windows.Forms.Label();
            this.lblCelkSoucet = new System.Windows.Forms.Label();
            this.lblHrac1Soucet = new System.Windows.Forms.Label();
            this.lblHrac2Soucet = new System.Windows.Forms.Label();
            this.lblHrac1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHrac2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHodKostkou
            // 
            this.btnHodKostkou.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHodKostkou.Enabled = false;
            this.btnHodKostkou.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnHodKostkou.Location = new System.Drawing.Point(456, 246);
            this.btnHodKostkou.Name = "btnHodKostkou";
            this.btnHodKostkou.Size = new System.Drawing.Size(229, 289);
            this.btnHodKostkou.TabIndex = 0;
            this.btnHodKostkou.Text = "Hodit kostkou";
            this.btnHodKostkou.UseVisualStyleBackColor = false;
            this.btnHodKostkou.Click += new System.EventHandler(this.btnHodKostkou_Click);
            // 
            // txtBoxCelkHodKostkou
            // 
            this.txtBoxCelkHodKostkou.Location = new System.Drawing.Point(16, 48);
            this.txtBoxCelkHodKostkou.Name = "txtBoxCelkHodKostkou";
            this.txtBoxCelkHodKostkou.Size = new System.Drawing.Size(71, 20);
            this.txtBoxCelkHodKostkou.TabIndex = 1;
            this.txtBoxCelkHodKostkou.TextChanged += new System.EventHandler(this.txtBoxCelkHodKostkou_TextChanged);
            // 
            // lblKostkaCislo
            // 
            this.lblKostkaCislo.AutoSize = true;
            this.lblKostkaCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.lblKostkaCislo.Location = new System.Drawing.Point(320, 204);
            this.lblKostkaCislo.Name = "lblKostkaCislo";
            this.lblKostkaCislo.Size = new System.Drawing.Size(0, 39);
            this.lblKostkaCislo.TabIndex = 2;
            // 
            // lblCelkSoucet
            // 
            this.lblCelkSoucet.AutoSize = true;
            this.lblCelkSoucet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.lblCelkSoucet.Location = new System.Drawing.Point(107, 207);
            this.lblCelkSoucet.Name = "lblCelkSoucet";
            this.lblCelkSoucet.Size = new System.Drawing.Size(0, 25);
            this.lblCelkSoucet.TabIndex = 5;
            // 
            // lblHrac1Soucet
            // 
            this.lblHrac1Soucet.AutoSize = true;
            this.lblHrac1Soucet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblHrac1Soucet.Location = new System.Drawing.Point(195, 96);
            this.lblHrac1Soucet.Name = "lblHrac1Soucet";
            this.lblHrac1Soucet.Size = new System.Drawing.Size(0, 20);
            this.lblHrac1Soucet.TabIndex = 6;
            // 
            // lblHrac2Soucet
            // 
            this.lblHrac2Soucet.AutoSize = true;
            this.lblHrac2Soucet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblHrac2Soucet.Location = new System.Drawing.Point(195, 148);
            this.lblHrac2Soucet.Name = "lblHrac2Soucet";
            this.lblHrac2Soucet.Size = new System.Drawing.Size(0, 20);
            this.lblHrac2Soucet.TabIndex = 7;
            // 
            // lblHrac1
            // 
            this.lblHrac1.AutoSize = true;
            this.lblHrac1.Location = new System.Drawing.Point(62, 101);
            this.lblHrac1.Name = "lblHrac1";
            this.lblHrac1.Size = new System.Drawing.Size(39, 13);
            this.lblHrac1.TabIndex = 8;
            this.lblHrac1.Text = "Hráč 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Číslo na kostce :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Celkový Součet :";
            // 
            // lblHrac2
            // 
            this.lblHrac2.AutoSize = true;
            this.lblHrac2.Location = new System.Drawing.Point(62, 155);
            this.lblHrac2.Name = "lblHrac2";
            this.lblHrac2.Size = new System.Drawing.Size(39, 13);
            this.lblHrac2.TabIndex = 11;
            this.lblHrac2.Text = "Hráč 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(428, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Zvolte kolik bude celkových hodů kostkou (na hráče)";
            // 
            // chartHistogram
            // 
            chartArea4.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend4);
            this.chartHistogram.Location = new System.Drawing.Point(16, 246);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Vysledky";
            this.chartHistogram.Series.Add(series4);
            this.chartHistogram.Size = new System.Drawing.Size(424, 289);
            this.chartHistogram.TabIndex = 17;
            this.chartHistogram.Text = "chartHistogram";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hráč 1 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hráč 2 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Celkové součty hráčů :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 548);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblHrac2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHrac1);
            this.Controls.Add(this.lblHrac2Soucet);
            this.Controls.Add(this.lblHrac1Soucet);
            this.Controls.Add(this.lblCelkSoucet);
            this.Controls.Add(this.lblKostkaCislo);
            this.Controls.Add(this.txtBoxCelkHodKostkou);
            this.Controls.Add(this.btnHodKostkou);
            this.Name = "Form1";
            this.Text = "Hra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHodKostkou;
        private System.Windows.Forms.TextBox txtBoxCelkHodKostkou;
        private System.Windows.Forms.Label lblKostkaCislo;
        private System.Windows.Forms.Label lblCelkSoucet;
        private System.Windows.Forms.Label lblHrac1Soucet;
        private System.Windows.Forms.Label lblHrac2Soucet;
        private System.Windows.Forms.Label lblHrac1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHrac2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

