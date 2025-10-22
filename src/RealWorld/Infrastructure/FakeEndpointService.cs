using Domain.Abstractions;
using Domain.Models;

namespace Infrastructure;

public class FakeEndpointService : IEndpointService
{
    public List<Endpoint> GetAll()
    {
        return
        [
            new Endpoint { Id = 1, Name = "A", Category = Category.Conference },
            new Endpoint { Id = 2, Name = "B", Category = Category.P2P, IsActive = false },
            new Endpoint { Id = 3, Name = "C", Category = Category.Conference },
            new Endpoint { Id = 4, Name = "D", Category = Category.P2P, IsActive = false },
            new Endpoint { Id = 5, Name = "E", Category = Category.Conference },
            new Endpoint { Id = 6, Name = "F", Category = Category.Radionet, IsActive = false },
            new Endpoint { Id = 7, Name = "G", Category = Category.Conference },
            new Endpoint { Id = 8, Name = "H", Category = Category.Conference },
            new Endpoint { Id = 9, Name = "I", Category = Category.P2P },
             new Endpoint { Id = 10, Name = "J", Category = Category.Radionet, IsActive = false },
            new Endpoint { Id = 11, Name = "K", Category = Category.Conference },
            new Endpoint { Id = 12, Name = "L", Category = Category.Conference },
            new Endpoint { Id = 13, Name = "M", Category = Category.P2P },
        ];
    }
}
