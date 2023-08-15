using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _ParitalFooter : ViewComponent
    {
        private readonly EfContext _efContext;

        public _ParitalFooter(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Abouts.ToList();
            return View(values);
        }
    }
}

