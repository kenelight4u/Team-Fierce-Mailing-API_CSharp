using System.Collections.Generic;
using AutoMapper;
using MailAPI.Data;
using MailAPI.DTOs;
using MailAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MailAPI.Controllers
{
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepo _repository;
        private readonly IMapper _mapper;

        public EmailController(IEmailRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [Route("api/v1/getmails")]
        [HttpGet]
        public ActionResult<IEnumerable<Email>> GetAllEmails()
        {
            var items = _repository.GetEmails();
            return Ok(_mapper.Map<IEnumerable<EmailReadDTO>>(items));
            //return Ok(items);
        }

        [Route("api/v1/sendmail")]
        [HttpPost]
        public ActionResult<EmailReadDTO> SendEmail(EmailCreateDTO emailCreateDTO)
        {
            var emailModel = _mapper.Map<Email>(emailCreateDTO);
            _repository.SendMail(emailModel);
           _repository.SaveChanges();
             var emailReadDTO = _mapper.Map<EmailReadDTO>(emailModel);
             return Ok(emailReadDTO);
        }

        //[Route("api/v1/sendmailwithtemplate")]
    }
}