﻿string fraseDigitada, fraseMemeToNervoso;
Console.Clear();
Console.Write("Usuário, o que você pensa sobre mim? ");
fraseDigitada = Console.ReadLine()!;

fraseMemeToNervoso =
    $"{fraseDigitada.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(fraseMemeToNervoso);