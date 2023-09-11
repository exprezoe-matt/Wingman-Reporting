using CrystalDecisions.CrystalReports.Engine;
using ReportGenerator.Reports;
using System;
using Wingman.Reporting.Services.Parameters;

namespace Wingman.Reporting.Services.Services
{
    internal static class ReportLibrary
    {
        public static ReportDocument GetDocumentByName(string name)
        {
            switch (name)
            {
                //case nameof(Blank): return new Blank();
                case nameof(CrystalReport2): return new CrystalReport2();
                case nameof(QuoteBody): return new QuoteBody();
                case nameof(rptAircraftDetailedRouteSummary): return new rptAircraftDetailedRouteSummary();
                case nameof(rptAircraftDetailedTechnicalSummary): return new rptAircraftDetailedTechnicalSummary();
                case nameof(rptAircraftFlightTimeCount): return new rptAircraftFlightTimeCount();
                case nameof(rptAircraftFlightTimeCountDatePeriod): return new rptAircraftFlightTimeCountDatePeriod();
                case nameof(rptAircraftFlightTimeCountDatePeriodDOW): return new rptAircraftFlightTimeCountDatePeriodDOW();
                case nameof(rptAircraftFlyingHours): return new rptAircraftFlyingHours();
                case nameof(rptAircraftFlyingSummary): return new rptAircraftFlyingSummary();
                case nameof(rptAircraftFuelCost): return new rptAircraftFuelCost();
                case nameof(rptAircraftFuelUplifts): return new rptAircraftFuelUplifts();
                case nameof(rptAircraftLastTechlogSummary): return new rptAircraftLastTechlogSummary();
                case nameof(rptAircraftServiceRecords): return new rptAircraftServiceRecords();
                case nameof(rptAircraftTechlogEntries): return new rptAircraftTechlogEntries();
                case nameof(rptAircraftTechlogsDifferingSchedules): return new rptAircraftTechlogsDifferingSchedules();
                case nameof(rptAircraftUseByOperator): return new rptAircraftUseByOperator();
                case nameof(rptAutoScheduleNoGroups): return new rptAutoScheduleNoGroups();
                case nameof(rptAutoScheduleSummaryByAC): return new rptAutoScheduleSummaryByAC();
                case nameof(rptAutoScheduleSummaryByACTotals): return new rptAutoScheduleSummaryByACTotals();
                case nameof(rptAutoScheduleSummaryByACType): return new rptAutoScheduleSummaryByACType();
                case nameof(rptAutoScheduleWithGroups): return new rptAutoScheduleWithGroups();
                case nameof(rptPassengerCountByOperatorSummaryCount): return new rptPassengerCountByOperatorSummaryCount();
                case nameof(rptPassengerLoadFactor): return new rptPassengerLoadFactor();
                case nameof(rptPassengerLoadFactorByDateByAircraft): return new rptPassengerLoadFactorByDateByAircraft();
                case nameof(rptQuote): return new rptQuote();
                case nameof(rptReservations): return new rptReservations();
                case nameof(rptScheduleByAirport): return new rptScheduleByAirport();
                case nameof(rptScheduleByAirportByDate): return new rptScheduleByAirportByDate();
                case nameof(rptScheduleByOperator): return new rptScheduleByOperator();
                case nameof(rptScheduledSummaryByAC): return new rptScheduledSummaryByAC();
                case nameof(rptScheduledSummaryByACType): return new rptScheduledSummaryByACType();
                case nameof(rptScheduleInvoicing): return new rptScheduleInvoicing();
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring): return new rpt_AdminAirportFuelAvailTimesExpiring();
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring2): return new rpt_AdminAirportFuelAvailTimesExpiring2();
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring3): return new rpt_AdminAirportFuelAvailTimesExpiring3();
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring4): return new rpt_AdminAirportFuelAvailTimesExpiring4();
                case nameof(rpt_AdminAreaRateTimesExpiringSoon): return new rpt_AdminAreaRateTimesExpiringSoon();
                case nameof(rpt_AdminCampTimesExpiringSoon): return new rpt_AdminCampTimesExpiringSoon();
                case nameof(rpt_AdminCurrencyAreaRateTimesExpiringSoon): return new rpt_AdminCurrencyAreaRateTimesExpiringSoon();
                case nameof(rpt_AdminFlightTimesExpiringSoon): return new rpt_AdminFlightTimesExpiringSoon();
                case nameof(rpt_AircraftFuelQuantity): return new rpt_AircraftFuelQuantity();
                case nameof(rpt_AircraftServiceTimeLeft): return new rpt_AircraftServiceTimeLeft();
                case nameof(rpt_AircraftTechnicalSummary): return new rpt_AircraftTechnicalSummary();
                case nameof(rpt_AirportDCAAirportPassengerACStats): return new rpt_AirportDCAAirportPassengerACStats();
                case nameof(rpt_AirportDepartureTaxDomestic): return new rpt_AirportDepartureTaxDomestic();
                case nameof(rpt_AirportDepartureTaxInternational): return new rpt_AirportDepartureTaxInternational();
                case nameof(rpt_AirportLandingFees): return new rpt_AirportLandingFees();
                case nameof(rpt_AirportLandingFeesByAircraft): return new rpt_AirportLandingFeesByAircraft();
                case nameof(rpt_AirportLandingFeesSelectedAirportByAircraft): return new rpt_AirportLandingFeesSelectedAirportByAircraft();
                case nameof(rpt_BaggageTag): return new rpt_BaggageTag();
                case nameof(rpt_ExcelReady_PassengerCountbyMonth): return new rpt_ExcelReady_PassengerCountbyMonth();
                case nameof(rpt_ExcelReady_PassengerFOC): return new rpt_ExcelReady_PassengerFOC();
                case nameof(rpt_ExcelReady_PassengerListByOperatorTotals): return new rpt_ExcelReady_PassengerListByOperatorTotals();
                case nameof(rpt_ExcelReady_PassengerSeatKMSbyMonth): return new rpt_ExcelReady_PassengerSeatKMSbyMonth();
                case nameof(rpt_ExpiryDatesCrossTab): return new rpt_ExpiryDatesCrossTab();
                case nameof(rpt_PassengerAreaStatistics): return new rpt_PassengerAreaStatistics();
                case nameof(rpt_PassengerAreaStatisticsByDate): return new rpt_PassengerAreaStatisticsByDate();
                case nameof(rpt_PassengerAreaStatisticsByOperatorACType): return new rpt_PassengerAreaStatisticsByOperatorACType();
                case nameof(rpt_PassengerAreaStatisticsByReservationCompany): return new rpt_PassengerAreaStatisticsByReservationCompany();
                case nameof(rpt_PassengerCountByOperatorByAirstripPairs): return new rpt_PassengerCountByOperatorByAirstripPairs();
                case nameof(rpt_PassengerCountByOperatorByDate): return new rpt_PassengerCountByOperatorByDate();
                case nameof(rpt_PassengerFOC): return new rpt_PassengerFOC();
                case nameof(rpt_PassengerFreightListByOperator): return new rpt_PassengerFreightListByOperator();
                case nameof(rpt_PassengerFreightListByOperatorByDate): return new rpt_PassengerFreightListByOperatorByDate();
                case nameof(rpt_PassengerListAllOperators): return new rpt_PassengerListAllOperators();
                case nameof(rpt_PassengerListAllOperatorsOneDay): return new rpt_PassengerListAllOperatorsOneDay();
                case nameof(rpt_PassengerListByDepartureAirport): return new rpt_PassengerListByDepartureAirport();
                case nameof(rpt_PassengerListByOperatorTotals): return new rpt_PassengerListByOperatorTotals();
                case nameof(rpt_PassengerListInvoicing): return new rpt_PassengerListInvoicing();
                case nameof(rpt_PassengerListInvoicingOLD): return new rpt_PassengerListInvoicingOLD();
                case nameof(rpt_PassengerManifest): return new rpt_PassengerManifest();
                case nameof(rpt_PassengerMannifestZambia): return new rpt_PassengerMannifestZambia();
                case nameof(rpt_PassengerOperatorDailyReservations): return new rpt_PassengerOperatorDailyReservations();
                case nameof(rpt_PassengersDailyReservationMovements): return new rpt_PassengersDailyReservationMovements();
                case nameof(rpt_Pilot28_365DaySummary): return new rpt_Pilot28_365DaySummary();
                case nameof(rpt_PilotCoPilotFlyingSummary): return new rpt_PilotCoPilotFlyingSummary();
                case nameof(rpt_PilotDetailedSummary): return new rpt_PilotDetailedSummary();
                case nameof(rpt_PilotDutyHours): return new rpt_PilotDutyHours();
                case nameof(rpt_PilotDutyHoursAllSefoPilots): return new rpt_PilotDutyHoursAllSefoPilots();
                case nameof(rpt_PilotFlyingHours): return new rpt_PilotFlyingHours();
                case nameof(rpt_PilotFlyingHoursLast30Hours): return new rpt_PilotFlyingHoursLast30Hours();
                case nameof(rpt_PilotFlyingHoursLast30HoursPivotTable): return new rpt_PilotFlyingHoursLast30HoursPivotTable();
                case nameof(rpt_PilotFlyingSummary): return new rpt_PilotFlyingSummary();
                case nameof(rpt_PilotStatus): return new rpt_PilotStatus();
                case nameof(rpt_PilotTypeSummary): return new rpt_PilotTypeSummary();
                case nameof(rpt_Quote): return new rpt_Quote();
                case nameof(rpt_ReservationsAllDay): return new rpt_ReservationsAllDay();
                case nameof(rpt_Route): return new rpt_Route();
                case nameof(rpt_ScheduleByAircraft): return new rpt_ScheduleByAircraft();
                case nameof(rpt_ScheduleByAirport2): return new rpt_ScheduleByAirport2();
                case nameof(rpt_ScheduleByReservationAirport): return new rpt_ScheduleByReservationAirport();
                case nameof(rpt_ScheduleFlightFollowing): return new rpt_ScheduleFlightFollowing();
                case nameof(rpt_ScheduleFlightMovements): return new rpt_ScheduleFlightMovements();
                case nameof(rpt_ScheduleFlightMovementsForSA): return new rpt_ScheduleFlightMovementsForSA();
                case nameof(rpt_SchedulesAllAirports): return new rpt_SchedulesAllAirports();
                case nameof(rpt_SchedulesByAirport): return new rpt_SchedulesByAirport();
                case nameof(rpt_Ticket): return new rpt_Ticket();
                default: throw new Exception("Invalid report name");
            }
        }

        public static string GetQueryByName(ReportParameters args, bool subreport = false)
        {
            switch (args.ReportName)
            {
                //case nameof(Blank): return "";
                case nameof(CrystalReport2): return "";
                case nameof(QuoteBody): return "";
                case nameof(rptAircraftDetailedRouteSummary): return "EXEC [VIEW].[sr_AircraftDetailedRouteSummary] @BeginDate, @EndDate";
                case nameof(rptAircraftDetailedTechnicalSummary) when args.AllAircraft == true: return "EXEC [VIEW].[sr_AircraftDetailedTechnicalSummary] @Aircraft, @BeginDate, @EndDate";
                case nameof(rptAircraftDetailedTechnicalSummary) when args.OwnAircraftOnly == true: return "EXEC [VIEW].[sr_AircraftDetailedTechnicalSummary] @Aircraft, @BeginDate, @EndDate";
                case nameof(rptAircraftDetailedTechnicalSummary) when args.AircraftSelected == true: return "EXEC [VIEW].[sr_AircraftDetailedTechnicalSummary] @Aircraft, @BeginDate, @EndDate";
                case nameof(rptAircraftFlightTimeCount): return "EXEC [VIEW].[sr_AircraftFlightTimeCount] @BeginDate, @EndDate";
                case nameof(rptAircraftFlightTimeCountDatePeriod): return "EXEC [VIEW].[sr_AircraftFlightTimeCount] @BeginDate, @EndDate)";
                case nameof(rptAircraftFlightTimeCountDatePeriodDOW): return "EXEC [VIEW].[sr_AircraftFlightTimeCount] @BeginDate, @EndDate";
                case nameof(rptAircraftFlyingHours): return "EXEC [VIEW].[sr_AircraftFlyingHours] @BeginDate, @EndDate";
                case nameof(rptAircraftFlyingSummary): return "EXEC [VIEW].[sr_AircraftFlyingSummary] @BeginDate, @EndDate";
                case nameof(rptAircraftFuelCost): return "EXEC [VIEW].[sr_AircraftFuelCost] @BeginDate, @EndDate";
                case nameof(rptAircraftFuelUplifts): return "EXEC [VIEW].[sr_AircraftFuelCost] @BeginDate, @EndDate";
                case nameof(rptAircraftLastTechlogSummary): return "EXEC [VIEW].[sr_AircraftLastTechlogSummary]";
                case nameof(rptAircraftServiceRecords): return "EXEC [VIEW].[sr_AircraftServiceHistory] @BeginDate, @EndDate";
                case nameof(rptAircraftTechlogEntries): return "EXEC [VIEW].[sr_AircraftTechlogEntries] @BeginDate, @EndDate";
                case nameof(rptAircraftTechlogsDifferingSchedules): return "EXEC [VIEW].[sr_AircraftTechlogsDifferingSchedules]";
                case nameof(rptAircraftUseByOperator): return "EXEC [VIEW].[sr_AircraftUseByOperator] @BeginDate, @EndDate";
                case nameof(rptAutoScheduleNoGroups): return "SELECT * FROM vr_GeneratedSchedule WHERE IDXRun = @Run";
                case nameof(rptAutoScheduleSummaryByAC): return "SELECT * FROM vr_GeneratedSchedule WHERE IDXRun = @Run";
                case nameof(rptAutoScheduleSummaryByACTotals): return "SELECT * FROM vr_GeneratedSchedule WHERE IDXRun = @Run";
                case nameof(rptAutoScheduleSummaryByACType): return "SELECT * FROM vr_GeneratedSchedule WHERE IDXRun = @Run";
                case nameof(rptAutoScheduleWithGroups): return "EXEC [VIEW].[sr_AutoSchedGroupsNotScheduled]";
                case nameof(rptPassengerCountByOperatorSummaryCount): return "EXEC [VIEW].[sr_PassengerCountByOperator] @BeginDate, @EndDate";
                case nameof(rptPassengerLoadFactor): return "EXEC [VIEW].[sr_PassengerLoadFactor] @BeginDate, @EndDate";
                case nameof(rptPassengerLoadFactorByDateByAircraft): return "EXEC [VIEW].[sr_PassengerLoadFactorByDayByAircraft] @BeginDate, @EndDate";
                case nameof(rptQuote): return "";
                case nameof(rptReservations): return "";
                case nameof(rptScheduleByAirport): return "";
                case nameof(rptScheduleByAirportByDate): return "EXEC [VIEW].[sr_ScheduleByAirportByDate] @BeginDate, @EndDate";
                case nameof(rptScheduleByOperator): return "EXEC [VIEW].[sr_ScheduleByOperator] @BeginDate, @EndDate";
                case nameof(rptScheduledSummaryByAC): return "SELECT * FROM  vr_ScheduledSummary WHERE Flightdate >= @BeginDate AND Flightdate <= @EndDate";
                case nameof(rptScheduledSummaryByACType): return "SELECT * FROM  vr_ScheduledSummary WHERE Flightdate >= @BeginDate AND Flightdate <= @EndDate";
                case nameof(rptScheduleInvoicing): return "EXEC [VIEW].[sr_ScheduleInvoicing] @BeginDate";
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring): return "SELECT * FROM vrep_AdminAirportFuelAvailTimesExpiring";
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring2): return "";
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring3): return "";
                case nameof(rpt_AdminAirportFuelAvailTimesExpiring4): return "";
                case nameof(rpt_AdminAreaRateTimesExpiringSoon): return "SELECT * FROM vrep_AdminAreaRateTimesExpiring";
                case nameof(rpt_AdminCampTimesExpiringSoon): return "SELECT * FROM vrep_AdminCampTimesExpiring";
                case nameof(rpt_AdminCurrencyAreaRateTimesExpiringSoon): return "SELECT * FROM vrep_AdminCurrencyAreaRateTimesExpiring";
                case nameof(rpt_AdminFlightTimesExpiringSoon): return "SELECT * FROM vrep_AdminFlightTimesExpiring";
                case nameof(rpt_AircraftFuelQuantity): return "";
                case nameof(rpt_AircraftServiceTimeLeft): return "SELECT * FROM vlst_TechnicalTechlog";
                case nameof(rpt_AircraftTechnicalSummary): return "";
                case nameof(rpt_AirportDCAAirportPassengerACStats): return "SELECT * FROM vrep_DCAStats where BookingDate BETWEEN @BeginDate AND @EndDate";
                case nameof(rpt_AirportDepartureTaxDomestic): return "SELECT * FROM vrep_APDepTaxInternal where FlightDate BETWEEN @BeginDate AND @EndDate ORDER BY FlightDate ASC, [From]ASC,ETD ASC";
                case nameof(rpt_AirportDepartureTaxInternational): return "SELECT * FROM vrep_APDepTaxInternational where FlightDate BETWEEN @BeginDate AND @EndDate ORDER BY FlightDate ASC";
                case nameof(rpt_AirportLandingFees): return "SELECT * FROM vr_AirportLandingFees where Date BETWEEN @BeginDate AND @EndDate";
                case nameof(rpt_AirportLandingFeesByAircraft): return "SELECT * FROM vr_AirportLandingFees where Date BETWEEN @BeginDate AND @EndDate ORDER BY IATATo ASC, Registration ASC";
                case nameof(rpt_AirportLandingFeesSelectedAirportByAircraft): return "SELECT * FROM vr_AirportLandingFees where Date BETWEEN @BeginDate AND @EndDate AND IATATo LIKE @IATA ORDER BY IATATo ASC, Registration ASC";
                case nameof(rpt_BaggageTag): return "";
                case nameof(rpt_ExcelReady_PassengerCountbyMonth): return "SELECT * FROM vr_PassengerCountByMonth where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY companyname ASC";
                case nameof(rpt_ExcelReady_PassengerFOC): return "SELECT * FROM vr_PassengerFOC WHERE BookingDate >= @BeginDate AND BookingDate <= @EndDate";
                case nameof(rpt_ExcelReady_PassengerListByOperatorTotals): return "SELECT * FROM vr_PassengerListOperatorTotal where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY  companyname ASC";
                case nameof(rpt_ExcelReady_PassengerSeatKMSbyMonth): return "SELECT * FROM vr_PassengerSeatKMByMonth where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY  companyname ASC";
                case nameof(rpt_ExpiryDatesCrossTab): return "SELECT * FROM vr_StartExpiryDates";
                case nameof(rpt_PassengerAreaStatistics): return $"SELECT * FROM [dbo].[{args.Username}_Passenger_Area_Statistics]";
                case nameof(rpt_PassengerAreaStatisticsByDate): return "SELECT * FROM [dbo].[{args.Username}_Passenger_Area_Statistics]";
                case nameof(rpt_PassengerAreaStatisticsByOperatorACType): return $"SELECT * FROM [dbo].[{args.Username}_Passenger_Area_Statistics]";
                case nameof(rpt_PassengerAreaStatisticsByReservationCompany): return $"SELECT * FROM [dbo].[{args.Username}_Passenger_Area_Statistics]";
                case nameof(rpt_PassengerCountByOperatorByAirstripPairs): return "SELECT * FROM vr_PassengerCountOperatorAirstripPairs where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY operator ASC";
                case nameof(rpt_PassengerCountByOperatorByDate): return $"SELECT DISTINCT * FROM vr_PassengerCountOperatorDate where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY  operator ASC,BookingDate ASC";
                case nameof(rpt_PassengerFOC): return "SELECT * FROM vr_PassengerFOC where BookingDate >= @BeginDate AND BookingDate <= @EndDate";
                case nameof(rpt_PassengerFreightListByOperator): return "SELECT * FROM vr_PassengerFreightListByOperator where BookingDate = @BeginDate ORDER BY Operator ASC, ReservationName ASC";
                case nameof(rpt_PassengerFreightListByOperatorByDate): return "SELECT * FROM vrep_ReportFreightByOperator where BookingDate BETWEEN @BeginDate AND @EndDate ORDER BY  operator ASC,bookingdate ASC";
                case nameof(rpt_PassengerListAllOperators): return "SELECT DISTINCT * FROM vr_PassengerListAllOperators where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY Operator, FAP";
                case nameof(rpt_PassengerListAllOperatorsOneDay): return "SELECT DISTINCT * FROM vr_PassengerListAllOperatorsOneDay where BookingDate = @BeginDate ORDER BY Operator, FAP;";
                case nameof(rpt_PassengerListByDepartureAirport): return "SELECT DISTINCT * FROM vrep_PassengerListDepartureAirport where BookingDate = @BeginDate ORDER BY BookingDate, FAP;";
                case nameof(rpt_PassengerListByOperatorTotals): return "SELECT DISTINCT * FROM vr_PassengerListOperatorTotal where BookingDate >= @BeginDate AND BookingDate <= @EndDate ORDER BY  companyname ASC";
                case nameof(rpt_PassengerListInvoicing): return "EXEC [VIEW].[sr_PassengerListInvoicing] @FlightDate = @BeginDate";
                case nameof(rpt_PassengerListInvoicingOLD): return "SELECT DISTINCT * FROM vr_PassengerListInvoicing where BookingDate = @BeginDate ORDER BY Operator";
                case nameof(rpt_PassengerManifest): return "SELECT * FROM vrep_PassengerManifest WHERE IDX = @IDX";
                case nameof(rpt_PassengerMannifestZambia): return "SELECT * FROM vrep_PassengerManifestDCA where FlightDate = @BeginDate AND IDX_ACDetails = @Aircraft";
                case nameof(rpt_PassengerOperatorDailyReservations) when args.AllOperators == true: return "SELECT * FROM vrep_groupitinerary where BookingDate BETWEEN @BeginDate AND @EndDate";
                case nameof(rpt_PassengerOperatorDailyReservations) when args.AllOperators == false: return "SELECT * FROM vrep_groupitinerary where BookingDate BETWEEN @BeginDate AND @EndDate AND idx_operators = @Operator";
                case nameof(rpt_PassengersDailyReservationMovements): return "select * from vsch_Reservations where BookingDate BETWEEN @BeginDate AND @EndDate";
                case nameof(rpt_Pilot28_365DaySummary): return "SELECT * FROM vrep_tmp_Flying_Summary_Pilot WHERE IDX_Personnel = @Pilot ORDER BY PilotName";
                case nameof(rpt_PilotCoPilotFlyingSummary): return "SELECT * FROM vrep_CoPilotFlyingHoursSummary where TechlogDate BETWEEN @BeginDate AND @EndDate ORDER BY FirstName ASC, Surname ASC";
                case nameof(rpt_PilotDetailedSummary): return "SELECT * FROM vrep_PilotSummaries where TechlogDate >= @BeginDate AND TechlogDate <= @EndDate and IDX_Personnel = @Pilot ORDER BY TechlogDate";
                case nameof(rpt_PilotDutyHours): return "SELECT FlightDate, IDX_Pilots, Firstname, Surname, DATEADD(n,-60,ETD) AS ETD, DATEADD(n,15,ETA) AS ETA, LEFT(CONVERT(VARCHAR(8), dbo.Time((([Duty Hours] + 75) / 60),(([Duty Hours] + 75) % 60),0),8),5) AS [Duty Hours]  FROM vrep_PilotDutyHours where FlightDate >= @BeginDate AND FlightDate <= @EndDate AND IDX_Pilots = @Pilot ORDER BY FlightDate ASC";
                case nameof(rpt_PilotDutyHoursAllSefoPilots): return "SELECT FlightDate, IDX_Pilots, Firstname, Surname, DATEADD(n,-60,ETD) AS ETD, DATEADD(n,15,ETA) AS ETA, LEFT(CONVERT(VARCHAR(8), dbo.Time((([Duty Hours] + 75) / 60),(([Duty Hours] + 75) % 60),0),8),5) AS [Duty Hours]  FROM vr_PilotDutyHoursAllSefoPilots where FlightDate >= @BeginDate AND FlightDate <= @EndDate AND [Pilot Active] = 1 ORDER BY Firstname, FlightDate ASC";
                case nameof(rpt_PilotFlyingHours): return "SELECT * FROM vrep_PilotHoursPredicted WHERE FlightDate >= @BeginDate AND FlightDate <= @EndDate and IDX_Pilots = @Pilot";
                case nameof(rpt_PilotFlyingHoursLast30Hours): return "SELECT * FROM dbo.ft_FlightTimePeriod(@BeginDate, @EndDate)";
                case nameof(rpt_PilotFlyingHoursLast30HoursPivotTable): return "";
                case nameof(rpt_PilotFlyingSummary): return "SELECT * FROM vrep_PilotFlyingHoursSummary where TechlogDate BETWEEN @BeginDate AND @EndDate";
                case nameof(rpt_PilotStatus): return "SELECT * FROM vrep_PilotExpiryDates order by Pilotname ASC";
                case nameof(rpt_PilotTypeSummary): return "SELECT * FROM vrep_PilotTypeSummary where TechlogDate >= @BeginDate AND TechlogDate <= @EndDate";
                case nameof(rpt_Quote): return "";
                case nameof(rpt_ReservationsAllDay): return "";
                case nameof(rpt_Route): return "SELECT * FROM vrep_Route WHERE IDX = @IDX";
                case nameof(rpt_ScheduleByAircraft): return "";
                case nameof(rpt_ScheduleByAirport2): return "[VIEW].[sr_ScheduleByAirport] @BeginDate";
                case nameof(rpt_ScheduleByReservationAirport): return "";
                case nameof(rpt_ScheduleFlightFollowing): return "EXEC sp_FlightMovements @Date = @BeginDate";
                case nameof(rpt_ScheduleFlightMovements) when subreport == false: return "EXEC sp_FlightMovements @Date = @BeginDate";
                case nameof(rpt_ScheduleFlightMovements) when subreport == true: return "SELECT * FROM vl_ScheduleLegResNotes";
                case nameof(rpt_ScheduleFlightMovementsForSA) when subreport == false: return "EXEC sp_FlightMovements @Date = @BeginDate";
                case nameof(rpt_ScheduleFlightMovementsForSA) when subreport == true: return "SELECT * FROM vl_ScheduleLegResNotes";
                case nameof(rpt_SchedulesAllAirports): return "SELECT * FROM vrep_ScheduleByAirport where FlightDate = @BeginDate ORDER BY FromName, ETD";
                case nameof(rpt_SchedulesByAirport): return "SELECT * FROM vrep_ScheduleByAirport where FlightDate = @BeginDate AND (FromAp = @Airport or ToAP = @Airport) ORDER BY FromName, ETD";
                case nameof(rpt_Ticket):
                    {
                        string ticketIds = string.Join(",", args.TicketIds);
                        return $"SELECT * FROM {args.Username} WHERE IDX IN ({ticketIds})";
                    }
                    
                default: throw new Exception("Invalid report name");
            }
        }
    }
}

