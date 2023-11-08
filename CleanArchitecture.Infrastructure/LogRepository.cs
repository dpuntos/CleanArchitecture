using CleanArchitecture.ApplicationCore;
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public class LogRepository : BaseInterface, ILogRepository
    {
        public Task DeleteLogAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Log> GetLogAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Log>> GetLogsAsync()
        {
            var llog = new List<Log>();
            llog.Add(new Log { message = "This is a sample log" });
            return Task.FromResult<IEnumerable<Log>>(llog);
        }

        public Task<Log> InsertLogAsync(Log log)
        {
            throw new NotImplementedException();
        }

        public Task<Log> UpdateLogAsync(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
