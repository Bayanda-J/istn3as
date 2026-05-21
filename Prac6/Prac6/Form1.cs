using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
            try
            {
                //this.taBook.FillBy(this.BookDataSet.Book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			taBook.FillByBookSearch(BookDataSet.Book, txtSearch.Text);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
            this.taBook.Fill(this.BookDataSet.Book);
        }

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			taBook.FillByBookSearch(BookDataSet.Book, txtSearch.Text);
		}
	}
}
