namespace Avat.Components
{
    partial class CtrlFirstRun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progress = new Avat.Components.MyProgress();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(185, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicializujem databázu";
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPercentage.Location = new System.Drawing.Point(55, 128);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(107, 59);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "38%";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(204, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 93);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Tento proces môže trvať aj niekoľko minút \r\nnakoľko sa spracováva celá databáza p" +
                "latiteľov\r\nDPH pre overovanie DIČ vo vašich výkazoch.";
            // 
            // progress
            // 
            this.progress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progress.Location = new System.Drawing.Point(21, 84);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(521, 16);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 0;
            this.progress.Value = 38;
            // 
            // CtrlFirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.Name = "CtrlFirstRun";
            this.Size = new System.Drawing.Size(743, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        internal MyProgress progress;
        internal System.Windows.Forms.Label lblPercentage;
    }
}
