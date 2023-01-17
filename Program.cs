using ProjetoHospedagem.Models;

 class Program
{
    private static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "David", sobrenome: "Werner");
        Pessoa p2 = new Pessoa(nome: "Gabriela", sobrenome: "Werner");

        Suite s1 = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 120);

        hospedes.Add(p1);
        hospedes.Add(p2);

        Reserva novaReserva = new Reserva(diasReservados:12);
        novaReserva.CadastrarHospedes(hospedes);
        novaReserva.CadastrarSuites(s1);

        Console.WriteLine($"Hóspedos: {novaReserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor : {novaReserva.CalcularValorDiaria()}");
    }
}