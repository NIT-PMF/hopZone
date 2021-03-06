﻿
using System.Linq;
using GraphQL.Types;
using HopZone.Models;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Extensions;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository.Interface;
using NIT.HopZone.Web.Repository;
using NIT.HopZone.Web.Settings;
using NIT.HopZone.Web.Types;

namespace NIT.HopZone.Web.Queries
{
    public class NTPQuery : ObjectGraphType
    {
        public NTPQuery
        (
            ICollectionRepository<Country> countriesRepository,
            ICollectionRepository<Season> seasonsRepository,
            ICollectionRepository<Admin> adminsRepository,
            IUserRepository<User> userRepository,
            IContactRepository<Contact> contactReppsitory,
            ISpotRepository<Spot> spotRepository
         )
     
        {

            Field<ListGraphType<SpotType>>(
               "Spots",
               resolve: ctx => spotRepository.GetAll());
            Field<ListGraphType<SpotType>>(
                "getSpotbyid",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: ctx =>
                {
                    return spotRepository.GetAll();
                });


            Field<ListGraphType<SpotType>>(
               "SpotsForUser",
               resolve: ctx => spotRepository.GetAll());
            Field<ListGraphType<SpotType>>(
                "SpostByUsers",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "username" }),
                resolve: ctx =>
                { 
                    return spotRepository.getSpots("username", ctx.GetArgument<string>("username"));
                });


            Field<AdminType>
            (
                "admin",
                arguments: new QueryArguments
                (
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    { Name = "code", Description = "Country code" }
                ),

                resolve: context => adminsRepository
                    .GetItemAsync("code", context.GetArgument<string>("code"))
                    .Result
            ).AddPermissions("super admin");

            Field<ListGraphType<AdminType>>
            (
                "admins",
                resolve: context => adminsRepository
                    .GetItemsAsync()
                    .Result
            );

            Field<ListGraphType<AdminType>>
            (
                "allAdmins",
                resolve: context => adminsRepository
                    .GetItemsAsync()
                    .Result
            );

            Field<ListGraphType<ContactType>>
            (
                "allContactForms",
                resolve: context => contactReppsitory
                    .GetAll()
                    .Result
            );

            Field<UserType>
            (
                "userByUsername",
                arguments: new QueryArguments
                (
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    { Name = "username", Description = "Username of account" }
                ),
                resolve: context => userRepository
                    .GetUserByUsername("Username", context.GetArgument<string>("username"))
                    .Result
            );

            Field<CountryType>
            (
                "country",
                arguments: new QueryArguments
                (
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    { Name = "code", Description = "Country code" }
                ),
                resolve: context => countriesRepository
                    .GetItemAsync("code", context.GetArgument<string>("code"))
                    .Result
            );

            Field<ListGraphType<CountryType>>
            (
                "countries",
                resolve: context => countriesRepository
                    .GetItemsAsync()
                    .Result
            );
        }
    }
}
