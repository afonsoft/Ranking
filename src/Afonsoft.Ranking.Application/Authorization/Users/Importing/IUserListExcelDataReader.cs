using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Afonsoft.Ranking.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
