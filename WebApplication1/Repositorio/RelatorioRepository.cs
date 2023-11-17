using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositorio;

namespace WebApplication1
{
    public class RelatorioRepository : IRelatorioRepository
    {
        private readonly BancoContext _bancoContext;

        public RelatorioRepository(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }
        public List<ExtratoAnaliticoCteModel> SearchAll()
        {
            return _bancoContext.Extratos.ToList();

        }
    }
}
