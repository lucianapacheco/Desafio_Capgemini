using Business.Classes.Anuncio.Model;
using Business.Classes.Anuncio.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Anuncios {

/* File History
 * --------------------------------------------------------------------
 * Created by : Luciana Pacheco
 * Date       : 10/05/2021
 * Purpose    : Criação da Mdl do Anúncio
 * --------------------------------------------------------------------
 */

    public partial class Cadastro : Form {

        #region Attributes


        #endregion

        #region Methods

        private void CadastrarAnuncio() {
            AnuncioMdl anuncioMdl = null;
            AnuncioPst anuncioPst = null;
            string nomeAnuncio = null;
            string nomeCliente = null;
            double investimento = 0;
            Int32 qtdMaxVisualizacao = 0;
            Int32 qtdMaxCliques = 0;
            Int32 qtdMaxCompartilhamento = 0;
            Int32 indice = 0;
            try {

                anuncioMdl = new AnuncioMdl();
                anuncioPst = new AnuncioPst();

                List<Int32> estatistica = new List<Int32>();

                nomeAnuncio = txtNomeAnuncio.Text;
                nomeCliente =  txtCliente.Text;
                DateTime dateInicio = dtInicio.Value.Date;
                DateTime dateFinal = dtpTermino.Value.Date;
                investimento = Convert.ToDouble(txtInvestimento.Text);

                estatistica = anuncioPst.Calcular(investimento);

                foreach (var valores in estatistica) {
                    if (indice == 0) {
                        qtdMaxVisualizacao = valores;
                    }
                    if (indice == 1) {
                        qtdMaxCliques = valores;
                    }
                    if (indice == 2) {
                        qtdMaxCompartilhamento = valores;
                    }
                    indice++;
                }

                anuncioMdl.NomeAnuncio = nomeAnuncio;
                anuncioMdl.Cliente = nomeCliente;
                anuncioMdl.DataInicio = dateInicio;
                anuncioMdl.DataTermino = dateFinal;
                anuncioMdl.InvestimentoDia = investimento;
                anuncioMdl.QuantidadeMaximaCliques = qtdMaxCliques;
                anuncioMdl.QuantidadeMaximaCompartilhamento = qtdMaxCompartilhamento;
                anuncioMdl.QuantidadeMaximaVisualizacao = qtdMaxVisualizacao;

                anuncioPst.Incluir(anuncioMdl);

                MessageBox.Show("Cadastro realizado com sucesso!");

            } catch (Exception ex) {
                throw ex;
            } finally {
                txtInvestimento.Text = "";
                txtCliente.Text = "";
                txtNomeAnuncio.Text = "";
                this.Close();
            }   
        }

        #endregion

        #region EventHandlers

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            try {
                CadastrarAnuncio();
            } catch (Exception ex) {
                throw ex;
            }
        }

        #endregion

        #region Constructors

        public Cadastro() {
            InitializeComponent();
        }

        #endregion
    }
}
