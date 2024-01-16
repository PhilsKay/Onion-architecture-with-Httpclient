using Onion_architecture.Infrastructure.FinanceAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_architecture.Infrastructure.RecipesAPI
{
    public interface IFinanceNews
    {
        Task<FinanceNews> GetNews();

    }
}
