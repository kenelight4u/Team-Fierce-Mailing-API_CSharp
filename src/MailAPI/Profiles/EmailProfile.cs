using AutoMapper;
using MailAPI.DTOs;
using MailAPI.Models;

namespace MailAPI.Profiles{
    public class EmailProfile : Profile{
        
        public EmailProfile()
        {
            //source to target
           CreateMap<Email, EmailReadDTO>();
           CreateMap<EmailCreateDTO, Email>();
        }
    }

}