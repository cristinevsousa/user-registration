﻿using UserRegistration.Infrastructure.Adress;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserRegistration.Infrastructure.User
{
	public class UserEntity
	{
		public int Id { get; set; }

		public string Cpf { get; set; }

		public string Nome { get; set; }

		public string Sobrenome { get; set; }

		public DateTime DataNascimento { get; set; }

		public string Email { get; set; }

		public string Telefone { get; set; }
    }
}