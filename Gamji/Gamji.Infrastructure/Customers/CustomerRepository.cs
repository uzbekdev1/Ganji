﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamji.Core.Interfaces;
using Gamji.Core.Models;

namespace Gamji.Infrastructure.Customers
{
	public class CustomerRepository : ICustomerRepository
	{
		public Customer GetCustomer(int id)
		{
			return new Customer();
		}


		public Customer GetCustomerByEmail(string EmailId)
		{
			return new Customer();
		}


		public Customer ValidateCustomerLogin(string EmailId, string Password)
		{
			return new Customer();
		}


		public Customer AddNewCustomer(Customer c)
		{
			return new Customer();
		}

		public Customer ForgotPassword(string EmailId)
		{
			return new Customer();
		}

		public Customer ResetPassword(string EmailId, string VerificationCode, string NewPassword)
		{
			return new Customer();
		}
	}
}
