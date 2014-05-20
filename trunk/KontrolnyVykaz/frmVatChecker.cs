using System;
using System.Text;
using System.Windows.Forms;
using KVValidator;
using System.Linq;

namespace KontrolnyVykaz
{
    public partial class frmVatChecker : Form
    {
        public frmVatChecker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                /*var validator = new RealWalidator..
                var valRes = validator.Validate("vzor.xml");
                if (valRes.Count > 0)
                    textBox1.Lines = valRes.ToArray();
                else
                    textBox1.Text = "OK";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
