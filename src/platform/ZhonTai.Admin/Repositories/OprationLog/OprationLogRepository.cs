﻿using ZhonTai.Admin.Core.Db.Transaction;
using ZhonTai.Admin.Core.Repositories;
using ZhonTai.Admin.Domain.OprationLog;

namespace ZhonTai.Admin.Repositories;

public class OprationLogRepository : RepositoryBase<OprationLogEntity>, IOprationLogRepository
{
    public OprationLogRepository(UnitOfWorkManagerCloud uowm) : base(uowm)
    {
    }
}