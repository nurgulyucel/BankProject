using BankUI.Context;
using Microsoft.AspNetCore.Mvc;

namespace BankUI.ViewComponents.Default
{
    public class _PartialTeam: ViewComponent
    {
        private readonly EfContext _efContext;

        public _PartialTeam(EfContext efContext)
        {
            _efContext = efContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _efContext.Teams.ToList();
            return View(values);
        }
    }
}
