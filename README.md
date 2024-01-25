# 1. Инициализируем массив StringsArray с добавлением значений элементов.
string[] StringsArray = { "GeekBrains", "HelloWorld", "abc", "hjiufhwei", "ffe", "12f", "fsd", "ffdfew", "124" }

# 2. Создаём новый массив.
string[] NewArray

# 3. Инициализируем массив NewArray элементами из массива StringsArray, длина которых меньше или равна 3.
string[] NewArray = StringsArray.Where(f => f.Length <= 3).ToArray()

# 4. Вывод элементов массива NewArray.
Console.Write(string.Join(",", NewArray))
