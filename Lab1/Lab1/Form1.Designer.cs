namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNumberRows = new System.Windows.Forms.Label();
            this.numericRows = new System.Windows.Forms.NumericUpDown();
            this.numberCol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.lNumberCols = new System.Windows.Forms.Label();
            this.numericCols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCols)).BeginInit();
            this.SuspendLayout();
            // 
            // lNumberRows
            // 
            this.lNumberRows.AutoSize = true;
            this.lNumberRows.Location = new System.Drawing.Point(13, 13);
            this.lNumberRows.Name = "lNumberRows";
            this.lNumberRows.Size = new System.Drawing.Size(137, 13);
            this.lNumberRows.TabIndex = 0;
            this.lNumberRows.Text = "Виберіть кількість рядків:";
            // 
            // numericRows
            // 
            this.numericRows.Location = new System.Drawing.Point(168, 13);
            this.numericRows.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericRows.Name = "numericRows";
            this.numericRows.Size = new System.Drawing.Size(35, 20);
            this.numericRows.TabIndex = 1;
            this.numericRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numberCol
            // 
            this.numberCol.AutoSize = true;
            this.numberCol.Location = new System.Drawing.Point(13, 68);
            this.numberCol.Name = "numberCol";
            this.numberCol.Size = new System.Drawing.Size(110, 13);
            this.numberCol.TabIndex = 2;
            this.numberCol.Text = "Кількість елементів:";
            this.numberCol.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Підтвердити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lResult
            // 
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResult.Location = new System.Drawing.Point(488, 13);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(380, 406);
            this.lResult.TabIndex = 4;
            // 
            // lNumberCols
            // 
            this.lNumberCols.AutoSize = true;
            this.lNumberCols.Location = new System.Drawing.Point(16, 40);
            this.lNumberCols.Name = "lNumberCols";
            this.lNumberCols.Size = new System.Drawing.Size(148, 13);
            this.lNumberCols.TabIndex = 5;
            this.lNumberCols.Text = "Виберіть кількість стовпців:";
            // 
            // numericCols
            // 
            this.numericCols.Location = new System.Drawing.Point(167, 38);
            this.numericCols.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCols.Name = "numericCols";
            this.numericCols.Size = new System.Drawing.Size(35, 20);
            this.numericCols.TabIndex = 6;
            this.numericCols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 435);
            this.Controls.Add(this.numericCols);
            this.Controls.Add(this.lNumberCols);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberCol);
            this.Controls.Add(this.numericRows);
            this.Controls.Add(this.lNumberRows);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GKS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumberRows;
        private System.Windows.Forms.NumericUpDown numericRows;
        private System.Windows.Forms.Label numberCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lNumberCols;
        private System.Windows.Forms.NumericUpDown numericCols;
    }
}

