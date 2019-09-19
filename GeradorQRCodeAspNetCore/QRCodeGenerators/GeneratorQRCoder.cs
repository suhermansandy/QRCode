using QRCoder;
using System.Drawing;
using System.IO;
using static QRCoder.PayloadGenerator;

namespace GeradorQRCodeAspNetCore.QRCodeGenerators
{
    public static class GeneratorQRCoder
    {
        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }        

        public static Bitmap GeneratedQRCodeString(string message)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(message, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20);
            return qrCodeAsBitmap;
        }
    }
}
