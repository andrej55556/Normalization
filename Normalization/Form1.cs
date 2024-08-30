using Npgsql;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Normalization
{
    public partial class FormAttributes : Form
    {
        string connection = "Host = localhost;Username = postgres;Password = postgres;Database = test_normal";

        public FormAttributes()
        {
            InitializeComponent();
        }

        private void FormAttributes_Load(object sender, EventArgs e)
        {
            /*using (var cn = NpgsqlDataSource.Create(constring))
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

                cn.Dispose();
                dr.Dispose();
            }*/

            var adapter = new NpgsqlDataAdapter("SELECT * FROM \"Attributes\"", connection);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridViewAttributes.DataSource = dataSet.Tables[0];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                /*atributesTableAdapter.Update(userdb0DataSet);
                adapter*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
