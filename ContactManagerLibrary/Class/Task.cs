using ContactManagerLibrary.Enums;

namespace ContactManagerLibrary.Class
{
    internal class Task
    {
        Guid TaskId { get; }
        ContactType Type { get; set; }
        string ReferenceId { get; set; }
        TaskParameters Parameters { get; set; }
    }
}