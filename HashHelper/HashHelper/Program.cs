using HashHelper.Base;

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("MD5 해쉬값을 드릴게요.");
Console.WriteLine("예시 " + @"C:\Users\한지원\Downloads\test.exe" + "\n");

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n");
    Console.WriteLine("파일 경로를 입력하세요:");
    Console.ForegroundColor = ConsoleColor.Yellow;
    string? path = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Cyan;

    MD5Manager m = new MD5Manager();
    string hash = m.CreateHash((string)path);

    if (string.IsNullOrEmpty(hash))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("파일을 찾을 수 없었습니다. 확인 후 다시 입력하세요.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(hash);
    }

}
