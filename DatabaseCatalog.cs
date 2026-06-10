namespace PoliceDepartmentIS;

internal static class DatabaseCatalog
{
    private static readonly string[] KadrovyColumns =
    [
        "ФИО", "Возраст", "Пол", "Адрес", "Телефон", "Паспортные данные",
        "Должность", "Оклад", "Звание", "Надбавка", "Итого зарплата"
    ];

    private static readonly string[] PrestupnikiColumns =
    [
        "Номер дела", "ФИО преступника", "Дата рождения", "Пол", "Адрес",
        "Вид преступления", "Статья", "Наказание", "Срок", "Пострадавший", "Состояние", "Сотрудник"
    ];

    public static IReadOnlyList<DbObjectDefinition> Tables { get; } =
    [
        new("Сотрудники", "dbo.Сотрудники", DbObjectKind.Table,
            ["ФИО", "Возраст", "Пол", "Адрес", "Телефон", "Паспортные данные", "Код должности", "Код звания"],
            ["Код сотрудника"],
            new()
            {
                ["Код должности"] = new("Код должности", "dbo.Должности",  "Наименование должности"),
                ["Код звания"]    = new("Код звания",    "dbo.Звания",     "Наименование")
            },
            true, "dbo.Сотрудники"),

        new("Должности", "dbo.Должности", DbObjectKind.Table,
            ["Наименование должности", "Оклад", "Обязанности", "Требования"],
            ["Код должности"], null, true, "dbo.Должности"),

        new("Звания", "dbo.Звания", DbObjectKind.Table,
            ["Наименование", "Надбавка", "Обязанности", "Требования"],
            ["Код звания"], null, true, "dbo.Звания"),

        new("Виды преступлений", "dbo.ВидыПреступлений", DbObjectKind.Table,
            ["Наименование", "Статья", "Наказание", "Срок"],
            ["Код вида преступления"], null, true, "dbo.ВидыПреступлений"),

        new("Преступники", "dbo.Преступники", DbObjectKind.Table,
            ["ФИО", "Дата рождения", "Пол", "Адрес", "Код вида преступления", "Код пострадавшего", "Состояние", "Код сотрудника"],
            ["Номер дела"],
            new()
            {
                ["Код вида преступления"] = new("Код вида преступления", "dbo.ВидыПреступлений", "Наименование"),
                ["Код пострадавшего"]     = new("Код пострадавшего",     "dbo.Пострадавшие",     "ФИО"),
                ["Код сотрудника"]        = new("Код сотрудника",        "dbo.Сотрудники",       "ФИО")
            },
            true, "dbo.Преступники"),

        new("Пострадавшие", "dbo.Пострадавшие", DbObjectKind.Table,
            ["ФИО", "Дата рождения", "Пол", "Адрес"],
            ["Код пострадавшего"], null, true, "dbo.Пострадавшие")
    ];

    public static IReadOnlyList<DbObjectDefinition> Queries { get; } =
    [
        new("Отдел кадров", "dbo.v_ОтделКадров", DbObjectKind.Query,
            KadrovyColumns, []),

        new("Преступники", "dbo.v_Преступники", DbObjectKind.Query,
            PrestupnikiColumns, [])
    ];

    public static IReadOnlyList<DbObjectDefinition> Filters { get; } =
    [
        // ── Фильтры по должностям (на основе запроса «Отдел кадров») ──────────
        new("Должность: Начальник отдела",    "dbo.v_ОтделКадров_Должность_НачальникОтдела",    DbObjectKind.Filter, KadrovyColumns, []),
        new("Должность: Старший следователь", "dbo.v_ОтделКадров_Должность_СтаршийСледователь", DbObjectKind.Filter, KadrovyColumns, []),
        new("Должность: Следователь",         "dbo.v_ОтделКадров_Должность_Следователь",        DbObjectKind.Filter, KadrovyColumns, []),
        new("Должность: Оперуполномоченный",  "dbo.v_ОтделКадров_Должность_Оперуполномоченный", DbObjectKind.Filter, KadrovyColumns, []),
        new("Должность: Инспектор архива",    "dbo.v_ОтделКадров_Должность_ИнспекторАрхива",    DbObjectKind.Filter, KadrovyColumns, []),

        // ── Фильтры по званиям (на основе запроса «Отдел кадров») ────────────
        new("Звание: Лейтенант полиции",          "dbo.v_ОтделКадров_Звание_Лейтенант",       DbObjectKind.Filter, KadrovyColumns, []),
        new("Звание: Старший лейтенант полиции",   "dbo.v_ОтделКадров_Звание_СтаршийЛейтенант", DbObjectKind.Filter, KadrovyColumns, []),
        new("Звание: Капитан полиции",             "dbo.v_ОтделКадров_Звание_Капитан",         DbObjectKind.Filter, KadrovyColumns, []),
        new("Звание: Майор полиции",               "dbo.v_ОтделКадров_Звание_Майор",           DbObjectKind.Filter, KadrovyColumns, []),
        new("Звание: Подполковник полиции",        "dbo.v_ОтделКадров_Звание_Подполковник",    DbObjectKind.Filter, KadrovyColumns, []),

        // ── Фильтры по видам преступлений (на основе запроса «Преступники») ──
        new("Вид преступления: Кража",                           "dbo.v_Преступники_Вид_Кража",          DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Вид преступления: Мошенничество",                   "dbo.v_Преступники_Вид_Мошенничество",  DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Вид преступления: Грабёж",                          "dbo.v_Преступники_Вид_Грабёж",         DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Вид преступления: Разбой",                          "dbo.v_Преступники_Вид_Разбой",         DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Вид преступления: Причинение тяжкого вреда здоровью","dbo.v_Преступники_Вид_ТяжкийВред",   DbObjectKind.Filter, PrestupnikiColumns, []),

        // ── Фильтры по состоянию дела (на основе запроса «Преступники») ──────
        new("Состояние: Передано в суд",  "dbo.v_Преступники_Состояние_ПередаСуд",      DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Состояние: Под следствием",  "dbo.v_Преступники_Состояние_ПодСледствием",  DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Состояние: В розыске",       "dbo.v_Преступники_Состояние_ВРозыске",       DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Состояние: Задержан",        "dbo.v_Преступники_Состояние_Задержан",       DbObjectKind.Filter, PrestupnikiColumns, []),
        new("Состояние: Под подпиской",   "dbo.v_Преступники_Состояние_ПодПодпиской",   DbObjectKind.Filter, PrestupnikiColumns, [])
    ];

    public static IReadOnlyList<DbObjectDefinition> AllObjects =>
        Tables.Concat(Queries).Concat(Filters).ToArray();
}
