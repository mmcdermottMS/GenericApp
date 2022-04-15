namespace GenericApp.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public static string GetGeneratedName()
        {
            // Creating object of random class
            Random rand = new();

            // Choosing the size of string
            // Using Next() string
            int stringlen = rand.Next(4, 10);
            int randValue;
            string str = string.Empty;
            char letter;
            for (int i = 0; i < stringlen; i++)
            {
                // Generating a random number.
                randValue = rand.Next(0, 26);

                // Generating random character by converting
                // the random number into character.
                letter = Convert.ToChar(randValue + 65);

                // Appending the letter to string.
                str += letter;
            }

            return str;
        }
    }
}