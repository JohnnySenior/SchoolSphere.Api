﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.Threading.Tasks;
using SchoolSphere.Api.Models.Foundations.Groups;

namespace SchoolSphere.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Group> InsertGroupAsync(Group group);
    }
}
