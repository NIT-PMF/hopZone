using GraphQL.Types;
using HopZone.Models;
using NIT.HopZone.BackEnd.InputTypes;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository.Interface;
using NIT.HopZone.Web.Types;

namespace NIT.HopZone.Web.Repository
{
    public class NTPMutation : ObjectGraphType
    {
        public NTPMutation(IUserRepository<User> userRepository, IContactRepository<Contact> contactRepository)
        {

            Name = "Mutation";

            Field<UserType>(
              "createUser",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UserInputType>> { Name = "user" }
              ),
              resolve: context =>
              {
                  var user = context.GetArgument<User>("user");

                  return userRepository.insert(user);
              });

            Field<ContactType>(
                "addContact",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<ContactInputType>> { Name = "contact" }
              ),
              resolve: context =>
              {
                  var contactForm = context.GetArgument<Contact>("contact");

                  return contactRepository.add(contactForm);
              });
        }
    }
}