using Business.Classes.Anuncio.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anuncios {

    /* File History
    * --------------------------------------------------------------------
    * Created by : Luciana Pacheco
    * Date       : 10/05/2021
    * Purpose    : Criação da Mdl do Anúncio
    * --------------------------------------------------------------------
    */

    public partial class SistemaAnuncios : Form {
        public SistemaAnuncios() {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar() {
            AnuncioPst anuncioPst = null;
            try {
                anuncioPst = new AnuncioPst();
                dtAnuncios.DataSource = anuncioPst.Pesquisar();

            } catch (Exception ex) {

                MessageBox.Show("Error:- " + ex.Message);

            } finally {
                anuncioPst = null;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            Cadastro cadastrofrm = new Cadastro();
            cadastrofrm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            Relatorios Relatoriofrm = new Relatorios();
            Relatoriofrm.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            AnuncioPst anuncio = new AnuncioPst();
            DataGridViewRow linhaAtual = dtAnuncios.CurrentRow;

            int indice = linhaAtual.Index;

            int id = Convert.ToInt32(dtAnuncios.Rows[indice].Cells["id"].Value);

            anuncio.Excluir(id);

            dtAnuncios.DataSource = anuncio.Pesquisar();

            MessageBox.Show("Anuncio excluído com sucesso! " + id);

        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            Inicializar();
        }
    }
}
