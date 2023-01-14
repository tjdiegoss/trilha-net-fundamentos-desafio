using static System.Console;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(ReadLine());
        }
        public void RemoverVeiculo()
        {
            WriteLine("Digite a placa do veículo para remover:");

            string placa = ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                WriteLine("Os veículos estacionados são:");
                
                int contador = 1;
                foreach (var item in veiculos)
                {
                    WriteLine($"Nº {contador}. Placa: {item}");
                    contador++;
                }
            }
            else
            {
                WriteLine("Não há veículos estacionados.");
            }
        }
    }
}