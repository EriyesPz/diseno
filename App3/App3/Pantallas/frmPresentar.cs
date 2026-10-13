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
    public partial class frmPresentar : Form
    {
        public frmPresentar()
        {
            InitializeComponent();
        }
        public Datos.DSEstudiante dS;
        private void frmPresentar_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = dS.Tables[0];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //dS.WriteXml("demo.xml");

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dS.WriteXml(this.saveFileDialog1.FileName);
            }   
              
                
        }
    }
}
