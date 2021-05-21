using System.Collections.Generic;
using Afonsoft.Ranking.Authorization.Users.Importing.Dto;
using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
