using QRCoder;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCode
{
    public class QRCodeProgram
    {
        public static string GenerateQRCode(string content)
        {
            string base64QRImage = "";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(3); // Adjust the size as needed
            //qrCodeImage.Save("F:\\QR_"+DateTime.Now.ToString("ddMMyyyyHHmmss")+".png", ImageFormat.Png);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                qrCodeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] imageBytes = memoryStream.ToArray();
                base64QRImage = Convert.ToBase64String(imageBytes);
            }
            return base64QRImage;
        }
    }
}
