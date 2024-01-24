using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using DesafioFundamentos.Utilitarios;

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
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Ferramentas.RetiraVazioString(Console.ReadLine());

            bool testeVazio = Ferramentas.EhVazio(placa);

            if(!testeVazio){
                veiculos.Add(placa);
            }else{
                Console.WriteLine("Placa inválida. Por favor tente novamente");
            }
            
        }


        public string AdicionarVeiculoTestes(string placaTeste)
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Ferramentas.RetiraVazioString(placaTeste);

            bool testeVazio = Ferramentas.EhVazio(placa);

            if(!testeVazio){
                veiculos.Add(placa);
                return placa;
            }else{
                Console.WriteLine("Placa inválida. Por favor tente novamente");
                return "Erro no teste";
            }
            
        }

        
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string placa = Ferramentas.RetiraVazioString(Console.ReadLine());


            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = Convert.ToInt32(Ferramentas.RetiraVazioString(Console.ReadLine()));
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");

            
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public string RemoverVeiculoTestes(string placaTeste, string horasTeste)
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string placa = Ferramentas.RetiraVazioString(placaTeste);
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = Convert.ToInt32(Ferramentas.RetiraVazioString(horasTeste));
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                return $"{placa} : {valorTotal}";

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

                return "Erro no teste";
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public List<string> ListarVeiculosTestes()
        {   
            List<string> listaCompleta = new List<string>();

            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"{item}");

                    listaCompleta.Add(item);
                    
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                
            }

            return listaCompleta;
        }



        public string procurarVeiculos(string placa){

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){

                return placa;

            }else{

                return "Placa não localizada";
            }
            
        }
    }
}
