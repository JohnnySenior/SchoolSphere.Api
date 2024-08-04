// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using SchoolSphere.Api.Infrastructure.Services;

namespace SchoolSphere.Api
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var scriptGenerationService = new ScriptGenerationService();
            scriptGenerationService.GenerateBildScript();
        }
    }
}