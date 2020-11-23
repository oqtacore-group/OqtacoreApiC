using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OqtacoreMLM.Controllers
{
    [ApiController]
    [Route("")]
    public class MainController : ControllerBase
    {
     

        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }


        public class SendEbookModel
        { 
            public string name { get; set; }
            public string email { get; set; }
            public string post_id { get; set; }
        }

        public class SubscribeNewsletterModel
        {
            public string url { get; set; }
            public string email { get; set; }
        }

        public class SubscribeNewsModel
        {
            public string email { get; set; }
            public string post_id { get; set; }
        }


        [HttpPost]
        [Route("/send_ebook")]
        public bool Send_ebook(SendEbookModel model)
        {

            return true;
        }

        [HttpPost]
        [Route("/subscribe_newsletter")]
        public bool Subscribe_newsletter(SubscribeNewsletterModel model)
        {

            return true;
        }

        [HttpPost]
        [Route("/subscribe_news")]
        public bool Subscribe_news(SubscribeNewsModel model)
        {

            return true;
        }
    }
}
