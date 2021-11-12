using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface Imovable //сздаем интернфейс для движущегося объекта
    {
        void Move();// создаем метод для движения(метод не имеет реализации)

        void Brake();// метод для торможения
    }
    class Mercedes : Imovable //создаем класс который реализует интерфейс
    {
        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}

