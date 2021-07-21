using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SnackApp.Models;
using SnackApp.Repositories;
using SnackApp.ViewModels;

namespace SnackApp.Controllers
{
    public class LancheController : Controller
    {
        private readonly ICategoriasRepository _categoriaRepository;
        private readonly ILancheRepository _lancheRepository;

        // Dependency injection 
        public LancheController(ILancheRepository lancheRepository,
            ICategoriasRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        // Action method which returns the snacks
        public IActionResult List(string categoria)
        {
            var _categoria = categoria;
            IEnumerable<Lanche> lanches;
            var categoriaAtual = string.Empty;

            // If do not inform a category, will return all snacks
            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches
                    .OrderBy(l => l.LancheId);
                categoria = "Todos os lanches";
            }
            else
            {
                // StringComparison ignores UpperCase x LowerCase
                if (string.Equals("Normal", _categoria, StringComparison.OrdinalIgnoreCase))
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l => l.Nome);

                else
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                        .OrderBy(l => l.Nome);

                categoriaAtual = _categoria;
            }

            // Applying the ViwModel pattern
            var LancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            // Obtains a snack list 
            return View(LancheListViewModel);
        }

        // Method which exhibits the snack
        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches
                .FirstOrDefault(l => l.LancheId == lancheId);
            if (lanche == null)
                return View("~/Views/Error/Error.cshtml");
            return View(lanche);
        }

        // Action method
        public IActionResult Search(string searchString)
        {
            var _searchString = searchString;
            IEnumerable<Lanche> lanches;
            var _categoriaAtual = string.Empty;

            // If searchString is empty, return all snacks
            if (string.IsNullOrEmpty(_searchString))
                lanches = _lancheRepository.Lanches
                    .OrderBy(l => l.LancheId);

            else
                // If has content, search based on the typed text
                lanches = _lancheRepository.Lanches
                    .Where(l => l.Nome
                        .ToLower()
                        .Contains(_searchString.ToLower()));

            return View("~/Views/Lanche/List.cshtml",
                new LancheListViewModel {Lanches = lanches, CategoriaAtual = "Todos os lanches"});
        }
    }
}