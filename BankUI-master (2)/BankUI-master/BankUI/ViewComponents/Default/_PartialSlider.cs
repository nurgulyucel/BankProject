using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialSlider : ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialSlider(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.SiliderBars.ToList();
            return View(values);
        }
    }
}
