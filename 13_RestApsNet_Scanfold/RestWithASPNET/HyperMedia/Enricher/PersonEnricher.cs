using Microsoft.AspNetCore.Mvc;

using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.HyperMedia.Constants;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.HyperMedia.Enricher
{
    public class PersonEnricher : ContentResponseEnricher<PersonVO>
    {
        private readonly object _lock = new object();
        protected override Task EnrichModel(PersonVO content, IUrlHelper urlhelper)
        {
            var path = "api/person/v1";
            string link = GetLink(content.Id, urlhelper, path);
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaulGet

            });
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaulPost

            });
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaulPut

            });
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.DELETE,
                Href = link,
                Rel = RelationType.self,
                Type = "int"

            });
            return null;
        }

        private string GetLink(long id, IUrlHelper urlhelper, string path)
        {

            lock (_lock)
            {
                var url = new { controller = path, id = id };
                return new StringBuilder(urlhelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();

            };
        }
    }
}


