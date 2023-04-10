Console.Clear();

Console.WriteLine("Введите текст");
string text = Console.ReadLine();

string [] separators = {" ", ",", ".", "-", ";", ":", "!", "?"};
int i = 0;
char s = ' ';

string [] Words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
string [] tempWords = new string[Words.Length];
string text1 = tempWords[0];

string [] TempArray (string [] inArray) {
    for (i = 0; i < inArray.Length; i++) {
        inArray[i] = inArray[i] + s;
        if (((inArray[i].LastIndexOf(s)-1) <= 2))
            tempWords[i] = inArray[i];
    }

    return(tempWords);
}

String Text1(string [] inArray) {
    for (i = 0; i < inArray.Length; i++)
    text1 = text1+inArray[i];
    return(text1);
}
 
void PrintArray(string[] inArray) {
    Console.WriteLine();
    Console.WriteLine("Результат - массив из строк, длина которых не более 3 символов");
    for (int i = 0; i < inArray.Length; i++) {
            Console.Write($"     {inArray[i]}");
        } 
}

TempArray(Words);
Text1(tempWords);

string [] newWords = text1.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintArray(newWords);

