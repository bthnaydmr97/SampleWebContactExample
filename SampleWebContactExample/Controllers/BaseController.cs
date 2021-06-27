using BusinessLayer;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebContactExample.Controllers
{
    public class BaseController : Controller
    {
        private ContactFacade _contactFacade;

        public ContactFacade ContactFacade
        {
            get
            {
                if (_contactFacade == null)
                    _contactFacade = new ContactFacade();
                return _contactFacade;
            }
        }
    }
}
