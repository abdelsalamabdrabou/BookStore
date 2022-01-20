using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.ConstantsStringSettings
{
    public static class Permissions
    {
        public const string PERMISSION_TYPE = "Permission";
        public static List<string> GeneratePermissionsForModule(string module)
        {
            var permissionsList = new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Update",
            $"Permissions.{module}.Delete"
        };

            return permissionsList;
        }

        public static List<string> GenerateAllPermissions()
        {
            var allPermissionsList = new List<string>();
            var allModules = Enum.GetNames(typeof(Modules));

            foreach (var module in allModules)
                allPermissionsList.AddRange(GeneratePermissionsForModule(module));

            return allPermissionsList;
        }
    }
}
