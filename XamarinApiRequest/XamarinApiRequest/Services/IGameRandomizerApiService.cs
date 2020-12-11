using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinApiRequest.Models;

namespace XamarinApiRequest.Services
{
    public interface IGameRandomizerApiService
    {
        Task<Game> GetRandomAsync();
    }
}
