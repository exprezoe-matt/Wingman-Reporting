using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wingman.Reporting.Services.Parameters;
using CrystalDecisions.Shared;
using System.Configuration;

namespace Wingman.Reporting.Services.Services
{
    public interface IReportService
    {
        Task<Stream> GenerateReportToStreamAsync(ReportParameters reportParam);
    }
    public class ReportService : IReportService
    {
        public async Task<Stream> GenerateReportToStreamAsync(ReportParameters reportParam)
        {
            return await Task.Run(() => 
            {
                var report = ReportLibrary.GetDocumentByName(reportParam.ReportName);

                string query = ReportLibrary.GetQueryByName(reportParam);

                var parameters = CreateSqlParameters(reportParam).ToArray();

                var data = FillDataSet(query, parameters);

                report.Load(reportParam.ReportName, OpenReportMethod.OpenReportByDefault);
                report.SetDataSource(data.Tables[0]);

                if (reportParam.HasSubreports)
                {
                    query = ReportLibrary.GetQueryByName(reportParam, subreport: true);
                    parameters = CreateSqlParameters(reportParam).ToArray();
                    data = FillDataSet(query, parameters);
                    report.Subreports[0].SetDataSource(data.Tables[0]);
                }

                SetReportParameters(ref report, reportParam);

                return report.ExportToStream(ExportFormatType.PortableDocFormat);
            });
        }
        private DataSet FillDataSet(string query, SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddRange(parameters);
                    var adapter = new SqlDataAdapter(command);
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        private IEnumerable<SqlParameter> CreateSqlParameters(ReportParameters args)
        {
            if (args.BeginDate != default)
            {
                yield return new SqlParameter("@BeginDate", args.BeginDate);
            }

            if (args.EndDate != default)
            {
                yield return new SqlParameter("@EndDate", args.EndDate);
            }

            if (args.PilotId != default)
            {
                yield return new SqlParameter("@Pilot", args.PilotId);
            }

            if (args.AircraftId != default)
            {
                yield return new SqlParameter("@Aircraft", args.AircraftId);
            }

            if (args.AirportId != default)
            {
                yield return new SqlParameter("@Airport", args.AirportId);
            }

            if (!string.IsNullOrEmpty(args.IATA))
            {
                yield return new SqlParameter("@IATA", args.IATA);
            }

            if (args.OperatorId != default)
            {
                yield return new SqlParameter("@Operator", args.OperatorId);
            }

            if (args.IDX != default)
            {
                yield return new SqlParameter("@IDX", args.IDX);
            }
        }
        private void SetReportParameters(ref ReportDocument report, ReportParameters args)
        {
            if (report.ParameterFields["SDate"] != null)
            {
                report.SetParameterValue("SDate", args.BeginDate);
            }

            if (report.ParameterFields["EDate"] != null)
            {
                report.SetParameterValue("EDate", args.EndDate);
            }

            if (report.ParameterFields["StartDate"] != null)
            {
                report.SetParameterValue("StartDate", args.BeginDate);
            }

            if (report.ParameterFields["EndDate"] != null)
            {
                report.SetParameterValue("EndDate", args.EndDate);
            }

            string resourcePath = AppContext.BaseDirectory + "\\Resources\\";

            if (report.ParameterFields["Img_Logo1"] != null)
            {
                report.SetParameterValue("Img_Logo1", resourcePath + "applogo_1_blank.bmp");
            }

            if (report.ParameterFields["Img_Logo2"] != null)
            {
                report.SetParameterValue("Img_Logo2", resourcePath + "applogo_2_blank.bmp");
            }

            if (report.ParameterFields["InputDate"] != null)
            {
                report.SetParameterValue("InputDate", args.BeginDate);
            }

            if (report.ParameterFields["Start"] != null)
            {
                report.SetParameterValue("Start", args.BeginDate);
            }

            if (report.ParameterFields["End"] != null)
            {
                report.SetParameterValue("End", args.EndDate);
            }

            if (report.ParameterFields["StartD"] != null)
            {
                report.SetParameterValue("StartD", args.BeginDate);
            }

            if (report.ParameterFields["EndD"] != null)
            {
                report.SetParameterValue("EndD", args.EndDate);
            }

            if (report.ParameterFields["InputDate"] != null)
            {
                report.SetParameterValue("InputDate", args.BeginDate);
            }

            if (report.ParameterFields["InputCurrency"] != null)
            {
                // TODO: get from user input

                report.SetParameterValue("InputCurrency", $"USD\t:[1]{Environment.NewLine}BWP\t:[11]{Environment.NewLine}ZAR\t:[18]");
            }
        }
        private void SetReportParameter(ref ReportDocument report, int index, object value)
        {
            try
            {
                report.SetParameterValue(index, value);
            }
            catch
            {
                // Do nothing
            }
        }
    }
}
