using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace RaceApp
{
    public class SqlTableManager
    {
        private readonly MyDbContext _context;

        public SqlTableManager(MyDbContext context)
        {
            _context = context;
        }

        //public List<Dictionary<string, object>> GetTableData(string tableName, params string[] columnNames)
        //{
        //    var sql = $"SELECT {string.Join(",", columnNames)} FROM {tableName}";
        //    var connection = _context.Database.Connection;
        //    var data = new List<Dictionary<string, object>>();

        //    connection.Open();

        //    using (var command = connection.CreateCommand())
        //    {
        //        command.CommandText = sql;

        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var rowData = new Dictionary<string, object>();

        //                for (var i = 0; i < reader.FieldCount; i++)
        //                {
        //                    rowData[reader.GetName(i)] = reader.GetValue(i);
        //                }

        //                data.Add(rowData);
        //            }
        //        }
        //    }

        //    connection.Close();

        //    return data;
        //}

        //public static List<object> GetTableData(string tableName, string[] columnNames)
        //{
        //    using (var context = new MyDbContext())
        //    {
        //        var objectContext = ((IObjectContextAdapter)context).ObjectContext;
        //        var entityType = objectContext.MetadataWorkspace
        //                                .GetItems<EntityType>(DataSpace.CSpace)
        //                                .FirstOrDefault(e => e.Name == tableName);

        //        var entityTypeClrType = ObjectContext.GetObjectType(entityType.GetType());
        //        var parameter = Expression.Parameter(entityTypeClrType, "e");
        //        var bindings = new List<MemberBinding>();
        //        foreach (var columnName in columnNames)
        //        {
        //            var property = entityType.Properties.FirstOrDefault(p => p.Name == columnName);
        //            if (property != null)
        //            {
        //                var member = Expression.Property(parameter, property.Name);
        //                var memberInfo = entityTypeClrType.GetProperty(property.Name);
        //                var binding = Expression.Bind(memberInfo, member);
        //                bindings.Add(binding);
        //            }
        //        }
        //        var selector = Expression.Lambda(Expression.MemberInit(Expression.New(entityTypeClrType), bindings), parameter);

        //        var tableNameEscaped = "[" + tableName.Replace(".", "].[") + "]";
        //        var query = objectContext.CreateQuery<object>(tableNameEscaped);
        //        var tableData = query.Select((Func<object, object>)selector.Compile())
        //                             .ToList();

        //        return tableData;
        //    }
        //}


        // если необходимо доавить в БД новую таблицу / поле (столбец) связь - необходимо выполнить миграцию. Черезе Вид - Другие Окна - Консоль диспетчера пакетов выполнить команду
        // enable-migrations один раз. Создается файл миграции. После этого все изменения командами. Например добавить колонку Type в таблицу Music будет
        // команда add-migration AddMusicType. После добавления необходима команда update-database

        
    }

}
