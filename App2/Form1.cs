using System.Data;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estudiante estudiante = new Estudiante();
        List<Estudiante> Salon = new List<Estudiante>();

        private void button1_Click(object sender, EventArgs e)
        {
            estudiante.ID = Convert.ToInt32(this.textBox1.Text);
            estudiante.Nombre = this.textBox2.Text;
            estudiante.Sueldo = Convert.ToDouble(this.textBox3.Text);
            Salon.Add(estudiante);

            DataRow datarow;
            datarow = ds.Tables[0].NewRow();
            datarow["ID"] = estudiante.ID;
            datarow["Nombre"] = estudiante.Nombre;
            datarow["Sueldo"] = estudiante.Sueldo;

            ds.Tables[0].Rows.Add(datarow);
            datarow[0] = estudiante.ID;
            datarow[1] = estudiante.Nombre;
            datarow[2] = estudiante.Sueldo;



            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Salon.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Estudiante estudiante in Salon)
            {
                MessageBox.Show(estudiante.Nombre);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Salon;
            this.comboBox1.DataSource = ds.Tables[0];
        }

        DataSet1 ds = new DataSet1();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.ValueMember = "ID";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedValue.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedIndex.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
        }
    }
}
