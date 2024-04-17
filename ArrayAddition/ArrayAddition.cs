using System;
using System.Linq;

class MainClass {

  public static string ArrayAddition(int[] arr) {

    // code goes here
    Array.Sort(arr);
    var largest = GetLargestNumber(arr, arr.Length);
    arr = arr.Where(val => val != largest).ToArray();
    var total = 0;

    for(int i = 0; i < arr.Length; i++){
      total += arr[i];
      for(var j = 0; j < arr.Length; j++){
        if(i!=j){
          total += arr[j];
          if (total == largest){
            return "true";
          }
        }
      }

      for(int k = 0; k < arr.Length; k++){
        if (i!=k){
          total -= arr[k];
          if(total == largest){
            return "true";
          }
        }
      }
      total = 0;
    }    

    return "false";

  }

  private static int GetLargestNumber(int[] arr, int n){

    int max = arr[0];

    for (int i=0; i < n; i++)
        if(arr[i] > max)
          max = arr[i];
    return max;
  } 

  static void Main() {  

    // keep this function call here
    Console.WriteLine(ArrayAddition(Console.ReadLine()));
    
  } 

}