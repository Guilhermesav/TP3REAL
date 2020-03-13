using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TP3REAL.Models;

namespace TP3REAL.Controllers
{
    public class PessoaInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(PessoaInfoModel pessoaInfoModel)
        {

            return View("Result",pessoaInfoModel);
        }
    }
}