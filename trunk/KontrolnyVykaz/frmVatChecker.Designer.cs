namespace KontrolnyVykaz
{
    partial class frmVatChecker
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTester = new System.Windows.Forms.TabPage();
            this.btnDesign1 = new System.Windows.Forms.Button();
            this.btnImportPayers = new System.Windows.Forms.Button();
            this.btnBlacklistImport = new System.Windows.Forms.Button();
            this.tabDbHelper = new System.Windows.Forms.TabPage();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.btnClearWin = new System.Windows.Forms.Button();
            this.btnExecNonQ = new System.Windows.Forms.Button();
            this.btnExecQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTester.SuspendLayout();
            this.tabDbHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(3, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(134, 31);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Validuj";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(143, 6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(687, 544);
            this.txtLog.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTester);
            this.tabControl1.Controls.Add(this.tabDbHelper);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 590);
            this.tabControl1.TabIndex = 2;
            // 
            // tabTester
            // 
            this.tabTester.Controls.Add(this.btnDesign1);
            this.tabTester.Controls.Add(this.btnImportPayers);
            this.tabTester.Controls.Add(this.btnBlacklistImport);
            this.tabTester.Controls.Add(this.btnTest);
            this.tabTester.Controls.Add(this.txtLog);
            this.tabTester.Location = new System.Drawing.Point(4, 22);
            this.tabTester.Name = "tabTester";
            this.tabTester.Padding = new System.Windows.Forms.Padding(3);
            this.tabTester.Size = new System.Drawing.Size(833, 564);
            this.tabTester.TabIndex = 0;
            this.tabTester.Text = "Tests";
            this.tabTester.UseVisualStyleBackColor = true;
            // 
            // btnDesign1
            // 
            this.btnDesign1.Location = new System.Drawing.Point(3, 253);
            this.btnDesign1.Name = "btnDesign1";
            this.btnDesign1.Size = new System.Drawing.Size(134, 31);
            this.btnDesign1.TabIndex = 5;
            this.btnDesign1.Text = "Design one - avat";
            this.btnDesign1.UseVisualStyleBackColor = true;
            this.btnDesign1.Click += new System.EventHandler(this.btnDesign1_Click);
            // 
            // btnImportPayers
            // 
            this.btnImportPayers.Location = new System.Drawing.Point(3, 108);
            this.btnImportPayers.Name = "btnImportPayers";
            this.btnImportPayers.Size = new System.Drawing.Size(134, 31);
            this.btnImportPayers.TabIndex = 4;
            this.btnImportPayers.Text = "Import tax payers";
            this.btnImportPayers.UseVisualStyleBackColor = true;
            this.btnImportPayers.Click += new System.EventHandler(this.btnImportPayers_Click);
            // 
            // btnBlacklistImport
            // 
            this.btnBlacklistImport.Location = new System.Drawing.Point(3, 71);
            this.btnBlacklistImport.Name = "btnBlacklistImport";
            this.btnBlacklistImport.Size = new System.Drawing.Size(134, 31);
            this.btnBlacklistImport.TabIndex = 2;
            this.btnBlacklistImport.Text = "Import blacklist";
            this.btnBlacklistImport.UseVisualStyleBackColor = true;
            this.btnBlacklistImport.Click += new System.EventHandler(this.btnBlacklistImport_Click);
            // 
            // tabDbHelper
            // 
            this.tabDbHelper.Controls.Add(this.gridResults);
            this.tabDbHelper.Controls.Add(this.btnClearWin);
            this.tabDbHelper.Controls.Add(this.btnExecNonQ);
            this.tabDbHelper.Controls.Add(this.btnExecQuery);
            this.tabDbHelper.Controls.Add(this.txtQuery);
            this.tabDbHelper.Location = new System.Drawing.Point(4, 22);
            this.tabDbHelper.Name = "tabDbHelper";
            this.tabDbHelper.Padding = new System.Windows.Forms.Padding(3);
            this.tabDbHelper.Size = new System.Drawing.Size(833, 564);
            this.tabDbHelper.TabIndex = 1;
            this.tabDbHelper.Text = "DB helper";
            this.tabDbHelper.UseVisualStyleBackColor = true;
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(6, 223);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.Size = new System.Drawing.Size(821, 335);
            this.gridResults.TabIndex = 13;
            // 
            // btnClearWin
            // 
            this.btnClearWin.Location = new System.Drawing.Point(6, 94);
            this.btnClearWin.Name = "btnClearWin";
            this.btnClearWin.Size = new System.Drawing.Size(161, 38);
            this.btnClearWin.TabIndex = 12;
            this.btnClearWin.Text = "&Clear query window";
            this.btnClearWin.UseVisualStyleBackColor = true;
            this.btnClearWin.Click += new System.EventHandler(this.btnClearWin_Click);
            // 
            // btnExecNonQ
            // 
            this.btnExecNonQ.Location = new System.Drawing.Point(6, 50);
            this.btnExecNonQ.Name = "btnExecNonQ";
            this.btnExecNonQ.Size = new System.Drawing.Size(161, 38);
            this.btnExecNonQ.TabIndex = 11;
            this.btnExecNonQ.Text = "E&xecute non-query";
            this.btnExecNonQ.UseVisualStyleBackColor = true;
            this.btnExecNonQ.Click += new System.EventHandler(this.btnExecNonQ_Click);
            // 
            // btnExecQuery
            // 
            this.btnExecQuery.Location = new System.Drawing.Point(6, 6);
            this.btnExecQuery.Name = "btnExecQuery";
            this.btnExecQuery.Size = new System.Drawing.Size(161, 38);
            this.btnExecQuery.TabIndex = 10;
            this.btnExecQuery.Text = "Execute &query";
            this.btnExecQuery.UseVisualStyleBackColor = true;
            this.btnExecQuery.Click += new System.EventHandler(this.btnExecQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuery.Location = new System.Drawing.Point(173, 6);
            this.txtQuery.MaxLength = 65535;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(654, 211);
            this.txtQuery.TabIndex = 9;
            this.txtQuery.Text = "select * from sqlite_master ;";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Location = new System.Drawing.Point(3, 588);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1128, 40);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Items";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(108, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Selected items: ";
            // 
            // frmVatChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 614);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVatChecker";
            this.Text = "Kontrolný výkaz";
            this.tabControl1.ResumeLayout(false);
            this.tabTester.ResumeLayout(false);
            this.tabTester.PerformLayout();
            this.tabDbHelper.ResumeLayout(false);
            this.tabDbHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTester;
        private System.Windows.Forms.TabPage tabDbHelper;
        private System.Windows.Forms.Button btnClearWin;
        private System.Windows.Forms.Button btnExecNonQ;
        private System.Windows.Forms.Button btnExecQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.Button btnBlacklistImport;
        private System.Windows.Forms.Button btnImportPayers;
        private System.Windows.Forms.Button btnDesign1;
    }
}

