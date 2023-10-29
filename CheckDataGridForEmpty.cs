using System.Windows.Forms;

namespace RaceApp
{
    internal static class CheckDataGrid
    {
        public static bool CheckDataGridForEmty(DataGridView dataGrid)
        {
            if (dataGrid == null || dataGrid.RowCount == 0) 
            {
                return true;
            }

            return false;
        }
    }
}
