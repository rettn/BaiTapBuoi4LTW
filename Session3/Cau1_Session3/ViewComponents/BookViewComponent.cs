using Microsoft.AspNetCore.Mvc;
using Cau1_Session3.Models;

namespace Cau1_Session3.ViewComponents
{
    public class BookViewComponent:ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}
