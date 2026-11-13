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
    public partial class FrmConsultarSalas : Form
    {
        public FrmConsultarSalas()
        {
            InitializeComponent();
            dgvSalas.AutoGenerateColumns = false;
        }

        private void CarregarSalas()
        {
            SalaRepositorio repositorio = new SalaRepositorio();

            List<Sala> salas = repositorio.ConsultarTodos();

            dgvSalas.DataSource = salas;
        }

        private void FrmConsultarSalas_Load(object sender, EventArgs e)
        {
            CarregarSalas();
        }
    }
}
