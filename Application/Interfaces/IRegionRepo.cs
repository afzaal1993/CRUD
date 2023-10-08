using Domain.Entities;
using Domain.Utilities;

namespace Application;

public interface IRegionRepo
{
    Task<List<Region>> GetAll();
    Region GetById(int id);
    Task<bool> Create(Region region);
    Task<bool> Update(Region region);
    Task<bool> Delete(int id);
}
