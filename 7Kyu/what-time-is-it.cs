using System;
using System.Text.RegularExpressions;
/*
 * Do not add any additional libraries
 */
public class TimeService
{

    public string GetMilitaryTimeFromStandardTime(string time) => $"{int.Parse(time.Split(':')[0]) % 12 + (time.Split(':')[2][2] == 'P' ? 12 : 0),2:D2}:{time.Split(':')[1]}:{time.Split(':')[2].Substring(0, 2)}";
}

namespace Bank
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class TimeServiceTests
    {

        private TimeService _timeService = new TimeService();

        [TestCase("12:00:01AM", "00:00:01")]
        [TestCase("11:46:47PM", "23:46:47")]
        public void TimeService_can_convert_from_12_hour_time_format_to_24_hour_time_format(string input, string expected)
        {
            var result = _timeService.GetMilitaryTimeFromStandardTime(input);
            Assert.AreEqual(result, expected);
        }
    }
}
