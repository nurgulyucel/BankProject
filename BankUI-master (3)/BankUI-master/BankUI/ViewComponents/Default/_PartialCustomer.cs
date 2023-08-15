using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialCustomer : ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialCustomer(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Customers.ToList();
            return View(values);
        }
    }
}

