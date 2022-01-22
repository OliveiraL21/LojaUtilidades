﻿using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Venda
{
   public interface IVendaService
    {
        public Task<VendaEntity> PostAsync(VendaEntity venda);
        public Task<VendaEntity> GetAsync(int id);
        public IEnumerable<VendaEntity> GetVendas();
        public IEnumerable<VendaEntity> GetByDate(VendaEntity venda);
        public IEnumerable<VendaEntity> GetByProductName(string produto);
        public Task<IEnumerable<VendaEntity>> GetAllAsync();
        public Task<VendaEntity> PutAsync(VendaEntity venda);
        public Task<bool> Delete(int id);
    }
}
