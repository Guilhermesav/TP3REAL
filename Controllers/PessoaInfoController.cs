using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP3REAL.Models;
using TP3REAL.Repositorios;

namespace TP3REAL.Controllers
{
    public class PessoaInfoController : Controller
    {
        private readonly PessoaInfoRepositorio _pessoaInfoRepositorio;

        public PessoaInfoController()
        {
            _pessoaInfoRepositorio = new PessoaInfoRepositorio();
        }
        // GET: Pessoa
        public ActionResult Index()
        {
     
            return View(_pessoaInfoRepositorio.GetAll());
        }
        public ActionResult PesquisaNome(string nome)
        {
            return View("Index", _pessoaInfoRepositorio.PesquisaNome(nome));
        }
        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            var pessoa = _pessoaInfoRepositorio.ProcurarId(id);
            return View(pessoa);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaInfoModel novaPessoa)
        {
            try
            {
                // TODO: Add insert logic here
                _pessoaInfoRepositorio.Add(novaPessoa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaInfoRepositorio.ProcurarId(id);
            return View(pessoa);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,PessoaInfoModel pessoaAtualizada)
        {
            try
            {

                var pessoa = _pessoaInfoRepositorio.ProcurarId(pessoaAtualizada.Id);
                _pessoaInfoRepositorio.Atualizar(pessoa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaInfoRepositorio.ProcurarId(id);
            return View(pessoa);
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PessoaInfoModel pessoaDeletar)
        {
            try
            {
                // TODO: Add delete logic here
                _pessoaInfoRepositorio.Delete(pessoaDeletar.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}