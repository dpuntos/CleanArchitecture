using CleanArchitecture.Domain;

namespace CleanArchitecture.ApplicationCore
{
    public interface ILogRepository : IBase
    {
        Task<IEnumerable<Log>> GetLogsAsync();
        Task<Log> GetLogAsync(int id);
        Task<Log> InsertLogAsync(Log log);
        Task<Log> UpdateLogAsync(Log log);
        Task DeleteLogAsync(int id);
    }
}