namespace PoliceDepartmentIS;

internal sealed record LookupDefinition(
    string KeyColumn,
    string SourceTable,
    string ValueColumn);

internal sealed record DbObjectDefinition(
    string Title,
    string SourceName,
    DbObjectKind Kind,
    string[] DisplayColumns,
    string[] KeyColumns,
    Dictionary<string, LookupDefinition>? Lookups = null,
    bool Editable = false,
    string? BaseTable = null)
{
    public string SelectSql =>
        $"SELECT {string.Join(", ", DisplayColumns.Select(c => $"[{c}]"))} FROM {SourceName}";
}
