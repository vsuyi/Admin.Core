﻿using Admin.Core.Common.Input;
using Admin.Core.Common.Output;
using Admin.Core.Model.Admin;
using Admin.Core.Service.Admin.Organization.Input;
using System.Threading.Tasks;

namespace Admin.Core.Service.Admin.Organization
{
    public partial interface IOrganizationService
    {
        Task<IResponseOutput> GetAsync(long id);

        Task<IResponseOutput> PageAsync(PageInput<OrganizationEntity> model);

        Task<IResponseOutput> AddAsync(OrganizationAddInput input);

        Task<IResponseOutput> UpdateAsync(OrganizationUpdateInput input);

        Task<IResponseOutput> DeleteAsync(long id);

        Task<IResponseOutput> SoftDeleteAsync(long id);
    }
}