using LibrarySimple.Controller;
using LibrarySimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUser
{
    class Program
    {
        static UserController user = new UserController();
        static void Main(string[] args)
        {
            var option = int.MinValue;

            while (option != 0)
            {
                Console.WriteLine("Sistema do AA");
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Usuário");
                Console.WriteLine("2 - Listar Usuário");
                Console.WriteLine("0 - Sair");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddUsers();
                        break;
                    case 2:
                        ListUsers();
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void ListUsers()
        {
            Console.WriteLine("List users AA");

            user.GetUsers().ToList().ForEach(x => Console.WriteLine($"Name:{x.Name}"));
        }

        private static void AddUsers()
        {
            Console.WriteLine("-- Inserir Usuario --");
            Console.WriteLine("Informe o Nome do celular");

            var name = Console.ReadLine();

            var result = user.AddUser(new User()
            {
                Name = name
            });

            if (result)
                Console.WriteLine("Sucess my little pony, join more one User of drugs");
            else
                Console.WriteLine("Fail from user");
        }


    }
}
