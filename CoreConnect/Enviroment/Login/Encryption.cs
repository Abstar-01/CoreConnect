namespace Enviroment
{
    public class Encryption {
        static string HashShuffler(string input) {
            char[] hashedChars = new char[input.Length];
            int primeOffset = 17;

            for (int i = 0; i < input.Length; i++) {
                char c = input[i];
                int asciiValue = (int)c;
                int newAscii = (asciiValue + (i + 1) * primeOffset) % 94 + 32;
                hashedChars[i] = (char)newAscii;
            }
            return new string(hashedChars);
        }
    }
    
}