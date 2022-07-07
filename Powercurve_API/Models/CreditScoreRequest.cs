namespace Laminin.Powercurve.Api.Models
{
    public class CreditScoreRequest
    {
        public string DistributionInstance { get; set; } // BPO
        public int DistributionCampaignId { get; set; } // CampaignID 10
        
        public string SourceLeadId { get; set; }
        public string IdNumber { get; set; }
        public double GrossAmount { get; set; }
        public double Limit { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public string MiddleName { get; set; }

        public string Gender { get; set; }

        public string Initial { get; set; }

        public string DatOfBirth { get;set }

        public string CellphoneNumber { get; set; }

        public int MonthlyIncome { get; set; }

        public int TotalIncome { get; set; }

        public int TotalExpenses { get; set; }

        public string RiskBand { get; set; }


    }
}
