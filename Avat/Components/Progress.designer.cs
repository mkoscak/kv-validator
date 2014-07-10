namespace Avat.Components
{
    partial class Progress
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCurrentOp = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblProgrress = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(486, 26);
            this.progressBar.TabIndex = 0;
            // 
            // lblCurrentOp
            // 
            this.lblCurrentOp.AutoSize = true;
            this.lblCurrentOp.Location = new System.Drawing.Point(9, 9);
            this.lblCurrentOp.Name = "lblCurrentOp";
            this.lblCurrentOp.Size = new System.Drawing.Size(99, 13);
            this.lblCurrentOp.TabIndex = 1;
            this.lblCurrentOp.Text = "Aktuálna operácia: ";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(114, 9);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(38, 13);
            this.lblOp.TabIndex = 2;
            this.lblOp.Text = "žiadna";
            // 
            // lblProgrress
            // 
            this.lblProgrress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgrress.AutoSize = true;
            this.lblProgrress.Location = new System.Drawing.Point(9, 54);
            this.lblProgrress.Name = "lblProgrress";
            this.lblProgrress.Size = new System.Drawing.Size(49, 13);
            this.lblProgrress.TabIndex = 3;
            this.lblProgrress.Text = "Priebeh: ";
            // 
            // lblProg
            // 
            this.lblProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProg.AutoSize = true;
            this.lblProg.Location = new System.Drawing.Point(114, 54);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(38, 13);
            this.lblProg.TabIndex = 4;
            this.lblProg.Text = "žiadna";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(398, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 112);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblProgrress);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblCurrentOp);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(526, 150);
            this.Name = "Progress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Priebeh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCurrentOp;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblProgrress;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Button btnCancel;
    }
}