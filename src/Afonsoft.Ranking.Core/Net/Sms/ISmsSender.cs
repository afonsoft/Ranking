﻿using System.Threading.Tasks;

namespace Afonsoft.Ranking.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}