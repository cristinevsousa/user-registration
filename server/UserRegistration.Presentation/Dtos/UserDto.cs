﻿namespace UserRegistration.Presentation.Dtos
{
	public class UserDto
	{
		public int Id { get; set; }

		public string Cpf { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }
	}
}