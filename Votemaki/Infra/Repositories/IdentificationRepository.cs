﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Votemaki.Core.Entities.MainEntities;
using Votemaki.Core.IRepository;
using Votemaki.Infra.Storage;

namespace Votemaki.Infra.Repositories
{
    public class IdentificationRepository : RepositoryBase<Identification>, IIdentificationRepository
    {
        public IdentificationRepository(
            TemakiContext temakiContext
            ) : base(temakiContext)
        {
        }

    }
}
