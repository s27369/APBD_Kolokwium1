namespace Kolokwium1.Repositories;

public class Repository : IRepository
{
    private IConfiguration _configuration;

    public Repository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
}