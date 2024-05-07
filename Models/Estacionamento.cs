namespace ParkingSystem.NET.Models
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
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Usuário digita a placa do veículo
            string placaVeiculo;
            do
            {
                placaVeiculo = Console.ReadLine();
                if (string.IsNullOrEmpty(placaVeiculo))
                {
                    Console.WriteLine("Digite a placa do veículo que deseja estacionar.");
                }
            } while (string.IsNullOrEmpty(placaVeiculo));

            // Adicionando o veiculo na lista de "veiculos" através da placa
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            //Usuário digita a placa e o valor é armazenado na variavel placa
            string placa;
            do
            {
                placa = Console.ReadLine();
                if (string.IsNullOrEmpty(placa))
                {
                    Console.WriteLine("Digite a placa do veículo que deseja retirar do estacionamento.");
                }
            } while (string.IsNullOrEmpty(placa));

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas;
                decimal valorTotal = 0;

                // Quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                do
                {
                    horas = int.Parse(Console.ReadLine());
                    if (string.IsNullOrEmpty(horas.ToString()))
                    {
                        Console.WriteLine("Por favor, digite as horas que o veículo permaneceu estaciondo!");
                    }
                } while (string.IsNullOrEmpty(horas.ToString()));


                // Calculando o proço do serviço de estacionamento
                Console.WriteLine("Calculando...");
                valorTotal = precoInicial + precoPorHora * horas;

                // Remover o veículo da lista pela placa digitada
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo com a placa {placa} foi removido e o preço total é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Laço de repetição para exibir os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
