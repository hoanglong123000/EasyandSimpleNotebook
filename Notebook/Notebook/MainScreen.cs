using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Notebook.Database;
namespace Notebook
{
    public partial class Main : Form
    {
        Noteb notecon = new Noteb();
        private string connectionstring = @"data source=LAPTOP-5C698NK2\SQLEXPRESS;initial catalog=notebook;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlCommand sqlcom = new SqlCommand();
        private SqlDataReader sqlreader;
        public Main()
        {
            InitializeComponent();
        }

        
        private void bind(List<NoteDB> n)
        {
            
            foreach (var i in n)
            {
                int id = this.Notebooklst.Rows.Add();
                this.Notebooklst.Rows[id].Cells[0].Value = i.No;
                this.Notebooklst.Rows[id].Cells[1].Value = i.Title;
                this.Notebooklst.Rows[id].Cells[2].Value = i.Desciption;
                this.Notebooklst.Rows[id].Cells[3].Value = i.Date;
            }
        }

        private void thoátCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {    
            AddNote transscrn = new AddNote();
            transscrn.ShowDialog();
            this.Close();
        }

        private void Rewritebtn_Click(object sender, EventArgs e)
        {
           
          
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            
            ReadNote transscrn = new ReadNote();
            transscrn.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<NoteDB> lstnotes = notecon.NoteDBs.ToList();
            this.bind(lstnotes);
            this.Refresh();

            
            //this.Notebooklst.Hide();
            //this.Rewritebtn.Hide();
            //this.Findbtn.Hide();
            //this.deletebtn.Hide();
        }

        private void Notebooklst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninFrm frm = new SigninFrm();
            frm.Show();
            this.lựaChọnToolStripMenuItem.Enabled = false;
        }

        private void Upbtn_Click(object sender, EventArgs e)
        {
            UpNote transscrn = new UpNote();
            transscrn.ShowDialog();
        }

        private void Deletetoolstripbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
