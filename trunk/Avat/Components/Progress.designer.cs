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
            this.lblCurrentOp = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblProgrress = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar = new Avat.Components.MyProgress();
            this.SuspendLayout();
            // 
            // lblCurrentOp
            // 
            this.lblCurrentOp.AutoSize = true;
            this.lblCurrentOp.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentOp.Location = new System.Drawing.Point(9, 9);
            this.lblCurrentOp.Name = "lblCurrentOp";
            this.lblCurrentOp.Size = new System.Drawing.Size(99, 13);
            this.lblCurrentOp.TabIndex = 1;
            this.lblCurrentOp.Text = "Aktuálna operácia: ";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.ForeColor = System.Drawing.Color.Gray;
            this.lblOp.Location = new System.Drawing.Point(114, 9);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(44, 13);
            this.lblOp.TabIndex = 2;
            this.lblOp.Text = "žiadna";
            // 
            // lblProgrress
            // 
            this.lblProgrress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgrress.AutoSize = true;
            this.lblProgrress.ForeColor = System.Drawing.Color.Gray;
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
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.ForeColor = System.Drawing.Color.Gray;
            this.lblProg.Location = new System.Drawing.Point(114, 54);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(44, 13);
            this.lblProg.TabIndex = 4;
            this.lblProg.Text = "žiadna";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(398, 68);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(486, 26);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(510, 131);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblProgrress);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblCurrentOp);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(526, 147);
            this.Name = "Progress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Priebeh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentOp;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblProgrress;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Button btnCancel;
        private MyProgress progressBar;
    }
}