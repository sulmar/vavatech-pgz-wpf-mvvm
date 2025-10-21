using Domain.Models;
using System.Collections.ObjectModel;

namespace Domain.Abstractions;

public interface IEntityService<T>
    where T : BaseEntity
{
    List<T> GetAll();
}
