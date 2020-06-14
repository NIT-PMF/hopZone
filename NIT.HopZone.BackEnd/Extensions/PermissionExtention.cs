using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace NIT.HopZone.Web.NIT.HopZone.BackEnd.Extensions
{
    public static class PermissionExtenstion
    {
        public static readonly string PermissionKey = "permission";

        public static void AddPermissions(this IProvideMetadata type, string claim)
        {
            var permissions = type.GetMetadata<List<string>>(PermissionKey);
            if (permissions == null)
            {
                permissions = new List<string>();
            }
            permissions.Add(claim);
            type.Metadata[PermissionKey] = permissions;
        }

        public static bool HasClaimsMatched(this IProvideMetadata type, IEnumerable<string> claimes)
        {
            var permissions = type.GetMetadata<IEnumerable<string>>(PermissionKey, new List<string> { });
            return permissions.Any(x => claimes.Contains(x));
        }

        public static bool AnyPermissions(this IProvideMetadata type)
        {
            var permissions = type.GetMetadata<IEnumerable<string>>(PermissionKey, new List<string> { });
            
            return permissions.Any();
        }
    }

}
