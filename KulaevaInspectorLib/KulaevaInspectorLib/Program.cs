using System;
using InspectorLib;

namespace KulaevaInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp functionInsp = new FunctionInsp();

            functionInsp.GetInspector("Васильев Василий Иванович");//Главный инспектор
            functionInsp.GetСarInspection("Автоинспекция г. Чита");//Название автоинспекции
            functionInsp.SetInspector("");//Изменение ФИО главного инспектора
            functionInsp.GenerateNumber(12, 'A', 75);//Госномер
            functionInsp.GetWorker();//Вывод списка всех сотрудников автоинспекции
            functionInsp.AddWorker();//Добавление нового сотрудника автоинспекции
        }
    }
}
