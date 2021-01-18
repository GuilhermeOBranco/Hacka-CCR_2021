using System;
using System.Drawing;

namespace HackaCCR_BackEnd.Service
{
    public class CertificadoService
    {

int g11, g22, r11, r22, b11, b22, x1, y1, z1;
        Color a, b;
        Bitmap img1, img2;
        int i, j;
        static string fname1, fname2;
        int count1 = 0, count2 = 0;
        bool flag = true;

        public bool ValidaCertificadoUdemy(string cert1, string cert2)
        {
            string fname1 = cert1;
            string fname2 = cert2;

            img1 = new Bitmap(fname1);
            img2 = new Bitmap(fname2);
            try
            {
                for (i = 0; i < img1.Width; i++)
                {
                    for (j = 0; j < img1.Height; j++)
                    {
                        a = img1.GetPixel(i, j);
                        b = img2.GetPixel(i, j);
                    }
                }

                String g1 = a.G.ToString();
                String g2 = b.G.ToString();
                String r1 = a.R.ToString();
                String r2 = b.R.ToString();
                String b1 = a.R.ToString();
                String b2 = b.R.ToString();

                g11 = Convert.ToInt16(g1);
                g22 = Convert.ToInt16(g2);
                r11 = Convert.ToInt16(r1);
                r22 = Convert.ToInt16(r2);
                b11 = Convert.ToInt16(b1);
                b22 = Convert.ToInt16(b2);
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new Exception("Utilize o mecanismo da Udemy para realizar o download do Certificado e tente novamente.");
            }


            if ((g11 > g22) && (r11 > r22) && (b11 > b22))
            {
                x1 = g11 - g22;
                y1 = r11 - r22;
                z1 = b11 - b22;
            }
            else
            {
                x1 = g22 - g11;
                y1 = r22 - r11;
                z1 = b22 - b11;
            }

            if ((x1 > 20) || (y1 > 20) || (z1 > 20))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaCertificadoDio(string cert1, string cert2)
        {
            string fname1 = cert1;
            string fname2 = cert2;

            img1 = new Bitmap(fname1);
            img2 = new Bitmap(fname2);
            try
            {
                for (i = 0; i < img1.Width; i++)
                {
                    for (j = 0; j < img1.Height; j++)
                    {
                        a = img1.GetPixel(i, j);
                        b = img2.GetPixel(i, j);
                    }
                }

                String g1 = a.G.ToString();
                String g2 = b.G.ToString();
                String r1 = a.R.ToString();
                String r2 = b.R.ToString();
                String b1 = a.R.ToString();
                String b2 = b.R.ToString();

                g11 = Convert.ToInt16(g1);
                g22 = Convert.ToInt16(g2);
                r11 = Convert.ToInt16(r1);
                r22 = Convert.ToInt16(r2);
                b11 = Convert.ToInt16(b1);
                b22 = Convert.ToInt16(b2);
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new Exception("Utilize o mecanismo da Dio para realizar o download do Certificado e tente novamente.");
            }


            if ((g11 > g22) && (r11 > r22) && (b11 > b22))
            {
                x1 = g11 - g22;
                y1 = r11 - r22;
                z1 = b11 - b22;
            }
            else
            {
                x1 = g22 - g11;
                y1 = r22 - r11;
                z1 = b22 - b11;
            }

            if ((x1 > 20) || (y1 > 20) || (z1 > 20))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}