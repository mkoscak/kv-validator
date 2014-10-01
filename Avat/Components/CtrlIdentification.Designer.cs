using System.Windows.Forms;
namespace Avat.Components
{
    partial class CtrlIdentification
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
            this.lblIcDph = new System.Windows.Forms.Label();
            this.lblDruh = new System.Windows.Forms.Label();
            this.lblObdobie = new System.Windows.Forms.Label();
            this.lblNazov = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblObec = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblPsc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPsc = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txteMail = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.txtPeriod = new System.Windows.Forms.NumericUpDown();
            this.panelKind = new System.Windows.Forms.Panel();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.cbPeriodType = new System.Windows.Forms.ComboBox();
            this.panelPeriod = new System.Windows.Forms.Panel();
            this.txtIcDph = new System.Windows.Forms.ComboBox();
            this.panelIC = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod)).BeginInit();
            this.panelKind.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.panelIC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIcDph
            // 
            this.lblIcDph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIcDph.AutoSize = true;
            this.lblIcDph.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIcDph.ForeColor = System.Drawing.Color.Black;
            this.lblIcDph.Location = new System.Drawing.Point(28, 31);
            this.lblIcDph.Margin = new System.Windows.Forms.Padding(10);
            this.lblIcDph.Name = "lblIcDph";
            this.lblIcDph.Size = new System.Drawing.Size(171, 18);
            this.lblIcDph.TabIndex = 6;
            this.lblIcDph.Text = "IČ DPH podávateľa KV:";
            // 
            // lblDruh
            // 
            this.lblDruh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDruh.AutoSize = true;
            this.lblDruh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDruh.ForeColor = System.Drawing.Color.Black;
            this.lblDruh.Location = new System.Drawing.Point(99, 75);
            this.lblDruh.Margin = new System.Windows.Forms.Padding(10);
            this.lblDruh.Name = "lblDruh";
            this.lblDruh.Size = new System.Drawing.Size(100, 18);
            this.lblDruh.TabIndex = 7;
            this.lblDruh.Text = "Druh výkazu:";
            // 
            // lblObdobie
            // 
            this.lblObdobie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObdobie.AutoSize = true;
            this.lblObdobie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObdobie.ForeColor = System.Drawing.Color.Black;
            this.lblObdobie.Location = new System.Drawing.Point(126, 115);
            this.lblObdobie.Margin = new System.Windows.Forms.Padding(10);
            this.lblObdobie.Name = "lblObdobie";
            this.lblObdobie.Size = new System.Drawing.Size(73, 18);
            this.lblObdobie.TabIndex = 8;
            this.lblObdobie.Text = "Obdobie:";
            // 
            // lblNazov
            // 
            this.lblNazov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNazov.AutoSize = true;
            this.lblNazov.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazov.ForeColor = System.Drawing.Color.Black;
            this.lblNazov.Location = new System.Drawing.Point(77, 157);
            this.lblNazov.Margin = new System.Windows.Forms.Padding(10);
            this.lblNazov.Name = "lblNazov";
            this.lblNazov.Size = new System.Drawing.Size(122, 18);
            this.lblNazov.TabIndex = 9;
            this.lblNazov.Text = "Názov subjektu:";
            // 
            // lblStat
            // 
            this.lblStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStat.AutoSize = true;
            this.lblStat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStat.ForeColor = System.Drawing.Color.Black;
            this.lblStat.Location = new System.Drawing.Point(159, 199);
            this.lblStat.Margin = new System.Windows.Forms.Padding(10);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(40, 18);
            this.lblStat.TabIndex = 10;
            this.lblStat.Text = "Štát:";
            // 
            // lblObec
            // 
            this.lblObec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObec.AutoSize = true;
            this.lblObec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObec.ForeColor = System.Drawing.Color.Black;
            this.lblObec.Location = new System.Drawing.Point(149, 241);
            this.lblObec.Margin = new System.Windows.Forms.Padding(10);
            this.lblObec.Name = "lblObec";
            this.lblObec.Size = new System.Drawing.Size(50, 18);
            this.lblObec.TabIndex = 11;
            this.lblObec.Text = "Obec:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(145, 409);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(10);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 18);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefon.ForeColor = System.Drawing.Color.Black;
            this.lblTelefon.Location = new System.Drawing.Point(132, 367);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(10);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(67, 18);
            this.lblTelefon.TabIndex = 15;
            this.lblTelefon.Text = "Telefón:";
            // 
            // lblUlica
            // 
            this.lblUlica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlica.ForeColor = System.Drawing.Color.Black;
            this.lblUlica.Location = new System.Drawing.Point(152, 325);
            this.lblUlica.Margin = new System.Windows.Forms.Padding(10);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(47, 18);
            this.lblUlica.TabIndex = 13;
            this.lblUlica.Text = "Ulica:";
            // 
            // lblPsc
            // 
            this.lblPsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPsc.AutoSize = true;
            this.lblPsc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPsc.ForeColor = System.Drawing.Color.Black;
            this.lblPsc.Location = new System.Drawing.Point(156, 280);
            this.lblPsc.Margin = new System.Windows.Forms.Padding(10);
            this.lblPsc.Name = "lblPsc";
            this.lblPsc.Size = new System.Drawing.Size(43, 18);
            this.lblPsc.TabIndex = 12;
            this.lblPsc.Text = "PSČ:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(213, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 26);
            this.txtName.TabIndex = 20;
            this.txtName.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtState.ForeColor = System.Drawing.Color.Black;
            this.txtState.Location = new System.Drawing.Point(213, 196);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(315, 26);
            this.txtState.TabIndex = 21;
            this.txtState.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(213, 238);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(315, 26);
            this.txtCity.TabIndex = 22;
            this.txtCity.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtPsc
            // 
            this.txtPsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtPsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPsc.ForeColor = System.Drawing.Color.Black;
            this.txtPsc.Location = new System.Drawing.Point(213, 277);
            this.txtPsc.Name = "txtPsc";
            this.txtPsc.Size = new System.Drawing.Size(315, 26);
            this.txtPsc.TabIndex = 23;
            this.txtPsc.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(213, 322);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 26);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(213, 364);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(315, 26);
            this.txtPhone.TabIndex = 25;
            this.txtPhone.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txteMail
            // 
            this.txteMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txteMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txteMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txteMail.ForeColor = System.Drawing.Color.Black;
            this.txteMail.Location = new System.Drawing.Point(213, 406);
            this.txteMail.Name = "txteMail";
            this.txteMail.Size = new System.Drawing.Size(315, 26);
            this.txteMail.TabIndex = 26;
            this.txteMail.Text = "@";
            this.txteMail.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(457, 113);
            this.txtYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(71, 24);
            this.txtYear.TabIndex = 30;
            this.txtYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.txtYear.ValueChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            this.txtYear.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.ForeColor = System.Drawing.Color.Black;
            this.txtPeriod.Location = new System.Drawing.Point(213, 113);
            this.txtPeriod.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(71, 24);
            this.txtPeriod.TabIndex = 31;
            this.txtPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPeriod.ValueChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            this.txtPeriod.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // panelKind
            // 
            this.panelKind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKind.Controls.Add(this.cbKind);
            this.panelKind.Location = new System.Drawing.Point(213, 73);
            this.panelKind.Margin = new System.Windows.Forms.Padding(0);
            this.panelKind.Name = "panelKind";
            this.panelKind.Size = new System.Drawing.Size(315, 24);
            this.panelKind.TabIndex = 32;
            this.panelKind.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // cbKind
            // 
            this.cbKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cbKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKind.ForeColor = System.Drawing.Color.Black;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(0, 0);
            this.cbKind.Margin = new System.Windows.Forms.Padding(0);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(313, 24);
            this.cbKind.TabIndex = 27;
            this.cbKind.Enter += new System.EventHandler(this.panelPeriod_Enter);
            this.cbKind.SelectedValueChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            this.cbKind.TextChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            // 
            // cbPeriodType
            // 
            this.cbPeriodType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPeriodType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cbPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPeriodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodType.ForeColor = System.Drawing.Color.Black;
            this.cbPeriodType.FormattingEnabled = true;
            this.cbPeriodType.Location = new System.Drawing.Point(0, 0);
            this.cbPeriodType.Margin = new System.Windows.Forms.Padding(0);
            this.cbPeriodType.Name = "cbPeriodType";
            this.cbPeriodType.Size = new System.Drawing.Size(162, 24);
            this.cbPeriodType.TabIndex = 29;
            this.cbPeriodType.SelectedValueChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            this.cbPeriodType.TextChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            // 
            // panelPeriod
            // 
            this.panelPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPeriod.Controls.Add(this.cbPeriodType);
            this.panelPeriod.Location = new System.Drawing.Point(290, 113);
            this.panelPeriod.Margin = new System.Windows.Forms.Padding(0);
            this.panelPeriod.Name = "panelPeriod";
            this.panelPeriod.Size = new System.Drawing.Size(164, 24);
            this.panelPeriod.TabIndex = 33;
            this.panelPeriod.Enter += new System.EventHandler(this.panelPeriod_Enter);
            // 
            // txtIcDph
            // 
            this.txtIcDph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.txtIcDph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIcDph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtIcDph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIcDph.ForeColor = System.Drawing.Color.Black;
            this.txtIcDph.FormattingEnabled = true;
            this.txtIcDph.Location = new System.Drawing.Point(0, 0);
            this.txtIcDph.Margin = new System.Windows.Forms.Padding(0);
            this.txtIcDph.Name = "txtIcDph";
            this.txtIcDph.Size = new System.Drawing.Size(313, 24);
            this.txtIcDph.TabIndex = 29;
            this.txtIcDph.Enter += new System.EventHandler(this.panelPeriod_Enter);
            this.txtIcDph.TextChanged += new System.EventHandler(this.txtIcDph_TextChanged);
            // 
            // panelIC
            // 
            this.panelIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIC.Controls.Add(this.txtIcDph);
            this.panelIC.Location = new System.Drawing.Point(213, 28);
            this.panelIC.Name = "panelIC";
            this.panelIC.Size = new System.Drawing.Size(315, 24);
            this.panelIC.TabIndex = 34;
            // 
            // CtrlIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelIC);
            this.Controls.Add(this.panelPeriod);
            this.Controls.Add(this.panelKind);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txteMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPsc);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.lblPsc);
            this.Controls.Add(this.lblObec);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lblNazov);
            this.Controls.Add(this.lblObdobie);
            this.Controls.Add(this.lblDruh);
            this.Controls.Add(this.lblIcDph);
            this.Name = "CtrlIdentification";
            this.Size = new System.Drawing.Size(596, 452);
            this.Load += new System.EventHandler(this.CtrlIdentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriod)).EndInit();
            this.panelKind.ResumeLayout(false);
            this.panelPeriod.ResumeLayout(false);
            this.panelIC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblIcDph;
        internal System.Windows.Forms.Label lblDruh;
        internal System.Windows.Forms.Label lblObdobie;
        internal System.Windows.Forms.Label lblNazov;
        internal System.Windows.Forms.Label lblStat;
        internal System.Windows.Forms.Label lblObec;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblTelefon;
        internal System.Windows.Forms.Label lblUlica;
        internal System.Windows.Forms.Label lblPsc;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtPsc;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.TextBox txteMail;
        internal System.Windows.Forms.NumericUpDown txtYear;
        internal System.Windows.Forms.NumericUpDown txtPeriod;
        internal ComboBox cbKind;
        internal ComboBox cbPeriodType;
        private System.Windows.Forms.Panel panelKind;
        private Panel panelPeriod;
        internal ComboBox txtIcDph;
        private Panel panelIC;
    }
}
