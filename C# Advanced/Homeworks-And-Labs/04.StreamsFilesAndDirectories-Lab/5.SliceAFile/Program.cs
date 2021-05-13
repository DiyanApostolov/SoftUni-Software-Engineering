using System;
using System.IO;

namespace _5.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                int partSize = (int)reader.Length / 4;

                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[1];
                    int count = 0;

                    using (FileStream writer = new FileStream($"../../../slice-{i+1}.txt", FileMode.Create))
                    {
                        while (count < partSize)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }
                    }

                }
            }
        }
    }
}
