// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System.Threading.Tasks;
using SchoolSphere.Api.Brokers.DateTimes;
using SchoolSphere.Api.Brokers.Loggings;
using SchoolSphere.Api.Brokers.Storages;
using SchoolSphere.Api.Models.Foundations.Students;

namespace SchoolSphere.Api.Services.Foundations.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;
        private readonly IDateTimeBroker dateTimeBroker;

        public StudentService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker,
            IDateTimeBroker dateTimeBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
            this.dateTimeBroker = dateTimeBroker;
        }

        public ValueTask<Student> AddStudentAsync(Student student) =>
            throw new System.NotImplementedException();
    }
}
