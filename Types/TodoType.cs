using DotNetRestApiTest.Models;
using GraphQL.Types;

namespace DotNetRestApiTest.Types
{
    public class TodoType : ObjectGraphType<TodoItem>
    {
        public TodoType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.IsComplete);
        }
    }
}
