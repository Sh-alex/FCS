﻿namespace Lab1
{
    partial class GraphVisual
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
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.Generate = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.createM = new System.Windows.Forms.Button();
            this.backG = new System.Windows.Forms.Button();
            this.nextG = new System.Windows.Forms.Button();
            this.modulsV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.relationsWithM = new System.Windows.Forms.Button();
            this.verificationRelations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.Location = new System.Drawing.Point(2, 1);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(705, 481);
            this.wpfHost.TabIndex = 0;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Location = new System.Drawing.Point(948, 19);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(84, 47);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Відобразити початковий граф";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Reload
            // 
            this.Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload.Location = new System.Drawing.Point(948, 92);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(84, 23);
            this.Reload.TabIndex = 4;
            this.Reload.Text = "Оновити";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // createM
            // 
            this.createM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createM.Location = new System.Drawing.Point(948, 220);
            this.createM.Name = "createM";
            this.createM.Size = new System.Drawing.Size(88, 37);
            this.createM.TabIndex = 5;
            this.createM.Text = "Сформувати модулі";
            this.createM.UseVisualStyleBackColor = true;
            this.createM.Click += new System.EventHandler(this.createM_Click);
            // 
            // backG
            // 
            this.backG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backG.Location = new System.Drawing.Point(948, 159);
            this.backG.Name = "backG";
            this.backG.Size = new System.Drawing.Size(41, 33);
            this.backG.TabIndex = 6;
            this.backG.Text = "<-";
            this.backG.UseVisualStyleBackColor = true;
            this.backG.Click += new System.EventHandler(this.backG_Click);
            // 
            // nextG
            // 
            this.nextG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextG.Location = new System.Drawing.Point(995, 159);
            this.nextG.Name = "nextG";
            this.nextG.Size = new System.Drawing.Size(41, 33);
            this.nextG.TabIndex = 7;
            this.nextG.Text = "->";
            this.nextG.UseVisualStyleBackColor = true;
            this.nextG.Click += new System.EventHandler(this.nextG_Click);
            // 
            // modulsV
            // 
            this.modulsV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modulsV.Location = new System.Drawing.Point(948, 263);
            this.modulsV.Name = "modulsV";
            this.modulsV.Size = new System.Drawing.Size(88, 39);
            this.modulsV.TabIndex = 8;
            this.modulsV.Text = "Уточнити модулі";
            this.modulsV.UseVisualStyleBackColor = true;
            this.modulsV.Click += new System.EventHandler(this.modulsV_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(713, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(229, 215);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(713, 233);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(229, 234);
            this.textBox2.TabIndex = 10;
            // 
            // relationsWithM
            // 
            this.relationsWithM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.relationsWithM.Location = new System.Drawing.Point(948, 343);
            this.relationsWithM.Name = "relationsWithM";
            this.relationsWithM.Size = new System.Drawing.Size(84, 39);
            this.relationsWithM.TabIndex = 11;
            this.relationsWithM.Text = "Визначити зв\'язки";
            this.relationsWithM.UseVisualStyleBackColor = true;
            this.relationsWithM.Click += new System.EventHandler(this.relationsWithM_Click);
            // 
            // verificationRelations
            // 
            this.verificationRelations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verificationRelations.Location = new System.Drawing.Point(948, 388);
            this.verificationRelations.Name = "verificationRelations";
            this.verificationRelations.Size = new System.Drawing.Size(84, 39);
            this.verificationRelations.TabIndex = 12;
            this.verificationRelations.Text = "Оптимізувати структуру";
            this.verificationRelations.UseVisualStyleBackColor = true;
            this.verificationRelations.Click += new System.EventHandler(this.verificationRelations_Click);
            // 
            // GraphVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 482);
            this.Controls.Add(this.verificationRelations);
            this.Controls.Add(this.relationsWithM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modulsV);
            this.Controls.Add(this.nextG);
            this.Controls.Add(this.backG);
            this.Controls.Add(this.createM);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.wpfHost);
            this.Name = "GraphVisual";
            this.Text = "GraphVisual";
            this.Load += new System.EventHandler(this.GraphVisual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button createM;
        private System.Windows.Forms.Button backG;
        private System.Windows.Forms.Button nextG;
        private System.Windows.Forms.Button modulsV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button relationsWithM;
        private System.Windows.Forms.Button verificationRelations;
    }
}