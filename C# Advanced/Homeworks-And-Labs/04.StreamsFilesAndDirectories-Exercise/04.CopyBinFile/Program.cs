using System;
using System.IO;

namespace _04.CopyBinFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream streamReader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (var streamWriter = new FileStream("../../../picCopy.png", FileMode.Create))
                {
                    while (true)
                    {
                        var buffer = new byte[4096];

                        int readSize = streamReader.Read(buffer, 0, buffer.Length);

                        if (readSize == 0)
                        {
                            break;
                        }

                        streamWriter.Write(buffer, 0, readSize);
                    }
                }
            }
        }
    }
}
