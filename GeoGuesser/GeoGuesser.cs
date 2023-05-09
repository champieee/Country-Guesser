using System;
using System.Threading;

class Game {

    public int seconds1 = 0;  
    private int questionNum = 1;  
    private int totalScore = 0;
    private int roundScore = 0;
    private int seconds = 0;
    private String difficulty = "";
    public String guess = "";
    private String answer = "";

  
public Game(){
  
}

  public void setQuestion(){
      
  }

 public void setDifficulty(String d){
 difficulty = d; 
   if(difficulty == "Easy"){
      seconds = 300;
      }
    
    else if (difficulty == "Medium"){
      seconds = 240;
    }
    
    else {
      seconds = 3;
      }
}

  public bool getGuess(){
    Console.WriteLine("Write Your Guess");
    guess += Console.ReadLine();
        
        if (guess.Equals(answer) && guess != null)
        {
            nextQuestion();
            totalScore += roundScore;
            return true;
        }
        else
        {
            return false;
        }

        guess = "";
    }

  

  public void nextQuestion(){
  questionNum += 1;
}
  
 

  public void countDown() {
    
    seconds1 = seconds;
    
    for (int i = seconds - 1; i <= seconds; i--){
    
      Thread.Sleep(1000);
      Console.Write("\rSeconds:" + i);
      roundScore -= 100;
      seconds1 --;

      if (i == 0){
        Console.WriteLine("\rTime's up, you got " + 
          finalScore() + " points"); 
        Environment.Exit(0);
      }

   }   
  }

  public int finalScore(){
    return totalScore;
  }


  }
