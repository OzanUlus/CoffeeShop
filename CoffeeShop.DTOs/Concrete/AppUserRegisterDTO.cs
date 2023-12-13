using CoffeeShop.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTOs.Concrete
{
    public class AppUserRegisterDTO : IDTO
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
    }
    public enum City 
    {
        Adana=1,
        Adıyaman,
        Afyonkarahisar,
        Ağrı,
        Amasya,
        Ankara,
        Antalya,
        Artvin,
        Aydın,
        Balıkesir,
        Bilecik,
        Bingöl,
        Bitlis,
        Bolu,
        Burdur,
        Bursa,
        Çanakkale,
        Çankırı,
        Çorum,
        Denizli,
        Diyarbakır,
        Edirne,
        Elazığ,
        Erzincan,
        Erzurum,
        Eskişehir,
        Gaziantep,
        Giresun,
        Gümüşhane,
        Hakkâri,
        Hatay,
        Isparta,
        Mersin,
        İstanbul,
        İzmir,
        Kars,
        Kastamonu,
        Kayseri,
        Kırklareli,
        Kırşehir,
        Kocaeli,
        Konya,
        Kütahya,
        Malatya,
        Manisa,
        Kahramanmaraş,
        Mardin,
        Muğla,
        Muş,
        Nevşehir,
        Niğde,
        Ordu,
        Rize,
        Sakarya,
        Samsun,
        Siirt,
        Sinop,
        Sivas,
        Tekirdağ,
        Tokat,
        Trabzon,
        Tunceli,
        Şanlıurfa,
        Uşak,
        Van,
        Yozgat,
        Zonguldak,
        Aksaray,
        Bayburt,
        Karaman,
        Kırıkkale,
        Batman,
        Şırnak,
        Bartın,
        Ardahan,
        Iğdır,
        Yalova,
        Karabük,
        Kilis,
        Osmaniye,
        Düzce



    }
}
