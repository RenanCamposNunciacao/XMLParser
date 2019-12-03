using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XMLStructure.InputDocumentStructure;

namespace XMLWebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        public int Default(InputDocument pInputDocument)
        {
            if (pInputDocument == null || pInputDocument.DeclarationList.Declaration.Command != "DEFAULT")
                return -1;

            if (pInputDocument == null || pInputDocument.DeclarationList.Declaration.DeclarationHeader.SiteID != "DUB")
                return -2;

            return 0;
        }
    }
}
