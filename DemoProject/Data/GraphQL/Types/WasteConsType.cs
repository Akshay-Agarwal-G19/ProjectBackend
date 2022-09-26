using DemoProject.Data.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL.Types
{
    public class WasteConsType: ObjectGraphType<WasteConsumer>
    {
        public WasteConsType()
        {
            Field(t => t.Id);
            Field(t => t.Username);
            Field(t => t.Password);
            Field(t => t.First_Name);
            Field(t => t.Last_Name);

        }

    }
}
