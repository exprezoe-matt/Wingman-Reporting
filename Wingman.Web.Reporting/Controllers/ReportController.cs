using Newtonsoft.Json;
using ReportGenerator.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Wingman.Reporting.Services.Parameters;
using Wingman.Reporting.Services.Services;

namespace Wingman.Web.Reporting.Controllers
{
    public class ReportController : ApiController
    {
        private readonly ReportService _reportService;
        public ReportController(ReportService reportService)
        {
            _reportService = reportService;
        }
        public ReportController() { }
        // POST api/values
        [HttpPost]
        public async Task<HttpResponseMessage> GenerateReport([FromBody] ReportParameters reportParam)
        {
            try
            {
                var reportStream = await _reportService.GenerateReportToStreamAsync(reportParam);

                // Set the stream position to the beginning
                reportStream.Position = 0;

                // Create an HTTP response with the PDF stream
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StreamContent(reportStream)
                };

                // Set content headers for the response
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = $"{reportParam.ReportName}.pdf"
                };

                return response;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
