using System;
using GetUserConten.BL;
using GetUserConten.Core;

namespace GetUserConten.ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserController user = GetUserController(TypeContent.TXTContent); //зависимость

            foreach (var item in  user.GetUsers())
            {
                Console.WriteLine($"имя {item.name} фамилия {item.fersName} группа {item.group}");
            }
        }

        private static IUserController GetUserController(TypeContent jSONContent)
        {
           switch (jSONContent)
            {
                case TypeContent.TXTContent: return GetTXT(); break;
                case TypeContent.JSONContent: return  GetJson(); break;
                default: throw new Exception("неизвестный тип данных");
            }


        }

        private static IUserController GetJson()
        {
            return new UserControllerJSON();
        }

        private static IUserController GetTXT()
        {
            return new UserControllerTXT();
        }
    }


}
