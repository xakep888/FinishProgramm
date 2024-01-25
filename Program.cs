
string[] StringsArray = { "GeekBrains", "HelloWorld", "abc", "hjiufhwei", "fjfue", "12f", "fsd", "ffdfew", "124" };

 private string[] SortArray(string[] strings){
 string[] NewArray = new string[strings.Length];

for (int i = 0; i < strings.Length; i++)
{
    if(strings[i].Length <= 3)
    {
         NewArray[i] = strings[i];
    }
}

}

