using System.Data;
using Microsoft.Data.SqlClient;

namespace PoliceDepartmentIS;

internal sealed class SqlDataRepository
{
    public DataTable Load(DbObjectDefinition definition)
    {
        using var connection = new SqlConnection(AppConfig.ConnectionString);
        using var adapter = new SqlDataAdapter(definition.SelectSql, connection);
        var table = new DataTable(definition.Title);
        adapter.Fill(table);
        return table;
    }

    public DataTable LoadRaw(string sql, string name)
    {
        using var connection = new SqlConnection(AppConfig.ConnectionString);
        using var adapter = new SqlDataAdapter(sql, connection);
        var table = new DataTable(name);
        adapter.Fill(table);
        return table;
    }

    public DataTable LoadLookup(LookupDefinition lookup)
    {
        var sql = $"SELECT [{lookup.KeyColumn}], [{lookup.ValueColumn}] FROM {lookup.SourceTable} ORDER BY [{lookup.ValueColumn}]";
        return LoadRaw(sql, lookup.SourceTable);
    }

    public SqlDataAdapter CreateEditableAdapter(DbObjectDefinition definition)
    {
        if (!definition.Editable || definition.BaseTable is null)
        {
            throw new InvalidOperationException("Этот объект доступен только для чтения.");
        }

        var connection = new SqlConnection(AppConfig.ConnectionString);
        var sql = $"SELECT {BuildEditableColumnList(definition)} FROM {definition.BaseTable}";
        var adapter = new SqlDataAdapter(sql, connection);
        var builder = new SqlCommandBuilder(adapter)
        {
            QuotePrefix = "[",
            QuoteSuffix = "]"
        };
        adapter.InsertCommand = builder.GetInsertCommand();
        adapter.UpdateCommand = builder.GetUpdateCommand();
        adapter.DeleteCommand = builder.GetDeleteCommand();
        return adapter;
    }

    private static string BuildEditableColumnList(DbObjectDefinition definition)
    {
        var columns = definition.KeyColumns.Concat(definition.DisplayColumns).Distinct();
        return string.Join(", ", columns.Select(c => $"[{c}]"));
    }
}
