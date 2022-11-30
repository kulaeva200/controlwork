using System;

namespace InspectorLib
{
    public class FunctionInsp

    {
        string[] staff = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };//Cотрудники
        string[] inspector = { "Васильев Василий Иванович" };//Главный инспектор

        public void GetInspector(string a)//данный метод возвращает ФИО главного инспектора автоинспекции
        {
            Console.WriteLine($"Главный инспектор – {a}");
        }

        public void GetСarInspection(string b)//данный метод возвращает название автоинспекции
        {
            Console.WriteLine($"Название – {b}");
        }

        public string SetInspector(string all)//данный метод изменяет ФИО главного инспектора, только если данное ФИО есть в списке сотрудников
        {

            Console.WriteLine("Для выбора нового главного инспектора введите число от 1 до 4");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                all = staff[0];
                staff = inspector;
                Console.WriteLine($"Новый главный инспектор - {all}");
                return all;
            }
            else if (i == 2)
            {
                all = staff[1];
                staff = inspector;
                Console.WriteLine($"Новый главный инспектор  - {all}");
                return all;
            }
            else if (i == 3)
            {
                all = staff[2];
                staff = inspector;
                Console.WriteLine($"Новый главный инспектор  - {all}");
                return all;
            }
            else if (i == 4)
            {
                all = staff[3];
                staff = inspector;
                Console.WriteLine($"Новый главный инспектор  - {all}");
                return all;
            }
            else
            {
                Console.WriteLine("Ошибка");//При вводе неправильного значение, выводит сообщение о ошибке
                return all;

            }
        }

        public string GenerateNumber(int number, char symbol, int code) //данный метод формирует из принимаемых аргументов госномер вида SYMBOLnumber_CODE
        {
            string num = symbol + "";
            num = num.ToUpper() + number + "_" + code;
            Console.WriteLine("Госномер:" + num);
            return num;
        }

        public void GetWorker()//данный метод возвращает список сотрудников
        {
            string[] All = new string[] { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
            Span <string> AllSpan = All;

            foreach (var staff in AllSpan)
            {
                Console.WriteLine("Фио сотрудников автоинспекции: " + staff);
            }
        }

        public void AddWorker()//данный метод добавляет нового сотрудника в список сотрудников
        {
            
            Console.WriteLine("Введите ФИО нового сотрудника");
            string newstaff = Console.ReadLine();
            Array.Resize(ref staff, staff.Length + 1);
            staff[staff.Length - 1] = newstaff;
            Console.WriteLine($"Cотрудник {newstaff} успешно добавлен");
            
        }
}

    }

