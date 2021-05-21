﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Afonsoft.Ranking.DynamicEntityProperties.Dto;
using Afonsoft.Ranking.DynamicEntityPropertyValues.Dto;

namespace Afonsoft.Ranking.DynamicEntityProperties
{
    public interface IDynamicEntityPropertyValueAppService
    {
        Task<DynamicEntityPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicEntityPropertyValueDto>> GetAll(GetAllInput input);

        Task Add(DynamicEntityPropertyValueDto input);

        Task Update(DynamicEntityPropertyValueDto input);

        Task Delete(int id);

        Task<GetAllDynamicEntityPropertyValuesOutput> GetAllDynamicEntityPropertyValues(GetAllDynamicEntityPropertyValuesInput input);
    }
}
