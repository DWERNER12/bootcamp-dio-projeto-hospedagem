using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        /*
        public List<Suite>? Suites { get; set; }
        */
        public int DiasReservados { get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospede)
        {
            Hospedes = hospede;
        }
        public void CadastrarSuites(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            
            if (quantidadeHospedes <= Suite?.Capacidade)
            {
                Console.WriteLine("Quantidade de hospedes esta dentro do permitido. ");
            }
            else
            {
                Console.WriteLine($"Número de hospedes utrapassa limite de capacidade da suite escolhida.. {Exception.ReferenceEquals}");
            }

            return quantidadeHospedes;
        }
        public decimal CalcularValorDiaria()
        {
            decimal valorReserva = 0;
            decimal desconto = 0.10M;
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados > 10)
            {
                decimal ValorDoDesconto = valor * desconto;
                valorReserva = valor - ValorDoDesconto;
            }
            else
            {
                valorReserva = valor;
            }
            return valorReserva;
        }
    }
}