namespace Lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.createM = new System.Windows.Forms.Button();
            this.backG = new System.Windows.Forms.Button();
            this.nextG = new System.Windows.Forms.Button();
            this.modulsV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.Location = new System.Drawing.Point(2, 1);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(728, 450);
            this.wpfHost.TabIndex = 0;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(736, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 198);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(736, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 231);
            this.label2.TabIndex = 2;
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
            this.modulsV.Location = new System.Drawing.Point(948, 292);
            this.modulsV.Name = "modulsV";
            this.modulsV.Size = new System.Drawing.Size(88, 39);
            this.modulsV.TabIndex = 8;
            this.modulsV.Text = "Уточнити модулі";
            this.modulsV.UseVisualStyleBackColor = true;
            this.modulsV.Click += new System.EventHandler(this.modulsV_Click);
            // 
            // GraphVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 451);
            this.Controls.Add(this.modulsV);
            this.Controls.Add(this.nextG);
            this.Controls.Add(this.backG);
            this.Controls.Add(this.createM);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wpfHost);
            this.Name = "GraphVisual";
            this.Text = "GraphVisual";
            this.Load += new System.EventHandler(this.GraphVisual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button createM;
        private System.Windows.Forms.Button backG;
        private System.Windows.Forms.Button nextG;
        private System.Windows.Forms.Button modulsV;
    }
}