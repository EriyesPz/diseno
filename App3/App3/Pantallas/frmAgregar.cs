using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3.Pantallas
{
    public partial class frmAgregar : Form
    {
        public Datos.DSEstudiante ds;
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataRow dr;
            dr = ds.Tables[0].NewRow();
            dr[0] = this.numericUpDown1.Value.ToString();
            dr[1] = this.textBox1.Text;
            dr[2] = this.numericUpDown2.Value.ToString();
        }
    }
}
