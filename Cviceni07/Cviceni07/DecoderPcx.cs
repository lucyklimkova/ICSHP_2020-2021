using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni07
{
    class DecoderPcx
    {
        private byte Identifier;
        private byte Version;
        private byte Encoding;
        private byte BitsPerPixel;
        private UInt16 XStart;
        private UInt16 YStart;
        private UInt16 XEnd;
        private UInt16 YEnd;
        private UInt16 HorzRes;
        private UInt16 VertRes;
        private byte[] Palette;
        private byte Reserved1;
        private byte NumBitPlanes;
        private UInt16 BytesPerLine;
        private UInt16 PaletteType;
        private UInt16 HorzScreenSize;
        private UInt16 VertScreenSize;
        private byte[] Reserved;

        private long MaxNumberOfbyts;
        private int ScanLineLength;

        private int ImageWidth;
        private int ImageHeight;
        private int LinePaddingSize;

        private readonly List<byte> PictureData;
        private readonly List<byte> PalleteData;

        public DecoderPcx()
        {
            Palette = new byte[48];
            Reserved = new byte[54];
            PictureData = new List<byte>();
            PalleteData = new List<byte>();
        }


        public Bitmap NactiObrazek(string str)
        {
            try
            {
                NactiSoubor(str);
                return VratBitmapu();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private void NactiSoubor(string nazevSouboru)
        {
            try
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(nazevSouboru, FileMode.Open)))
                {
                    NactiHlavicku(binaryReader);
                    RLEDecoder(binaryReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NactiHlavicku(BinaryReader binaryReader)
        {
            Identifier = binaryReader.ReadByte();
            Version = binaryReader.ReadByte();
            Encoding = binaryReader.ReadByte();
            BitsPerPixel = binaryReader.ReadByte();
            XStart = binaryReader.ReadUInt16();
            YStart = binaryReader.ReadUInt16();
            XEnd = binaryReader.ReadUInt16();
            YEnd = binaryReader.ReadUInt16();
            HorzRes = binaryReader.ReadUInt16();
            VertRes = binaryReader.ReadUInt16();
            Palette = binaryReader.ReadBytes(48);
            Reserved1 = binaryReader.ReadByte();
            NumBitPlanes = binaryReader.ReadByte();
            BytesPerLine = binaryReader.ReadUInt16();
            PaletteType = binaryReader.ReadUInt16();
            HorzScreenSize = binaryReader.ReadUInt16();
            VertScreenSize = binaryReader.ReadUInt16();
            Reserved = binaryReader.ReadBytes(54);
            MaxNumberOfbyts = (1L << (BitsPerPixel * NumBitPlanes));
            ScanLineLength = (BytesPerLine * NumBitPlanes);
            ImageWidth = XEnd - XStart;
            ImageHeight = YEnd - YStart;
            LinePaddingSize = ((BytesPerLine * NumBitPlanes) * (8 / BitsPerPixel)) - ((XEnd - XStart) + 1);
        }

        private void RLEDecoder(BinaryReader reader)
        {
            List<byte> data = new List<byte>();
            int iteraceX;
            int iteraceY = 0;
            do
            {
                iteraceY++;
                for (iteraceX = 0; iteraceX < ScanLineLength;)
                {
                    byte byt = reader.ReadByte();
                    if (byt > 192)
                    {
                        byt -= 192;
                        byte byt2 = reader.ReadByte();

                        if (iteraceX <= ScanLineLength)
                        {
                            for (byte x = 0; x < byt; x++)
                            {
                                PictureData.Add(byt2);
                                iteraceX++;
                            }
                        }
                        else
                            iteraceX += byt;
                    }
                    else
                    {
                        if (iteraceX <= ScanLineLength)
                            PictureData.Add(byt);
                        iteraceX++;
                    }
                }
            } while (iteraceY < ImageHeight);

            while (!(reader.BaseStream.Position == reader.BaseStream.Length))
            {
                PalleteData.Add(reader.ReadByte());
            }
        }

        private Bitmap VratBitmapu()
        {
            Bitmap bitmap = new Bitmap((int)ImageWidth, (int)ImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            int x, y, i, position = 0;

            if (BytesPerLine == 0) BytesPerLine = Convert.ToUInt16(ImageWidth);

            if (BitsPerPixel == 8 && NumBitPlanes == 1)
            {
                Palette = new byte[768];
                int index = PalleteData.Count - 768;
                for (int v = PalleteData.Count - 768; v < PalleteData.Count; v++)
                {
                    Palette[v - index] = PalleteData[v];
                }
            }

            try
            {
                if (NumBitPlanes == 1 && BitsPerPixel == 8)
                {
                    byte[] scanline = new byte[BytesPerLine];
                    for (y = 0; y < ImageHeight; y++)
                    {
                        for (i = 0; i < BytesPerLine; i++)
                            scanline[i] = PictureData[position++];

                        for (x = 0; x < ImageWidth; x++)
                        {
                            i = scanline[x];
                            bitmap.SetPixel(x, y, Color.FromArgb(Palette[i * 3], Palette[i * 3 + 1], Palette[i * 3 + 2]));
                        }
                    }
                }
                else if (NumBitPlanes == 3)
                {
                    byte[] scanLineRed = new byte[BytesPerLine];
                    byte[] scanLineGreen = new byte[BytesPerLine];
                    byte[] scanLineBlue = new byte[BytesPerLine];

                    for (y = 0; y < ImageHeight; y++)
                    {
                        for (i = 0; i < BytesPerLine; i++)
                            scanLineRed[i] = PictureData[position++];
                        for (i = 0; i < BytesPerLine; i++)
                            scanLineGreen[i] = PictureData[position++];
                        for (i = 0; i < BytesPerLine; i++)
                            scanLineBlue[i] = PictureData[position++];

                        for (int n = 0; n < ImageWidth; n++)
                        {
                            bitmap.SetPixel(n, y, Color.FromArgb(scanLineRed[n], scanLineGreen[n], scanLineBlue[n]));
                        }
                    }
                }
                else
                {
                    throw new Exception("Typ obrázku není podporován!");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return bitmap;
        }

    }
}
