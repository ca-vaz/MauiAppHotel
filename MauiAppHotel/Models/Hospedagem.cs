namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoEscolhido { get; set; }
        public int QtdAdultos { get; set; }
        public int QtdCriancas { get; set; }

        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }

        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

        public double TotalHospedagem
        {
            get
            {
                double total_adultos = QtdAdultos * QuartoEscolhido.ValorAdultos;
                double total_criancas = QtdCriancas * QuartoEscolhido.ValorCriancas;

                return (total_adultos + total_criancas) * Estadia;
            }
        }
    }
}
