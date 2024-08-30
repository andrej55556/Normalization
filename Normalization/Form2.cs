using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Normalization
{
    public partial class Form2 : Form
    {
        string constring = "Host = localhost;Username = postgres;Password = postgres";
        Guid g = new Guid();

        public Form2()
        {
            InitializeComponent();
        }

        void CreateDB()
        {
            using (var cn = NpgsqlDataSource.Create(constring))
            {
                cn.OpenConnection();

                g = Guid.NewGuid();

                //var sql = $"CREATE DATABASE userdb{g}";
                var sql = $"CREATE DATABASE \"{g}\"";
                //Console.WriteLine(sql);
                var cmd = cn.CreateCommand(sql);

                var dr = cmd.ExecuteNonQuery();

                cn.Dispose();
            }
            constring = $"Host = localhost;Username = postgres;Password = postgres;Database = {g};Client Encoding=UTF8";
        }


        void Attributes()
        {
            using (var cn = NpgsqlDataSource.Create(constring))
            {
                cn.OpenConnection();
                var sql = "CREATE TABLE \"Attributes\" (\r\n    \"id_attribute\" SERIAL PRIMARY KEY,\r\n    \"attribute_name\" VARCHAR\r\n);";
                var cmd = cn.CreateCommand(sql);

                var dr = cmd.ExecuteNonQuery();

                cn.Dispose();
            }
        }

        void Connection()
        {
            using (var cn = NpgsqlDataSource.Create(constring))
            {
                cn.OpenConnection();
                var sql = "select * from \"Attributes\" ORDER BY id_attribute";
                var cmd = cn.CreateCommand(sql);
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var n = dr["attribute_name"].ToString();
                    //dataSet.Tables["Attributes"].Rows.Add(n);
                    dataGridViewAttributes.Rows.Add(n);
                }

                /* var dataTable = new DataTable();
                 dataTable.Load(dr);
                 //reader.Close();
                 dataGridViewAttributes.DataSource = dataTable;*/

                cn.Dispose();
                dr.Dispose();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateDB();
            Attributes();
            Connection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //atributesTableAdapter.Update(userdb0DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
