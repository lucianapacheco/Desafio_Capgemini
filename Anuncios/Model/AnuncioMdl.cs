using System;

namespace Business.Classes.Anuncio.Model {

/* File History
 * --------------------------------------------------------------------
 * Created by : Luciana Pacheco
 * Date       : 10/05/2021
 * Purpose    : Criação da Mdl do Anúncio
 * --------------------------------------------------------------------
 */

    public class AnuncioMdl {

        public int Id { get; set; }
        public string Cliente { get; set; }
        public string NomeAnuncio { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public double InvestimentoDia { get; set; }
        public Int32 QuantidadeMaximaVisualizacao { get; set; }
        public Int32 QuantidadeMaximaCliques { get; set; }
        public Int32 QuantidadeMaximaCompartilhamento { get; set; }

    }
}
