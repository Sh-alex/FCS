namespace Lab1
{
    partial class GraphVisualizer
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
            this.SuspendLayout();
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.Location = new System.Drawing.Point(-1, 0);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(672, 428);
            this.wpfHost.TabIndex = 0;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // Generate
            // 
            this.Generate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Generate.Location = new System.Drawing.Point(677, 40);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(85, 23);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Відобразити";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Reload
            // 
            this.Reload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Reload.Location = new System.Drawing.Point(677, 88);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(85, 23);
            this.Reload.TabIndex = 2;
            this.Reload.Text = "Оновити";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // GraphVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 428);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.wpfHost);
            this.Name = "GraphVisualizer";
            this.Text = "GraphVisualizer";
            this.Load += new System.EventHandler(this.GraphVisualizer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Reload;
    }
}