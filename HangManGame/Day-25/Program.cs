// See https://aka.ms/new-console-template for more information
class HangManGame
{
    static void Main(string[] args)
    {

        List<string> list = new List<string>();
        list.Add("ENGINEER");
        list.Add("DEVELOPMENT");
        list.Add("DOUBLE");
        list.Add("JEALOUS");
        list.Add("VOCABOLARY");
        list.Add("MECHANIC");
        list.Add("SINCERELY");

        int count =0;
        int lives = 6;
        List<char> guessed = new List<char>();
        char input;
        foreach(var item in list)
        {
            string word = item;
            string dashes = new string('_', word.Length);
            char[] dashDisplay = dashes.ToCharArray();
            

            while (lives != 0)
            {   
                foreach(var chara in dashDisplay)
                {
                    Console.Write(chara);
                }
                Console.WriteLine("Lives: "+ lives);
                Console.WriteLine("guessed: " );
                foreach(var i in guessed)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Guess a letter: ");
                try{
                input = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter correct Alphabet");
                    continue;
                }
                input = char.ToUpper(input);  

                
                if(guessed.Contains(input))
                {
                    Console.WriteLine("Guess letter already exists");
                    continue;
                }
                bool found = false;
                for(int i = 0; i < word.Length; i++)
                {
                    if(input == word[i])
                    {
                        found = true;
                        dashDisplay[i] = input;
                    }
                }
                if (!found)
                {
                    lives--;
                    Console.WriteLine("wrong guess");
                }
                else
                {
                    guessed.Add(input);
                    Console.WriteLine("Guess found. Correct !!");
                }
                if (!dashDisplay.Contains('_'))
                {
                    Console.WriteLine("You won! Word: " + word);
                    return;
                }
                else
                {
                    Console.WriteLine("You Lose");
                }
                
            }
        }
        
    }
}
