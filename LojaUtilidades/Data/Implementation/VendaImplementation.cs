﻿using Data.Context;
using Data.Repositorios;
using Domain.Entidades;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class VendaImplementation : Repository<VendaEntity>, IVendaRepository
    {
        private readonly DbSet<VendaEntity> _dataSet;
        private readonly MyContext _context;
        public VendaImplementation(MyContext context) : base(context)
        {
            _context = context;
            _dataSet = context.Set<VendaEntity>();
        }

        public IEnumerable<VendaEntity> GetVendas()
        {
            var result = _dataSet.Include(v => v.ItensVenda)
                .ThenInclude(it => it.Produto).ToList();

            return result;

        }
        public IEnumerable<VendaEntity> GetByDate(VendaEntity venda)
        {
            var result = _dataSet.Where(v => v.Data_da_Venda == venda.Data_da_Venda).Include(v => v.ItensVenda).ThenInclude(it => it.Produto).ToList();

            return result;
        }

        public IEnumerable<VendaEntity> GetByProductName(VendaEntity venda)
        {
            var result = _dataSet.Include(v => v.ItensVenda)
                .ThenInclude(it => it.Produto.Nome).ToList();

            return result;
        }
    }
}
