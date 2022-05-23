using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.AutoMappers
{
    public class PersonelProfil:Profile
    {
        public PersonelProfil()
        {
            CreateMap<Personeller, PersonelCreateVM>();
            CreateMap<PersonelCreateVM, Personeller>();




        }

    }
}
