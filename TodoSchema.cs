using GraphQL;
using GraphQL.Types;

namespace DotNetRestApiTest
{
    public class TodoSchema : Schema
    {
        public TodoSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<TodoQuery>();
        }
    }
}
