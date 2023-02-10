namespace AstrologyVersusAstronomy.Services
{
	public class AstrologyServiceLayer : IAstrologyServiceLayer
	{
		//This is text from Todd to test out the Git branch!

		// Use conditionals to determine, and return an astrological sign based on the user's
		// birthdate. Feel free to use the common ones - https://www.britannica.com/topic/zodiac,
		// or invent your own!
		public string GetAstrologicalSign(string month, int dayOfMonth)
		{
			string astrologicalSign = "";
			switch (month)
			{
				case "January":
					if (dayOfMonth <= 19) astrologicalSign = "Capricornus";
					else astrologicalSign = "Aquarius";
					break;
				case "February":
					if (dayOfMonth <= 18) astrologicalSign = "Aquarius";
					else astrologicalSign = "Pisces";
					break;
				case "March":
					if (dayOfMonth <= 20) astrologicalSign = "Pisces";
					else astrologicalSign = "Aries";
					break;
				case "April":
					if (dayOfMonth <= 19) astrologicalSign = "Aries";
					else astrologicalSign = "Taurus";
					break;
				case "May":
					if (dayOfMonth <= 20) astrologicalSign = "Taurus";
					else astrologicalSign = "Gemini";
					break;
				case "June":
					if (dayOfMonth <= 21) astrologicalSign = "Gemini";
					else astrologicalSign = "Cancer";
					break;
				case "July":
					if (dayOfMonth <= 22) astrologicalSign = "Cancer";
					else astrologicalSign = "Leo";
					break;
				case "August":
					if (dayOfMonth <= 22) astrologicalSign = "Leo";
					else astrologicalSign = "Virgo";
					break;
				case "September":
					if (dayOfMonth <= 22) astrologicalSign = "Virgo";
					else astrologicalSign = "Libra";
					break;
				case "October":
					if (dayOfMonth <= 23) astrologicalSign = "Libra";
					else astrologicalSign = "Scorpius";
					break;
				case "November":
					if (dayOfMonth <= 21) astrologicalSign = "Scorpius";
					else astrologicalSign = "Sagittarius";
					break;
				case "December":
					if (dayOfMonth <= 21) astrologicalSign = "Sagittarius";
					else astrologicalSign = "Capricornus";
					break;
			}
			//TEST
			return astrologicalSign;
		}


		// Use conditionals to determine, then return a horoscope / prediction for the future 
		// based on the astrological sign of the user that you generated in the above method.
		// Be creative!
		public string GetHoroscope(string astrologicalSign)
		{
			return string.Empty;
		}

		
	}
}
