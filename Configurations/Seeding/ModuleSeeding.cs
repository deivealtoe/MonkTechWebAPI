using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Models;

namespace MonkTechWebAPI.Configurations.Seeding
{
    public class ModuleSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            Salao salaoUm = new Salao { Id = 1, Cnpj = "00000000000000", RazaoSocial = "Salão 01" };
            Salao salaoDois = new Salao { Id = 2, Cnpj = "11111111111111", RazaoSocial = "Salão 02" };
            Salao salaoTres = new Salao { Id = 3, Cnpj = "22222222222222", RazaoSocial = "Salão 03" };
            Salao salaoQuatro = new Salao { Id = 4, Cnpj = "33333333333333", RazaoSocial = "Salão 04" };
            Salao salaoCinco = new Salao { Id = 5, Cnpj = "44444444444444", RazaoSocial = "Salão 05" };

            builder.Entity<Salao>().HasData(salaoUm, salaoDois, salaoTres, salaoQuatro, salaoCinco);

            Endereco enderecoUm = new Endereco { Id = 1, Pais = "País 01", Estado = "Estado 01", Cidade = "Cidade 01", Bairro = "Bairro 01", Rua = "Rua 01", Numero = "01", Cep = "29000000", SalaoId = salaoUm.Id };
            Endereco enderecoDois = new Endereco { Id = 2, Pais = "País 02", Estado = "Estado 02", Cidade = "Cidade 02", Bairro = "Bairro 02", Rua = "Rua 02", Numero = "02", Cep = "29200000", SalaoId = salaoDois.Id };
            Endereco enderecoTres = new Endereco { Id = 3, Pais = "País 03", Estado = "Estado 03", Cidade = "Cidade 03", Bairro = "Bairro 03", Rua = "Rua 03", Numero = "03", Cep = "29300000", SalaoId = salaoTres.Id };
            Endereco enderecoQuatro = new Endereco { Id = 4, Pais = "País 02", Estado = "Estado 02", Cidade = "Cidade 04", Bairro = "Bairro 04", Rua = "Rua 04", Numero = "SN", Cep = "29400000", SalaoId = salaoQuatro.Id };
            Endereco enderecoCinco = new Endereco { Id = 5, Pais = "País 03", Estado = "Estado 03", Cidade = "Cidade 03", Bairro = "Bairro 04", Rua = "Rua 03", Numero = "05", Cep = "29550000", SalaoId = salaoCinco.Id };

            builder.Entity<Endereco>().HasData(enderecoUm, enderecoDois, enderecoTres, enderecoQuatro, enderecoCinco);

            Agenda agendaUm = new Agenda 
            { 
                Id = 1, 
                Dia = DateTime.Today, 
                HoraInicio = "13:00", 
                HoraFim = "14:00", 
                SalaoId = salaoUm.Id
            };
            Agenda agendaDois = new Agenda
            {
                Id = 2,
                Dia = DateTime.Today,
                HoraInicio = "11:00",
                HoraFim = "12:30",
                SalaoId = salaoUm.Id
            };
            Agenda agendaTres = new Agenda
            {
                Id = 3,
                Dia = DateTime.Today,
                HoraInicio = "08:20",
                HoraFim = "10:00",
                SalaoId = salaoDois.Id
            };
            Agenda agendaQuatro = new Agenda
            {
                Id = 4,
                Dia = DateTime.Today,
                HoraInicio = "07:20",
                HoraFim = "09:00",
                SalaoId = salaoDois.Id
            };
            Agenda agendaCinco = new Agenda
            {
                Id = 5,
                Dia = DateTime.Today,
                HoraInicio = "08:20",
                HoraFim = "10:00",
                SalaoId = salaoTres.Id
            };
            Agenda agendaSeis = new Agenda
            {
                Id = 6,
                Dia = DateTime.Today,
                HoraInicio = "08:20",
                HoraFim = "10:00",
                SalaoId = salaoQuatro.Id
            };
            Agenda agendaSete = new Agenda
            {
                Id = 7,
                Dia = DateTime.Today,
                HoraInicio = "08:20",
                HoraFim = "10:00",
                SalaoId = salaoCinco.Id
            };

            builder.Entity<Agenda>().HasData(
                agendaUm, agendaDois, agendaTres, agendaQuatro, agendaCinco, agendaSeis, agendaSete
            );
        }
    }
}
