﻿using System;

namespace OfferLocker.Business.Identity.Models
{
    public sealed class UserModel
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
    }
}
