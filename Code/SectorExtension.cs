namespace GTIinsight.Shared
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
                Sector.Energy => "Energy and Mining Technology",
                Sector.FinTech => "Financial Services and FinTech",
                Sector.Health => "Health industries",
                Sector.Education => "Education",
                Sector.Resources => "Resources",
                Sector.Tourism => "Infrastructure and tourism",
                _ => sector.ToString(),
            };
        }
    }
}