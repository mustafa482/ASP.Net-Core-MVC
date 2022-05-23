using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViewModel_DTO.Business;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Controllers
{
    public class PersonelController : Controller
    {
        public PersonelController(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateVM personelCreateVM)
        {
            #region Manuel
            Personeller p = new Personeller()
            {
                Ad = personelCreateVM.Ad,
                Soyad = personelCreateVM.Soyad
            };

            #endregion

            #region Implicit
            //Personeller personeller = personelCreateVM;
            //PersonelCreateVM personelCreate = personeller;
            #endregion

            #region Explicit
            Personeller p1 = (Personeller)personelCreateVM;
            PersonelCreateVM Vm1 = (PersonelCreateVM)p1;
            #endregion 

            #region Reflection

            //Personeller personeller1 = TypeConversion.Conversion<PersonelCreateVM, Personeller>(personelCreateVM);
            //PersonelListeVM personelListeVM = TypeConversion.Conversion<Personeller, PersonelListeVM>(new Personeller
            //{
            //    Ad = "Mustafa",
            //    Soyad = "Mustafayev",
            //    Pozisiya = "A"
            //});
            #endregion

            #region AutoMapper
            Personeller p2 = Mapper.Map<Personeller>(personelCreateVM);
            PersonelCreateVM personel1 = Mapper.Map<PersonelCreateVM>(p2);


            #endregion

            return View();
        }
        public IActionResult Listele()
        {
            List<PersonelListeVM> personels = new List<Personeller>
            {
                new Personeller{Ad="A1",Soyad="B"},
                new Personeller{Ad="A2",Soyad="B"},
                new Personeller{Ad="A3",Soyad="B"},
                new Personeller{Ad="A4",Soyad="B"},
                new Personeller{Ad="A5",Soyad="B"}

            }.Select(p => new PersonelListeVM
            {
                Ad = p.Ad,
                Pozisiya = p.Pozisiya,
                Soyad = p.Soyad


            }).ToList();

            return View(personels);
        }
    }
}
