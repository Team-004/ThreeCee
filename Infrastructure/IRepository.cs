using System.Collections.Generic;

namespace ThreeCee.Infrastructure;

public interface IRepository<TEntity> where TEntity :class
{
    TEntity GetById(int id);
    List<TEntity> GetAll();
    int Add(TEntity entity);
    void Update(TEntity updatedVehicle);
    void Delete(int id);
    void DeleteAll();
}