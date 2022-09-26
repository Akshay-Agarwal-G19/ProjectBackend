using DemoProject.Data.GraphQL.Types;
using DemoProject.Repository;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data.GraphQL
{
    public class DemoProjectQuery:ObjectGraphType
    {
        public DemoProjectQuery(WasteProdRepo wasteprodrepo)
        {
            Field<ListGraphType<WasteProdType>>(
                "wasteproducers",
                resolve: context => wasteprodrepo.GetWasteProd()
                );

            Field<ListGraphType<WasteProdType>>(
               "wasteproducersbyfname",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "firstname" }),
               resolve: context =>
               {
                   var firstname = context.GetArgument<string>("firstname");
                   return wasteprodrepo.GetWasteProdbyfname(firstname);
               }

               );
        }
    }
}
