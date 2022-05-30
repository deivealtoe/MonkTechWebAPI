using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Models;

namespace MonkTechWebAPI.Configurations.Seeding
{
    public class ModuleSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            Salao best = new Salao { Id = 1, Cnpj = "01234567890123", RazaoSocial = "Best" };
            Salao awesome = new Salao { Id = 2, Cnpj = "09876543210987", RazaoSocial = "Awesome" };
            Salao good = new Salao { Id = 3, Cnpj = "13579123456789", RazaoSocial = "Good" };

            builder.Entity<Salao>().HasData(best, awesome, good);

            Endereco vitoria = new Endereco { Id = 1, Estado = "Espírito Santo", Cidade = "Vitória", Bairro = "Jardim da Penha", Rua = "Clotilde", Numero = "SN", Cep = "29000000", SalaoId = best.Id };
            Endereco guarapari = new Endereco { Id = 2, Estado = "Espírito Santo", Cidade = "Guarapari", Bairro = "Cordoado", Rua = "America", Numero = "22", Cep = "29555000", SalaoId = awesome.Id };
            Endereco serra = new Endereco { Id = 3, Estado = "Espírito Santo", Cidade = "Serra", Bairro = "Laranjeiras", Rua = "Copacabana", Numero = "1", Cep = "29888000", SalaoId = good.Id };

            builder.Entity<Endereco>().HasData(vitoria, guarapari, serra);

            Agenda um = new Agenda 
            { 
                Id = 1, 
                Dia = DateTime.Today, 
                HoraInicio = "13:00", 
                HoraFim = "14:00", 
                NomeDoCliente = "Maria", 
                TelefoneDoCliente = "999998888",
                SalaoId = best.Id
            };
            Agenda dois = new Agenda
            {
                Id = 2,
                Dia = DateTime.Today,
                HoraInicio = "11:00",
                HoraFim = "12:30",
                NomeDoCliente = "Roberta",
                TelefoneDoCliente = "911113333",
                SalaoId = good.Id
            };
            Agenda tres = new Agenda
            {
                Id = 3,
                Dia = DateTime.Today,
                HoraInicio = "08:20",
                HoraFim = "10:00",
                NomeDoCliente = "Carla",
                TelefoneDoCliente = "977776666",
                SalaoId = awesome.Id
            };

            builder.Entity<Agenda>().HasData(um, dois, tres);
        }
    }
}
