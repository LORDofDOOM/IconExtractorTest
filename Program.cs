using IconExtractorTest;
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Icon fileIcon = IconFromFile.GetFileIcon(@"C:\Windows\explorer.exe", IconFromFile.IconSizeEnum.ExtraLargeIcon);

        using (var bitmap = fileIcon.ToBitmap())
        {
#if NET462
            bitmap.Save(@"C:\fileIconBitmap_NET462.png", ImageFormat.Png);
#else
            bitmap.Save(@"C:\fileIconBitmap_CoreCLR.png", ImageFormat.Png);
#endif
        }
    }
}