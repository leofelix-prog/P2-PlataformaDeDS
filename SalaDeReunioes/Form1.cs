using SalaDeReunioes.Dados;

namespace SalaDeReunioes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            AtualizarReservasRecentes();
        }

        private void btnCadastrarSala_Click(object sender, EventArgs e)
        {
            FrmCadastroSala formulario = new FrmCadastroSala();
            formulario.ShowDialog();
        }

        private void btnConsultarSalas_Click(object sender, EventArgs e)
        {
            FrmConsultarSalas formulario = new FrmConsultarSalas();
            formulario.ShowDialog();
        }

        private void btnGerenciarReservas_Click(object sender, EventArgs e)
        {
            FrmGerenciarReservas formulario = new FrmGerenciarReservas();
            formulario.ShowDialog();
        }

        private void AtualizarReservasRecentes()
        {
            ReservaRepositorio repositorio = new ReservaRepositorio();

            int quantidade = repositorio.ReservasUltimos7Dias();

            lblQtddReservasRecentes.Text = quantidade.ToString();
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            AtualizarReservasRecentes();
        }

        private void lblQtddReservasRecentes_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
