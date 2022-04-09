﻿using LSE.Stocks.Domain.Models.Shares;

namespace LSE.Stocks.Application.Repositories
{
    public interface IShareExchangeRepository
    {
        Task SaveShareExchangeAsync(ShareExchange shareExchange);
    }
}
