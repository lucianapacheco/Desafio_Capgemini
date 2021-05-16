using Business.Classes.Anuncio.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Business.Classes.Anuncio.Persistence {

    /* File History
     * --------------------------------------------------------------------
     * Created by : Luciana Pacheco
     * Date       : 10/05/2021
     * Purpose    : Criação da Pst da Estatística do Anúncio
     * --------------------------------------------------------------------
     */

    public class AnuncioPst {
        #region Connection

        public SqlConnection _con = new SqlConnection("Data Source = .\\SQL2019; Connection Timeout = 10; Initial Catalog = divulga_tudo; User Id= sa; Password = Root1526; MultipleActiveResultSets=True; Pooling=True; Min Pool Size=5; Max Pool Size=750;");

        #endregion

        #region Methods

        /* Incluir Anuncio */
        public bool Incluir(AnuncioMdl Anuncio) {
            int i;

            using (SqlCommand Command = new SqlCommand("stp_anuncio_incluir", _con)) {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@cliente", Anuncio.Cliente);
                Command.Parameters.AddWithValue("@nome_anuncio", Anuncio.NomeAnuncio);
                Command.Parameters.AddWithValue("@data_inicio", Anuncio.DataInicio);
                Command.Parameters.AddWithValue("@data_termino", Anuncio.DataTermino);
                Command.Parameters.AddWithValue("@investimento_dia", Anuncio.InvestimentoDia);
                Command.Parameters.AddWithValue("@quantidade_maxima_visualizacao", Anuncio.QuantidadeMaximaVisualizacao);
                Command.Parameters.AddWithValue("@quantidade_maxima_cliques", Anuncio.QuantidadeMaximaCliques);
                Command.Parameters.AddWithValue("@quantidade_maxima_compartilhamento", Anuncio.QuantidadeMaximaCompartilhamento);

                _con.Open();

                i = Command.ExecuteNonQuery();
            }
            _con.Close();
            return i >= 1;
        }

        /* Pesquisar Anuncio */
        public List<AnuncioMdl> Pesquisar(string cliente, DateTime? data_inicio, DateTime? data_termino) {
            List<AnuncioMdl> Anuncios = new List<AnuncioMdl>();

            using (SqlCommand Command = new SqlCommand("stp_anuncio_pesquisar", _con)) {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@cliente", cliente);
                Command.Parameters.AddWithValue("@data_termino", data_termino);
                Command.Parameters.AddWithValue("@data_inicio", data_inicio);

                _con.Open();

                SqlDataReader reader = Command.ExecuteReader();
                
                while (reader.Read()) {
                    AnuncioMdl Anuncio = new AnuncioMdl();
                    Int32 teste = Convert.ToInt32(reader["id"]);
                    String teste1 = (reader["cliente"]).ToString();
                    Anuncio.Id = Convert.ToInt32(reader["id"]);
                    if (reader["cliente"] != DBNull.Value) {
                        Anuncio.Cliente = (reader["cliente"]).ToString();
                    }
                    if (reader["nome_anuncio"] != DBNull.Value) {
                        Anuncio.NomeAnuncio = Convert.ToString(reader["nome_anuncio"]);
                    }
                    if (reader["data_inicio"] != DBNull.Value) {
                        Anuncio.DataInicio = Convert.ToDateTime(reader["data_inicio"]);
                    }
                    if (reader["data_termino"] != DBNull.Value) {
                        Anuncio.DataTermino = Convert.ToDateTime(reader["data_termino"]);
                    }
                    if (reader["investimento_dia"] != DBNull.Value) {
                        Anuncio.InvestimentoDia = Convert.ToDouble(reader["investimento_dia"]);
                    }
                    if (reader["quantidade_maxima_visualizacao"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaVisualizacao = Convert.ToInt32(reader["quantidade_maxima_visualizacao"]);
                    }
                    if (reader["quantidade_maxima_cliques"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaCliques = Convert.ToInt32(reader["quantidade_maxima_cliques"]);
                    }
                    if (reader["quantidade_maxima_compartilhamento"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaCompartilhamento = Convert.ToInt32(reader["quantidade_maxima_compartilhamento"]);
                    }

                    Anuncios.Add(Anuncio);
                }
                _con.Close();

                return Anuncios;
            }
        }

        /* Pesquisar Anuncio */
        public List<AnuncioMdl> Pesquisar(string nome_anuncio) {

            List<AnuncioMdl> Anuncios = new List<AnuncioMdl>();

            using (SqlCommand Command = new SqlCommand("stp_anuncio_pesquisar", _con)) {
                Command.CommandType = CommandType.StoredProcedure;
                _con.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read()) {
                    AnuncioMdl Anuncio = new AnuncioMdl();

                    Anuncio.Id = Convert.ToInt32(reader["id"]);
                    if (reader["cliente"] != DBNull.Value) {
                        Anuncio.Cliente = Convert.ToString(reader["cliente"]);
                    }
                    if (reader["nome_anuncio"] != DBNull.Value) {
                        Anuncio.NomeAnuncio = Convert.ToString(reader["nome_anuncio"]);
                    }
                    if (reader["data_inicio"] != DBNull.Value) {
                        Anuncio.DataInicio = Convert.ToDateTime(reader["data_inicio"]);
                    }
                    if (reader["data_termino"] != DBNull.Value) {
                        Anuncio.DataTermino = Convert.ToDateTime(reader["data_termino"]);
                    }
                    if (reader["investimento_dia"] != DBNull.Value) {
                        Anuncio.InvestimentoDia = Convert.ToDouble(reader["investimento_dia"]);
                    }
                    if (reader["quantidade_maxima_visualizacao"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaVisualizacao = Convert.ToInt32(reader["quantidade_maxima_visualizacao"]);
                    }
                    if (reader["quantidade_maxima_cliques"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaCliques = Convert.ToInt32(reader["quantidade_maxima_cliques"]);
                    }
                    if (reader["quantidade_maxima_compartilhamento"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaCompartilhamento = Convert.ToInt32(reader["quantidade_maxima_compartilhamento"]);
                    }

                    Anuncios.Add(Anuncio);
                }
                _con.Close();

                return Anuncios;
            }
        }

        public List<AnuncioMdl> Pesquisar() {

            List<AnuncioMdl> Anuncios = new List<AnuncioMdl>();

            using (SqlCommand Command = new SqlCommand("stp_anuncio_pesquisar", _con)) {
                Command.CommandType = CommandType.StoredProcedure;
                _con.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read()) {
                    AnuncioMdl Anuncio = new AnuncioMdl();

                    Anuncio.Id = Convert.ToInt32(reader["id"]);
                    if (reader["cliente"] != DBNull.Value) {
                        Anuncio.Cliente = Convert.ToString(reader["cliente"]);
                    }
                    if (reader["nome_anuncio"] != DBNull.Value) {
                        Anuncio.NomeAnuncio = Convert.ToString(reader["nome_anuncio"]);
                    }
                    if (reader["data_inicio"] != DBNull.Value) {
                        Anuncio.DataInicio = Convert.ToDateTime(reader["data_inicio"]);
                    }
                    if (reader["data_termino"] != DBNull.Value) {
                        Anuncio.DataTermino = Convert.ToDateTime(reader["data_termino"]);
                    }
                    if (reader["investimento_dia"] != DBNull.Value) {
                        Anuncio.InvestimentoDia = Convert.ToDouble(reader["investimento_dia"]);
                    }
                    if (reader["quantidade_maxima_visualizacao"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaVisualizacao = Convert.ToInt32(reader["quantidade_maxima_visualizacao"]);
                    }
                    if (reader["quantidade_maxima_cliques"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaCliques = Convert.ToInt32(reader["quantidade_maxima_cliques"]);
                    }
                    if (reader["quantidade_maxima_compartilhamento"] != DBNull.Value) {
                        Anuncio.QuantidadeMaximaCompartilhamento = Convert.ToInt32(reader["quantidade_maxima_compartilhamento"]);
                    }
                    Anuncios.Add(Anuncio);
                }
                _con.Close();

                return Anuncios;
            }
        }

        /* Alterar Anúncio */
        public void Alterar(AnuncioMdl Anuncio) {

            using (SqlCommand Command = new SqlCommand("stp_anuncio_alterar", _con)) {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@id", Anuncio.Id);
                Command.Parameters.AddWithValue("@cliente", Anuncio.Cliente);
                Command.Parameters.AddWithValue("@nome_anuncio", Anuncio.NomeAnuncio);
                Command.Parameters.AddWithValue("@data_inicio", Anuncio.DataInicio);
                Command.Parameters.AddWithValue("@data_termino", Anuncio.DataTermino);
                Command.Parameters.AddWithValue("@investimento_dia", Anuncio.InvestimentoDia);
                Command.Parameters.AddWithValue("@quantidade_maxima_visualizacao", Anuncio.QuantidadeMaximaVisualizacao);
                Command.Parameters.AddWithValue("@quantidade_maxima_cliques", Anuncio.QuantidadeMaximaCliques);
                Command.Parameters.AddWithValue("@quantidade_maxima_compartilhamento", Anuncio.QuantidadeMaximaCompartilhamento);

                _con.Open();

                Command.ExecuteNonQuery();
            }
            _con.Close();
        }

        /* Excluir Anúncio */
        public bool Excluir(int id) {
            int i;

            using (SqlCommand Command = new SqlCommand("stp_anuncio_excluir", _con)) {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@id", id);

                _con.Open();

                i = Command.ExecuteNonQuery();
            }
            _con.Close();
            return i >= 1;
        }

        public List<Int32> Calcular(double investimento) {

            List<Int32> estatisticas = new List<Int32>();

            double valor = 0.0;
            Int32 operacao = 0;
            Int32 totalVisualizacao = 0;
            Int32 totalCompartilhamento = 0;
            Int32 totalCliques = 0;
            Int32 vezesCompartilhada = 0;
            Int32 cliquesAtual = 0;
            Int32 compartilhamentoAtual = 0;
            Boolean visualizacao = true;

            while (vezesCompartilhada <= 4 && visualizacao == true) {
                if (vezesCompartilhada < 1) {
                    valor = investimento;
                }

                if (vezesCompartilhada < 1) {
                    operacao = Convert.ToInt32(valor) * 30;
                }
                //tratando o total de visualizações
                totalVisualizacao += operacao;

                //tratando o total de cliques
                operacao = operacao / 100;
                operacao *= 12;
                cliquesAtual = operacao;
                totalCliques += operacao;

                //tratando o total de compartilhamentos
                operacao = cliquesAtual / 20;
                operacao *= 3;
                compartilhamentoAtual = operacao;
                totalCompartilhamento += operacao;

                if (vezesCompartilhada <= 4) {
                    operacao = compartilhamentoAtual * 40;
                }
                vezesCompartilhada++;
                if (operacao == 0) {
                    visualizacao = false;
                }
            }

            estatisticas.Add(totalVisualizacao);
            estatisticas.Add(totalCliques);
            estatisticas.Add(totalCompartilhamento);

            return estatisticas;
        }
    }
    #endregion
}


