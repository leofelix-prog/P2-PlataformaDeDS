using SalaDeReunioes.Dados;

namespace SalaDeReunioes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            FrmCadastroSala formulario = new FrmCadastroSala();
            formulario.ShowDialog();
        }
    }
}
