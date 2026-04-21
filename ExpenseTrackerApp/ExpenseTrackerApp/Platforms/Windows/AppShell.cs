using System.Diagnostics;

namespace ExpenseTrackerApp
{
    [DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
    internal partial class AppShell : Page
    {
        /* Quota exceeded. Please try again later. */
        public static implicit operator Page(AppShell v)
        {
            throw new NotImplementedException();
        }

        private static string DebuggerDisplay => ToString();
    }
}