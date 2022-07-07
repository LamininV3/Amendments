using System.Data.SqlClient;
using Laminin.PowerCurve.Models;
using Laminin.PowerCurve;

namespace Laminin.Powercurve.Api.Models
{
    public class modPowerCurve
    {

        private static readonly PowerCurveConfig _config;

        public string offerDecision, declineReason;
        public double offerLimit;



        public static Laminin.PowerCurve.Requests.RetailRiskAssessment GetLeadData(CreditScoreRequest dto)
        {
            Laminin.PowerCurve.Requests.RetailRiskAssessment DataRequest = new Laminin.PowerCurve.Requests.RetailRiskAssessment();
            
            try
            {
                DataRequest.General.FeGenAoRef = Convert.ToInt32(dto.SourceLeadId);
                DataRequest.General.FeGenIdNo = dto.IdNumber;
                DataRequest.General.FeGenCustNo = 0;
                DataRequest.General.FeGenPocInd = 1;

                DataRequest.General.FeGenAppDate = System.DateTime.Now.ToString("yyyyMMdd");
                DataRequest.General.FeGenAppTime = System.Convert.ToInt32(System.DateTime.Now.ToString("HHmmss"));
                DataRequest.General.FeGenAppCentreNo = 0;
                DataRequest.General.FeGenAppProcess = "3";
                DataRequest.General.FeGenCallType = "1";
                DataRequest.General.FeGenCallerCod = 51;
                DataRequest.General.FeGenIdType = "ZFS001";
                DataRequest.General.FeGenNcaInActInd = "Y";
                DataRequest.General.FeGenSpecialProc = "KS";
                DataRequest.General.FeGenTriggerCode = "3PS";
                DataRequest.General.FeGenUseCustInfo = "Y";
                DataRequest.General.FeGenUserId = "KSS";
                DataRequest.General.FeGenVerNo = "1";
                DataRequest.General.FeGenReprocessInd = "N";
                DataRequest.General.FeGenReprocessCounter = 0;
                DataRequest.General.FeGenDebtRestructure = "0";

                DataRequest.General.FeGenFut1 = "";
                DataRequest.General.FeGenFut2 = "";
                DataRequest.General.FeGenFut3 = "";
                DataRequest.General.FeGenFut4 = "";
                DataRequest.General.FeGenFut5 = "";
                DataRequest.General.FeGenFut6 = 0;
                DataRequest.General.FeGenFut7 = 0;
                DataRequest.General.FeGenFut8 = 0;
                DataRequest.General.FeGenFut9 = 0;
                DataRequest.General.FeGenFut10 = 0;
                DataRequest.General.FeGenFut11 = 0;
                DataRequest.General.FeGenFut12 = 0;
                DataRequest.General.FeGenFut13 = 0;
                DataRequest.General.FeGenFut14 = 0;
                DataRequest.General.FeGenFut15 = 0;
                DataRequest.General.FeGenFut16 = 0;
                DataRequest.General.FeGenFut17 = 0;
                DataRequest.General.FeGenFut18 = 0;
                DataRequest.General.FeGenFut19 = 0;
                DataRequest.General.FeGenFut20 = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
                DataRequest.ConsBPData.CpmCustGender = dto.Gender;
                DataRequest.ConsBPData.CpmCustTitle = "";
                DataRequest.ConsBPData.CpmCustInitial = dto.FirstName;
                DataRequest.ConsBPData.CpmCustFirstNam = dto.FirstName;
                DataRequest.ConsBPData.CpmCustOtherNam = dto.MiddleName;
                DataRequest.ConsBPData.CpmCustSurNam = dto.SurName;
                DataRequest.ConsBPData.CpmCustDatOfBirth = dto.DatOfBirth;
                DataRequest.ConsBPData.CpmCustTelCellNo = dto.CellphoneNumber;
                DataRequest.ConsBPData.CpmCustMarketSegment = "130";
                DataRequest.ConsBPData.CpmCustNonResident = "N";
                DataRequest.ConsBPData.CpmCustTelBussCod = "";
                DataRequest.ConsBPData.CpmCustTelBussNo = "";
                DataRequest.ConsBPData.CpmCustTelCellCod = "";
                DataRequest.ConsBPData.CpmCustTelHomeAreacod = "";
                DataRequest.ConsBPData.CpmCustTelHomeNo = "";
                DataRequest.ConsBPData.CpmCustAccomodatCod = "";
                DataRequest.ConsBPData.CpmCustAddPoLine1 = "";
                DataRequest.ConsBPData.CpmCustAddPoLine2 = "";
                DataRequest.ConsBPData.CpmCustAddPoSubrb = "";
                DataRequest.ConsBPData.CpmCustAddPoCity = "";
                DataRequest.ConsBPData.CpmCustAddPoCod = "";
                DataRequest.ConsBPData.CpmCustAddResLine1 = "";
                DataRequest.ConsBPData.CpmCustAddResLine2 = "";
                DataRequest.ConsBPData.CpmCustAddResSubrb = "";
                DataRequest.ConsBPData.CpmCustAddResCity = "";
                DataRequest.ConsBPData.CpmCustAddResPoCod = "";
                DataRequest.ConsBPData.CpmCustCitizenCod = "";
                DataRequest.ConsBPData.CpmCustCountryOfBirth = "";
                DataRequest.ConsBPData.CpmCustCountryOfRes = "";
                DataRequest.ConsBPData.CpmCustNationality = "";
                DataRequest.ConsBPData.CpmCustMaritalStatus = "";
                DataRequest.ConsBPData.CpmCustMaritalType = 0;
                DataRequest.ConsBPData.CpmCustNoOfDepnd = 0;
                DataRequest.ConsBPData.CpmCustEmail = "";
                DataRequest.ConsBPData.CpmCustEnterpriseType = "";
                DataRequest.ConsBPData.CpmCustStaff = "";
                DataRequest.ConsBPData.CpmCustTertQualfcation = "";
                DataRequest.ConsBPData.CpmProfRetirementAge = "";
                DataRequest.ConsBPData.CpmCustFuture1 = "";
                DataRequest.ConsBPData.CpmCustFuture2 = "";
                DataRequest.ConsBPData.CpmCustFuture3 = "";
                DataRequest.ConsBPData.CpmCustFuture4 = "";
                DataRequest.ConsBPData.CpmCustFuture5 = "";
                DataRequest.ConsBPData.CpmCustFuture6 = "";
                DataRequest.ConsBPData.CpmCustFuture7 = "";
                DataRequest.ConsBPData.CpmCustFuture8 = "";
                DataRequest.ConsBPData.CpmCustFuture9 = "0";
                DataRequest.ConsBPData.CpmCustFuture10 = "0";
                DataRequest.ConsBPData.CpmCustFuture11 = "0";
                DataRequest.ConsBPData.CpmCustFuture12 = "0";
                DataRequest.ConsBPData.CpmCustFuture13 = "0";
                DataRequest.ConsBPData.CpmCustFuture14 = "0";
                DataRequest.ConsBPData.CpmCustFuture15 = "0";
                DataRequest.ConsBPData.CpmCustFuture16 = "0";
                DataRequest.ConsBPData.CpmCustFuture17 = "0";
                DataRequest.ConsBPData.CpmCustFuture18 = "0";
                DataRequest.ConsBPData.CpmCustFuture19 = "0";
                DataRequest.ConsBPData.CpmCustFuture20 = "0";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
                DataRequest.ConsBPEmpData.CpmCustGrossmnthlyincme = dto.MonthlyIncome;
                DataRequest.ConsBPEmpData.CpmCustOtherIncme = 0;
                DataRequest.ConsBPEmpData.CpmCustEmploymntStatus = "0";
                DataRequest.ConsBPEmpData.CpmCustCtrctEd = "";
                DataRequest.ConsBPEmpData.CpmCustCtrctSd = "";
                DataRequest.ConsBPEmpData.CpmCustTimeCuremplEd = "";
                DataRequest.ConsBPEmpData.CpmCustTimeCuremplSd = "";
                DataRequest.ConsBPEmpData.CpmCustCuremplNam = "";
                DataRequest.ConsBPEmpData.CpmCustCuremplAddLin1 = "";
                DataRequest.ConsBPEmpData.CpmCustCuremplAddLin2 = "";
                DataRequest.ConsBPEmpData.CpmCustCuremplAddSubrb = "";
                DataRequest.ConsBPEmpData.CpmCustCuremplAddCity = "";
                DataRequest.ConsBPEmpData.CpmCustCuremplAddPoCod = "";
                DataRequest.ConsBPEmpData.CpmProfOccption = "";
                DataRequest.ConsBPEmpData.CpmCustOccptionLevel = "";
                DataRequest.ConsBPEmpData.CpmProfOccptionustry = "";
                DataRequest.ConsBPEmpData.CpmCustIndustryCod = "";
                DataRequest.ConsBPEmpData.CpmCustUnemplReason = "";
                DataRequest.ConsBPEmpData.CpmProfTimeSelfEmplEd = "";
                DataRequest.ConsBPEmpData.CpmProfTimeSelfEmplSd = "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
               DataRequest.Affordability.AffPTotIncme = dto.TotalIncome;
               DataRequest.Affordability.AffPTotMnthlyExpenses = dto.TotalExpenses;
               DataRequest.Affordability.AppPGrossIncme = 0;
               DataRequest.Affordability.AffPNetIncme = 0;
               DataRequest.Affordability.AffPOthrMnthlyInc = 0;
               DataRequest.Affordability.AffPHouseholdExp = 0;
               DataRequest.Affordability.AffPMnthlyLivingExp = 0;
               DataRequest.Affordability.AffPTotMthLivExpenses = 0;
               DataRequest.Affordability.AffPLoanRepay = 0;
               DataRequest.Affordability.AffPTotMnthlyCntRepay = 0;
               DataRequest.Affordability.AffPMnthlyHomloanInst = 0;
               DataRequest.Affordability.AffPTax = 0;
               DataRequest.Affordability.AffPTotDeductions = 0;
               DataRequest.Affordability.AffPVafInstall = 0;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
                DataRequest.Consents.PsExtBureauConsent = "Y";
                DataRequest.Consents.PsUnderAdminOrder = "N";
                DataRequest.Consents.PsUnderDebtReview = "N";
                DataRequest.Consents.PsUnderSequestration = "N";
                DataRequest.Consents.PsFuture1 = "";
                DataRequest.Consents.PsFuture2 = "";
                DataRequest.Consents.PsFuture3 = "";
                DataRequest.Consents.PsFuture4 = "";
                DataRequest.Consents.PsFuture5 = "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
                Laminin.PowerCurve.Requests.ProductRequest prod = new Laminin.PowerCurve.Requests.ProductRequest();
                prod.FeGenAppType = "P";
                prod.FeGenReqstdLim = 0;
                prod.FeGenAccNo = 0;
                prod.FeGenAppMrktgrpCod = "53";
                prod.FeGenAgrmntType = "";
                prod.FeGenProdId = "";
                prod.FeGenProdNo = 0;
                prod.FeGenPrdCatg = "";
                prod.FeGenPrdCatgTyp = "";
                prod.FeGenLoanPurpose = "";
                prod.FeGenInstalPayFreq = 0;
                prod.FeGenLoanTerm = 0;
                prod.FeGenLnItem = "0";
                prod.FeGenNoOfInstall = "1";
                DataRequest.ProductRequest.Add(prod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return DataRequest;
        }


        public static KeyValuePair<double, List<string>> getPowercurveLimitAndCardOptions(CreditScoreRequest dto)
        {
            double powerCurveLimit = 0;
            List<string> cardOptions = new List<string>();
            double risk_factor =0, aff_factor =0, riskLimit = 0, affLimit = 0;
            double _5k_limit =0, _8k_limit =0, _25k_limit=0, _58k_limit =0, _92k_limit = 0;
            //getPowercurveLimitAndCardOptions = new KeyValuePair<double, List<string>>(powerCurveLimit, cardOptions);

            if (DBNull.Value.Equals(dto.RiskBand))
            {
                dto.RiskBand = "Rsk09";
            }

            string strSQL = "SELECT [risk_band], [risk_factor], [afford_factor], [5k_limit], [8k_limit], [25k_limit], [58k_limit], [92k_limit] " + 
                            "FROM sc_campaign.dbo.sc_limitmatrix_closedcampaigns_202004 WHERE risk_band = '" + dto.RiskBand + "' ";

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
                        risk_factor = Convert.ToDouble(reader.GetValue(1));
                        aff_factor = Convert.ToDouble(reader.GetValue(2));
                        _5k_limit = Convert.ToDouble(reader.GetValue(3));
                        _8k_limit = Convert.ToDouble(reader.GetValue(4));
                        _25k_limit = Convert.ToDouble(reader.GetValue(5));
                        _58k_limit = Convert.ToDouble(reader.GetValue(6));
                        _92k_limit = Convert.ToDouble(reader.GetValue(7));
                    }
                    reader.Close();
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (dto.GrossAmount >= 7500 && dto.GrossAmount < 8000)
                {
                    if (DBNull.Value.Equals(dto.Limit))
                    {
                        powerCurveLimit = _5k_limit;
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                    }
                    else
                    {
                        powerCurveLimit = Convert.ToDouble(Math.Min(_5k_limit, dto.Limit));
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                    }
                }
                else if (dto.GrossAmount >= 8000 && dto.GrossAmount < 25000)
                {
                    if (DBNull.Value.Equals(dto.Limit))
                    {
                        powerCurveLimit = _8k_limit;
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                    }
                    else
                    {
                        powerCurveLimit = Convert.ToInt32(Math.Min(_8k_limit, dto.Limit));
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                    }
                }
                else if (dto.GrossAmount >= 25000 && dto.GrossAmount < 58000)
                {
                    if (DBNull.Value.Equals(dto.Limit))
                    {
                        powerCurveLimit = Convert.ToInt32(_25k_limit);
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                        cardOptions.Add("TITANIUM CREDIT CARD" + "                                                              ;" + "TNTPUN");
                    }
                    else
                    {
                        powerCurveLimit = Convert.ToInt32(Math.Min(_25k_limit, dto.Limit));
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                        cardOptions.Add("TITANIUM CREDIT CARD" + "                                                              ;" + "TNTPUN");
                    }
                }
                else if (dto.GrossAmount >= 58000 && dto.GrossAmount < 92000)
                {
                    if (DBNull.Value.Equals(dto.Limit))
                    {
                        powerCurveLimit = _58k_limit;
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                        cardOptions.Add("TITANIUM CREDIT CARD" + "                                                              ;" + "TNTPUN");
                        cardOptions.Add("PLATINUM CREDIT CARD" + "                                                              ;" + "SPTSBR");
                    }
                    else
                    {
                        powerCurveLimit = Convert.ToInt32(Math.Min(_58k_limit, dto.Limit));
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                        cardOptions.Add("TITANIUM CREDIT CARD" + "                                                              ;" + "TNTPUN");
                        cardOptions.Add("PLATINUM CREDIT CARD" + "                                                              ;" + "SPTSBR");
                    }
                }
                else if (dto.GrossAmount >= 92000)
                {
                    if (DBNull.Value.Equals(dto.Limit))
                    {
                        powerCurveLimit = _92k_limit;
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                        cardOptions.Add("TITANIUM CREDIT CARD" + "                                                              ;" + "TNTPUN");
                        cardOptions.Add("PLATINUM CREDIT CARD" + "                                                              ;" + "SPTSBR");
                    }
                    else
                    {
                        powerCurveLimit = Convert.ToDouble(Math.Min(_92k_limit, dto.Limit));
                        cardOptions.Add("GOLD CREDIT CARD" + "                                                              ;" + "SGLSBR");
                        cardOptions.Add("TITANIUM CREDIT CARD" + "                                                              ;" + "TNTPUN");
                        cardOptions.Add("PLATINUM CREDIT CARD" + "                                                              ;" + "SPTSBR");
                    }
                }

                affLimit = Math.Round((dto.GrossAmount - dto.TotalExpenses) / aff_factor, 0);
                riskLimit = Math.Round(dto.GrossAmount * risk_factor, 0);

                powerCurveLimit = Convert.ToInt32(Math.Min(powerCurveLimit, affLimit));
                powerCurveLimit = Convert.ToInt32(Math.Min(powerCurveLimit, riskLimit));

            }
            catch (Exception ex)
            { 
            
            }
            return new KeyValuePair<double, List<string>>(powerCurveLimit, cardOptions);
        }

    }
}
