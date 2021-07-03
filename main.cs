using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    int[] Numbers = new int [10];
    double[] OddNum = new double[10];
    double[] EvenNum = new double[10];
    
  Console.WriteLine("enter a number");
  for(int i = 0; i< 10; i++)
  {
   Numbers[i] = Convert.ToInt32(Console.ReadLine());
   
  if (Numbers[i]% 2 == 0){
    Console.WriteLine("even");
    EvenNum[i]= Numbers[i];
    
  }
  else
  {
    Console.WriteLine("odd");
    OddNum[i]= Numbers[i];
    
  }
  }
  

   Array.Sort(EvenNum);
   Console.WriteLine("Even numbers in acending order");
   foreach(int i in EvenNum)
   {
     Console.WriteLine(i);
   }
 Array.Reverse(OddNum);
 Console.WriteLine("Odd numbers in decending order");
 foreach(int i in OddNum)
 {
   Console.WriteLine(i);
 }
foreach(int sum in EvenNum)
{
  var add = EvenNum.Sum();
  Console.WriteLine("The Sum of even numbers is " + add);
  var sumofodds = OddNum.Sum();
  Console.WriteLine("The Sum of odd numbers is "+ sumofodds);
  Console.ReadLine();
}
  }
}