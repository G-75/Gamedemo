using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "oyun silindi.");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.GameName + "oyun kaydedildi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "oyun güncellendi.");

        }
    }
}
