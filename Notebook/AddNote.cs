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
    public partial class AddNote : Form
    {
       // private string connectionstring = @"Data Source=LAPTOP-5C698NK2\SQLEXPRESS;Initial Catalog=notebook;Integrated Security=True";
      //  private SqlCommand sqlcom = new SqlCommand();
      //  private SqlDataReader sqlreader;
       Noteb noteb = new Noteb();
   
        public AddNote()
        {
            InitializeComponent();
        }


        private void returnaddscrnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Addnotebtn_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlcon = new SqlConnection(this.connectionstring))
            //{
            //    sqlcon.Open();
            //    this.sqlcom = new SqlCommand("Insert into NoteDB(Title, Date, Desciption) Values (@Title, @Date, @Desciption)", sqlcon);
            //    this.sqlcom.Parameters.Add("@Title", this.titlebox.Text.ToString());
            //    this.sqlcom.Parameters.Add("@Date", this.datebox.Value.ToString());
            //    this.sqlcom.Parameters.Add("@Desciption", this.descripbox.Text.ToString());
            //    this.sqlcom.ExecuteNonQuery();


            //    sqlcon.Close();
            //    this.Close();
            //    Main main = new Main();
            //    main.Refresh();
            //    main.Show();

            // }

            NoteDB noteDB = new NoteDB()
            {
                Title = this.titlebox.Text.ToString(),
                Date = this.datebox.Value,
                Desciption = this.descripbox.Text
            };

            
            if (noteDB != null)
            {
                noteb.NoteDBs.Add(noteDB);
                noteb.SaveChanges();
                this.Refresh();
                this.Close();
                Main main = new Main();
                main.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.descripbox.Text.ToString() != "")
            {
                this.Addnotebtn.Enabled = true;
            }
            else
            {
                this.Addnotebtn.Enabled = false;
            }    
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
