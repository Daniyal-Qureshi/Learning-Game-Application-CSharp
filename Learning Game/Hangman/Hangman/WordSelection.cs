using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGame
{
   public class WordSelection{
      

       public string getWord(string filename) {
         
           Random obj = new Random();
            string[] words = null;
            try
            {
                words = System.IO.File.ReadAllLines(filename);
            }
            catch(Exception ob) {}
                string word = words[obj.Next(0, words.Length - 1)];
           while (word.Trim().Length==0)
               word = words[obj.Next(0, words.Length - 1)];   
           
           
           return word;


       }


    }
}
