using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summerland.BL.ViewModels
{
	/// <summary>
	/// View model for Price List views.
	/// </summary>
	public class PriceList
	{
		private const decimal ExchangeRatePoundsToEuros = 1.20M;

		public decimal PricePerGuestPounds
		{
			get { return 90M; }
		}

		public decimal PricePartyOfTwoPounds
		{
			get { return this.PricePerGuestPounds * 2; }
		}

		public decimal PricePerGuestEuros
		{
			get { return this.PricePerGuestPounds * ExchangeRatePoundsToEuros; }
		}

		public decimal PricePartyOfTwoEuros
		{
			get { return this.PricePartyOfTwoPounds * ExchangeRatePoundsToEuros; }
		}
	}
}
