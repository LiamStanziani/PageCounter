using System.Transactions;

namespace PageCounterApp.Services
{
    public class PageCounterService : IPageCounterService
    {
        // A method that takes the page name and returns the current page count for the page
        public int IncrementPageCount(string pageName)
        {
            if (_pageCounts.ContainsKey(pageName))
            {
                int count = _pageCounts[pageName] + 1;
                _pageCounts[pageName] = count;
                return count;
            }
            else
            {
                _pageCounts.Add(pageName, 1);
                return 1;
            }
        }

        private Dictionary<string, int> _pageCounts = new Dictionary<string, int>();
    }
}
