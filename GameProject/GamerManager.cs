using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        //MicroService
        IUserValidationService userValidationService;
public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer) == true)
            { 
                Console.WriteLine("Kayıt olundu");
            } 
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }

        }
        
     
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
