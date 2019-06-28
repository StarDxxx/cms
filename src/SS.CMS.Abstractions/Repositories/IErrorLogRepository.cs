using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SS.CMS.Data;
using SS.CMS.Models;

namespace SS.CMS.Repositories
{
    public interface IErrorLogRepository : IRepository
    {
        Task DeleteAsync(List<int> idList);

        ErrorLogInfo GetErrorLogInfo(int logId);

        Task DeleteAllAsync();

        Task<int> AddErrorLogAsync(ErrorLogInfo logInfo);

        Task<int> AddErrorLogAsync(Exception ex, string summary = "");

        Task<int> AddErrorLogAsync(string pluginId, Exception ex, string summary = "");

        Task<int> AddStlErrorLogAsync(string summary, string elementName, string stlContent, Exception ex);
    }
}
