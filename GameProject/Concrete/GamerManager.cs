using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        public void add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" "+ gamer.LastName+" isimli oyuncu eklenmistir. ");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silinmistir. ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu guncellenmistir. ");
        }
    }
}
