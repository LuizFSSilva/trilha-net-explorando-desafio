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

        //Implementação da verificação da contagem de hóspedes e a capacidade
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count >= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Hóspedes acima da capacidade. Programa encerrado");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        //Implementado método que retorna a quantidade de Hóspedes
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        //Cálculo do valor da diária com desconto aplicado
        public decimal CalcularValorDiaria()
        {
            decimal desconto = 1;
            if (DiasReservados >= 10)
            {
                desconto = 0.9M;
            }

            decimal valor = DiasReservados * Suite.ValorDiaria * desconto;

            return valor;
        }
    }
}