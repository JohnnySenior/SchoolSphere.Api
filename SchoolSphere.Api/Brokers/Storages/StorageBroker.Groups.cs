// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSphere.Api.Models.Foundations.Groups;

namespace SchoolSphere.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Group> Groups { get; set; }

        public ValueTask<Group> InsertGroupAsync(Group group) =>
            InsertAsync(group);

        public ValueTask<IQueryable<Group>> SelectAllGroupsAsync() =>
            SelectAllAsync<Group>();

        public ValueTask<Group> SelectGroupByIdAsync(Guid groupId) =>
            SelectAsync<Group>(groupId);

        public ValueTask<Group> UpdateGroupAsync(Group group) =>
            UpdateAsync(group);
    }
}
