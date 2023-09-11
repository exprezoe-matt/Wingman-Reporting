using System;
using System.IO;
using System.Linq;
using Wingman.Reporting.Services.Parameters;

namespace Wingman.Reporting.Services.Services
{
    public interface IReportService
    {
        Stream GenerateReportToStream(ReportParameters reportParam);
    }
}
