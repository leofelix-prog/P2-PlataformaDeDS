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

        private void CarregarSalas(string pesquisa = "")
        {
            SalaRepositorio repositorio = new SalaRepositorio();

            List<Sala> salas = repositorio.ConsultarTodos();

            List<Sala> salasFiltradas = new List<Sala>();

            foreach (Sala sala in salas)
            {
                if (sala.Nome.ToLower().Contains(pesquisa.ToLower()))
                {
                    salasFiltradas.Add(sala);
                }
            }

            dgvSalas.DataSource = salasFiltradas;
        }

        private void FrmConsultarSalas_Load(object sender, EventArgs e)
        {
            CarregarSalas();
        }

        private void txtPesquisarSala_TextChanged(object sender, EventArgs e)
        {
            CarregarSalas(txtPesquisarSala.Text);
        }
    }
}
