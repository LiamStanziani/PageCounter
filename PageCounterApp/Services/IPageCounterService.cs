
namespace PageCounterApp.Services
{
    public interface IPageCounterService
    {
        // A method that takes the page name and returns the current page count for the page
        public int IncrementPageCount(string pageName);
    }
}
