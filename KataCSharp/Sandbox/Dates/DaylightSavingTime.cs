using System;

namespace KataCSharp.Sandbox.Dates
{
	public class DaylightSavingTime
	{
		public void Start()
		{
			TestDaylightSavingTime();
		}

		// get timezone in EET winter +2
		// get timezone in EET summer +3
		// validFrom 2024-02-20 10:00:00+3
		// get offset from winter timezone and summer date. expected +3
		// get offset from summer timezone and winter date. expected +3
	
		void TestDaylightSavingTime()
		{
			var timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
			foreach (var timeZoneInfoObj in timeZoneInfos)
			{
				Console.WriteLine(timeZoneInfoObj.StandardName + " " + timeZoneInfoObj.DisplayName + " " + timeZoneInfoObj.BaseUtcOffset + "| SupportsDaylightSavingTime " + timeZoneInfoObj.SupportsDaylightSavingTime);
			}

			TimeZoneInfo timeZoneInfoSummer = TimeZoneInfo.FindSystemTimeZoneById("Jordan Standard Time");
			//TimeZoneInfo timeZoneInfoSummer = TimeZoneInfo.FindSystemTimeZoneById("Eastern European Summer Time");
			var date = new DateTime(2024, 02, 20, 10, 00, 00, DateTimeKind.Unspecified);
			var timeZone = timeZoneInfoSummer.GetUtcOffset(date);
			var validFrom = new DateTimeOffset(date, timeZone);

			TimeZoneInfo timeZoneInfoWinter = TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time");
			var t = timeZoneInfoWinter.GetUtcOffset(validFrom);



		}
	}
}
