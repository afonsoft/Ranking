using System;
using System.Threading.Tasks;
using Flurl.Http.Content;
using Afonsoft.Ranking.Authorization.Users.Profile.Dto;

namespace Afonsoft.Ranking.Authorization.Users.Profile
{
    public class ProxyProfileControllerService : ProxyControllerBase
    {
        public async Task<UploadProfilePictureOutput> UploadProfilePicture(Action<CapturedMultipartContent> buildContent)
        {
            return await ApiClient
                .PostMultipartAsync<UploadProfilePictureOutput>(GetEndpoint(nameof(UploadProfilePicture)), buildContent);
        }
    }
}