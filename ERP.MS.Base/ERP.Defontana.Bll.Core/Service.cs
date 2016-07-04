using ERP.Defontana.Bll.Interface;
using ERP.Defontana.Cpl.Dto;
using ERP.Defontana.Cpl.Exceptions;
using ERP.Defontana.Cpl.Util;
using ERP.Defontana.Dal.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Defontana.Bll.Core
{
    public class Service : IService
    {

        private IDao<EmpresaDto> dao;

        public Service(IDao<EmpresaDto> dao)
        {
            this.dao = dao;
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
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Service() {
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
