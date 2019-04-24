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

namespace movie_database__data_binding_version
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter daDirectors, daMovies;
        DataSet ds;
        SqlCommandBuilder cb;
        BindingSource bsDirectors, bsMovies;

        public Form1()
        {   
            InitializeComponent();
            conn = new SqlConnection("Server=DESKTOP-51G331G\\SQLEXPRESS;Database=MDB;Trusted_Connection=True");
            ds = new DataSet();
            conn.Open();
            daDirectors = new SqlDataAdapter("SELECT * FROM Directors", conn);
            daMovies = new SqlDataAdapter("SELECT * FROM Movies", conn);
            cb = new SqlCommandBuilder(daMovies);
            daDirectors.Fill(ds, "Directors");
            daMovies.Fill(ds, "Movies");
            DataRelation dr = new DataRelation("FK_Movies_Directors", ds.Tables["Directors"].Columns["DID"],
             ds.Tables["Movies"].Columns["DID"]);
            ds.Relations.Add(dr);
            bsDirectors = new BindingSource();
            bsDirectors.DataSource = ds;
            bsDirectors.DataMember = "Directors";
            bsMovies = new BindingSource();
            bsMovies.DataSource = bsDirectors;
            bsMovies.DataMember = "FK_Movies_Directors";
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDBDataSet.Directors' table. You can move, or remove it, as needed.
            this.directorsTableAdapter.Fill(this.mDBDataSet.Directors);

            bsDirectors = new BindingSource();
            bsDirectors.DataSource = ds;
            bsDirectors.DataMember = "Directors";
            bsMovies = new BindingSource();
            bsMovies.DataSource = bsDirectors;
            bsMovies.DataMember = "FK_Movies_Directors";
            dataGridView1.DataSource = bsDirectors;
            dataGridView2.DataSource = bsMovies;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            daMovies.Update(ds, "Movies");
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

       




    }
}
