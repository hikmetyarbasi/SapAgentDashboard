﻿using System.Threading.Tasks;
using SapAgent.Entities.Concrete.Pure;

namespace SapAgent.Business.Pure.Abstract
{
    public interface IBackgroundProcessManager
    {
        Task<BackgroundProcess[]> Get();
        void Add(BackgroundProcess process);
    }
}