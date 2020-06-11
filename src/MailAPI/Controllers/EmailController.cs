using System.Collections.Generic;
using MailAPI.Data;
using MailAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MailAPI.Controllers
{
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepo _repository;

        public EmailController(IEmailRepo repository)
        {
            _repository = repository;
        }


        [Route("api/v1/getmails")]
        public ActionResult <IEnumerable<Email>> GetAllEmails(){
            return Ok(_repository.GetEmails());
        }
    }
}