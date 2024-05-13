using Kolokwium1.Repositories;

namespace Kolokwium1.Services;

public class Service : IService
{
    private readonly IRepository _repository;

    public Service(IRepository repository)
    {
        _repository = repository;
    }
}