using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialWork : ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialWork(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Processes.ToList();
            return View(values);
        }
    }
}
