using System;
using System.Collections.Generic;
class Campeonato {
  private static Time[] times = new Time[8];
  private static List<Jogador> jogs = new List<Jogador>();
  private string nome;
  private static int numTimes;
  public Campeonato(string nome){
    this.nome = nome;
  }
  public void setNameCamp(string nome) {
    this.nome = nome;
  }
  public string getNameCamp() {
    return this.nome;
  }

// PARTE DOS TIMES //
  
  // Adiciona um time ao campeonato //
  public static void inserirTime(Time obj) {
    if (numTimes == times.Length)
      Array.Resize(ref times, times.Length + 2);
      /* verifica o tamanho do vetor */
    times[numTimes] = obj;
    numTimes++;
  }
  // Lista os times //
  public static Time[] listarTime() {
    Time[] aux = new Time[numTimes];
    Array.Copy(times, aux, numTimes);
    return aux;
  }
  public static Time listarTime(int id) {
    // percorre o vetor //
    foreach(Time obj in times)
      if(obj != null && obj.getId() == id) return obj;
    return null;
  }
  // Atualiza os times //
  public static void atualizarTime(Time obj){
    // localiza o time com o nome informado //
    Time aux = listarTime(obj.getId());
    // atualiza o nome do time //
    if(aux != null) {
      aux.setId(obj.getId());
      aux.setNomeTime(obj.getNomeTime());
    }
  }
  // Remove um time do campeonato //
  public static void excluirTime(Time obj) {
    int aux = indiceTime(obj.getId());
    if(aux != -1){
      for(int i = aux ; i < numTimes - 1 ; i++)
        times[i] = times[i + 1];
      numTimes--;
      Console.WriteLine("Time excluído com sucesso!");
    }
    if(aux == -1){
      Console.WriteLine("Ops! O time citado não existe");
    }
  }
  public static int indiceTime(int id){
    for (int i = 0; i < numTimes ; i++){
      Time obj = times[i];
      if(obj.getId() == id) return i; 
    }
    return -1 ; 
  }

// PARTE DOS JOGADORES // 
  
  //  Insere um jogador  //
  public static void inserirJogador(Jogador obj) {
    // Insere objeto na lista
    jogs.Add(obj);
  }

  // Lista os jogadores cadastrados por time //
  public static void listarJogador(string time) {
    foreach(Jogador obj in jogs) {   
      if (obj.getTime() == time) Console.WriteLine(obj);    
    }
  }
  // Lista todos os jogadores cadastrados no campeonato // 
  public static List<Jogador> listarJogador() {
    // retorna todos os objetos da lista //
    return jogs;
  }
  // Atualiza um jogador //
  public static void atualizarJogador(Jogador obj) {
    Jogador aux = listarJogador(obj.getIdJog());
    if(aux != null){
      aux.SetNome(obj.GetNome());
      aux.SetCamisa(obj.GetCamisa())
      aux.Setemail(obj.Getemail())
      aux.SetIdTime(obj.GetIdTime())
      }
  }  
  //exclui um jogador//
  public static void excluirJogador(Jogador obj) {
    Pet aux = listarJogador(obj.getIdJog());
    if(aux != null) jogs.Remove(aux);
  }
}