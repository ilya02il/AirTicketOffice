using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace reCaptcha
{
	public static class Captcha
    {
	    public static Bitmap GenerateCaptcha(string captchaText, int width, int height)
	    {
			var oRandom = new Random();
			
			var aFontEmSizes = new[] { 15, 20, 25, 30, 35 };

			var aFontNames = new[]
			{
				"Comic Sans MS", 
				"Arial", 
				"Times New Roman", 
				"Georgia", 
				"Verdana", 
				"Geneva"
			};

			var aFontStyles = new[]
			{
				FontStyle.Bold, 
				FontStyle.Italic, 
				FontStyle.Regular, 
				FontStyle.Strikeout, 
				FontStyle.Underline
			};

			var aHatchStyles = new[]
			{
				HatchStyle.BackwardDiagonal, HatchStyle.Cross, 
				HatchStyle.DashedDownwardDiagonal, HatchStyle.DashedHorizontal, 
				HatchStyle.DashedUpwardDiagonal, HatchStyle.DashedVertical, 
				HatchStyle.DiagonalBrick, HatchStyle.DiagonalCross, 
				HatchStyle.Divot, HatchStyle.DottedDiamond, HatchStyle.DottedGrid, 
				HatchStyle.ForwardDiagonal, HatchStyle.Horizontal, 
				HatchStyle.HorizontalBrick, HatchStyle.LargeCheckerBoard, 
				HatchStyle.LargeConfetti, HatchStyle.LargeGrid, 
				HatchStyle.LightDownwardDiagonal, HatchStyle.LightHorizontal, 
				HatchStyle.LightUpwardDiagonal, HatchStyle.LightVertical, 
				HatchStyle.Max, HatchStyle.Min, HatchStyle.NarrowHorizontal, 
				HatchStyle.NarrowVertical, HatchStyle.OutlinedDiamond, 
				HatchStyle.Plaid, HatchStyle.Shingle, HatchStyle.SmallCheckerBoard, 
				HatchStyle.SmallConfetti, HatchStyle.SmallGrid, 
				HatchStyle.SolidDiamond, HatchStyle.Sphere, HatchStyle.Trellis, 
				HatchStyle.Vertical, HatchStyle.Wave, HatchStyle.Weave, 
				HatchStyle.WideDownwardDiagonal, HatchStyle.WideUpwardDiagonal, HatchStyle.ZigZag
			};

			//Creates an output Bitmap
			var oOutputBitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
			var oGraphics = Graphics.FromImage(oOutputBitmap);
			oGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;

			//Create a Drawing area
			var oRectangleF = new RectangleF(0, 0, width, height);
			var oBrush = new HatchBrush(aHatchStyles[oRandom.Next
				(aHatchStyles.Length - 1)], Color.FromArgb((oRandom.Next(100, 255)),
				(oRandom.Next(100, 255)), (oRandom.Next(100, 255))), Color.White);
			oGraphics.FillRectangle(oBrush, oRectangleF);

			var oMatrix = new Matrix();

			for (int i = 0; i <= captchaText.Length - 1; i++)
			{
				oMatrix.Reset();
				var iChars = captchaText.Length;
				var x = width / (iChars + 1) * i;
				var y = height / 2;

				//Rotate text Random
				oMatrix.RotateAt(oRandom.Next(-40, 40), new PointF(x, y));
				oGraphics.Transform = oMatrix;

				//Draw the letters with Random Font Type, Size and Color
				oGraphics.DrawString
				(

				//Text
				captchaText.Substring(i, 1),

				//Random Font Name and Style
				new Font(aFontNames[oRandom.Next(aFontNames.Length - 1)],
				   aFontEmSizes[oRandom.Next(aFontEmSizes.Length - 1)],
				   aFontStyles[oRandom.Next(aFontStyles.Length - 1)]),

				//Random Color (Darker colors RGB 0 to 100)
				new SolidBrush(Color.FromArgb(oRandom.Next(0, 100),
				   oRandom.Next(0, 100), oRandom.Next(0, 100))),
				x,
				oRandom.Next(10, 40)
				);
				oGraphics.ResetTransform();
			}

			return oOutputBitmap;
	    }
    }
}
