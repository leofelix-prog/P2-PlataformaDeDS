
using System;
using System.Collections.Generic;
using SalaDeReunioes.Models;

namespace SalaDeReunioes.Dados
{
    internal class DisponibilidadeRepositorio
    {
        public List<Sala> ConsultarDisponibilidade(DateTime dataInicial, DateTime dataFinal)
        {
            if (dataFinal.Date < dataInicial.Date)
            {
                throw new ArgumentException("A data final não pode ser anterior à data inicial.");
            }

            SalaRepositorio salaRepositorio = new SalaRepositorio();
            ReservaRepositorio reservaRepositorio = new ReservaRepositorio();

            List<Sala> salas = salaRepositorio.ConsultarTodos();
            List<Reserva> reservas = reservaRepositorio.ConsultarTodos();

            int quantidadeDias = (dataFinal.Date - dataInicial.Date).Days + 1;
            decimal horasTotais = quantidadeDias * 11m;

            foreach (Sala sala in salas)
            {
                sala.HorasLivres = horasTotais;

                foreach (Reserva reserva in reservas)
                {
                    if (reserva.SalaId != sala.Id)
                    {
                        continue;
                    }

                    DateTime primeiroDia = dataInicial.Date;
                    if (reserva.Inicio.Date > primeiroDia)
                    {
                        primeiroDia = reserva.Inicio.Date;
                    }

                    DateTime ultimoDia = dataFinal.Date;
                    if (reserva.Fim.Date < ultimoDia)
                    {
                        ultimoDia = reserva.Fim.Date;
                    }

                    for (DateTime dia = primeiroDia; dia <= ultimoDia; dia = dia.AddDays(1))
                    {
                        DateTime inicioExpediente = dia.AddHours(8);
                        DateTime fimExpediente = dia.AddHours(19);

                        DateTime inicioOcupado = reserva.Inicio > inicioExpediente
                            ? reserva.Inicio
                            : inicioExpediente;

                        DateTime fimOcupado = reserva.Fim < fimExpediente
                            ? reserva.Fim
                            : fimExpediente;

                        if (fimOcupado > inicioOcupado)
                        {
                            decimal horasOcupadas = Convert.ToDecimal(
                                (fimOcupado - inicioOcupado).TotalHours
                            );

                            sala.HorasLivres -= horasOcupadas;
                        }
                    }
                }
            }

            salas.Sort((sala1, sala2) =>
                sala2.HorasLivres.CompareTo(sala1.HorasLivres)
            );

            return salas;
        }
    }
}
