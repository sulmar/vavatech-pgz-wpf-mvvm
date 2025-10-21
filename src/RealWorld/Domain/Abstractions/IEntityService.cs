using Domain.Models;

namespace Domain.Abstractions;

public interface IEntityService<T>
    where T : BaseEntity
{
    List<T> GetAll();
}
