using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Models
{
    public class Personeller
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisiya { get; set; }
        public int Maas { get; set; }
        public bool Hal { get; set; }

        #region Implicit/Gizli/Bilincsiz
        //public static implicit operator PersonelCreateVM(Personeller model)
        //{
        //    return new PersonelCreateVM()
        //    {
        //        Ad = model.Ad,
        //        Soyad = model.Soyad
        //    };
        //}

        //public static implicit operator Personeller(PersonelCreateVM model)
        //{
        //    return new Personeller()
        //    {
        //        Ad = model.Ad,
        //        Soyad = model.Soyad
        //    };
        //}
        #endregion

        #region Explicit/Aciq/Bilincli
        public static explicit operator PersonelCreateVM(Personeller model)
        {
            return new PersonelCreateVM()
            {
                Ad = model.Ad,
                Soyad = model.Soyad
            };
        }

        public static explicit operator Personeller(PersonelCreateVM model)
        {
            return new Personeller()
            {
                Ad = model.Ad,
                Soyad = model.Soyad
            };
        }
        #endregion


    }
}
