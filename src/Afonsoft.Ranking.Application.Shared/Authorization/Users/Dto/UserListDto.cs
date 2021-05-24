using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Afonsoft.Ranking.Authorization.Users.Dto
{
    public class UserListDto : EntityDto<long>, IPassivable, IHasCreationTime
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public Guid? ProfilePictureId { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public List<UserListRoleDto> Roles { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }

        public string Telephone { get; set; }

        public string Celphone { get; set; }

        public string Address { get; set; }

        public char? Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public decimal? Height { get; set; }

        public decimal? Weight { get; set; }
    }
}