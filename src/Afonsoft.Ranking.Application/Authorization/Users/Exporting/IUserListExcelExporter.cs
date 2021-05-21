using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Users.Dto;
using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}