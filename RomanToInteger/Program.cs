// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Numerics;

Console.WriteLine("Hello, World!");
var romanNumber = new Dictionary<char, int>()
{
    { 'I',1},
    { 'V',5},
    { 'X',10},
    { 'L',50},
    { 'C',100},
    { 'D',500},

    { 'M',1000}
}
;


var s = "MCMXCIV";
var Total = 0;
for(int i = 0;i<s.Length;i++)
{
    if (i + 1 >= s.Length)
    { 
        Total += romanNumber.GetValueOrDefault(s[i]);
        break;
    
    }


    if (romanNumber.GetValueOrDefault(s[i]) < romanNumber.GetValueOrDefault(s[i + 1])) {

        Total += (romanNumber.GetValueOrDefault(s[i+1]) - romanNumber.GetValueOrDefault(s[i]));
        i++;
        continue;
    }
    else if (romanNumber.GetValueOrDefault(s[i]) == romanNumber.GetValueOrDefault(s[i + 1]))
    {
        Total += (romanNumber.GetValueOrDefault(s[i + 1]) + romanNumber.GetValueOrDefault(s[i]));
        i++;
        continue;
    }
    else if (romanNumber.GetValueOrDefault(s[i]) > romanNumber.GetValueOrDefault(s[i + 1]))
    {
        Total +=  romanNumber.GetValueOrDefault(s[i]);
        
        continue;
    }
   



}

Console.WriteLine(Total);

