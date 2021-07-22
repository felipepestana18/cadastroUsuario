using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroUsuario.Data;
using CadastroUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuario.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Index()
        {
            using (var data = new UsuarioData())
                return View(data.Read());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {

            if (!ModelState.IsValid)
            {

                return View(usuario);

            }
            else
            {
                using (var data = new UsuarioData())
                {
                    data.Create(usuario);
                    return RedirectToAction("Index");

                }
            }

        }
              
    }
}