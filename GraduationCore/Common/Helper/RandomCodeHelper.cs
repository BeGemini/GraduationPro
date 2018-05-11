using GraduationCore.Common.Models.ViewModels;
using System;
using System.DrawingCore;
using System.DrawingCore.Imaging;
using System.IO;

namespace GraduationCore.Common.Helper
{
    public class RandomCodeHelper
    {
        private string RndNum(int VcodeNum)
        {
            string Vchar = "0,1,2,3,4,5,6,7,8,9"
            + "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z"
            + "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] VcArray = Vchar.Split(',');
            string code = string.Empty;
            int temp = -1;
            Random random = new Random();
            for (int i = 0; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    random = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));//初始化随机类  
                }
                int t = random.Next(61);//获取随机数  
                if (temp != -1 && temp == t)
                {
                    return RndNum(VcodeNum);//如果获取的随机数重复，则递归调用  
                }
                temp = t;//把本次产生的随机数记录起来  
                code += VcArray[t];//随机数的位数加一  
            }
            return code;
        }

        public MemoryStream Create(out string code, int numbers = 4)
        {
            code = RndNum(numbers);
            Bitmap Img = null;
            Graphics graphics = null;
            MemoryStream memoryStream = null;
            Random random = new Random();
            Color[] color = { Color.Black, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
            string[] fonts = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
            Img = new Bitmap((int)code.Length * 18, 32);
            graphics = Graphics.FromImage(Img);
            graphics.Clear(Color.White);
            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(Img.Width);
                int y = random.Next(Img.Height);
                graphics.DrawRectangle(new Pen(Color.LightGray, 0), x, y, 1, 1);
            }
            for (int i = 0; i < code.Length; i++)
            {
                int cindex = random.Next(7);
                int findex = random.Next(5);
                Font font = new Font(fonts[findex], 15, FontStyle.Bold);
                Brush brush = new SolidBrush(color[cindex]);
                int n = 4;
                if ((i + 1) % 2 == 0)
                {
                    n = 2;
                }
                graphics.DrawString(code.Substring(i, 1), font, brush, 3 + (i * 12), n);
            }
            memoryStream = new MemoryStream();
            Img.Save(memoryStream, ImageFormat.Jpeg);
            graphics.Dispose();
            Img.Dispose();
            return memoryStream;
        }
    }
}