using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class AdminInputType : InputObjectGraphType
    {
        public AdminInputType(){
       
            Name = "AdminInput";
           Field<NonNullGraphType<StringGraphType>>("Username");
           Field<StringGraphType>("FirstName");
            Field<NonNullGraphType<StringGraphType>>("Password");
           Field<StringGraphType>("LastName");

        }
    }
}
