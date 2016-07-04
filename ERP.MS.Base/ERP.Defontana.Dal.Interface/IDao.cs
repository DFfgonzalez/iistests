using System;
using System.Linq.Expressions;

namespace ERP.Defontana.Dal.Interface
{
    public interface IDao<TEntityDto>
    {

        void Add(TEntityDto dto);
        void Delete(TEntityDto dto);
        void Update(TEntityDto dto);

        TEntityDto[] GetAll(string idEmpresa);
        TEntityDto[] GetAll(string idEmpresa, params string[] includes);
        TEntityDto[] GetAll(Expression<Func<TEntityDto, bool>> filtro);
        TEntityDto[] GetAll(Expression<Func<TEntityDto, bool>> filtro, params string[] includes);

        void Save();

    }
}
