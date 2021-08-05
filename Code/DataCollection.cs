#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

namespace GTIinsight.Shared
{
    public static class DataCollection
    {
        public static Period GetPeriod(int periodValue)
        {
            var year = Math.Floor(periodValue / 100m);
            var month = periodValue - (year * 100);

            return new Period((int)year, (int)month);
        }
        private static readonly List<GTIMetric> _gtiMetrics = new();
        private static Period _minPeriod;
        private static Period _maxPeriod;
        public static Period[] Periods;

        static DataCollection()
        {
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 9), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 10), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 11), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 12), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 1), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 2), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 3), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 4), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 5), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 6), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 7), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 8), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 9), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 10), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 11), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 12), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 1), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 2), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 3), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 4), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 5), 0, 0, 0));
            //_gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 6), 0, 0, 0));

            // DIGITECH
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2019, 9), 13, 8, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2019, 10), 12, 11, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2019, 11), 74, 49, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2019, 12), 92, 59, 33));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 1), 103, 67, 36));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 2), 192, 113, 79));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 3), 246, 158, 88));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 4), 229, 129, 100));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 5), 352, 197, 155));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 6), 601, 199, 402));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 7), 476, 154, 319));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 8), 413, 118, 290));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 9), 360, 112, 243));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 10), 488, 109, 230));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 11), 471, 111, 98));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 12), 492, 118, 109));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 1), 352, 73, 94));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 2), 275, 65, 51));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 3), 301, 67, 56));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 4), 248, 65, 38));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 5), 239, 50, 30));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 6), 253, 21, 16));
            
            // FinTech
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2019, 9), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2019, 10), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2019, 11), 21, 16, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2019, 12), 24, 14, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 1), 32, 23, 9));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 2), 41, 15, 26));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 3), 39, 23, 16));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 4), 29, 20, 9));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 5), 33, 16, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 6), 86, 33, 53));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 7), 77, 38, 39));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 8), 48, 18, 30));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 9), 77, 41, 36));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 10), 100, 32, 47));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 11), 120, 57, 21));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 12), 93, 43, 20));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 1), 80, 33, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 2), 108, 48, 26));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 3), 148, 44, 47));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 4), 155, 52, 39));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 5), 124, 33, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 6), 142, 25, 14));


            // AgTech
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2019, 9), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2019, 10), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2019, 11), 10, 6, /*<5*/ 4));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2019, 12), 7, 6, /*<5*/ 1));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 1), 10, 6, /*<5*/ 4));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 2), 54, 31, 23));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 3), 68, 53, 15));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 4), 65, 46, 19));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 5), 138, 83, 55));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 6), 215, 68, 147));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 7), 126, 36, 90));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 8), 123, 31, 90));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 9), 84, 15, 68));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 10), 93, 15, 37));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 11), 105, 16, 18));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 12), 85, 10, 6));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 1), 62, 6, 11));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 2), 65, 10, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 3), 61, 9, 7));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 4), 64, 5, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 5), 75, 6, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 6), 55, 5, 0));

            // Circular Economy
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 9), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 10), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 11), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2019, 12), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 1), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 2), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 3), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 4), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 5), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 6), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 7), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 8), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 9), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 10), /*<5*/ 5, 0, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 11), 0, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 12), /*<5*/ 5, 0, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 1), /*<5*/ 5, 0, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 2), 6, /*<5*/ 3, /*<5*/ 3));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 3), 12, /*<5*/ 5, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 4), 10, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 5), 11, /*<5*/ 5, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 6), 9, /*<5*/ 5, /*<5*/ 4));


            //Defence
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2019, 9), /*<5*/ 5, /*<5*/ 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2019, 10), /*<5*/ 4, /*<5*/ 2, /*<5*/ 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2019, 11), 15, 13, /*<5*/ 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2019, 12), 17, 12, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 1), 28, 20, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 2), 36, 25, 11));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 3), 64, 38, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 4), 52, 40, 12));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 5), 104, 57, 46));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 6), 143, 47, 96));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 7), 110, 40, 70));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 8), 91, 20, 71));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 9), 75, 25, 48));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 10), 86, 26, 30));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 11), 101, 15, 19));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 12), 75, 16, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 1), 60, 7, 11));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 2), 51, 15, 6));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 3), 57, 8, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 4), 51, 12, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 5), 39, 5, /*<5*/ 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 6), 48, /*<5*/ 5, 0));


            // Energy
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2019, 9), /*<5*/ 5, /*<5*/ 5, 00));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2019, 10), 6, /*<5*/ 3, /*<5*/ 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2019, 11), 25, 13, 12));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2019, 12), 45, 28, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 1), 63, 46, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 2), 120, 78, 42));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 3), 206, 152, 54));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 4), 215, 129, 86));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 5), 294, 170, 124));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 6), 408, 150, 258));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 7), 321, 108, 212));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 8), 245, 69, 174));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 9), 209, 66, 137));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 10), 231, 51, 97));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 11), 224, 39, 31));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 12), 218, 31, 36));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 1), 145, 24, 20));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 2), 112, 24, 12));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 3), 113, 24, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 4), 85, 14, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 5), 111, 21, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 6), 85, /*<5*/ 5, /*<5*/ 5));

            // Health
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2019, 9), /*<5*/ 4, /*<5*/ 4, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2019, 10), /*<5*/ 4, /*<5*/ 2, /*<5*/ 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2019, 11), 28, 20, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2019, 12), 33, 31, /*<5*/ 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 1), 31, 26, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 2), 95, 60, 35));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 3), 144, 111, 33));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 4), 190, 136, 54));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 5), 273, 194, 79));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 6), 431, 169, 262));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 7), 301, 118, 181));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 8), 226, 77, 148));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 9), 257, 91, 158));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 10), 224, 57, 79));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 11), 214, 38, 22));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 12), 205, 42, 32));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 1), 145, 36, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 2), 176, 53, 21));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 3), 184, 50, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 4), 178, 37, 22));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 5), 153, 28, 15));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 6), 174, 16, /*<5*/ 4));

            // some bookkeeping
            SetupMetrics();
        }

        private static void SetupMetrics()
        {
            _minPeriod = GetPeriod(_gtiMetrics.Min(x => x.Period.Value));
            _maxPeriod = GetPeriod(_gtiMetrics.Max(x => x.Period.Value));

            var current = _minPeriod.ToDateTime();
            var max = _maxPeriod.ToDateTime();

            var periods = new List<Period>();

            while (current <= max)
            {
                periods.Add(new Period(current.Year, current.Month));
                current = current.AddMonths(1);
            }

            Periods = periods.ToArray();
        }

        public static IEnumerable<string> GetPeriodLabels()
        {
            return Periods.Select(x => x.ToString());
        }

        public static IEnumerable<Metric> GetSectorMetrics(Sector[] sectors)
        {
            IEnumerable<GTIMetric> q = GetMetrics(sectors);

            foreach (var period in Periods)
            {
                var periodQ = q
                    .Where(x => x.Period.Value == period.Value);

                yield return new Metric(
                    periodQ.Sum(x => x.Submitted),
                    periodQ.Sum(x => x.Invited),
                    periodQ.Sum(x => x.Rejected)
                    );
            }
        }

        public static IEnumerable<GTIMetric> GetMetrics(Sector[] sectors)
        {
            IEnumerable<GTIMetric> q;

            if (sectors.Length == 0)
                q = _gtiMetrics;
            else
                q = _gtiMetrics
                  .Where(x => sectors.Contains(x.Sector));
            return q;
        }

        public record Metric(int Submitted, int Invited, int Rejected)
        {
            public int Pending => Submitted - Invited - Rejected;

        }
    }
}