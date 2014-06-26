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
            this.dataGridView1.DataSource = tmp;

            this.dataGridView1.BackgroundColor = this.BackColor;
        }
    }
}
