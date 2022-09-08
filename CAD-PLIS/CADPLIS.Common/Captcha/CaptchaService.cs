using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.Captcha
{
    public static class CaptchaService
    {
        private const string Letters = "1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,P,Q,R,S,T,U,V,W,X,Y,Z";

        public static Task<CaptchaResult> GenerateCaptchaImageAsync(int width = 0, int height = 30)
        {
            string captchaCode = GenerateRandomCaptchaAsync();
            //Verification code color set
            Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };

            //Captcha font set
            string[] fonts = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial" };

            //Define the size of the image and generate an instance of the image
            var image = new Bitmap(width == 0 ? captchaCode.Length * 25 : width, height);

            var g = Graphics.FromImage(image);

            //Set the background to white
            g.Clear(Color.White);

            var random = new Random();

            for (var i = 0; i < 100; i++)
            {
                var x = random.Next(image.Width);
                var y = random.Next(image.Height);
                g.DrawRectangle(new Pen(Color.LightGray, 0), x, y, 1, 1);
            }

            //The verification code is drawn in G
            for (var i = 0; i < captchaCode.Length; i++)
            {
                //Random color index value
                var cindex = random.Next(c.Length);

                //Random font index value
                var findex = random.Next(fonts.Length);

                //font
                var f = new Font(fonts[findex], 15, FontStyle.Bold);

                //color  
                Brush b = new SolidBrush(c[cindex]);

                var ii = 4;
                if ((i + 1) % 2 == 0)
                    ii = 2;

                //Draws a validation character 
                g.DrawString(captchaCode.Substring(i, 1), f, b, 17 + (i * 17), ii);
            }

            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);

            g.Dispose();
            image.Dispose();
            
            return Task.FromResult(new CaptchaResult
            {
                CaptchaCode = captchaCode,
                CaptchaMemoryStream = ms,
                Timestamp = DateTime.Now
            });
        }

        public static string GenerateRandomCaptchaAsync(int codeLength = 4)
        {
            var array = Letters.Split(new[] { ',' });

            var random = new Random();

            var temp = -1;

            var captcheCode = string.Empty;

            for (int i = 0; i < codeLength; i++)
            {
                if (temp != -1)
                    random = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));

                var index = random.Next(array.Length);

                if (temp != -1 && temp == index)
                    return GenerateRandomCaptchaAsync(codeLength);

                temp = index;

                captcheCode += array[index];
            }

            return captcheCode;
        }

    }
}
