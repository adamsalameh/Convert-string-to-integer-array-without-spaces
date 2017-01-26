using System;


public class StringAndNumber
{
	public static void Main(String[] args)
	{
		string str ="22, 33, 44,  ,,,   55,,  66  , 77.";
        string[] numbers = str.Split(' ',',','.');
 
      	int count=0;
       	int x =0;
        
		    for (int i=0; i<numbers.Length;i++){
              if (numbers[i]!=""){
               count++;
   		  }
   		  }
      string[] number = new String[count];
       for (int i=0; i<numbers.Length;i++){
       if (numbers[i]!=""){
        number[x] =numbers[i];
        x++;
    }
    }
      int[] num = new int[number.Length];
      for (int j=0; j<number.Length;j++){
    
        num[j] =int.Parse(number[j]);
       
    }
    
    
    Console.WriteLine(numbers.Length);
    Console.WriteLine(number.Length);
    Console.WriteLine(num.Length);
    foreach (string n in number){
        Console.Write(n);
    }
                       
		        
	}
}
//23
//6
//6
//223344556677
	
