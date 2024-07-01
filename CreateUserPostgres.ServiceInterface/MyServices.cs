using ServiceStack;
using CreateUserPostgres.ServiceModel;

namespace CreateUserPostgres.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
}