using System;
using System.Drawing;
using System.IO;

namespace Dropify
{
    class CaptchaProvider
    {
        internal static string LastCaptcha { get; set; }

        internal static Image GetCaptchaImage()
        {
            string[] imageFileNames = {
                "3p4nn.png", "4nnf3.png", "57gnx.png", "b2nen.png", "cc845.png",
                "en32e.png", "gpxng.png", "n8ydd.png", "nn4wx.png", "xce8d.png",
                "4n3mn.png", "537nf.png", "7g3nf.png", "bxxfc.png", "edg3p.png",
                "g3ex3.png", "n8pfe.png", "nf7bn.png", "w2n7e.png", "yyn57.png"
            };

            Random random = new Random();
            //String holds the name for randomly choosen captcha image. That name is generated
            //from the imageFileNames array. Random.Next is set to a max length of array's length
            //so that the random number it gives is always within the boundary of the array.
            string captchaImage = imageFileNames[random.Next(imageFileNames.Length)];

            LastCaptcha = Path.GetFileNameWithoutExtension(captchaImage);

            Image image = (Image)Captcha.ResourceManager.GetObject(LastCaptcha);
            //Console.WriteLine(LastCaptcha);
            return image;
        }



    }
}
