using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialAbout : ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialAbout(EfContext efContext)
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
