using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteConsInputType: InputObjectGraphType
    {
        public WasteConsInputType()
        {
            Name = "WasteConsInput";
            Field<NonNullGraphType<StringGraphType>>("Username");
            Field<StringGraphType>("FirstName");
            Field<NonNullGraphType<StringGraphType>>("Password");
            Field<StringGraphType>("LastName");

        }
    }
}
