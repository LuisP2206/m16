using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace DAL
{
	public static class Utils
	{
		public static string ImagemParaBase64(Image imagem)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				imagem.Save(ms, imagem.RawFormat);
				return Convert.ToBase64String(ms.ToArray());
			}
		}

		public static Image Base64ParaImagem(string base64)
		{
			byte[] bytesImagem = Convert.FromBase64String(base64);
			return new Bitmap(new MemoryStream(bytesImagem));
		}

		public static long GetCurrentUnix()
		{
			return DateTimeOffset.Now.ToUnixTimeSeconds();
		}

		public static DateTime UnixToDate(long unix)
		{
			DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			dtDateTime = dtDateTime.AddSeconds(unix).ToLocalTime();
			return dtDateTime;
		}

		public static string Hash(string text)
		{
			using (SHA256Managed sha = new SHA256Managed())
			{
				byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);
				byte[] hashBytes = sha.ComputeHash(textBytes);

				return BitConverter.ToString(hashBytes).Replace("-", "");
			}
		}
	}
}
