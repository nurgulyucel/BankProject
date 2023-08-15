using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _ParitalGallery:ViewComponent
    {
        private readonly EfContext _efContext;

        public _ParitalGallery(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Gallerys.ToList();
            return View(values);
        }
    }
}
