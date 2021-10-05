using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void add(Game game);

        void Delete(Game game);
        void Update(Game game);


    }
}
