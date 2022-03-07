using System;
using System.Collections.Generic;
class Program {
  public static void Main(string[] args) {
    //Menu principal//
    Console.WriteLine("Bem vindo!");
    Console.WriteLine("----- Escolha um nome para seu campeonato: -----");
    Campeonato camp = new Campeonato(Console.ReadLine());
    Console.WriteLine($"Você criou o campeonato '{camp.getNameCamp()}'!");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
    //Escolher uma opção//
    int op = 0;
    do {
      try{
        op = Menu();
        switch(op){
          case 1: menuinserirTime(); break;
          case 2: menulistarTime(); break;
          case 3: menuatualizarTime(); break;
          case 4: menuexcluirTime(); break;
          case 5: menuinserirJogador(); break;
          case 6: menulistarJogador(); break;
          case 7: menulistarJogTime(); break;
          case 8: menuatualizarJogadores(); break;
          case 9: menuexcluirJogadores(); break;
        }
      }
      catch(Exception erro){
        op = -1;
        Console.WriteLine("Erro:" + erro.Message);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
      }
    } while (op != 0);
  }
  //Menu principal//
  public static int Menu(){
    Console.WriteLine("-------------- Escolha uma opção ---------------");
    Console.WriteLine("01 Inserir time");
    Console.WriteLine("02 Listar times");
    Console.WriteLine("03 Atualizar um time");
    Console.WriteLine("04 Excluir um time");
    Console.WriteLine("05 Inserir um jogador");
    Console.WriteLine("06 Listar todos os jogadores");
    Console.WriteLine("07 Listar jogadores por time");
    Console.WriteLine("08 Atualizar jogadores");
    Console.WriteLine("09 Excluir jogadores");
    Console.WriteLine("00 Finalizar o sistema");
    Console.WriteLine("------------------------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

// PARTE DOS TIMES //
  
  //Inserir um time no campeonato//
  public static void menuinserirTime() {
    Console.WriteLine("-------------- Inserir novo time ---------------");
    Console.Write("Digite o nome do novo time: ");
    string novoTime = Console.ReadLine();
    Console.Write("Digite o id do novo time: ");
    int novoId = int.Parse(Console.ReadLine());
    Time obj = new Time(novoId , novoTime);
    Campeonato.inserirTime(obj);
    Console.WriteLine("Time inserido com sucesso! ");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  //Listar os times do campeonato//
  public static void menulistarTime() {
    Console.WriteLine("---------------- Listar times ------------------");  
    foreach (Time obj in Campeonato.listarTime())
      Console.WriteLine(obj);
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  //Atualizar algum time do campeonato//
  public static void menuatualizarTime() {
    Console.WriteLine("------------ Atualizar o time ------------");
    Console.Write("Insira o id do time a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome do time: ");
    string nomeNovo = Console.ReadLine();
    Time obj = new Time(id, nomeNovo);
    Campeonato.atualizarTime(obj);
    Console.WriteLine("Time atualizado com sucesso!");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  //Excluir algum time do campeonato//
  public static void menuexcluirTime(){
    Console.WriteLine("----------------- Excluir time -----------------");
    Console.Write("Insira o id do time a ser excluido: ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";
    Time obj = new Time(id , nome);
    Campeonato.excluirTime(obj);
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  
// PARTE DOS JOGADORES(AS) //

  // Inserir um jogador(a) //
  public static void menuinserirJogador() {
    Console.WriteLine("---------------- Inserir jogador ---------------");
    Console.Write("Informe o id do jogador");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe o id do Time ");
    int idTime = int.Parse(Console.ReadLine());
    int novoId = int.Parse(Console.ReadLine());
    Console.Write("Quantos jogadores(as) deseja inserir? ");
    for (int i = int.Parse(Console.ReadLine()); i > 0; i--){
      Console.Write("Insira o nome do novo(a) jogador(a): ");
      string nomeNovoJog = Console.ReadLine();
      Console.Write("Insira a camisa do novo(a) jogador(a): ");
      int camisaNovoJog = int.Parse(Console.ReadLine());
      Console.Write("Insira o email do novo(a) jogador(a): ");
      string emailNovoJog = Console.ReadLine();
      Jogador jog = new Jogador(novoid , nomeNovoJog, camisaNovoJog, emailNovoJog, nome , novoIdTime);
      Campeonato.inserirJogador(jog);
    Console.WriteLine("Jogador inserido com sucesso!");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
}
  //  Listar todos os jogadores //
  public static void menulistarJogador() {
    Console.WriteLine("----------- Listar todos os jogadores ----------");
    foreach(Jogador obj in Campeonato.listarJogador())
      Console.WriteLine(obj);
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  // Listar jogadores por time //
  public static void menulistarJogTime() {
    Console.WriteLine("----------- Listar jogadores por time ----------");
    Console.WriteLine("Insira o id do time do qual deseja listar os jogadores: ");
    Campeonato.listarJogador(Console.ReadLine());
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  // Atualizar jogadores //
  public static void menuatualizarJogadores() {
    Console.WriteLine("----------- Excluir jogadores ------------------");
    Console.WriteLine("Insira o id do jogador a ser atualizado: ");
    Campeonato.atualizarJogador(Console.ReadLine());
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  // Excluir jogadores //
  public static void menuexcluirJogadores() {
    Console.WriteLine("----------- Excluir jogadores ------------------");
    Console.Write("Insira o id do jogador a ser excluído: ");
    int idjog = int.Parse(Console.ReadLine());
    Jogador obj = new Jogador(idjog);
    Campeonato.excluirJogador(obj);
    Console.WriteLine("Jogador excluído com sucesso!");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
  }
  
} 