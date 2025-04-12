

List<string> listaDeNomes = null!;




/*void DigiteSeuNome()
{
    Console.WriteLine("Digite seu nome:");
    string nome = Console.ReadLine();
    if (listaDeNomes.Any(x => x == nome) == false)
    {
        Console.WriteLine("Usuário não cadastrado");
        OpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"Seja bem vindo {nome}");
    }
    
   
}*/



void DigiteNome()
{
    Console.WriteLine("digite seu nome");
    string nome = Console.ReadLine();
    bool oNomeEstaNaLista = false;

    if (listaDeNomes == null)
    {
        listaDeNomes = new List<string>();
        listaDeNomes.Add("larieli");
        listaDeNomes.Add("sonia");
        listaDeNomes.Add("jhie");
    }

    for (int i = 0;  i < listaDeNomes.Count; i++)
    {
        if(listaDeNomes[i] == nome)
        {
            oNomeEstaNaLista = true;
            Console.WriteLine($"Seja bem vindo(a) {nome}");
            break;
        }
     
    }

    if (oNomeEstaNaLista == false)
    {
        Console.WriteLine($"Nome {nome} não está na lista");
        OpcoesDoMenu();
    }
}




void OpcoesDoMenu()
{
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] cadastrar novo usuário");
    Console.WriteLine("[2] acessar como convidado");
    Console.WriteLine("[3] sair");

    Console.WriteLine("Digite uma opção:");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastroDeUsuario();
            break;
        case 2:
            Console.WriteLine("Acesso concedido como convidado");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void CadastroDeUsuario()
{
    Console.Clear();
    Console.WriteLine("Cadastre um novo usuário");
    Console.WriteLine("insira o nome do usuário:");
    string nome = Console.ReadLine();
    listaDeNomes.Add(nome);
    Console.WriteLine($"usuário {nome} foi cadastrado com sucesso");
    Console.WriteLine("Digite qualquer tecla para voltar ao inicio");
    Console.ReadKey();
    Console.Clear();
    DigiteNome();
}

DigiteNome();


