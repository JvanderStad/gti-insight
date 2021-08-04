namespace GTIinsight.Shared
{
    public static class SectorExtension
    {
        public static string GetDisplayName(this Sector sector)
        {
            return sector switch
            {
                Sector.DigiTech => "DigiTech",
                Sector.FinTech => "Financial Services and FinTech",
                _ => sector.ToString(),
            };
        }
    }
}