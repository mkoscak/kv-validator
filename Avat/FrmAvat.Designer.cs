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
            this.toolStripLabelA = new System.Windows.Forms.ToolStripLabel();
            this.btnA1 = new System.Windows.Forms.ToolStripButton();
            this.btnA2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelB = new System.Windows.Forms.ToolStripLabel();
            this.btnB1 = new System.Windows.Forms.ToolStripButton();
            this.btnB2 = new System.Windows.Forms.ToolStripButton();
            this.btnB3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelC = new System.Windows.Forms.ToolStripLabel();
            this.btnC1 = new System.Windows.Forms.ToolStripButton();
            this.btnC2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelD = new System.Windows.Forms.ToolStripLabel();
            this.btnD1 = new System.Windows.Forms.ToolStripButton();
            this.btnD2 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuOps = new System.Windows.Forms.ToolStrip();
            this.btnReadXml = new System.Windows.Forms.ToolStripButton();
            this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.btnSaveXml = new System.Windows.Forms.ToolStripButton();
            this.btnOtherOps = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNewAvat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImportBlackList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportVatPayers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.pixLogo = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gridData = new Avat.Components.MyDoubleBufferedGrid();
            this.menuXml.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuOps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuXml
            // 
            this.menuXml.AutoSize = false;
            this.menuXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuXml.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuXml.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuXml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIdentification,
            this.toolStripSeparator1,
            this.toolStripLabelA,
            this.btnA1,
            this.btnA2,
            this.toolStripSeparator2,
            this.toolStripLabelB,
            this.btnB1,
            this.btnB2,
            this.btnB3,
            this.toolStripSeparator3,
            this.toolStripLabelC,
            this.btnC1,
            this.btnC2,
            this.toolStripSeparator4,
            this.toolStripLabelD,
            this.btnD1,
            this.btnD2});
            this.menuXml.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuXml.Location = new System.Drawing.Point(10, 80);
            this.menuXml.Margin = new System.Windows.Forms.Padding(10);
            this.menuXml.Name = "menuXml";
            this.menuXml.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuXml.Size = new System.Drawing.Size(130, 502);
            this.menuXml.TabIndex = 1;
            this.menuXml.Text = "toolStrip1";
            // 
            // btnIdentification
            // 
            this.btnIdentification.CheckOnClick = true;
            this.btnIdentification.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIdentification.ForeColor = System.Drawing.Color.Gray;
            this.btnIdentification.Image = ((System.Drawing.Image)(resources.GetObject("btnIdentification.Image")));
            this.btnIdentification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIdentification.Name = "btnIdentification";
            this.btnIdentification.Size = new System.Drawing.Size(128, 36);
            this.btnIdentification.Text = "Identifikácia";
            this.btnIdentification.Click += new System.EventHandler(this.btnIdentification_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // toolStripLabelA
            // 
            this.toolStripLabelA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabelA.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripLabelA.Name = "toolStripLabelA";
            this.toolStripLabelA.Size = new System.Drawing.Size(128, 16);
            this.toolStripLabelA.Text = "A";
            this.toolStripLabelA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnA1
            // 
            this.btnA1.Checked = true;
            this.btnA1.CheckOnClick = true;
            this.btnA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnA1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA1.ForeColor = System.Drawing.Color.Gray;
            this.btnA1.Image = ((System.Drawing.Image)(resources.GetObject("btnA1.Image")));
            this.btnA1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(128, 36);
            this.btnA1.Text = "A1 (9)";
            this.btnA1.ToolTipText = "A1 - Štandardné odberateľské faktúry (tuzemské)";
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.CheckOnClick = true;
            this.btnA2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA2.ForeColor = System.Drawing.Color.Gray;
            this.btnA2.Image = ((System.Drawing.Image)(resources.GetObject("btnA2.Image")));
            this.btnA2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(128, 36);
            this.btnA2.Text = "A2";
            this.btnA2.ToolTipText = "A2 - vybrané transakcie (daň platí príjemca)";
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // toolStripLabelB
            // 
            this.toolStripLabelB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabelB.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripLabelB.Name = "toolStripLabelB";
            this.toolStripLabelB.Size = new System.Drawing.Size(128, 16);
            this.toolStripLabelB.Text = "B";
            this.toolStripLabelB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnB1
            // 
            this.btnB1.CheckOnClick = true;
            this.btnB1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB1.ForeColor = System.Drawing.Color.Gray;
            this.btnB1.Image = ((System.Drawing.Image)(resources.GetObject("btnB1.Image")));
            this.btnB1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(128, 36);
            this.btnB1.Text = "B1";
            this.btnB1.ToolTipText = "B1 - prijaté faktúry (daň v tuzemsku)";
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.CheckOnClick = true;
            this.btnB2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB2.ForeColor = System.Drawing.Color.Gray;
            this.btnB2.Image = ((System.Drawing.Image)(resources.GetObject("btnB2.Image")));
            this.btnB2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(128, 36);
            this.btnB2.Text = "B2";
            this.btnB2.ToolTipText = "B2 - prijaté faktúry (daň platí dodávateľ)";
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.CheckOnClick = true;
            this.btnB3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB3.ForeColor = System.Drawing.Color.Gray;
            this.btnB3.Image = ((System.Drawing.Image)(resources.GetObject("btnB3.Image")));
            this.btnB3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(128, 36);
            this.btnB3.Text = "B3";
            this.btnB3.ToolTipText = "B3 - celkové sumy základov dane z prijatých zjednodušených faktúr";
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(128, 6);
            // 
            // toolStripLabelC
            // 
            this.toolStripLabelC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabelC.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripLabelC.Name = "toolStripLabelC";
            this.toolStripLabelC.Size = new System.Drawing.Size(128, 16);
            this.toolStripLabelC.Text = "C";
            this.toolStripLabelC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnC1
            // 
            this.btnC1.CheckOnClick = true;
            this.btnC1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC1.ForeColor = System.Drawing.Color.Gray;
            this.btnC1.Image = ((System.Drawing.Image)(resources.GetObject("btnC1.Image")));
            this.btnC1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(128, 36);
            this.btnC1.Text = "C1";
            this.btnC1.ToolTipText = "C1 - opravné faktúry k vystaveným faktúram (okrem ERP)";
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.CheckOnClick = true;
            this.btnC2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC2.ForeColor = System.Drawing.Color.Gray;
            this.btnC2.Image = ((System.Drawing.Image)(resources.GetObject("btnC2.Image")));
            this.btnC2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(128, 36);
            this.btnC2.Text = "C2";
            this.btnC2.ToolTipText = "C2 - opravné faktúry k prijatým faktúram";
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(128, 6);
            // 
            // toolStripLabelD
            // 
            this.toolStripLabelD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabelD.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripLabelD.Name = "toolStripLabelD";
            this.toolStripLabelD.Size = new System.Drawing.Size(128, 16);
            this.toolStripLabelD.Text = "D";
            this.toolStripLabelD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnD1
            // 
            this.btnD1.CheckOnClick = true;
            this.btnD1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD1.ForeColor = System.Drawing.Color.Gray;
            this.btnD1.Image = ((System.Drawing.Image)(resources.GetObject("btnD1.Image")));
            this.btnD1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnD1.Name = "btnD1";
            this.btnD1.Size = new System.Drawing.Size(128, 36);
            this.btnD1.Text = "D1";
            this.btnD1.ToolTipText = "D1 - sumár elektronickej registračnej pokladnice (ERP)";
            this.btnD1.Click += new System.EventHandler(this.btnD1_Click);
            // 
            // btnD2
            // 
            this.btnD2.CheckOnClick = true;
            this.btnD2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD2.ForeColor = System.Drawing.Color.Gray;
            this.btnD2.Image = ((System.Drawing.Image)(resources.GetObject("btnD2.Image")));
            this.btnD2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(128, 36);
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
            this.tableLayoutPanel1.Controls.Add(this.pixLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelContent, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 592);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // menuOps
            // 
            this.menuOps.AutoSize = false;
            this.menuOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuOps.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuOps.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuOps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReadXml,
            this.btnCheckAll,
            this.btnSaveXml,
            this.btnOtherOps});
            this.menuOps.Location = new System.Drawing.Point(160, 10);
            this.menuOps.Margin = new System.Windows.Forms.Padding(10);
            this.menuOps.Name = "menuOps";
            this.menuOps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuOps.Size = new System.Drawing.Size(798, 50);
            this.menuOps.TabIndex = 2;
            this.menuOps.Text = "toolStrip1";
            // 
            // btnReadXml
            // 
            this.btnReadXml.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReadXml.ForeColor = System.Drawing.Color.Gray;
            this.btnReadXml.Image = ((System.Drawing.Image)(resources.GetObject("btnReadXml.Image")));
            this.btnReadXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(112, 47);
            this.btnReadXml.Text = "Načítať KV";
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckAll.ForeColor = System.Drawing.Color.Gray;
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(148, 47);
            this.btnCheckAll.Text = "Skontrolovať KV";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveXml.ForeColor = System.Drawing.Color.Gray;
            this.btnSaveXml.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveXml.Image")));
            this.btnSaveXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(104, 47);
            this.btnSaveXml.Text = "Uložiť KV";
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnOtherOps
            // 
            this.btnOtherOps.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOtherOps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewAvat,
            this.toolStripSeparator5,
            this.btnImportBlackList,
            this.btnImportVatPayers,
            this.toolStripSeparator6,
            this.btnExportToExcel});
            this.btnOtherOps.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOtherOps.ForeColor = System.Drawing.Color.Gray;
            this.btnOtherOps.Image = ((System.Drawing.Image)(resources.GetObject("btnOtherOps.Image")));
            this.btnOtherOps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOtherOps.Name = "btnOtherOps";
            this.btnOtherOps.Size = new System.Drawing.Size(152, 47);
            this.btnOtherOps.Text = "Ďalšie operácie";
            // 
            // btnNewAvat
            // 
            this.btnNewAvat.Name = "btnNewAvat";
            this.btnNewAvat.Size = new System.Drawing.Size(232, 22);
            this.btnNewAvat.Text = "Nový výkaz";
            this.btnNewAvat.Click += new System.EventHandler(this.btnNewAvat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(229, 6);
            // 
            // btnImportBlackList
            // 
            this.btnImportBlackList.Name = "btnImportBlackList";
            this.btnImportBlackList.Size = new System.Drawing.Size(232, 22);
            this.btnImportBlackList.Text = "Import black-list";
            this.btnImportBlackList.Click += new System.EventHandler(this.btnImportBlackList_Click);
            // 
            // btnImportVatPayers
            // 
            this.btnImportVatPayers.Name = "btnImportVatPayers";
            this.btnImportVatPayers.Size = new System.Drawing.Size(232, 22);
            this.btnImportVatPayers.Text = "Import platcov";
            this.btnImportVatPayers.Click += new System.EventHandler(this.btnImportVatPayers_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(229, 6);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(232, 22);
            this.btnExportToExcel.Text = "Export výkazu do excelu";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // pixLogo
            // 
            this.pixLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pixLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixLogo.ErrorImage = null;
            this.pixLogo.Image = ((System.Drawing.Image)(resources.GetObject("pixLogo.Image")));
            this.pixLogo.InitialImage = null;
            this.pixLogo.Location = new System.Drawing.Point(3, 3);
            this.pixLogo.Name = "pixLogo";
            this.pixLogo.Size = new System.Drawing.Size(144, 64);
            this.pixLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pixLogo.TabIndex = 3;
            this.pixLogo.TabStop = false;
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
            this.panelContent.Location = new System.Drawing.Point(153, 73);
            this.panelContent.Name = "panelContent";
            this.panelContent.RowCount = 2;
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContent.Size = new System.Drawing.Size(812, 516);
            this.panelContent.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "A1 - Štandardné odberateľské faktúry (tuzemské)";
            // 
            // gridData
            // 
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridData.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Location = new System.Drawing.Point(3, 43);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridData.RowHeadersWidth = 30;
            this.gridData.RowTemplate.Height = 25;
            this.gridData.Size = new System.Drawing.Size(806, 470);
            this.gridData.TabIndex = 6;
            this.gridData.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.gridData_CellToolTipTextNeeded);
            // 
            // FrmAvat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(992, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "FrmAvat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aVat";
            this.Load += new System.EventHandler(this.FrmDesignOne_Load);
            this.menuXml.ResumeLayout(false);
            this.menuXml.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuOps.ResumeLayout(false);
            this.menuOps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabelA;
        private System.Windows.Forms.ToolStripLabel toolStripLabelB;
        private System.Windows.Forms.ToolStripLabel toolStripLabelC;
        private System.Windows.Forms.ToolStripLabel toolStripLabelD;
        private System.Windows.Forms.ToolStripButton btnD1;
        private System.Windows.Forms.ToolStripButton btnD2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip menuOps;
        private System.Windows.Forms.ToolStripButton btnReadXml;
        private System.Windows.Forms.ToolStripButton btnCheckAll;
        private System.Windows.Forms.ToolStripButton btnSaveXml;
        private System.Windows.Forms.PictureBox pixLogo;
        private System.Windows.Forms.ToolStripDropDownButton btnOtherOps;
        private System.Windows.Forms.TableLayoutPanel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem btnImportBlackList;
        private System.Windows.Forms.ToolStripMenuItem btnImportVatPayers;
        private Avat.Components.MyDoubleBufferedGrid gridData;
        private System.Windows.Forms.ToolStripMenuItem btnExportToExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btnNewAvat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}