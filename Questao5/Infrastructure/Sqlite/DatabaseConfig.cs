﻿using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Sqlite
{
    public class DatabaseConfig
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Name { get; set; }
        public List<ContaCorrenteModel> ContaCorrenteModel { get; internal set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
