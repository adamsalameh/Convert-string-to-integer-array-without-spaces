using System;


public class StringAndNumber
{
	public static void Main(String[] args)
	{
		//string that contains numbers	
		string str ="22, 33, 44,  ,,,   55,,  66  , 77.";
		//create an array from the string without spaces & , &. 
		string[] numbers = str.Split(' ',',','.');
		// the size of the array is 23 index and the numbers are 6;
		// becasue the spaces and , and . get an empty value in the rest of the index;
		//0---22   1---   2---33   3---   4---44   5---  .....
		//to remove the empty value
      	        int count=0;
         	int x =0;
		// to know the size of the array that we need;count 
        
		    for (int i=0; i<numbers.Length;i++){
                    if (numbers[i]!=""){
                    count++;
   		 	 	}
   		     }
		// to assign the values to the new array with the required size
     		string[] number = new String[count];
       		for (int i=0; i<numbers.Length;i++){
       			if (numbers[i]!=""){
       			number[x] =numbers[i];
       			x++;// because numbers length and number length not the same;
   			 }
   		 }
		//Create an integer array
      		int[] num = new int[number.Length];
                for (int j=0; j<number.Length;j++){
		        num[j] =int.Parse(number[j]); //convert from string to int
		         }
    
    
    		Console.WriteLine(numbers.Length);
   		Console.WriteLine(number.Length);
    		Console.WriteLine(num.Length);
    		foreach (string n in number){
       		 Console.Write(n);
   		 }
		
		//short way:
		/*
		var array = Console.ReadLine().Split(new char[] { ' ',',','.' }, StringSplitOptions.RemoveEmptyEntries).
		            Select(int.Parse).ToList();
                Console.WriteLine(string.Join(", ", array));
		
		*/

                       
		        
}
}
//23
//6
//6
//223344556677
	
