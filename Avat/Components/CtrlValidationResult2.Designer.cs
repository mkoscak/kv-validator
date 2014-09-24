namespace Avat.Components
{
    partial class CtrlValidationResult2
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
            this.flowContent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowContent
            // 
            this.flowContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowContent.AutoScroll = true;
            this.flowContent.Location = new System.Drawing.Point(3, 3);
            this.flowContent.Name = "flowContent";
            this.flowContent.Size = new System.Drawing.Size(554, 406);
            this.flowContent.TabIndex = 1;
            // 
            // CtrlValidationResult2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowContent);
            this.Name = "CtrlValidationResult2";
            this.Size = new System.Drawing.Size(560, 412);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowContent;

    }
}
