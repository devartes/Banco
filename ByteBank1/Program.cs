namespace ByteBank1 {

    public class Program {

        static void ShowMenu() {
            Console.WriteLine("0 - Bem-vindo(a) - digite 1 acessar a conta");
            Console.WriteLine("2 - Inserir novo usuário");
            Console.WriteLine("3 - Deletar um usuário");
            Console.WriteLine("4 - Listar todas as contas registradas");
            Console.WriteLine("5 - Detalhes de um usuário");
            Console.WriteLine("6 - Quantia armazenada no banco");
            Console.WriteLine("7 - Manipular a conta");
            Console.WriteLine("8 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas , List<double> saldos) {
            Console.Write("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite o nome: ");
            titulares.Add("Insira a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
        }

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos) {
            for(int i = 0; i < cpfs.Count; i++) {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}");
            }
        }

        public static void Main(string[] args) {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;

            do {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option) {
                    case 0:
                        Console.WriteLine("encerrando o programa...");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);
            
            

        }

    }

}