using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace toDoApp.Controllers
{
    public class TodoController : Controller
    {
        public String Index()
        {
            return "test";
        }
    }
}