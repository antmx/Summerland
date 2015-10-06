using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Summerland.BL
{
	public class StringUtil
	{
		public static bool IsEmailAddress(string str)
		{
			if (string.IsNullOrEmpty(str) || !Regex.IsMatch(str, "^.+@.+\\..{2,10}$"))
			{
				return false;
			}

			return true;
		}
	}
}
