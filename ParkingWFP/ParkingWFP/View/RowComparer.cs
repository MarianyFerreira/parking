using System.Windows.Forms;

namespace ParkingWFP.View
{
    class RowComparer : System.Collections.IComparer
    {
        private static int sortOrderModifier = 1;

        public RowComparer(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
            {
                sortOrderModifier = -1;
            }
            else if (sortOrder == SortOrder.Ascending)
            {
                sortOrderModifier = 1;
            }
        }

        public int Compare(object x, object y)
        {
            DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
            DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

            // Try to sort based on the Last Name column.
            int CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells["StartedAt"].Value.ToString(),
                    DataGridViewRow2.Cells["StartedAt"].Value.ToString());

            // If the Last Names are equal, sort based on the First Name.
            if (CompareResult == 0)
            {
                CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells["StartedAt"].Value.ToString(),
                    DataGridViewRow2.Cells["StartedAt"].Value.ToString());
            }
            return CompareResult * sortOrderModifier;
        }
    }
}
