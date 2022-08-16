namespace CapaPresentacion
{
    public partial class FRCliente : Form
    {
        public FRCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click_2(object sender, EventArgs e)
        {
            txtID.Value = 0;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            picFoto.Image = null;   
        }
    }
}