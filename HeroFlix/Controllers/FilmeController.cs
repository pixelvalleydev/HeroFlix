using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroFlix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeroFlix.Controllers
{
    public class FilmeController : Controller
    {
        // GET: Filme
        public ActionResult Index()
        {
            return View(ObterFilmes());
        }

        // GET: Filme/Details/5
        public ActionResult Details(int id)
        {
            List<Filme> filmes = ObterFilmes();

            Filme filme = filmes.Where(f => f.Id == id).First();
            return View(filme);
        }

        // GET: Filme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filme/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filme filme)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Filme/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Filme/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Filme/Delete/5
        public ActionResult Delete(int id)
        {
            List<Filme> filmes = ObterFilmes();

            Filme filme = filmes.Where(f => f.Id == id).First();
            return View(filme);
        }

        // POST: Filme/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        private List<Filme> ObterFilmes()
        {
            List<Filme> filmes = new List<Filme>();

            filmes.Add(new Filme
            {
                Id = 1,
                Titulo = "Filme SA",
                Elenco = "Pedro Silva, João Souza, Dioni Silva",
                Genero = "Ação",
                Sinopse = "Filme muito legal para assistir",
                Status = Models.Enums.StatusFilme.Planejado
            });

            filmes.Add(new Filme
            {
                Id = 2,
                Titulo = "Filme SB",
                Elenco = "Pedro Silva, João Souza, Dioni Silva",
                Genero = "Ação",
                Sinopse = "Filme muito legal para assistir",
                Status = Models.Enums.StatusFilme.Assistido,
                AssistidoEm = new DateTime(2018, 06, 12)
            });

            filmes.Add(new Filme
            {
                Id = 3,
                Titulo = "Filme SC",
                Elenco = "Pedro Silva, João Souza, Dioni Silva",
                Genero = "Aventura",
                Sinopse = "Filme muito legal para assistir",
                Status = Models.Enums.StatusFilme.Assistido,
                AssistidoEm = DateTime.Now
            });

            return filmes;
        }
    }
}