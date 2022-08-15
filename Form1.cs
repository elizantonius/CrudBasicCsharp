using System.Data;

namespace CrudBasicCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVUG367;Initial Catalog=crudsepnop;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {     
            con.Open();
             SqlCommand command = new SqlCommand("insert into user value('"+(npm.Text)+ "', '" + (nama.Text) + "', '" + (jurusan.Text) + "')" , con);
            command.ExecuteNonQuery();
            MessageBox.Show("Tersimpan");
            con.Close();
            BindData();

        }

        void BindData()
        {
            SqlCommand koneksi = new SqlCommand("select * from user", con);
            SqlDataAdapter sd = new SqlDataAdapter(koneksi);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}