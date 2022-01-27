using System;
using GetUserConten.Core;

namespace GetUserConten.ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserController user = GetUserController(TypeContent.JSONContent); //зависимость

            foreach (var item in  user.GetUsers())
            {
                Console.WriteLine($"имя {item.name} фамилия{item.fersName} группа{item.group}");
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
            throw new NotImplementedException();
        }

        private static IUserController GetTXT()
        {
            throw new NotImplementedException();
        }
    }


}
