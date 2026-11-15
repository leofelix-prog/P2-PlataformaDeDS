using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalaDeReunioes.Dados;
using SalaDeReunioes.Models;

namespace SalaDeReunioes
{
    public partial class FrmDisponibilidadeSalas : Form
    {
        public FrmDisponibilidadeSalas()
        {
            InitializeComponent();
            dgvDisponibilidade.AutoGenerateColumns = false;
            colHorasLivres.DefaultCellStyle.Format = "0.#";
        }

        private void CarregarDisponibilidade()
        {
            DisponibilidadeRepositorio repositorio = new DisponibilidadeRepositorio();

            List<Sala> salas = repositorio.ConsultarDisponibilidade(dtpDataInicial.Value,
                                                                    dtpDataFinal.Value
                                                                   );

            dgvDisponibilidade.DataSource = salas;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (dtpDataFinal.Value.Date < dtpDataInicial.Value.Date)
            {
                MessageBox.Show("A data final não pode ser anterior à data inicial.");
                return;
            }

            CarregarDisponibilidade();
        }
    }
}
