using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.HyperMedia.Filters
{
    public class HyperMediaFilter:ResultFilterAttribute

    {
        private readonly HyperMediaFilterOptions _hyperMediaFilterOptions;

        public HyperMediaFilter(HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;

        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnricherResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnricherResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult objectResult)
            {
                var enricher = _hyperMediaFilterOptions.ContentResponseEnricher.FirstOrDefault(x => x.CanEnrich(context));
                
                if (enricher != null)
                {
                    Task.FromResult(enricher.Enrich(context));
                }
            };
        }
    }
}
