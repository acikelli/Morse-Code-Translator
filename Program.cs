using System;


namespace Treehouse
{
    class Program
    {
        public static void Main()
        {
          while(true)
          {
              Console.WriteLine("enter text or morse code to be translated(enter to exit)");
              //Put space beetween Morse Code input elements
              string input = Console.ReadLine();
              if(string.IsNullOrWhiteSpace(input))
              {
                  break;
              }
              
              string outputMorse = MorseCodeTranslator.ToMorse(input);
              string outputText = MorseCodeTranslator.ToText(input);

              Console.WriteLine("Morse:" + outputMorse);
              Console.WriteLine("Text:" + outputText);
    
           }
        }
    }
}
