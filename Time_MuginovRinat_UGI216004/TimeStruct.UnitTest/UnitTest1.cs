using NUnit.Framework;

namespace TimeStruct.UnitTest
{
    [TestFixture]
    public class TimeTests
    {
        [Test]
        public void ConstructorTest()
        {
            var time = new Time(12, 18, 21);
            Assert.That(time.Hours, Is.EqualTo(12));
            Assert.That(time.Minutes, Is.EqualTo(18));
            Assert.That(time.Seconds, Is.EqualTo(21));
        }
        [TestCase(-30)]
        [TestCase(75)]
        public void MinutesSet_NegativeOrBigValue_ArgumentException(int val)
        {
            var time = new Time();
            Assert.That(() => time.Minutes = val, Throws.ArgumentException);
        }
        [TestCase(-30)]
        [TestCase(75)]
        public void SecondsSet_NegativeOrBigValue_ArgumentException(int val)
        {
            var time = new Time();
            Assert.That(() => time.Seconds = val, Throws.ArgumentException);
        }
        [TestCase(15, 42, 18, 56538)]
        [TestCase(0, 0, 0, 0)]
        public void DurationInSecondsTest(int hours, int minutes, int sceconds, int result)
        {
            var time = new Time(hours, minutes, sceconds);
            Assert.That(time.DurationInSeconds, Is.EqualTo(result));
        }
        [TestCase(15, 42, 18, "15:42:18\"")]
        [TestCase(0, 0, 0, "0:0:0\"")]
        public void ToStringTest(int hours, int minutes, int seconds, string result)
        {
            var time = new Time(hours, minutes, seconds);
            Assert.That(time.ToString(), Is.EqualTo(result));
        }
        [TestCase(30, 30, true)]
        [TestCase(30, 15, false)]
        public void Equals_TwoTimes_ExpectedResult(int hours1, int hours2, bool result)
        {
            var time1 = new Time(hours1, 0, 0);
            var time2 = new Time(hours2, 0, 0);
            Assert.That(time1.Equals(time2), Is.EqualTo(result));
        }
        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var angle = new Time();
            var smth = new object();
            Assert.That(() => angle.Equals(smth), Throws.ArgumentException);
        }
        [Test]
        public static void GetHashCodeTest()
        {
            var x = new Time(45, 18, 31);
            var y = new Time(45, 18, 31);
            var z = new Time(10, 45, 7);
            Assert.That(x.Equals(y), Is.True);
            Assert.That(x.Equals(z), Is.False);
        }
        [Test]
        public static void ComparisonTest()
        {
            var x = new Time(45, 18, 31);
            var y = new Time(45, 18, 31);
            var z = new Time(10, 45, 50);
            Assert.That(x == y, Is.True);
            Assert.That(x != y, Is.False);
            Assert.That(x == z, Is.False);
            Assert.That(x != z, Is.True);

            Assert.That(x > z, Is.True);
            Assert.That(z > x, Is.False);

            Assert.That(x < z, Is.False);
            Assert.That(z < x, Is.True);

            Assert.That(x >= y, Is.True);
            Assert.That(y >= x, Is.True);
            Assert.That(z >= x, Is.False);

            Assert.That(x <= y, Is.True);
            Assert.That(y <= x, Is.True);
            Assert.That(x <= z, Is.False);

        }

        [TestCase(30, 40, 50, 20, 30, 40, 51, 11, 30)]
        [TestCase(30, 40, 50, 0, 0, 0, 30, 40, 50)]
        [TestCase(0, 0, 59, 0, 0, 2, 0, 1, 1)]
        public void AdditionTest(int hours1, int minutes1, int seconds1,
                                int hours2, int minutes2, int seconds2,
                                int resultHours, int resultMinutes, int resultSeconds)
        {
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            var result = new Time(resultHours, resultMinutes, resultSeconds);

            Assert.That(time1 + time2, Is.EqualTo(result));
        }
        [TestCase(0, 0, 59, 0, 2, 0)]
        public void SubtractionExpectedResult(int hours1, int minutes1, int seconds1,
                        int hours2, int minutes2, int seconds2)
        {
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);

            Assert.That(() => time1-time2, Throws.ArgumentException);
        }
        [TestCase(30, 40, 50, 30, 40, 50, 0, 0, 0)]
        [TestCase(30, 40, 50, 0, 0, 0, 30, 40, 50)]
        [TestCase(0, 2, 0, 0, 0, 2, 0, 1, 58)]
        public void SubtractionTest(int hours1, int minutes1, int seconds1,
                int hours2, int minutes2, int seconds2,
                int resultHours, int resultMinutes, int resultSeconds)
        {
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            var result = new Time(resultHours, resultMinutes, resultSeconds);

            Assert.That(time1 - time2, Is.EqualTo(result));
        }

        [TestCase(2, 31, 41, 51, 63, 23, 42)]
        [TestCase(0.5, 31, 41, 51, 15, 50, 56)]
        public void MultiplicationTest(double k,
                                       int hours, int minutes, int seconds,
                                       int resultHours, int resultMinutes, int resultSeconds)
        {
            var time = new Time(hours, minutes, seconds);
            var result = new Time(resultHours, resultMinutes, resultSeconds);
            Assert.That(k * time, Is.EqualTo(result));
        }
    }
}
    