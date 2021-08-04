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
            // load DIGITECH
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