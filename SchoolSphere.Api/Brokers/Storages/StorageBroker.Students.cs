// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSphere.Api.Models.Foundations.Students;

namespace SchoolSphere.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Student> Students { get; set; }

        public ValueTask<Student> InsertStudentAsync(Student student) =>
            InsertAsync(student);

        public ValueTask<IQueryable<Student>> SelectAllStudentsAsync() =>
            SelectAllAsync<Student>();

        public ValueTask<Student> SelectStudentByIdAsync(Guid studentId) =>
            SelectAsync<Student>(studentId);

        public ValueTask<Student> UpdateStudentAsync(Student student) =>
            UpdateAsync(student);

        public ValueTask<Student> DeleteStudentAsync(Student student) =>
            DeleteAsync(student);
    }
}
