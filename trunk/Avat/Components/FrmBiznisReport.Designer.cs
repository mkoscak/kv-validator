namespace Avat.Components
{
    partial class FrmBiznisReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblIcDph = new System.Windows.Forms.Label();
            this.lblpPocPrij = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.grpPrij = new System.Windows.Forms.GroupBox();
            this.lblpDanPrij = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpSumaPrij = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpVyst = new System.Windows.Forms.GroupBox();
            this.lblpDanVyst = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpSumaVyst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblpPocVyst = new System.Windows.Forms.Label();
            this.lblpBilancia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpOdb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblpDod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabSumar = new System.Windows.Forms.TabPage();
            this.tabTopOdb = new System.Windows.Forms.TabPage();
            this.gridTopOdb = new Avat.Components.MyDoubleBufferedGrid();
            this.tabTopDod = new System.Windows.Forms.TabPage();
            this.gridTopDod = new Avat.Components.MyDoubleBufferedGrid();
            this.panelHeader.SuspendLayout();
            this.grpPrij.SuspendLayout();
            this.grpVyst.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabSumar.SuspendLayout();
            this.tabTopOdb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopOdb)).BeginInit();
            this.tabTopDod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopDod)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(195)))));
            this.panelHeader.Controls.Add(this.lblHeader2);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(587, 65);
            this.panelHeader.TabIndex = 4;
            // 
            // lblHeader2
            // 
            this.lblHeader2.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.ForeColor = System.Drawing.Color.White;
            this.lblHeader2.Location = new System.Drawing.Point(139, 0);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblHeader2.Size = new System.Drawing.Size(326, 65);
            this.lblHeader2.TabIndex = 1;
            this.lblHeader2.Text = "Biznis report";
            this.lblHeader2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(139, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "AVAT";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnClose.Location = new System.Drawing.Point(470, 427);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 26);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "&Zatvoriť";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblIcDph
            // 
            this.lblIcDph.AutoSize = true;
            this.lblIcDph.BackColor = System.Drawing.Color.Transparent;
            this.lblIcDph.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIcDph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.lblIcDph.Location = new System.Drawing.Point(13, 32);
            this.lblIcDph.Margin = new System.Windows.Forms.Padding(10);
            this.lblIcDph.Name = "lblIcDph";
            this.lblIcDph.Size = new System.Drawing.Size(95, 18);
            this.lblIcDph.TabIndex = 7;
            this.lblIcDph.Text = "Počet faktúr:";
            // 
            // lblpPocPrij
            // 
            this.lblpPocPrij.AutoSize = true;
            this.lblpPocPrij.BackColor = System.Drawing.Color.Transparent;
            this.lblpPocPrij.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpPocPrij.ForeColor = System.Drawing.Color.Green;
            this.lblpPocPrij.Location = new System.Drawing.Point(128, 32);
            this.lblpPocPrij.Margin = new System.Windows.Forms.Padding(10);
            this.lblpPocPrij.Name = "lblpPocPrij";
            this.lblpPocPrij.Size = new System.Drawing.Size(17, 18);
            this.lblpPocPrij.TabIndex = 8;
            this.lblpPocPrij.Text = "0";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportReport.BackColor = System.Drawing.Color.Transparent;
            this.btnExportReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnExportReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnExportReport.Location = new System.Drawing.Point(360, 427);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(100, 26);
            this.btnExportReport.TabIndex = 47;
            this.btnExportReport.TabStop = false;
            this.btnExportReport.Text = "&Uložiť report";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // grpPrij
            // 
            this.grpPrij.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPrij.Controls.Add(this.lblpDanPrij);
            this.grpPrij.Controls.Add(this.label3);
            this.grpPrij.Controls.Add(this.lblpSumaPrij);
            this.grpPrij.Controls.Add(this.label1);
            this.grpPrij.Controls.Add(this.lblIcDph);
            this.grpPrij.Controls.Add(this.lblpPocPrij);
            this.grpPrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrij.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(195)))));
            this.grpPrij.Location = new System.Drawing.Point(6, 6);
            this.grpPrij.Name = "grpPrij";
            this.grpPrij.Size = new System.Drawing.Size(269, 151);
            this.grpPrij.TabIndex = 48;
            this.grpPrij.TabStop = false;
            this.grpPrij.Text = "Prijaté faktúry";
            // 
            // lblpDanPrij
            // 
            this.lblpDanPrij.AutoSize = true;
            this.lblpDanPrij.BackColor = System.Drawing.Color.Transparent;
            this.lblpDanPrij.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpDanPrij.ForeColor = System.Drawing.Color.Green;
            this.lblpDanPrij.Location = new System.Drawing.Point(128, 108);
            this.lblpDanPrij.Margin = new System.Windows.Forms.Padding(10);
            this.lblpDanPrij.Name = "lblpDanPrij";
            this.lblpDanPrij.Size = new System.Drawing.Size(17, 18);
            this.lblpDanPrij.TabIndex = 12;
            this.lblpDanPrij.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Suma dane:";
            // 
            // lblpSumaPrij
            // 
            this.lblpSumaPrij.AutoSize = true;
            this.lblpSumaPrij.BackColor = System.Drawing.Color.Transparent;
            this.lblpSumaPrij.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpSumaPrij.ForeColor = System.Drawing.Color.Green;
            this.lblpSumaPrij.Location = new System.Drawing.Point(128, 70);
            this.lblpSumaPrij.Margin = new System.Windows.Forms.Padding(10);
            this.lblpSumaPrij.Name = "lblpSumaPrij";
            this.lblpSumaPrij.Size = new System.Drawing.Size(17, 18);
            this.lblpSumaPrij.TabIndex = 10;
            this.lblpSumaPrij.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suma faktúr:";
            // 
            // grpVyst
            // 
            this.grpVyst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpVyst.Controls.Add(this.lblpDanVyst);
            this.grpVyst.Controls.Add(this.label4);
            this.grpVyst.Controls.Add(this.lblpSumaVyst);
            this.grpVyst.Controls.Add(this.label6);
            this.grpVyst.Controls.Add(this.label7);
            this.grpVyst.Controls.Add(this.lblpPocVyst);
            this.grpVyst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVyst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(195)))));
            this.grpVyst.Location = new System.Drawing.Point(281, 6);
            this.grpVyst.Name = "grpVyst";
            this.grpVyst.Size = new System.Drawing.Size(269, 151);
            this.grpVyst.TabIndex = 49;
            this.grpVyst.TabStop = false;
            this.grpVyst.Text = "Vystavené faktúry";
            // 
            // lblpDanVyst
            // 
            this.lblpDanVyst.AutoSize = true;
            this.lblpDanVyst.BackColor = System.Drawing.Color.Transparent;
            this.lblpDanVyst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpDanVyst.ForeColor = System.Drawing.Color.Green;
            this.lblpDanVyst.Location = new System.Drawing.Point(128, 108);
            this.lblpDanVyst.Margin = new System.Windows.Forms.Padding(10);
            this.lblpDanVyst.Name = "lblpDanVyst";
            this.lblpDanVyst.Size = new System.Drawing.Size(17, 18);
            this.lblpDanVyst.TabIndex = 12;
            this.lblpDanVyst.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Suma dane:";
            // 
            // lblpSumaVyst
            // 
            this.lblpSumaVyst.AutoSize = true;
            this.lblpSumaVyst.BackColor = System.Drawing.Color.Transparent;
            this.lblpSumaVyst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpSumaVyst.ForeColor = System.Drawing.Color.Green;
            this.lblpSumaVyst.Location = new System.Drawing.Point(128, 70);
            this.lblpSumaVyst.Margin = new System.Windows.Forms.Padding(10);
            this.lblpSumaVyst.Name = "lblpSumaVyst";
            this.lblpSumaVyst.Size = new System.Drawing.Size(17, 18);
            this.lblpSumaVyst.TabIndex = 10;
            this.lblpSumaVyst.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(13, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Suma faktúr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(13, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Počet faktúr:";
            // 
            // lblpPocVyst
            // 
            this.lblpPocVyst.AutoSize = true;
            this.lblpPocVyst.BackColor = System.Drawing.Color.Transparent;
            this.lblpPocVyst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpPocVyst.ForeColor = System.Drawing.Color.Green;
            this.lblpPocVyst.Location = new System.Drawing.Point(128, 32);
            this.lblpPocVyst.Margin = new System.Windows.Forms.Padding(10);
            this.lblpPocVyst.Name = "lblpPocVyst";
            this.lblpPocVyst.Size = new System.Drawing.Size(17, 18);
            this.lblpPocVyst.TabIndex = 8;
            this.lblpPocVyst.Text = "0";
            // 
            // lblpBilancia
            // 
            this.lblpBilancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpBilancia.AutoSize = true;
            this.lblpBilancia.BackColor = System.Drawing.Color.Transparent;
            this.lblpBilancia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpBilancia.ForeColor = System.Drawing.Color.Green;
            this.lblpBilancia.Location = new System.Drawing.Point(295, 170);
            this.lblpBilancia.Margin = new System.Windows.Forms.Padding(10);
            this.lblpBilancia.Name = "lblpBilancia";
            this.lblpBilancia.Size = new System.Drawing.Size(17, 18);
            this.lblpBilancia.TabIndex = 51;
            this.lblpBilancia.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(207, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Bilancia:";
            // 
            // lblpOdb
            // 
            this.lblpOdb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpOdb.AutoSize = true;
            this.lblpOdb.BackColor = System.Drawing.Color.Transparent;
            this.lblpOdb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpOdb.ForeColor = System.Drawing.Color.Green;
            this.lblpOdb.Location = new System.Drawing.Point(295, 208);
            this.lblpOdb.Margin = new System.Windows.Forms.Padding(10);
            this.lblpOdb.Name = "lblpOdb";
            this.lblpOdb.Size = new System.Drawing.Size(17, 18);
            this.lblpOdb.TabIndex = 53;
            this.lblpOdb.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(51, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "Počet odberateľov z black-listu:";
            // 
            // lblpDod
            // 
            this.lblpDod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpDod.AutoSize = true;
            this.lblpDod.BackColor = System.Drawing.Color.Transparent;
            this.lblpDod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpDod.ForeColor = System.Drawing.Color.Green;
            this.lblpDod.Location = new System.Drawing.Point(295, 246);
            this.lblpDod.Margin = new System.Windows.Forms.Padding(10);
            this.lblpDod.Name = "lblpDod";
            this.lblpDod.Size = new System.Drawing.Size(17, 18);
            this.lblpDod.TabIndex = 55;
            this.lblpDod.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.label9.Location = new System.Drawing.Point(49, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "Počet dodávateľov z black-listu:";
            // 
            // tabReports
            // 
            this.tabReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabReports.Controls.Add(this.tabSumar);
            this.tabReports.Controls.Add(this.tabTopOdb);
            this.tabReports.Controls.Add(this.tabTopDod);
            this.tabReports.Location = new System.Drawing.Point(8, 68);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(567, 356);
            this.tabReports.TabIndex = 56;
            // 
            // tabSumar
            // 
            this.tabSumar.Controls.Add(this.grpPrij);
            this.tabSumar.Controls.Add(this.lblpDod);
            this.tabSumar.Controls.Add(this.grpVyst);
            this.tabSumar.Controls.Add(this.label9);
            this.tabSumar.Controls.Add(this.label5);
            this.tabSumar.Controls.Add(this.lblpOdb);
            this.tabSumar.Controls.Add(this.lblpBilancia);
            this.tabSumar.Controls.Add(this.label8);
            this.tabSumar.Location = new System.Drawing.Point(4, 22);
            this.tabSumar.Name = "tabSumar";
            this.tabSumar.Padding = new System.Windows.Forms.Padding(3);
            this.tabSumar.Size = new System.Drawing.Size(559, 330);
            this.tabSumar.TabIndex = 0;
            this.tabSumar.Text = "Štatistika výkazu";
            this.tabSumar.UseVisualStyleBackColor = true;
            // 
            // tabTopOdb
            // 
            this.tabTopOdb.Controls.Add(this.gridTopOdb);
            this.tabTopOdb.Location = new System.Drawing.Point(4, 22);
            this.tabTopOdb.Name = "tabTopOdb";
            this.tabTopOdb.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopOdb.Size = new System.Drawing.Size(559, 330);
            this.tabTopOdb.TabIndex = 1;
            this.tabTopOdb.Text = "Top 5 odberateľských transakcií";
            this.tabTopOdb.UseVisualStyleBackColor = true;
            // 
            // gridTopOdb
            // 
            this.gridTopOdb.AllowUserToAddRows = false;
            this.gridTopOdb.AllowUserToDeleteRows = false;
            this.gridTopOdb.AllowUserToOrderColumns = true;
            this.gridTopOdb.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gridTopOdb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTopOdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTopOdb.BackgroundColor = System.Drawing.Color.White;
            this.gridTopOdb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTopOdb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTopOdb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTopOdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTopOdb.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridTopOdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTopOdb.EnableHeadersVisualStyles = false;
            this.gridTopOdb.GridColor = System.Drawing.Color.Gainsboro;
            this.gridTopOdb.Location = new System.Drawing.Point(3, 3);
            this.gridTopOdb.Margin = new System.Windows.Forms.Padding(1);
            this.gridTopOdb.Name = "gridTopOdb";
            this.gridTopOdb.ReadOnly = true;
            this.gridTopOdb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTopOdb.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridTopOdb.RowHeadersWidth = 30;
            this.gridTopOdb.RowTemplate.Height = 25;
            this.gridTopOdb.Size = new System.Drawing.Size(553, 324);
            this.gridTopOdb.TabIndex = 6;
            // 
            // tabTopDod
            // 
            this.tabTopDod.Controls.Add(this.gridTopDod);
            this.tabTopDod.Location = new System.Drawing.Point(4, 22);
            this.tabTopDod.Name = "tabTopDod";
            this.tabTopDod.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopDod.Size = new System.Drawing.Size(559, 330);
            this.tabTopDod.TabIndex = 2;
            this.tabTopDod.Text = "Top 5 dodávateľských transakcií";
            this.tabTopDod.UseVisualStyleBackColor = true;
            // 
            // gridTopDod
            // 
            this.gridTopDod.AllowUserToAddRows = false;
            this.gridTopDod.AllowUserToDeleteRows = false;
            this.gridTopDod.AllowUserToOrderColumns = true;
            this.gridTopDod.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gridTopDod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridTopDod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTopDod.BackgroundColor = System.Drawing.Color.White;
            this.gridTopDod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTopDod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTopDod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridTopDod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTopDod.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridTopDod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTopDod.EnableHeadersVisualStyles = false;
            this.gridTopDod.GridColor = System.Drawing.Color.Gainsboro;
            this.gridTopDod.Location = new System.Drawing.Point(3, 3);
            this.gridTopDod.Margin = new System.Windows.Forms.Padding(1);
            this.gridTopDod.Name = "gridTopDod";
            this.gridTopDod.ReadOnly = true;
            this.gridTopDod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTopDod.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridTopDod.RowHeadersWidth = 30;
            this.gridTopDod.RowTemplate.Height = 25;
            this.gridTopDod.Size = new System.Drawing.Size(553, 324);
            this.gridTopDod.TabIndex = 6;
            // 
            // FrmBiznisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 466);
            this.Controls.Add(this.tabReports);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 500);
            this.Name = "FrmBiznisReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biznis report";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmValidationResult_KeyDown);
            this.panelHeader.ResumeLayout(false);
            this.grpPrij.ResumeLayout(false);
            this.grpPrij.PerformLayout();
            this.grpVyst.ResumeLayout(false);
            this.grpVyst.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabSumar.ResumeLayout(false);
            this.tabSumar.PerformLayout();
            this.tabTopOdb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTopOdb)).EndInit();
            this.tabTopDod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTopDod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label lblIcDph;
        internal System.Windows.Forms.Label lblpPocPrij;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.GroupBox grpPrij;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblpSumaPrij;
        internal System.Windows.Forms.Label lblpDanPrij;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpVyst;
        internal System.Windows.Forms.Label lblpDanVyst;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblpSumaVyst;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lblpPocVyst;
        internal System.Windows.Forms.Label lblpBilancia;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblpOdb;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblpDod;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabSumar;
        private System.Windows.Forms.TabPage tabTopOdb;
        private System.Windows.Forms.TabPage tabTopDod;
        private MyDoubleBufferedGrid gridTopDod;
        private MyDoubleBufferedGrid gridTopOdb;
    }
}