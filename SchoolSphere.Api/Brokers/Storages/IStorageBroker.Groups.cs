// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using SchoolSphere.Api.Models.Foundations.Groups;

namespace SchoolSphere.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Group> InsertGroupAsync(Group group);
        ValueTask<IQueryable<Group>> SelectAllGroupsAsync();
        ValueTask<Group> SelectGroupByIdAsync(Guid groupId);
        ValueTask<Group> UpdateGroupAsync(Group group);
    }
}
