using DotNetRestApiTest.Controllers;
using DotNetRestApiTest.Models;
using DotNetRestApiTest.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace DotNetRestApiTest
{
    public class TodoQuery : ObjectGraphType
    {
        /*
        public TodoQuery(TodoController todoController)
        {
            Field<ListGraphType<TodoType>>(
            "todos",
            resolve: context =>
            {
                var todos = todoController.GetTodoItems();
                return todos;
            });
        }
        */

        public TodoQuery(TodoRepository todoRepository)
        {
            Field<ListGraphType<TodoType>>(
            "todos",
            resolve: context =>
            {
                var todos = todoRepository.GetAll();
                return todos;
            });
        }
    }
}
