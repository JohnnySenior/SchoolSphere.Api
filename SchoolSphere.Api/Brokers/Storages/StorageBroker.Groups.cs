﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using SchoolSphere.Api.Models.Foundations.Groups;

namespace SchoolSphere.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Group> Groups { get; set; }
    }
}