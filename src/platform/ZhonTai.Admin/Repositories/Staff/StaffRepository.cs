﻿using ZhonTai.Admin.Core.Db.Transaction;
using ZhonTai.Admin.Core.Repositories;
using ZhonTai.Admin.Domain.Staff;

namespace ZhonTai.Admin.Repositories;

public class StaffRepository : RepositoryBase<StaffEntity>, IStaffRepository
{
    public StaffRepository(UnitOfWorkManagerCloud uowm) : base(uowm)
    {

    }
}