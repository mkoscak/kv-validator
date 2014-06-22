namespace VAToo
{
    partial class FrmVatoo
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
            this.layoutMain = new VAToo.Components.MyTableLayout();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelIdent = new System.Windows.Forms.Panel();
            this.btnD2 = new System.Windows.Forms.RadioButton();
            this.btnD1 = new System.Windows.Forms.RadioButton();
            this.btnC2 = new System.Windows.Forms.RadioButton();
            this.btnC1 = new System.Windows.Forms.RadioButton();
            this.btnB3 = new System.Windows.Forms.RadioButton();
            this.btnB2 = new System.Windows.Forms.RadioButton();
            this.btnB1 = new System.Windows.Forms.RadioButton();
            this.btnA2 = new System.Windows.Forms.RadioButton();
            this.btnA1 = new System.Windows.Forms.RadioButton();
            this.btnIdentifikacia = new System.Windows.Forms.RadioButton();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridTmp = new VAToo.Components.MyDoubleBufferedGrid();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btnOtherOps = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelIdent.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTmp)).BeginInit();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.picLogo, 0, 0);
            this.layoutMain.Controls.Add(this.panelIdent, 0, 1);
            this.layoutMain.Controls.Add(this.panelGrid, 1, 1);
            this.layoutMain.Controls.Add(this.panelOperations, 1, 0);
            this.layoutMain.Location = new System.Drawing.Point(12, 12);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(883, 617);
            this.layoutMain.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.ErrorImage = null;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(194, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // panelIdent
            // 
            this.panelIdent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelIdent.Controls.Add(this.btnD2);
            this.panelIdent.Controls.Add(this.btnD1);
            this.panelIdent.Controls.Add(this.btnC2);
            this.panelIdent.Controls.Add(this.btnC1);
            this.panelIdent.Controls.Add(this.btnB3);
            this.panelIdent.Controls.Add(this.btnB2);
            this.panelIdent.Controls.Add(this.btnB1);
            this.panelIdent.Controls.Add(this.btnA2);
            this.panelIdent.Controls.Add(this.btnA1);
            this.panelIdent.Controls.Add(this.btnIdentifikacia);
            this.panelIdent.Location = new System.Drawing.Point(3, 103);
            this.panelIdent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelIdent.Name = "panelIdent";
            this.panelIdent.Size = new System.Drawing.Size(197, 511);
            this.panelIdent.TabIndex = 2;
            // 
            // btnD2
            // 
            this.btnD2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnD2.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnD2.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnD2.FlatAppearance.BorderSize = 0;
            this.btnD2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD2.ForeColor = System.Drawing.Color.White;
            this.btnD2.Location = new System.Drawing.Point(3, 462);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(188, 45);
            this.btnD2.TabIndex = 9;
            this.btnD2.Text = "D2";
            this.btnD2.UseVisualStyleBackColor = false;
            // 
            // btnD1
            // 
            this.btnD1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnD1.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnD1.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnD1.FlatAppearance.BorderSize = 0;
            this.btnD1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD1.ForeColor = System.Drawing.Color.White;
            this.btnD1.Location = new System.Drawing.Point(3, 411);
            this.btnD1.Name = "btnD1";
            this.btnD1.Size = new System.Drawing.Size(188, 45);
            this.btnD1.TabIndex = 8;
            this.btnD1.Text = "D1";
            this.btnD1.UseVisualStyleBackColor = false;
            // 
            // btnC2
            // 
            this.btnC2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnC2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnC2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnC2.FlatAppearance.BorderSize = 0;
            this.btnC2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC2.ForeColor = System.Drawing.Color.White;
            this.btnC2.Location = new System.Drawing.Point(3, 360);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(188, 45);
            this.btnC2.TabIndex = 7;
            this.btnC2.Text = "C2";
            this.btnC2.UseVisualStyleBackColor = false;
            // 
            // btnC1
            // 
            this.btnC1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnC1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnC1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnC1.FlatAppearance.BorderSize = 0;
            this.btnC1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC1.ForeColor = System.Drawing.Color.White;
            this.btnC1.Location = new System.Drawing.Point(3, 309);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(188, 45);
            this.btnC1.TabIndex = 6;
            this.btnC1.Text = "C1";
            this.btnC1.UseVisualStyleBackColor = false;
            // 
            // btnB3
            // 
            this.btnB3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnB3.BackColor = System.Drawing.Color.Coral;
            this.btnB3.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnB3.FlatAppearance.BorderSize = 0;
            this.btnB3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB3.ForeColor = System.Drawing.Color.White;
            this.btnB3.Location = new System.Drawing.Point(3, 258);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(188, 45);
            this.btnB3.TabIndex = 5;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = false;
            // 
            // btnB2
            // 
            this.btnB2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnB2.BackColor = System.Drawing.Color.Coral;
            this.btnB2.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnB2.FlatAppearance.BorderSize = 0;
            this.btnB2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB2.ForeColor = System.Drawing.Color.White;
            this.btnB2.Location = new System.Drawing.Point(3, 207);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(188, 45);
            this.btnB2.TabIndex = 4;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = false;
            // 
            // btnB1
            // 
            this.btnB1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnB1.BackColor = System.Drawing.Color.Coral;
            this.btnB1.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnB1.FlatAppearance.BorderSize = 0;
            this.btnB1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB1.ForeColor = System.Drawing.Color.White;
            this.btnB1.Location = new System.Drawing.Point(3, 156);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(188, 45);
            this.btnB1.TabIndex = 3;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = false;
            // 
            // btnA2
            // 
            this.btnA2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnA2.BackColor = System.Drawing.Color.DarkGray;
            this.btnA2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnA2.FlatAppearance.BorderSize = 0;
            this.btnA2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA2.ForeColor = System.Drawing.Color.White;
            this.btnA2.Location = new System.Drawing.Point(3, 105);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(188, 45);
            this.btnA2.TabIndex = 2;
            this.btnA2.Text = "A2";
            this.btnA2.UseVisualStyleBackColor = false;
            // 
            // btnA1
            // 
            this.btnA1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnA1.BackColor = System.Drawing.Color.DarkGray;
            this.btnA1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnA1.FlatAppearance.BorderSize = 0;
            this.btnA1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA1.ForeColor = System.Drawing.Color.White;
            this.btnA1.Location = new System.Drawing.Point(3, 54);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(188, 45);
            this.btnA1.TabIndex = 1;
            this.btnA1.Text = "A1";
            this.btnA1.UseVisualStyleBackColor = false;
            // 
            // btnIdentifikacia
            // 
            this.btnIdentifikacia.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnIdentifikacia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIdentifikacia.Checked = true;
            this.btnIdentifikacia.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnIdentifikacia.FlatAppearance.BorderSize = 0;
            this.btnIdentifikacia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIdentifikacia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIdentifikacia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIdentifikacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentifikacia.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIdentifikacia.ForeColor = System.Drawing.Color.White;
            this.btnIdentifikacia.Location = new System.Drawing.Point(3, 3);
            this.btnIdentifikacia.Name = "btnIdentifikacia";
            this.btnIdentifikacia.Size = new System.Drawing.Size(188, 45);
            this.btnIdentifikacia.TabIndex = 0;
            this.btnIdentifikacia.TabStop = true;
            this.btnIdentifikacia.Text = "Identifikácia";
            this.btnIdentifikacia.UseVisualStyleBackColor = false;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelGrid.Controls.Add(this.gridTmp);
            this.panelGrid.Location = new System.Drawing.Point(200, 103);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(680, 511);
            this.panelGrid.TabIndex = 3;
            // 
            // gridTmp
            // 
            this.gridTmp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.gridTmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTmp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridTmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTmp.Location = new System.Drawing.Point(3, 3);
            this.gridTmp.Name = "gridTmp";
            this.gridTmp.Size = new System.Drawing.Size(674, 504);
            this.gridTmp.TabIndex = 0;
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.btnOtherOps);
            this.panelOperations.Controls.Add(this.btnSaveXml);
            this.panelOperations.Controls.Add(this.btnValidate);
            this.panelOperations.Controls.Add(this.btnLoadXml);
            this.panelOperations.Location = new System.Drawing.Point(203, 3);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(677, 94);
            this.panelOperations.TabIndex = 4;
            // 
            // btnOtherOps
            // 
            this.btnOtherOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOtherOps.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOtherOps.FlatAppearance.BorderSize = 0;
            this.btnOtherOps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOtherOps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOtherOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherOps.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtherOps.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOtherOps.Location = new System.Drawing.Point(510, 3);
            this.btnOtherOps.Name = "btnOtherOps";
            this.btnOtherOps.Size = new System.Drawing.Size(163, 88);
            this.btnOtherOps.TabIndex = 4;
            this.btnOtherOps.Text = "Ostatné operácie";
            this.btnOtherOps.UseVisualStyleBackColor = false;
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveXml.FlatAppearance.BorderSize = 0;
            this.btnSaveXml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSaveXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSaveXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveXml.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveXml.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveXml.Location = new System.Drawing.Point(341, 3);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(163, 88);
            this.btnSaveXml.TabIndex = 3;
            this.btnSaveXml.Text = "Uložiť kontrolný výkaz";
            this.btnSaveXml.UseVisualStyleBackColor = false;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnValidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnValidate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnValidate.Location = new System.Drawing.Point(172, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(163, 88);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Skontrolovať kontrolný výkaz";
            this.btnValidate.UseVisualStyleBackColor = false;
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadXml.FlatAppearance.BorderSize = 0;
            this.btnLoadXml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLoadXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoadXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadXml.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadXml.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoadXml.Location = new System.Drawing.Point(3, 3);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(163, 88);
            this.btnLoadXml.TabIndex = 1;
            this.btnLoadXml.Text = "Načítať kontrolný výkaz";
            this.btnLoadXml.UseVisualStyleBackColor = false;
            // 
            // FrmVatoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(907, 641);
            this.Controls.Add(this.layoutMain);
            this.MinimumSize = new System.Drawing.Size(915, 675);
            this.Name = "FrmVatoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAToo v0.1";
            this.Load += new System.EventHandler(this.FrmVatoo_Load);
            this.layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelIdent.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTmp)).EndInit();
            this.panelOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VAToo.Components.MyTableLayout layoutMain;
        private System.Windows.Forms.RadioButton btnIdentifikacia;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelIdent;
        private System.Windows.Forms.RadioButton btnA1;
        private System.Windows.Forms.RadioButton btnA2;
        private System.Windows.Forms.RadioButton btnB1;
        private System.Windows.Forms.RadioButton btnB2;
        private System.Windows.Forms.RadioButton btnB3;
        private System.Windows.Forms.RadioButton btnC1;
        private System.Windows.Forms.RadioButton btnC2;
        private System.Windows.Forms.RadioButton btnD1;
        private System.Windows.Forms.RadioButton btnD2;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnSaveXml;
        private VAToo.Components.MyDoubleBufferedGrid gridTmp;
        private System.Windows.Forms.Button btnOtherOps;

    }
}

