using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            char sexo;
            string rg;
            string estadoCivil;
            string end;
            string bairro;
            int numCasa;
            string cidade;
            string estado;
            string email;
            string numCelular;
            int curso;
            int opcao1;
            int opcao2;
            int opcao3;
            int opcao4;

            Console.WriteLine("---------------");
            Console.WriteLine("Cadastro online");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite seu nome completo: ");
            Console.ResetColor();
            nome=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite sua idade: ");
            Console.ResetColor();
            idade=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Informe seu sexo usando F para feminino ou M para masculino: ");
            Console.ResetColor();
            sexo=Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite seu RG: ");
            Console.ResetColor();
            rg=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Informe seu estado civil: ");
            Console.ResetColor();
            estadoCivil=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite o nome da sua rua: ");
            Console.ResetColor();
            end=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite o nome do seu bairro: ");
            Console.ResetColor();
            bairro=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite o número da sua casa: ");
            Console.ResetColor();
            numCasa=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Informe sua cidade: ");
            Console.ResetColor();
            cidade=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Informe a sigla do estado: ");  
            Console.ResetColor();          
            estado=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite o número do seu celular: ");
            Console.ResetColor();
            numCelular=Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite seu email: ");
            Console.ResetColor();
            email=Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("Cursos disponíveis: ");
            Console.ResetColor();
            Console.WriteLine("(1) Informática ");
            Console.WriteLine("(2) Enfermagem ");
            Console.WriteLine("(3) Administração ");
            Console.WriteLine("(4) Edificações ");

            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite o número do curso que deseja: ");
            Console.ResetColor();
            curso=Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            opcao1=curso;
            opcao2=curso;
            opcao3=curso;
            opcao4=curso;

            if(opcao1==1){
                Console.ForegroundColor=ConsoleColor.DarkCyan;
                Console.WriteLine(nome+", idade "+idade+" anos, "+estadoCivil);
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Mora na rua "+end+" N°: "+numCasa+" Bairro: "+bairro);
                Console.WriteLine("Na cidade de "+cidade+" no estado de "+estado);
                Console.WriteLine("Celular - "+numCelular);
                Console.WriteLine("Email - "+email);
                Console.ForegroundColor=ConsoleColor.DarkBlue;
                Console.WriteLine("Curso: Informática");
                Console.ResetColor();

            }if(opcao2==2){
                Console.ForegroundColor=ConsoleColor.DarkCyan;
                Console.WriteLine(nome+", idade "+idade+" anos, "+estadoCivil);
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Mora na rua "+end+" N°: "+numCasa+" Bairro: "+bairro);
                Console.WriteLine("Na cidade de "+cidade+" no estado de "+estado);
                Console.WriteLine("Celular - "+numCelular);
                Console.WriteLine("Email - "+email);
                Console.ForegroundColor=ConsoleColor.DarkBlue;
                Console.WriteLine("Curso: Enfermagem");
                Console.ResetColor();

            }if(opcao3==3){
                Console.ForegroundColor=ConsoleColor.DarkCyan;
                Console.WriteLine(nome+", idade "+idade+" anos, "+estadoCivil);
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Mora na rua "+end+" N°: "+numCasa+" Bairro: "+bairro);
                Console.WriteLine("Na cidade de "+cidade+" no estado de "+estado);
                Console.WriteLine("Celular - "+numCelular);
                Console.WriteLine("Email - "+email);
                Console.ForegroundColor=ConsoleColor.DarkBlue;
                Console.WriteLine("Curso: Administrção");
                Console.ResetColor();

            }if(opcao4==4){
                Console.ForegroundColor=ConsoleColor.DarkCyan;
                Console.WriteLine(nome+", idade "+idade+" anos, "+estadoCivil);
                Console.WriteLine("Sexo: "+sexo);
                Console.WriteLine("Mora na rua "+end+" N°: "+numCasa+" Bairro: "+bairro);
                Console.WriteLine("Na cidade de "+cidade+" no estado de "+estado);
                Console.WriteLine("Celular - "+numCelular);
                Console.WriteLine("Email - "+email);
                Console.ForegroundColor=ConsoleColor.DarkBlue;
                Console.WriteLine("Curso: Edificações");
                Console.ResetColor();

            }
            Console.Beep();
        }
    }
}
