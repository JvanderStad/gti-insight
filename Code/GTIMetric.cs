using System;

namespace GTIinsight.Shared
{
    public record GTIMetric(Sector Sector, Period Period, int Submitted, int Invited, int Rejected)
    {
        public int Pending => Submitted - Invited - Rejected;
        public string ProcessedPercentage
        {
            get
            {
                if (Submitted == 0)
                    return "0 %";

                var processed = ((Submitted - Pending) / (decimal)Submitted) * 100m;
                var percentage = (int)Math.Round(processed);


                return $"{percentage} %";
}
        }

        public string RejectedOfProcessedPercentage
        {
            get
            {
                if (Invited + Rejected == 0)
                    return "0 %";

                var rejected = (Rejected / (decimal)(Invited + Rejected)) * 100m;

                var percentage = (int)Math.Round(rejected);


                return $"{percentage} %";
            }
        }

        public string InvitedOfProcessedPercentage
        {
            get
            {
                if (Invited + Rejected == 0)
                    return "0 %";

                var invited = (Invited / (decimal)(Invited + Rejected)) * 100m;

                var percentage = (int)Math.Round(invited);


                return $"{percentage} %";
            }
        }
    }


}