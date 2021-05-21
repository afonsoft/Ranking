using System.Collections.Generic;
using Afonsoft.Ranking.Auditing.Dto;
using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
