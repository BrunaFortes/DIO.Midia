using System;

namespace DIO.Series
{
    class Program
    {
	
        static SerieRepositorio repositorioS = new SerieRepositorio();
		static FilmeRepositorio repositorioF = new FilmeRepositorio();
		static LivroRepositorio repositorioL = new LivroRepositorio();
		static JogoRepositorio repositorioJ = new JogoRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuarioFSL = ObterOpcaoUsuarioFSL();
			
			while (opcaoUsuarioFSL.ToUpper() != "X")
			{
				switch (opcaoUsuarioFSL)
				{
					case "1":           
						goto Filmes;
						
					case "2":			
						goto Series;
						
					case "3":			
						goto Livros;
						
					case "4":			
						goto Jogos;
						
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuarioFSL = ObterOpcaoUsuarioFSL();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();

			Series:
			string opcaoUsuarioS = ObterOpcaoUsuarioS();
			while (opcaoUsuarioS.ToUpper() != "X")
			{
				switch (opcaoUsuarioS)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						System.Console.WriteLine("Deseja excluir a série? [S/N]");
						char escolha;
						escolha=char.Parse(Console.ReadLine());
						if(escolha=='s'|escolha=='S'){ 
							ExcluirSerie();
						}else{
							goto Series;
						}
						break;
					case "5":
						VisualizarSerie();
						break;
					
						case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuarioS = ObterOpcaoUsuarioS();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
			 
			Filmes:
			string opcaoUsuarioF = ObterOpcaoUsuarioF();
			while (opcaoUsuarioF.ToUpper() != "X")
			{
				switch (opcaoUsuarioF)
				{
					case "1":
						ListarFilmes();
						break;
					case "2":
						InserirFilme();
						break;
					case "3":
						AtualizarFilme();
						break;
					case "4":
						System.Console.WriteLine("Tem certeza? [s/n]");
						char escolha;
						escolha=char.Parse(Console.ReadLine());
						if(escolha=='s'|escolha=='S'){
							ExcluirFilme();
						}else{
							goto Filmes;
						}						
						break;
					case "5":
						VisualizarFilme();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuarioF = ObterOpcaoUsuarioF();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
			
			Livros:
			string opcaoUsuarioL = ObterOpcaoUsuarioL();
			while (opcaoUsuarioL.ToUpper() != "X")
			{
				switch (opcaoUsuarioL)
				{
					case "1":
						ListarLivros();
						break;
					case "2":
						InserirLivro();
						break;
					case "3":
						AtualizarLivro();
						break;
					case "4":
						System.Console.WriteLine("Deseja excluir o livro? [s/n]");
						char escolha;
						escolha=char.Parse(Console.ReadLine());
						if(escolha=='s'|escolha=='S'){ 
							ExcluirLivro();
						}else{
							goto Livros;
						}
						break;
					case "5":
						VisualizarLivro();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuarioL = ObterOpcaoUsuarioL();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();

			Jogos:
			string opcaoUsuarioJ = ObteropcaoUsuarioJ();
			while (opcaoUsuarioJ.ToUpper() != "X")
			{
				switch (opcaoUsuarioJ)
				{
					case "1":
						ListarJogos();
						break;
					case "2":
						InserirJogo();
						break;
					case "3":
						AtualizarJogo();
						break;
					case "4":
						System.Console.WriteLine("Deseja excluir o Jogo? [s/n]");
						char escolha;
						escolha=char.Parse(Console.ReadLine());
						if(escolha=='s'|escolha=='S'){ 
							ExcluirJogo();
						}else{
							goto Jogos;
						}
						break;
					case "5":
						VisualizarJogo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuarioJ = ObteropcaoUsuarioJ();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
			
			
        }

        private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorioS.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorioS.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(IdS: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioS.Atualiza(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorioS.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaIdS(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(IdS: repositorioS.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioS.Insere(novaSerie);
		}
        private static void ExcluirFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorioF.ExcluiF(indiceFilme);
		}

        private static void VisualizarFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var filme = repositorioF.RetornaPorIdF(indiceFilme);

			Console.WriteLine(filme);
		}

        private static void AtualizarFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Filme: ");
			string entradaDescricao = Console.ReadLine();

			Filme atualizaFilme = new Filme(IdF: indiceFilme,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioF.AtualizaF(indiceFilme, atualizaFilme);
		}
        private static void ListarFilmes()
		{
			Console.WriteLine("Listar Filmes");

			var lista = repositorioF.ListaF();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum filme cadastrada.");
				return;
			}

			foreach (var filme in lista)
			{
                var excluido = filme.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaIdF(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirFilme()
		{
			Console.WriteLine("Inserir novo Filme");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano do Filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Filme: ");
			string entradaDescricao = Console.ReadLine();

			Filme novoFilme = new Filme(IdF: repositorioF.ProximoIdF(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioF.InsereF(novoFilme);
		}
        private static void ExcluirLivro()
		{
			Console.Write("Digite o id do Livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			repositorioL.ExcluiL(indiceLivro);
		}

        private static void VisualizarLivro()
		{
			Console.Write("Digite o id do Livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			var livro = repositorioL.RetornaPorIdL(indiceLivro); 

			Console.WriteLine(livro); 
		}

        private static void AtualizarLivro()
		{
			Console.Write("Digite o id do Livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Livro: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Livro: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Livro: ");
			string entradaDescricao = Console.ReadLine();

			Livro atualizaLivro = new Livro(IdL: indiceLivro,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioL.AtualizaL(indiceLivro, atualizaLivro);
		}
        private static void ListarLivros()
		{
			Console.WriteLine("Listar Livros");

			var lista = repositorioL.ListaL();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum Livro cadastrado.");
				return;
			}

			foreach (var livro in lista) 
			{
                var excluido = livro.retornaExcluido(); 
                
				Console.WriteLine("#ID {0}: - {1} {2}", livro.retornaIdL(), livro.retornaTitulo(), (excluido ? "*Excluído*" : "")); 
			}
		}

        private static void InserirLivro()
		{
			Console.WriteLine("Inserir novo Livro");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Livro: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano do Livro: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Livro: ");
			string entradaDescricao = Console.ReadLine();

			Livro novoLivro = new Livro(IdL: repositorioL.ProximoIdL(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioL.InsereL(novoLivro);
		}
        private static void ExcluirJogo()
		{
			Console.Write("Digite o id do Jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			repositorioJ.ExcluiJ(indiceJogo);
		}

        private static void VisualizarJogo()
		{
			Console.Write("Digite o id do Jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			var jogo = repositorioJ.RetornaPorIdJ(indiceJogo); 

			Console.WriteLine(jogo); 
		}

        private static void AtualizarJogo()
		{
			Console.Write("Digite o id do Jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Jogo: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Jogo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Jogo: ");
			string entradaDescricao = Console.ReadLine();

			Jogo atualizaJogo = new Jogo(IdJ: indiceJogo,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioJ.AtualizaJ(indiceJogo, atualizaJogo);
		}
        private static void ListarJogos()
		{
			Console.WriteLine("Listar Jogos");

			var lista = repositorioJ.ListaJ();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum Jogo cadastrado.");
				return;
			}

			foreach (var jogo in lista) 
			{
                var excluido = jogo.retornaExcluido(); 
                
				Console.WriteLine("#ID {0}: - {1} {2}", jogo.retornaIdJ(), jogo.retornaTitulo(), (excluido ? "*Excluído*" : "")); 
			}
		}

        private static void InserirJogo()
		{
			Console.WriteLine("Inserir novo Jogo");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Jogo: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano do Jogo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Jogo: ");
			string entradaDescricao = Console.ReadLine();

			Jogo novoJogo = new Jogo(IdJ: repositorioJ.ProximoIdJ(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioJ.InsereJ(novoJogo);
		}
		private static string ObterOpcaoUsuarioFSL()
		{
			Console.WriteLine();
			Console.WriteLine("Spooky - Diversão na palma da mão");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Filmes:");
			Console.WriteLine("2- Séries:");
			Console.WriteLine("3- Livros:");
			Console.WriteLine("4- Jogos:");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuarioFSL = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioFSL;
		}
        private static string ObterOpcaoUsuarioS()
		{
			Console.WriteLine();
			Console.WriteLine("Spooky - Diversão na palma da mão");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuarioS = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioS;
		}

				private static string ObterOpcaoUsuarioF()
		{
			Console.WriteLine();
			Console.WriteLine("Spooky - Diversão na palma da mão");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar filme");
			Console.WriteLine("2- Inserir novo filme");
			Console.WriteLine("3- Atualizar filme");
			Console.WriteLine("4- Excluir filme");
			Console.WriteLine("5- Visualizar filme");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuarioF = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioF;
		}
				private static string ObterOpcaoUsuarioL()
		{
			Console.WriteLine();
			Console.WriteLine("Spooky - Diversão na palma da mão");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar livro");
			Console.WriteLine("2- Inserir novo livro");
			Console.WriteLine("3- Atualizar livro");
			Console.WriteLine("4- Excluir livro");
			Console.WriteLine("5- Visualizar livro");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuarioL = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioL;
			
		}
		private static string ObteropcaoUsuarioJ()
		{
			Console.WriteLine();
			Console.WriteLine("Spooky - Diversão na palma da mão");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Jogo");
			Console.WriteLine("2- Inserir novo Jogo");
			Console.WriteLine("3- Atualizar Jogo");
			Console.WriteLine("4- Excluir Jogo");
			Console.WriteLine("5- Visualizar Jogo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuarioJ = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuarioJ;
		}
    }
}
