﻿using System;

namespace Store.NHibernate.Repo
{
    public class UserRepo
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime RegisteredDate { get; set; }
    }
}
