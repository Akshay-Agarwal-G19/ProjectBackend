using DemoProject.Data.Entities;
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
    public class DemoProjectMutation : ObjectGraphType
    {
        public DemoProjectMutation(WasteProdRepo wasteprodrepo, WasteConsRepo wasteconsrepo, AdminRepo adminrepo)
        {
            Field<WasteProdType>(
            "createwasteprod",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<WasteProdInputType>> { Name = "wasteProducer" }),
            resolve: context =>
            {
                var wasteProducer = context.GetArgument<WasteProducer>("wasteProducer");
                return wasteprodrepo.Addwasteprod(wasteProducer);
            });

            //Field<BooleanGraphType>(
            //"login",
            //arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserInputType>> { Name = "user" }),
            //resolve: context =>
            //{
            //    var user = context.GetArgument<User>("user");
            //    return userRepository.login(user.Email, user.Password);
            //});

        }
    }
}
