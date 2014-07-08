using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Avat.Components
{
    /// <summary>
    /// Double buffering-ovy datagridview komponent
    /// </summary>
    public class MyDoubleBufferedGrid : DataGridView
    {
        public MyDoubleBufferedGrid()
            : this(true)
        {
        }

        public MyDoubleBufferedGrid(bool useAlternateStyle)
        {
            DoubleBuffered = true;

            if (useAlternateStyle)
                AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;

            var selector = new DataGridViewColumnSelector(this);
            AllowUserToResizeRows = false;
            BackgroundColor = Color.Gainsboro;
        }
    }

    /// <summary>
    /// Trieda na zobrazenie popup menu s vyberom stlpcov na zobrazenie/skrytie
    /// </summary>
    class DataGridViewColumnSelector
    {
        private DataGridView mDataGridView = null;
        private CheckedListBox mCheckedListBox;
        private ToolStripDropDown mPopup;

        public int MaxHeight = 300;
        public int Width = 150;

        /// <summary>
        /// DataGridView object s ktorym je selector prepojeny
        /// </summary>
        public DataGridView DataGridView
        {
            get { return mDataGridView; }
            set
            {
                if (mDataGridView != null) mDataGridView.CellMouseClick -= new DataGridViewCellMouseEventHandler(mDataGridView_CellMouseClick);
                mDataGridView = value;
                if (mDataGridView != null) mDataGridView.CellMouseClick += new DataGridViewCellMouseEventHandler(mDataGridView_CellMouseClick);
            }
        }

        void mDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex == -1)
            {
                mCheckedListBox.Items.Clear();
                foreach (DataGridViewColumn c in mDataGridView.Columns)
                {
                    mCheckedListBox.Items.Add(c.HeaderText, c.Visible);
                }
                int PreferredHeight = (mCheckedListBox.Items.Count * 16) + 7;
                mCheckedListBox.Height = (PreferredHeight < MaxHeight) ? PreferredHeight : MaxHeight;
                mCheckedListBox.Width = this.Width;
                mPopup.Show(Cursor.Position);
            }
        }

        public DataGridViewColumnSelector()
        {
            mCheckedListBox = new CheckedListBox();
            mCheckedListBox.CheckOnClick = true;
            mCheckedListBox.ItemCheck += new ItemCheckEventHandler(mCheckedListBox_ItemCheck);

            ToolStripControlHost mControlHost = new ToolStripControlHost(mCheckedListBox);
            mControlHost.Padding = Padding.Empty;
            mControlHost.Margin = Padding.Empty;
            mControlHost.AutoSize = false;

            mPopup = new ToolStripDropDown();
            mPopup.Padding = Padding.Empty;
            mPopup.Items.Add(mControlHost);
        }

        public DataGridViewColumnSelector(DataGridView dgv)
            : this()
        {
            this.DataGridView = dgv;
        }

        void mCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            mDataGridView.Columns[e.Index].Visible = (e.NewValue == CheckState.Checked);
        }
    }
}
