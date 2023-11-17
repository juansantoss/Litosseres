using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositorio;

namespace WebApplication1.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly IRelatorioRepository _relatorioRepository;
        public RelatorioController(IRelatorioRepository relatorioRepository)
        {
            _relatorioRepository = relatorioRepository;
        }
        public IActionResult Index()
        {
            //var clientes = _relatorioRepository.Extratos.ToList();
            //return View(clientes);
            return View();
        }

        public IActionResult Cte()
        {
            //List<ExtratoAnaliticoCteModel> student = _relatorioRepository.SearchAll();
            //return View(student);
            List<ExtratoAnaliticoCteModel> student = _relatorioRepository.SearchAll();
            return View(student);
        }
        public IActionResult Nfe()
        {
            return View();
        }
        public IActionResult Nfse()
        {
            return View();
        }
    }
}
