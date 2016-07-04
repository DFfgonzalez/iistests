using ERP.Defontana.Dal.Interface;
using ERP.Defontana.Cpl.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace ERP.Defontana.Dal.Core
{
    public class Dao : IDao<EmpresaDto>, IDisposable
    {

        private MsContext context;

        public Dao()
        {
            context = new MsContext();

            // Configuración de mapeo.
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<EmpresaDto, Empresa>();
                config.CreateMap<Empresa, EmpresaDto>();
            });

        }

        public void Add(EmpresaDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(EmpresaDto dto)
        {
            throw new NotImplementedException();
        }

        public EmpresaDto[] GetAll(Expression<Func<EmpresaDto, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public EmpresaDto[] GetAll(string idEmpresa)
        {
            throw new NotImplementedException();
        }

        public EmpresaDto[] GetAll(Expression<Func<EmpresaDto, bool>> filtro, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public EmpresaDto[] GetAll(string idEmpresa, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(EmpresaDto dto)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Dao() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
