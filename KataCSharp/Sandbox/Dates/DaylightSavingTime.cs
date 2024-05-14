using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace KataCSharp.Sandbox.Dates
{
	public class DaylightSavingTime
	{
		public void Start()
		{
			//var timeZoneInfoSummer = CustomSummerTimeZone();

			//var timeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
			//foreach (var timeZoneInfoObj in timeZoneInfos)
			//{
			//	Console.WriteLine(timeZoneInfoObj.StandardName + " " + timeZoneInfoObj.DisplayName + " " + timeZoneInfoObj.BaseUtcOffset + "| SupportsDaylightSavingTime " + timeZoneInfoObj.SupportsDaylightSavingTime);
			//}
			TestGetUtcOffset();
			//ShowStartAndEndDates();
			//TestDaylightSavingTime();
		}

		// get timezone in EET winter +2
		// get timezone in EET summer +3
		// validFrom 2024-02-20 10:00:00+3
		// get offset from winter timezone and summer date. expected +3
		// get offset from summer timezone and winter date. expected +3
		void TestGetUtcOffset()
		{
			var tz = TimeZoneInfo.Local;
			var dateSummer = new DateTimeOffset(2024, 02, 20, 12, 00, 00, new TimeSpan(3, 0, 0));
			dateSummer = dateSummer.ToUniversalTime();
			var dateWinter = new DateTimeOffset(2024, 02, 20, 12, 00, 00, new TimeSpan(2, 0, 0));
			dateWinter = dateWinter.ToUniversalTime();

			var t1 = tz.GetUtcOffset(dateSummer);
			var t2 = tz.GetUtcOffset(dateWinter);

		}

		void TestDaylightSavingTime()
		{
			var date = new DateTime(2024, 02, 20, 12, 00, 00);
			var tz = TimeZoneInfo.Local.GetUtcOffset(date);
			var dateTimeOffset = new DateTimeOffset(date, new TimeSpan(3,0,0));
			var timeZoneInfoWinter = TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time");
			var winterTZ = timeZoneInfoWinter.GetUtcOffset(dateTimeOffset);
			// winterTZ +2

			var timeZoneInfoSummer = CustomSummerTimeZone();
			var summerTZ = timeZoneInfoSummer.GetUtcOffset(dateTimeOffset);
			// summerTZ +3

			var localDate = dateTimeOffset.ToLocalTime();
			
			var date2 = new DateTime(2024, 02, 20, 12, 00, 00, DateTimeKind.Utc);

		}

		TimeZoneInfo CustomSummerTimeZone()
		{
			string displayName = "(GMT+03:00) EEST";
			string standardName = "Eastern European Summer Time";
			string daylightName = "Eastern European Summer Daylight Time";
			TimeSpan offset = new TimeSpan(3, 0, 0);

			var adjustmentList = CreateAdjustmentRules();

			TimeZoneInfo palmer = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName, daylightName, adjustmentList, disableDaylightSavingTime: true);

			//TimeZoneInfo.AdjustmentRule[] adjustments = palmer.GetAdjustmentRules();
			DisplayAdjustments(palmer);

			return palmer;
		}
		TimeZoneInfo.AdjustmentRule[] CreateAdjustmentRules()
		{
			TimeSpan delta = new TimeSpan(1, 0, 0);
			TimeZoneInfo.AdjustmentRule adjustment;
			List<TimeZoneInfo.AdjustmentRule> adjustmentList = new List<TimeZoneInfo.AdjustmentRule>();
			TimeZoneInfo.TransitionTime transitionRuleStart, transitionRuleEnd;
			transitionRuleStart = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, 2, 0, 0), 01, 05, DayOfWeek.Sunday);
			transitionRuleEnd = TimeZoneInfo.TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, 2, 0, 0), 11, 01, DayOfWeek.Sunday);
			adjustment = TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(new DateTime(1976, 1, 1), DateTime.MaxValue.Date, delta, transitionRuleStart, transitionRuleEnd);
			adjustmentList.Add(adjustment);

			return adjustmentList.ToArray();
		}
		private enum WeekOfMonth
		{
			First = 1,
			Second = 2,
			Third = 3,
			Fourth = 4,
			Last = 5,
		}

		private static void ShowStartAndEndDates()
		{
			// Get all time zones from system
			ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();
			// Get each time zone
			foreach (TimeZoneInfo timeZone in timeZones)
			{
				if (timeZone.StandardName != "FLE Standard Time") continue;
				
				DisplayAdjustments(timeZone);
			}
		}

		private static void DisplayAdjustments(TimeZoneInfo timeZone)
		{
			string[] monthNames = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

			TimeZoneInfo.AdjustmentRule[] adjustments = timeZone.GetAdjustmentRules();
			// Display message for time zones with no adjustments
			if (adjustments.Length == 0)
			{
				Console.WriteLine("{0} has no adjustment rules", timeZone.StandardName);
			}
			else
			{
				// Handle time zones with 1 or 2+ adjustments differently
				bool showCount = false;
				int ctr = 0;
				string spacer = "";

				Console.WriteLine("{0} Adjustment rules", timeZone.StandardName);
				if (adjustments.Length > 1)
				{
					showCount = true;
					spacer = "   ";
				}
				// Iterate adjustment rules
				foreach (TimeZoneInfo.AdjustmentRule adjustment in adjustments)
				{
					if (showCount)
					{
						Console.WriteLine("   Adjustment rule #{0}", ctr + 1);
						ctr++;
					}
					// Display general adjustment information
					Console.WriteLine("{0}   Start Date: {1:D}", spacer, adjustment.DateStart);
					Console.WriteLine("{0}   End Date: {1:D}", spacer, adjustment.DateEnd);
					Console.WriteLine("{0}   Time Change: {1}:{2:00} hours", spacer,
									  adjustment.DaylightDelta.Hours, adjustment.DaylightDelta.Minutes);
					// Get transition start information
					TimeZoneInfo.TransitionTime transitionStart = adjustment.DaylightTransitionStart;
					Console.Write("{0}   Annual Start: ", spacer);
					if (transitionStart.IsFixedDateRule)
					{
						Console.WriteLine("On {0} {1} at {2:t}",
										  monthNames[transitionStart.Month - 1],
										  transitionStart.Day,
										  transitionStart.TimeOfDay);
					}
					else
					{
						Console.WriteLine("The {0} {1} of {2} at {3:t}",
										  ((WeekOfMonth)transitionStart.Week).ToString(),
										  transitionStart.DayOfWeek.ToString(),
										  monthNames[transitionStart.Month - 1],
										  transitionStart.TimeOfDay);
					}
					// Get transition end information
					TimeZoneInfo.TransitionTime transitionEnd = adjustment.DaylightTransitionEnd;
					Console.Write("{0}   Annual End: ", spacer);
					if (transitionEnd.IsFixedDateRule)
					{
						Console.WriteLine("On {0} {1} at {2:t}",
										  monthNames[transitionEnd.Month - 1],
										  transitionEnd.Day,
										  transitionEnd.TimeOfDay);
					}
					else
					{
						Console.WriteLine("The {0} {1} of {2} at {3:t}",
										  ((WeekOfMonth)transitionEnd.Week).ToString(),
										  transitionEnd.DayOfWeek.ToString(),
										  monthNames[transitionEnd.Month - 1],
										  transitionEnd.TimeOfDay);
					}
				}
			}
			Console.WriteLine();
		}
	}
}
