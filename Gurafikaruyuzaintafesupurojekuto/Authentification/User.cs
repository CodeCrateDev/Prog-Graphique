using System;
using System.Collections.Generic;
using System.Text;

namespace Authentification
{
    public class User
    {
        public static User Current { get; private set; }

        public static bool IsLoggedIn => Current != null;

        public string Matricule { get; private set; }

        public bool IsAdmin { get; private set; }

        public User(string matricule, bool isAdmin)
        {
            Matricule = matricule;
            IsAdmin = isAdmin;
        }

        internal void SetCurrent()
        {
            Current = this;
        }

        internal void UnsetCurrent()
        {
            Current = null;
        }
    }
}
