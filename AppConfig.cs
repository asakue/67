namespace PoliceDepartmentIS;

internal static class AppConfig
{
    public const string DatabaseTitle = "База данных «Отдел кадров и учёт преступников»";

    public static string ConnectionString =>
        Environment.GetEnvironmentVariable("POLICE_IS_CONNECTION")
        ?? @"Server=(localdb)\MSSQLLocalDB;Database=PoliceDepartmentIS;Trusted_Connection=True;TrustServerCertificate=True;";
}
