﻿namespace UserRegistration.Domain.Address
{
	public struct AddressModel
	{
        public int Id { get; set; }

        public string ZipCode { get; set; }

		public string State { get; set; }

		public string City { get; set; }

		public string Neighborhood { get; set; }

		public string Street { get; set; }

		public string Number { get; set; }

		public string Complement { get; set; }

		public string Reference { get; set; }

		public bool IsAmazonasState()
		{
			return State == "AM";
		}
	}
}

