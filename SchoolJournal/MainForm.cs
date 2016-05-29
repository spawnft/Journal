using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolJournal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
           // dataGridView1.ColumnHeadersHeight = 50;
           ////dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
           // dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
        }

        void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            // check that we are in a header cell!
            if (e.RowIndex == -1 && e.ColumnIndex >= 0 && e.ColumnIndex!=0)
            {
                //e.PaintBackground(e.ClipBounds, true);
                //Rectangle rect = this.dataGridView1.GetColumnDisplayRectangle(e.ColumnIndex, true);
                //Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                //if (this.dataGridView1.ColumnHeadersHeight < titleSize.Width)
                //{
                //    this.dataGridView1.ColumnHeadersHeight = titleSize.Width;
                //}

                //e.Graphics.TranslateTransform(0, titleSize.Width);
                //e.Graphics.RotateTransform(-90.0F);
                //e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y - (dataGridView1.ColumnHeadersHeight - titleSize.Width), rect.X));
                //e.Graphics.RotateTransform(90.0F);
                //e.Graphics.TranslateTransform(0, -titleSize.Width);
                //e.Handled = true;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ученикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPupil p = new AddPupil();
            p.ShowDialog();
        }

        private void AnalizeByClassGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void учительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher t = new AddTeacher();
            t.ShowDialog();
        }

        private void предметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPredmet pr = new AddPredmet();
            pr.ShowDialog();
        }

        private void классToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClass c = new AddClass();
            c.ShowDialog();
        }
    }
}
