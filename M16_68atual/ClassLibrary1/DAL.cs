using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace DAL
{
	public class ConString
	{
		public static SqlConnection con;

		static ConString()
		{
			con = new SqlConnection(@"server=.\SQLEXPRESS;Database=p40_68;Trusted_Connection=True;");
		}
	}
	public class Proc
	{
		public string login(string user, string pass)
		{
			ConString.con.Open();
			string tipo = "";
			try
			{
				SqlCommand verif = new SqlCommand(@"Select Tipo from Login where [User] = '" + user + "' and Pass = '" + pass + "'", ConString.con);
				SqlDataReader reader = verif.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						tipo = reader.GetValue(0).ToString();
					}
					return tipo;
				}
				else
				{
					return "loginfailed";
				}
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			finally
			{
				ConString.con.Close();
			}
		}
	}
	public class Reg
	{
		public bool registar(string user, string pass, string tipo, string BI, string Nome, string Morada, string email, string telefone, string localidade)
		{
			ConString.con.Open();
			try
			{
				SqlCommand add = new SqlCommand(@"Insert into Login(User,Pass,Tipo) values(@user,@pass,@tipo)", ConString.con);
				add.Parameters.AddWithValue("user", user);
				add.Parameters.AddWithValue("pass", pass);
				add.Parameters.AddWithValue("tipo", tipo);
				add.ExecuteNonQuery();
				SqlCommand add2 = new SqlCommand(@"Insert into Colecionadores(B.I.,Nome,Morada,e-mail,telefone,localidade) values(@B.I.,@Nome,@Morada,@e-mail,@telefone,@localidade)", ConString.con);
				add2.Parameters.AddWithValue("BI", BI);
				add2.Parameters.AddWithValue("Nome", Nome);
				add2.Parameters.AddWithValue("Morada", Morada);
				add2.Parameters.AddWithValue("email", email);
				add2.Parameters.AddWithValue("telefone", telefone);
				add2.Parameters.AddWithValue("localidade", localidade);
				add2.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				ConString.con.Close();
			}
		}
	}
	/*public class InsCar
    {
        public bool Car(string fab, DateTime data, string marca, string modelo, string matricula, string pais)
        {
            ConString.con.Open();
            try
            {
                SqlCommand add = new SqlCommand(@"Insert into Automovel(Fabricante,Data_aquisicao,Marca,Modelo,Matricula,Pais) values(@fab,@data,@marca,@modelo,@matricula,@pais)", ConString.con);
                add.Parameters.AddWithValue("fab", fab);
                add.Parameters.AddWithValue("data", data);
                add.Parameters.AddWithValue("marca", marca);
                add.Parameters.AddWithValue("modelo", modelo);
                add.Parameters.AddWithValue("matricula", matricula);
                add.Parameters.AddWithValue("pais", pais);
                add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                ConString.con.Close();
            }
        }
    }*/
	/*public class InsStand
    {
        public bool Stand(string stand)
        {
            ConString.con.Open();
            try
            {
                SqlCommand add = new SqlCommand(@"Insert into Stand(Nome) values(@stand)", ConString.con);
                add.Parameters.AddWithValue("stand", stand);
                add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                ConString.con.Close();
            }
        }
    }*/
	public class ObE
	{
		public string Eventos(string eventos)
		{
			ConString.con.Open();
			try
			{
				SqlCommand getE = new SqlCommand(@"Select Nome from Eventos", ConString.con)
				{
					CommandType = CommandType.Text
				};
				SqlDataReader reader1 = getE.ExecuteReader();
				while (reader1.Read())
				{
					reader1.GetValue(0).ToString();
				}
				return eventos;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			finally
			{
				ConString.con.Close();
			}
		}
		/*public string Matricula(string matricula)
        {
            ConString.con.Open();
            try
            {
                SqlCommand add = new SqlCommand(@"Select Matricula from Automovel", ConString.con);
                add.CommandType = CommandType.Text;
                SqlDataReader reader1 = add.ExecuteReader();
                while (reader1.Read())
                {
                    reader1.GetValue(0).ToString();
                }
                return matricula;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                ConString.con.Close();
            }
        }*/
	}
	/*public class UpAuto
    {
        public bool Update(string stand, DateTime data, string matricula)
        {
            ConString.con.Open();
            try
            {
                SqlCommand add = new SqlCommand(@"update Automovel set Stand = @stand, Data_aquisicao = @data where Matricula = @matricula", ConString.con);
                add.Parameters.AddWithValue("stand", stand);
                add.Parameters.AddWithValue("data", data);
                add.Parameters.AddWithValue("matricula", matricula);
                add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                ConString.con.Close();
            }
        }
    }*/
	/*public class UpLog
    {
        public bool Update(string user, string pass, string morada, string email, string telefone, string localidade)
        {
            ConString.con.Open();
            try
            {
                SqlCommand add = new SqlCommand(@"update Login set User = @user, Pass = @pass", ConString.con);
                add.Parameters.AddWithValue("user", user);
                add.Parameters.AddWithValue("pass", pass);
                add.ExecuteNonQuery();
                SqlCommand add2 = new SqlCommand(@"update Colecionadores set Morada = @morada, email = @email, telefone = @telefone, localidade = @localidade", ConString.con);
                add.Parameters.AddWithValue("morada", morada);
                add.Parameters.AddWithValue("email", email);
                add.Parameters.AddWithValue("telefone", telefone);
                add.Parameters.AddWithValue("localidade", localidade);
                add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                ConString.con.Close();
            }
        }
    }*/
	public class ObC
	{
		public string Colecao(string colecao)
		{
			ConString.con.Open();
			try
			{
				SqlCommand getC = new SqlCommand(@"Select Nome from Colecao", ConString.con)
				{
					CommandType = CommandType.Text
				};
				SqlDataReader reader1 = getC.ExecuteReader();
				while (reader1.Read())
				{
					reader1.GetValue(0).ToString();
				}
				return colecao;
			}
			catch (Exception ex)        //Cookies acessos , tratar da imagem , tratar forms adm , tratar list views , site   
			{
				return ex.Message;
			}
			finally
			{
				ConString.con.Close();
			}
		}
	}
	public class ObM
	{
		public string Moedas(string moedas)
		{
			ConString.con.Open();
			try
			{
				SqlCommand getM = new SqlCommand(@"Select Nome from Moeda", ConString.con)
				{
					CommandType = CommandType.Text
				};
				SqlDataReader reader1 = getM.ExecuteReader();
				while (reader1.Read())
				{
					reader1.GetValue(0).ToString();
				}
				return moedas;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			finally
			{
				ConString.con.Close();
			}
		}

		public static bool InserirMoeda(Image imagem)
		{
			ConString.con.Open();
			try
			{
				SqlCommand add = new SqlCommand(@"Insert into Moeda(Imagem) values(@imagem)", ConString.con);
				// TODO: adicionar os outros campos
				add.Parameters.AddWithValue("imagem", ImageToBase64(imagem));
				add.ExecuteNonQuery();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				ConString.con.Close();
			}
		}

		public static Image SelectImageMoeda(long idMoeda)
		{
			ConString.con.Open();
			try
			{
				SqlCommand getM = new SqlCommand(@"Select Nome from Moeda", ConString.con)
				{
					CommandType = CommandType.Text
				};
				SqlDataReader reader1 = getM.ExecuteReader();
				string imagemBase64 = null;
				while (reader1.Read())
				{
					imagemBase64 = reader1.GetValue(0).ToString();
				}
				if (imagemBase64 == null)
				{
					return null;
				}

				return Base64ToImage(imagemBase64);
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				ConString.con.Close();
			}
		}

		private static string ImageToBase64(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				return Convert.ToBase64String(ms.ToArray());
			}
		}

		private static Image Base64ToImage(string base64)
		{
			byte[] imageBytes = Convert.FromBase64String(base64);
			return new Bitmap(new MemoryStream(imageBytes));
		}
	}
}