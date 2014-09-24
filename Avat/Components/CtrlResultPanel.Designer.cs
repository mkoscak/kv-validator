namespace Avat.Components
{
    partial class CtrlResultPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlResultPanel));
            this.panelLine = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblErrorCount = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelLine.Location = new System.Drawing.Point(0, 55);
            this.panelLine.Margin = new System.Windows.Forms.Padding(0);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(518, 2);
            this.panelLine.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(20, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(386, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nazov";
            // 
            // lblErrorCount
            // 
            this.lblErrorCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErrorCount.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCount.Location = new System.Drawing.Point(412, 23);
            this.lblErrorCount.Name = "lblErrorCount";
            this.lblErrorCount.Size = new System.Drawing.Size(86, 18);
            this.lblErrorCount.TabIndex = 2;
            this.lblErrorCount.Text = "2 chyby";
            this.lblErrorCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.txtError.Location = new System.Drawing.Point(24, 71);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(474, 49);
            this.txtError.TabIndex = 3;
            this.txtError.TabStop = false;
            this.txtError.Text = resources.GetString("txtError.Text");
            // 
            // CtrlResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblErrorCount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelLine);
            this.MinimumSize = new System.Drawing.Size(518, 137);
            this.Name = "CtrlResultPanel";
            this.Size = new System.Drawing.Size(518, 137);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblErrorCount;
        private System.Windows.Forms.TextBox txtError;
    }
}
