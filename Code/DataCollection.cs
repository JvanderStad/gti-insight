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

            ////////////////////////////////////////////////////



            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 8), 123, 31, 92)); 
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 8), 91, 20, 71));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 8), 412, 118, 294));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2020, 8), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 8), 245, 70, 175));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 8), 48, 18, 30)); 
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 8), 227, 79, 147));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2020, 8), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 9), 84, 16, 68));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 9), 75, 25, 50)); 
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 9), 360, 112, 248));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 9), 209, 66, 143));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 9), 77, 41, 36));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 9), 257, 92, 164));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2020, 9), 5, 0, 5)); 
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2020, 9), 5, 5, 0)); 
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 10), 93, 22, 63));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 10), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 10), 84, 30, 50));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 10), 483, 117, 340));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2020, 10), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 10), 231, 67, 146));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 10), 100, 34, 62));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 10), 223, 72, 127));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 11), 104, 18, 20));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 11), 101, 18, 22));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 11), 471, 116, 115));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2020, 11), 5, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 11), 224, 42, 41));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 11), 120, 58, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 11), 214, 47, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2020, 11), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2020, 12), 85, 13, 19));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2020, 12), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2020, 12), 76, 20, 20));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2020, 12), 492, 124, 151));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2020, 12), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2020, 12), 219, 34, 54));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2020, 12), 92, 43, 24));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2020, 12), 205, 49, 49));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2020, 12), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2020, 12), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 1), 62, 7, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 1), 5, 0, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 1), 60, 9, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 1), 352, 78, 122));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 1), 5, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 1), 145, 27, 33));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 1), 80, 34, 24));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 1), 145, 39, 38));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 1), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 1), 5, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 2), 65, 12, 9));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 2), 6, 3, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 2), 52, 16, 11));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 2), 275, 69, 67));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 2), 64, 4, 7));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 2), 112, 28, 25));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 2), 108, 49, 31));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 2), 177, 61, 35));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 2), 26, 3, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 2), 35, 16, 6));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 3), 62, 14, 15));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 3), 11, 3, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 3), 57, 12, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 3), 300, 74, 77));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 3), 130, 10, 24));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 3), 113, 29, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 3), 147, 50, 55));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 3), 185, 62, 40));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 3), 55, 9, 17));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 3), 44, 15, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 4), 64, 6, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 4), 10, 0, 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 4), 51, 15, 9));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 4), 249, 72, 53));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 4), 145, 9, 46));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 4), 84, 18, 13));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 4), 156, 58, 42));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 4), 181, 55, 35));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 4), 59, 9, 16));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 4), 45, 16, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 5), 75, 9, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 5), 12, 3, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 5), 38, 7, 4));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 5), 242, 71, 52));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 5), 129, 8, 24));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 5), 111, 26, 22));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 5), 124, 43, 37));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 5), 153, 52, 23));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 5), 43, 8, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 5), 40, 16, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 6), 77, 7, 6));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 6), 13, 3, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 6), 69, 16, 9));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 6), 345, 78, 80));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 6), 138, 5, 20));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 6), 114, 20, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 6), 188, 62, 52));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 6), 211, 49, 21));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 6), 80, 11, 22));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 6), 42, 8, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 7), 56, 10, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 7), 11, 3, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 7), 43, 13, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 7), 200, 49, 29));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 7), 92, 4, 12));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 7), 71, 11, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 7), 112, 39, 31));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 7), 128, 30, 9));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 7), 27, 5, 4));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 7), 31, 7, 2));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 8), 37, 5, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 8), 11, 1, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 8), 49, 13, 4));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 8), 211, 46, 24));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 8), 77, 4, 7));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 8), 52, 12, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 8), 103, 33, 27));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 8), 144, 25, 11));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 8), 43, 5, 10));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 8), 45, 8, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 9), 30, 1, 0)); 
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 9), 16, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 9), 43, 12, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 9), 170, 31, 19));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 9), 73, 2, 8));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 9), 47, 5, 2));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 9), 86, 25, 19));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 9), 125, 20, 11));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 9), 43, 4, 5));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 9), 40, 9, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 10), 35, 4, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 10), 7, 1, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 10), 38, 7, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 10), 161, 27, 7));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 10), 72, 3, 3));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 10), 55, 6, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 10), 90, 15, 6));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 10), 103, 12, 12));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 10), 30, 6, 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 10), 37, 2, 2));
            _gtiMetrics.Add(new GTIMetric(Sector.AgTech, new Period(2021, 11), 8, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.CircularEconomy, new Period(2021, 11), 5, 5, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Defence, new Period(2021, 11), 12, 2, 1));
            _gtiMetrics.Add(new GTIMetric(Sector.DigiTech, new Period(2021, 11), 52, 12, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Education, new Period(2021, 11), 22, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Energy, new Period(2021, 11), 17, 2, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.FinTech, new Period(2021, 11), 27, 6, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Health, new Period(2021, 11), 18, 2, 2));
            _gtiMetrics.Add(new GTIMetric(Sector.Tourism, new Period(2021, 11), 10, 0, 0));
            _gtiMetrics.Add(new GTIMetric(Sector.Resources, new Period(2021, 11), 14, 1, 0));







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