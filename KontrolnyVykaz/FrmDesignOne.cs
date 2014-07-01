using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KVValidator;

namespace KontrolnyVykaz
{
    public partial class FrmDesignOne : Form
    {
        KVDPH kvDph = new KVDPH();

        public FrmDesignOne()
        {
            InitializeComponent();
        }

        private void FrmDesignOne_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 54, 54);

            this.menuXml.Renderer = new ToolRenderer();
            this.menuXml.BackColor = this.BackColor;

            this.menuOps.Renderer = new ToolRenderer();
            this.menuOps.BackColor = this.BackColor;

            var tmp = new BindingList<A1>();
            for (int i = 0; i < 10; i++)
                tmp.Add(new A1());
            this.gridData.DataSource = tmp;

            this.gridData.BackgroundColor = this.BackColor;

            this.btnIdentification.PerformClick();
            UpdateButtonTexts();
        }

        void DisableAllButtons(ToolStripButton except)
        {
            btnIdentification.Checked = false;
            btnA1.Checked = false;
            btnA2.Checked = false;
            btnB1.Checked = false;
            btnB2.Checked = false;
            btnB3.Checked = false;
            btnC1.Checked = false;
            btnC2.Checked = false;
            btnD1.Checked = false;
            btnD2.Checked = false;
            except.Checked = true;
            lblTitle.Text = except.ToolTipText;
        }

        private void btnIdentification_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnIdentification);
            gridData.DataSource = null;
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA1);
            gridData.DataSource = new BindingList<A1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A1 != null)
                gridData.DataSource = new BindingList<A1>(kvDph.Transakcie.A1);
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA2);
            gridData.DataSource = new BindingList<A2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A2 != null)
                gridData.DataSource = new BindingList<A2>(kvDph.Transakcie.A2);
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB1);
            gridData.DataSource = new BindingList<B1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B1 != null)
                gridData.DataSource = new BindingList<B1>(kvDph.Transakcie.B1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB2);
            gridData.DataSource = new BindingList<B2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B2 != null)
                gridData.DataSource = new BindingList<B2>(kvDph.Transakcie.B2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB3);
            gridData.DataSource = new BindingList<B3>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B3 != null)
                gridData.DataSource = new BindingList<B3>(kvDph.Transakcie.B3);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC1);
            gridData.DataSource = new BindingList<C1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C1 != null)
                gridData.DataSource = new BindingList<C1>(kvDph.Transakcie.C1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC2);
            gridData.DataSource = new BindingList<C2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C2 != null)
                gridData.DataSource = new BindingList<C2>(kvDph.Transakcie.C2);
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD1);
            gridData.DataSource = new BindingList<D1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D1 != null)
                gridData.DataSource = new BindingList<D1>(kvDph.Transakcie.D1);
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD2);
            gridData.DataSource = new BindingList<D2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D2 != null)
                gridData.DataSource = new BindingList<D2>(kvDph.Transakcie.D2);
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (!ReadXml())
                    return;

                //MessageBox.Show(this, "Načítanie vstupného súboru prebehlo úspešne!", "Načítanie xml", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIdentification.PerformClick();
                UpdateButtonTexts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Načítanie vstupného súboru neprebehlo úspešne: {0}{0}{1}", Environment.NewLine, ex.Message), "Načítanie xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void UpdateButtonTexts()
        {
            btnA1.Text = string.Format("A1 ({0})", kvDph.Transakcie.A1.Count);
            btnA2.Text = string.Format("A2 ({0})", kvDph.Transakcie.A2.Count);
            btnB1.Text = string.Format("B1 ({0})", kvDph.Transakcie.B1.Count);
            btnB2.Text = string.Format("B2 ({0})", kvDph.Transakcie.B2.Count);
            btnB3.Text = string.Format("B3 ({0})", kvDph.Transakcie.B3.Count);
            btnC1.Text = string.Format("C1 ({0})", kvDph.Transakcie.C1.Count);
            btnC2.Text = string.Format("C2 ({0})", kvDph.Transakcie.C2.Count);
            btnD1.Text = string.Format("D1 ({0})", kvDph.Transakcie.D1.Count);
            btnD2.Text = string.Format("D2 ({0})", kvDph.Transakcie.D2.Count);
        }

        private bool ReadXml()
        {
            string path = GetXmlPath();
            if (string.IsNullOrEmpty(path))
                return false;

            this.kvDph = KVDPH.LoadFromFile(path);

            return true;
        }

        private string GetXmlPath()
        {
            var curDir = Environment.CurrentDirectory;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML files|*.xml";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;

            Environment.CurrentDirectory = curDir;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }
    }
}
