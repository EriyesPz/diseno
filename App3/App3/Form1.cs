namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.frmAgregar forma = new Pantallas.frmAgregar();

            forma.MdiParent = this;
            forma.ds = this.ds;
            forma.Show();
        }

        Datos.DSEstudiante ds = new Datos.DSEstudiante();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds.ReadXml("demo.xml");
            }
            catch (Exception ex)
            {
                ds.WriteXml("demo.xml");
                ds.ReadXml("demo.xml");
            }
        }

        private void presentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.frmPresentar presentar = new Pantallas.frmPresentar();
            presentar.MdiParent = this;
            presentar.dS = this.ds;
            presentar.Show();
        }
    }
}
