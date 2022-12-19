// 5 игроков .Нужно показать все разбиение игроков на 2 команды.0 попадает в 1 команду.
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length + 1);
    }
}
FindWords("аисв",new char[2]);