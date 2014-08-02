namespace Avat.Forms
{
    partial class FrmAvat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuXml = new System.Windows.Forms.ToolStrip();
            this.btnIdentification = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnA1 = new System.Windows.Forms.ToolStripButton();
            this.btnA2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnB1 = new System.Windows.Forms.ToolStripButton();
            this.btnB2 = new System.Windows.Forms.ToolStripButton();
            this.btnB3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnC1 = new System.Windows.Forms.ToolStripButton();
            this.btnC2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnD1 = new System.Windows.Forms.ToolStripButton();
            this.btnD2 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuOps = new System.Windows.Forms.ToolStrip();
            this.btnReadXml = new System.Windows.Forms.ToolStripButton();
            this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.btnSaveXml = new System.Windows.Forms.ToolStripButton();
            this.btnOtherOps = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNewAvat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBiznisReport = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStripCorner = new System.Windows.Forms.ToolStrip();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderProgress = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gridData = new Avat.Components.MyDoubleBufferedGrid();
            this.menuXml.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuOps.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuXml
            // 
            this.menuXml.AutoSize = false;
            this.menuXml.BackColor = System.Drawing.Color.White;
            this.menuXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuXml.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuXml.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuXml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIdentification,
            this.toolStripSeparator1,
            this.btnA1,
            this.btnA2,
            this.toolStripSeparator2,
            this.btnB1,
            this.btnB2,
            this.btnB3,
            this.toolStripSeparator3,
            this.btnC1,
            this.btnC2,
            this.toolStripSeparator4,
            this.btnD1,
            this.btnD2});
            this.menuXml.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuXml.Location = new System.Drawing.Point(0, 45);
            this.menuXml.Name = "menuXml";
            this.menuXml.Padding = new System.Windows.Forms.Padding(0);
            this.menuXml.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuXml.Size = new System.Drawing.Size(150, 493);
            this.menuXml.TabIndex = 1;
            this.menuXml.Text = "toolStrip1";
            // 
            // btnIdentification
            // 
            this.btnIdentification.CheckOnClick = true;
            this.btnIdentification.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIdentification.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIdentification.Image = global::Avat.Properties.Resources.identdef;
            this.btnIdentification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdentification.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIdentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIdentification.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnIdentification.Name = "btnIdentification";
            this.btnIdentification.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnIdentification.Size = new System.Drawing.Size(129, 35);
            this.btnIdentification.Text = "Identifikácia";
            this.btnIdentification.Click += new System.EventHandler(this.btnIdentification_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // btnA1
            // 
            this.btnA1.Checked = true;
            this.btnA1.CheckOnClick = true;
            this.btnA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnA1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnA1.Image = ((System.Drawing.Image)(resources.GetObject("btnA1.Image")));
            this.btnA1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnA1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnA1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnA1.Name = "btnA1";
            this.btnA1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnA1.Size = new System.Drawing.Size(129, 40);
            this.btnA1.Text = "A1 (9)";
            this.btnA1.ToolTipText = "A1 - Štandardné odberateľské faktúry (tuzemské)";
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.CheckOnClick = true;
            this.btnA2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnA2.Image = ((System.Drawing.Image)(resources.GetObject("btnA2.Image")));
            this.btnA2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnA2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnA2.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnA2.Name = "btnA2";
            this.btnA2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnA2.Size = new System.Drawing.Size(129, 40);
            this.btnA2.Text = "A2";
            this.btnA2.ToolTipText = "A2 - vybrané transakcie (daň platí príjemca)";
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // btnB1
            // 
            this.btnB1.CheckOnClick = true;
            this.btnB1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnB1.Image = ((System.Drawing.Image)(resources.GetObject("btnB1.Image")));
            this.btnB1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnB1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnB1.Name = "btnB1";
            this.btnB1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnB1.Size = new System.Drawing.Size(129, 40);
            this.btnB1.Text = "B1";
            this.btnB1.ToolTipText = "B1 - prijaté faktúry (daň v tuzemsku)";
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.CheckOnClick = true;
            this.btnB2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnB2.Image = ((System.Drawing.Image)(resources.GetObject("btnB2.Image")));
            this.btnB2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnB2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB2.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnB2.Name = "btnB2";
            this.btnB2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnB2.Size = new System.Drawing.Size(129, 40);
            this.btnB2.Text = "B2";
            this.btnB2.ToolTipText = "B2 - prijaté faktúry (daň platí dodávateľ)";
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.CheckOnClick = true;
            this.btnB3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnB3.Image = ((System.Drawing.Image)(resources.GetObject("btnB3.Image")));
            this.btnB3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnB3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB3.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnB3.Name = "btnB3";
            this.btnB3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnB3.Size = new System.Drawing.Size(129, 40);
            this.btnB3.Text = "B3";
            this.btnB3.ToolTipText = "B3 - celkové sumy základov dane z prijatých zjednodušených faktúr";
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // btnC1
            // 
            this.btnC1.CheckOnClick = true;
            this.btnC1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnC1.Image = ((System.Drawing.Image)(resources.GetObject("btnC1.Image")));
            this.btnC1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnC1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnC1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnC1.Name = "btnC1";
            this.btnC1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnC1.Size = new System.Drawing.Size(129, 40);
            this.btnC1.Text = "C1";
            this.btnC1.ToolTipText = "C1 - opravné faktúry k vystaveným faktúram (okrem ERP)";
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.CheckOnClick = true;
            this.btnC2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnC2.Image = ((System.Drawing.Image)(resources.GetObject("btnC2.Image")));
            this.btnC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnC2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnC2.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnC2.Name = "btnC2";
            this.btnC2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnC2.Size = new System.Drawing.Size(129, 40);
            this.btnC2.Text = "C2";
            this.btnC2.ToolTipText = "C2 - opravné faktúry k prijatým faktúram";
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // btnD1
            // 
            this.btnD1.CheckOnClick = true;
            this.btnD1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnD1.Image = ((System.Drawing.Image)(resources.GetObject("btnD1.Image")));
            this.btnD1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnD1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnD1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnD1.Name = "btnD1";
            this.btnD1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnD1.Size = new System.Drawing.Size(129, 40);
            this.btnD1.Text = "D1";
            this.btnD1.ToolTipText = "D1 - sumár elektronickej registračnej pokladnice (ERP)";
            this.btnD1.Click += new System.EventHandler(this.btnD1_Click);
            // 
            // btnD2
            // 
            this.btnD2.CheckOnClick = true;
            this.btnD2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnD2.Image = ((System.Drawing.Image)(resources.GetObject("btnD2.Image")));
            this.btnD2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnD2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnD2.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnD2.Name = "btnD2";
            this.btnD2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnD2.Size = new System.Drawing.Size(129, 40);
            this.btnD2.Text = "D2";
            this.btnD2.ToolTipText = "D2 - dodanie tovaru alebo služby nezdaniteľným osobám";
            this.btnD2.Click += new System.EventHandler(this.btnD2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuXml, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuOps, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStripCorner, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 538);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuOps
            // 
            this.menuOps.AutoSize = false;
            this.menuOps.BackColor = System.Drawing.Color.GhostWhite;
            this.menuOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuOps.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuOps.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuOps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReadXml,
            this.btnCheckAll,
            this.btnSaveXml,
            this.btnOtherOps});
            this.menuOps.Location = new System.Drawing.Point(150, 0);
            this.menuOps.Name = "menuOps";
            this.menuOps.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.menuOps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuOps.Size = new System.Drawing.Size(842, 45);
            this.menuOps.TabIndex = 2;
            this.menuOps.Text = "toolStrip1";
            // 
            // btnReadXml
            // 
            this.btnReadXml.BackColor = System.Drawing.Color.Transparent;
            this.btnReadXml.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReadXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnReadXml.Image = ((System.Drawing.Image)(resources.GetObject("btnReadXml.Image")));
            this.btnReadXml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReadXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReadXml.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(84, 34);
            this.btnReadXml.Text = "Načítať";
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(106, 34);
            this.btnCheckAll.Text = "Skontrolovať";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveXml.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnSaveXml.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveXml.Image")));
            this.btnSaveXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveXml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveXml.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(68, 34);
            this.btnSaveXml.Text = "Uložiť";
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnOtherOps
            // 
            this.btnOtherOps.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOtherOps.BackColor = System.Drawing.Color.Transparent;
            this.btnOtherOps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewAvat,
            this.toolStripSeparator6,
            this.btnExportToExcel,
            this.btnBiznisReport});
            this.btnOtherOps.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherOps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.btnOtherOps.Image = ((System.Drawing.Image)(resources.GetObject("btnOtherOps.Image")));
            this.btnOtherOps.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOtherOps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOtherOps.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.btnOtherOps.Name = "btnOtherOps";
            this.btnOtherOps.Size = new System.Drawing.Size(130, 34);
            this.btnOtherOps.Text = "Ďalšie operácie";
            // 
            // btnNewAvat
            // 
            this.btnNewAvat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAvat.ForeColor = System.Drawing.Color.Black;
            this.btnNewAvat.Name = "btnNewAvat";
            this.btnNewAvat.Size = new System.Drawing.Size(218, 22);
            this.btnNewAvat.Text = "Nový výkaz";
            this.btnNewAvat.Click += new System.EventHandler(this.btnNewAvat_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(215, 6);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(218, 22);
            this.btnExportToExcel.Text = "Export výkazu do excelu";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnBiznisReport
            // 
            this.btnBiznisReport.Name = "btnBiznisReport";
            this.btnBiznisReport.Size = new System.Drawing.Size(218, 22);
            this.btnBiznisReport.Text = "Biznis report";
            this.btnBiznisReport.Click += new System.EventHandler(this.btnBiznisReport_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.ColumnCount = 1;
            this.panelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContent.Controls.Add(this.lblTitle, 0, 0);
            this.panelContent.Controls.Add(this.gridData, 0, 1);
            this.panelContent.Location = new System.Drawing.Point(153, 48);
            this.panelContent.Name = "panelContent";
            this.panelContent.RowCount = 2;
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContent.Size = new System.Drawing.Size(836, 487);
            this.panelContent.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(836, 49);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "A1 - Štandardné odberateľské faktúry (tuzemské)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripCorner
            // 
            this.toolStripCorner.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCorner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCorner.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCorner.Location = new System.Drawing.Point(0, 0);
            this.toolStripCorner.Name = "toolStripCorner";
            this.toolStripCorner.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripCorner.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripCorner.Size = new System.Drawing.Size(150, 45);
            this.toolStripCorner.TabIndex = 5;
            this.toolStripCorner.Text = "toolStrip1";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.panelHeader.Controls.Add(this.lblHeaderProgress);
            this.panelHeader.Controls.Add(this.lblHeader2);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(992, 65);
            this.panelHeader.TabIndex = 3;
            // 
            // lblHeaderProgress
            // 
            this.lblHeaderProgress.AutoSize = true;
            this.lblHeaderProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderProgress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeaderProgress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderProgress.ForeColor = System.Drawing.Color.White;
            this.lblHeaderProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeaderProgress.Location = new System.Drawing.Point(920, 0);
            this.lblHeaderProgress.Name = "lblHeaderProgress";
            this.lblHeaderProgress.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.lblHeaderProgress.Size = new System.Drawing.Size(72, 41);
            this.lblHeaderProgress.TabIndex = 2;
            this.lblHeaderProgress.Text = "progress..";
            this.lblHeaderProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblHeader2.Text = "KONTROLNÝ VÝKAZ DPH 2014";
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
            // gridData
            // 
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.BackgroundColor = System.Drawing.Color.White;
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.GridColor = System.Drawing.Color.Gainsboro;
            this.gridData.Location = new System.Drawing.Point(1, 50);
            this.gridData.Margin = new System.Windows.Forms.Padding(1);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridData.RowHeadersWidth = 30;
            this.gridData.RowTemplate.Height = 25;
            this.gridData.Size = new System.Drawing.Size(834, 436);
            this.gridData.TabIndex = 6;
            // 
            // FrmAvat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 616);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "FrmAvat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVAT - kontrolný výkaz DPH";
            this.Load += new System.EventHandler(this.FrmDesignOne_Load);
            this.menuXml.ResumeLayout(false);
            this.menuXml.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuOps.ResumeLayout(false);
            this.menuOps.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuXml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnIdentification;
        private System.Windows.Forms.ToolStripButton btnA1;
        private System.Windows.Forms.ToolStripButton btnB2;
        private System.Windows.Forms.ToolStripButton btnA2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnB1;
        private System.Windows.Forms.ToolStripButton btnB3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnC1;
        private System.Windows.Forms.ToolStripButton btnC2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnD1;
        private System.Windows.Forms.ToolStripButton btnD2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip menuOps;
        private System.Windows.Forms.ToolStripButton btnReadXml;
        private System.Windows.Forms.ToolStripButton btnCheckAll;
        private System.Windows.Forms.ToolStripButton btnSaveXml;
        private System.Windows.Forms.ToolStripDropDownButton btnOtherOps;
        private System.Windows.Forms.TableLayoutPanel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem btnExportToExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btnNewAvat;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.ToolStrip toolStripCorner;
        private System.Windows.Forms.Label lblHeaderProgress;
        private System.Windows.Forms.ToolStripMenuItem btnBiznisReport;
        private Avat.Components.MyDoubleBufferedGrid gridData;
    }
}