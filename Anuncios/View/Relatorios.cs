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

    public partial class Relatorios : Form {

        #region Attributes


        #endregion

        #region Methods

        private void FiltrarAnuncio() {
            AnuncioPst anuncioPst = null;
            DateTime? datafinal = null;
            DateTime? datainicio = null;

            try {
                anuncioPst = new AnuncioPst();

                string cliente = txtCliente.Text;
                if (ckDtFinal.Checked) {
                    datafinal = dtTermino.Value.Date;
                }
                if (ckDtInicio.Checked) {
                    datainicio = dtInicio.Value.Date;
                }

                dtRelatorio.DataSource = anuncioPst.Pesquisar(cliente, datainicio, datafinal);

            } catch (Exception ex) {

                MessageBox.Show("Error:- " + ex.Message);

            } finally {
                anuncioPst = null;
            }

        }

        #endregion

        #region EventHandlers

        private void button2_Click(object sender, EventArgs e) {
            this.Close();

        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            FiltrarAnuncio();
        }

        #endregion

        #region Constructors

        public Relatorios() {
            InitializeComponent();
            dtInicio.Enabled = false;
            dtTermino.Enabled = false;
        }

        #endregion

        private void ckDtInicio_CheckedChanged(object sender, EventArgs e) {
            if (ckDtInicio.Checked) {
                dtInicio.Enabled = true;
            } else {
                dtInicio.Enabled = false;
            }
        }

        private void ckDtFinal_CheckedChanged(object sender, EventArgs e) {
            if (ckDtFinal.Checked) { 
                dtTermino.Enabled = true;
            } else {
                dtTermino.Enabled = false;
            }
        }
    }
}
