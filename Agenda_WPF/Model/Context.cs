﻿using Microsoft.EntityFrameworkCore;

namespace Agenda_WPF.Model
{
    class Context : DbContext
    {
        public Context() : base("DbAgendas")
        {

        }

        //Definir as classes que vão virar tabelas no banco
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
