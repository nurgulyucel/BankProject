using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialServices : ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialServices(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Services.ToList();
            return View(values);
        }
    }
}
