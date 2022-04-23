using FYRO.Application.Common.Interfaces;

namespace FYRO.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
