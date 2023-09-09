using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace ReportGenerator
{
    internal class ReportCreator
    {
        private readonly string connectionString;

        public ReportCreator(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string Create(string[] args)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".pdf");

            string json = args[0];

            ReportArguments reportArgs = JsonSerializer.Deserialize<ReportArguments>(json);

            var report = ReportLibrary.GetDocumentByName(reportArgs.ReportName);

            string query = ReportLibrary.GetQueryByName(reportArgs);

            var parameters = CreateSqlParameters(reportArgs).ToArray();

            var data = FillDataSet(query, parameters);

            report.Load(reportArgs.ReportName, OpenReportMethod.OpenReportByDefault);
            report.SetDataSource(data.Tables[0]);

            if (reportArgs.HasSubreports)
            {
                query = ReportLibrary.GetQueryByName(reportArgs, subreport: true);
                parameters = CreateSqlParameters(reportArgs).ToArray();
                data = FillDataSet(query, parameters);
                report.Subreports[0].SetDataSource(data.Tables[0]);
            }

            SetReportParameters(ref report, reportArgs);
            report.ExportToDisk(ExportFormatType.PortableDocFormat, outputPath);

            return outputPath;
        }

        private DataSet FillDataSet(string query, SqlParameter[] parameters)
        {
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                var adapter = new SqlDataAdapter(command);
                var dataset = new DataSet();
                adapter.Fill(dataset);
                return dataset;
            }
            finally
            {
                connection.Dispose();
            }
        }

        private IEnumerable<SqlParameter> CreateSqlParameters(ReportArguments args)
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

        private void SetReportParameters(ref ReportDocument report, ReportArguments args)
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
