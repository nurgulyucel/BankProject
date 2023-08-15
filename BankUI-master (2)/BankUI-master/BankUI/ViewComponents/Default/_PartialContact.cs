using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialContact : ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialContact(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Contacts.ToList();
            return View(values);
        }
    }
}

