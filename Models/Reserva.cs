namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade menor que o número de hospedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiariaHospedes = DiasReservados * Suite.ValorDiaria;
            decimal valor = valorDiariaHospedes;

            if (DiasReservados >= 10)
            {
                double percentual = Convert.ToDouble(valorDiariaHospedes) * 0.10;
                decimal valorFinal = valorDiariaHospedes - Convert.ToDecimal(percentual);
                valor = valorFinal;
            }

            return valor;
        }
    }
}