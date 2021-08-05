﻿namespace GTIinsight.Shared
{
    public static class SectorExtension
    {
        public static string GetDisplayName(this Sector sector)
        {
            return sector switch
            {
                Sector.AgTech => "Argri-food and AgTech",
                Sector.CircularEconomy => "Circular economy",
                Sector.Defence => "Defence, advanced manufacturing and space",
                Sector.DigiTech => "DigiTech",
                Sector.FinTech => "Financial Services and FinTech",
                _ => sector.ToString(),
            };
        }
    }
}