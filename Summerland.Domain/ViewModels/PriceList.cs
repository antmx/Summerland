using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summerland.Domain.ViewModels
{
	/// <summary>
	/// View model for Price List views.
	/// </summary>
	public class PriceList
	{
		private const decimal ExchangeRatePoundsToEuros = 1.27M;

		public decimal PricePerGuestPounds
		{
			get { return 90M; }
		}

		public decimal PricePerGuestEuros
		{
			get { return this.PricePerGuestPounds * ExchangeRatePoundsToEuros; }
		}
	}
}
