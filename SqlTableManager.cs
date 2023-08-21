using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp
{
    public class SqlTableManager
    {
        private readonly MyDbContext _context;

        public SqlTableManager(MyDbContext context)
        {
            _context = context;
        }

        public List<Dictionary<string, object>> GetTableData(string tableName, params string[] columnNames)
        {
            var sql = $"SELECT {string.Join(",", columnNames)} FROM {tableName}";
            var connection = _context.Database.Connection;
            var data = new List<Dictionary<string, object>>();

            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = sql;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rowData = new Dictionary<string, object>();

                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            rowData[reader.GetName(i)] = reader.GetValue(i);
                        }

                        data.Add(rowData);
                    }
                }
            }

            connection.Close();

            return data;
        }
        // если необходимо доавить в БД новую таблицу / поле (столбец) связь - необходимо выполнить миграцию. Черезе Вид - Другие Окна - Консоль диспетчера пакетов выполнить команду
        // enable-migrations один раз. Создается файл миграции. После этого все изменения командами. Например добавить колонку Type в таблицу Music будет
        // команда add-migration AddMusicType. После добавления необходима команда update-database


    }
}
