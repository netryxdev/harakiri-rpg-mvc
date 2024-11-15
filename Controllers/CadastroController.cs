﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using harakiri_rpg.Models.Pages.Cadastro;
using harakiri_rpg.Services.Interfaces;
using harakiri_rpg.Models.DB;
using Microsoft.AspNetCore.Authorization;

namespace harakiri_rpg.Controllers
{
    [AllowAnonymous]
    public class CadastroController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly IUsuarioService _usuarioService;

        public CadastroController(ApplicationDbContext context, IUsuarioService usuarioService)
        {
            _context = context;
            _usuarioService = usuarioService;
        }

        // GET: Register
        public IActionResult Index()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CadastroViewModel model)
        {

            if(!ModelState.IsValid)
            {
                // desenvolver um display message generico para erro
                DisplayError("Ocorreu um erro.");
                return View(model);
            }

            _usuarioService.CriarUsuario(model);

            DisplayMessage("Besta Fera");
            // desenvolver um display message generico para SUCESSO

            return RedirectToAction("Index");
        }
    }
}
