using System.Data.SqlClient;
using Laminin.Powercurve.Api.Models;
using Laminin.PowerCurve.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laminin.Powercurve.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditScoreController : ControllerBase
    {
        private readonly PowerCurveConfig _config;

        public string offerDecision, declineReason;
        public double offerLimit;


        public CreditScoreController(PowerCurveConfig config)
        {
            _config = config;
        }

        [HttpPost]
        public async Task<JsonResult> getPowerCurveResult([FromBody] CreditScoreRequest dto)
        {

            if (ValidateData(dto.GrossAmount, dto.TotalExpenses, dto.TotalIncome, dto.Limit, dto.IdNumber) != "")
            {
                offerDecision = ValidateData(dto.GrossAmount, dto.TotalExpenses, dto.TotalIncome, dto.Limit, dto.IdNumber);
                return new JsonResult(offerDecision);
            };

            PowerCurve.Services.PowerCurveService serv = new Laminin.PowerCurve.Services.PowerCurveService(_config);
            
            //KSS Selection.
            KeyValuePair<double, List<string>> offerOptions = modPowerCurve.getPowercurveLimitAndCardOptions(dto);
            double requestLimit = offerOptions.Key;
            //cardOptions = offerOptions.Value;

            var SendData = Models.modPowerCurve.GetLeadData(dto);

            try
            {
                //User Required
                var response = await serv.SendRequest("John", SendData);

                if (response.PreScreenDecision.FinDecisionCod != "A")
                {
                    offerDecision = "Decline";
                    declineReason = getPowercurveDeclineReason(response.PreScreenDecision.FinDeclineCod1);

                    return new JsonResult(offerDecision, declineReason);
                }
                else if (response.FraudDecision.FrdRollDecisionCod != "A")
                {
                    offerDecision = "Decline";
                    declineReason = getPowercurveDeclineReason(response.FraudDecision.FrdRollDeclineCod1);

                    return new JsonResult(offerDecision, declineReason);

                }
                else if (response.ProductDecision.Product.FinDecisionCod != "A")
                {
                    offerDecision = "Decline";
                    declineReason = getPowercurveDeclineReason(response.ProductDecision.Product.FinDeclineCod1);

                    return new JsonResult(offerDecision, declineReason);

                }
                else
                {
                    offerLimit = System.Convert.ToDouble(requestLimit);

                    List<Laminin.PowerCurve.Responses.ProductOffer> prods = response.ProductDecision.Product.ProductOffer;
                    foreach (var pr in prods)
                    {
                       
                        if (pr.FinOffSystemVerdict.Contains("A"))
                        {
                            offerDecision = "Accept";
                            offerLimit = Math.Min(offerLimit, pr.FinOffMaxLimAmnt);
                            break;
                        }
                        else
                        {
                            offerDecision = "Decline";
                            offerLimit = 0;
                            break;
                        }
                    }

                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            // Send customer and offer details to BPO


            return new JsonResult(new { Accepted = true });

            return new JsonResult(offerDecision, offerLimit.ToString());
        }

        public string ValidateData(double GrossAmount, double TotalExpenses, double TotalIncome, double Limit, string IdNumber)
        {
            string vValidateData = "";

            if(IdNumber.Length != 13)
            {
                return vValidateData = "ID Number length is not 13 characters";
            }

            if(IdNumber.Length == 0)
            {
                return vValidateData = "ID Number is required.";
            }

            if(GrossAmount != 0.00 && GrossAmount! > 0)
            {
                return vValidateData = "Gross amount is required.";
            }

            if (TotalExpenses != 0.00 && TotalExpenses! > 0)
            {
                return vValidateData = "Total Expenses amount is required.";
            }

            if (Limit != 0.00 && Limit! > 0)
            {
                return vValidateData = "Limit amount is required.";
            }

            if (TotalIncome != 0.00 && TotalIncome! > 0)
            {
                return vValidateData = "Total Income is required.";
            }

            return vValidateData;
        }

        public string getPowercurveDeclineReason(string DeclineCode)
        {
            string declineReason = "";
            string strSQL = "SELECT TOP 1 Description FROM [PowerCurveDeclineCodes] WHERE DeclineCode = '" + DeclineCode + "' ";
            try
            {
                using (SqlConnection connection = new SqlConnection(_config.ConnString))
                {
                    SqlCommand command = new SqlCommand(strSQL, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    command.CommandText = strSQL;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        declineReason = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
            return declineReason;
        }



    }
}
