using System.Collections.Generic;
using Abp;
using Afonsoft.Ranking.Chat.Dto;
using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
