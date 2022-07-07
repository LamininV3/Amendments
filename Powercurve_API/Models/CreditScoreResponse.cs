namespace Laminin.Powercurve.Api.Models
{
    public class CreditScoreResponse
    {
        public string OfferDecision { get; set; }
        public double OfferLimit { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public long PowerCurveRequestId { get; set; }
    }
}
