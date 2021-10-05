using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService

    {
        public void add(Game game)
        {
            Console.WriteLine(game.Name+"adli oyun eklnedi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "adli oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "adli oyun guncellendi");
        }
    }
}
