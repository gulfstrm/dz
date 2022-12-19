// Посмотреть папаки.Обойти дерриторию.

string path = "/Users/gulfs/OneDrive/Рабочий стол/домашки/examples/c_Sharp_Coursee/1_lesson";

DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}