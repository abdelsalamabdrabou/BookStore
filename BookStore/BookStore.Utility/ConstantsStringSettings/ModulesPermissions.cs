using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.ConstantsStringSettings
{
    public class ModulesPermissions
    {
        #region Book_Module
        public const string BOOK_CREATE = "Permissions.Book.Create";
        public const string BOOK_VIEW = "Permissions.Book.View";
        public const string BOOK_UPDATE = "Permissions.Book.Update";
        public const string BOOK_DELETE = "Permissions.Book.Delete";
        #endregion

        #region Roles_Module
        public const string ROLES_CREATE = "Permissions.Roles.Create";
        public const string ROLES_VIEW = "Permissions.Roles.View";
        public const string ROLES_UPDATE = "Permissions.Roles.Update";
        public const string ROLES_DELETE = "Permissions.Roles.Delete";
        #endregion
    }
}
