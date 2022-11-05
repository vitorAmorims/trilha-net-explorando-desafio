using System.Globalization;
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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade == hospedes.Count())
            {
                
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception("Capacidade menor que o número de hóspedes recebido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Suite.Capacidade;
        }

        public decimal CalcularValorDiaria()
        {
            int dezDias = 10;
            decimal valor = Suite.ValorDiaria;

            if(DiasReservados >= dezDias)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Hospedagem com promoção!");
                Console.WriteLine("-------------------------");
                var desconto = (Suite.ValorDiaria / 10);
                valor = valor - desconto;
            }
            Console.WriteLine($"Valor total da hospedagem: {CalcularValorTotalHospedagem(valor).ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
            return valor;
        }
        public decimal CalcularValorTotalHospedagem(decimal valor)
        {
            return DiasReservados * valor;
        }

        public void NomesDosHospedes(List<Pessoa> Hospedes)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Estavam hospedados:");
            foreach (var hospede in Hospedes)
            {
                System.Console.WriteLine(hospede.NomeCompleto);
            }
        }
    }
}
