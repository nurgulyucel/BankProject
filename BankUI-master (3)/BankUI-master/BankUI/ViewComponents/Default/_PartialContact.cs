using BankUI.Context;
using BankUI.Models;
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

        public IViewComponentResult Invoke(Contact contact)
        {
            if (ModelState.IsValid) 
            {
                _efContext.Contacts.Add(contact); 
                _efContext.SaveChanges(); 
            }
            var values = _efContext.Contacts.ToList();
            return View(values);
        }
        }
    }


