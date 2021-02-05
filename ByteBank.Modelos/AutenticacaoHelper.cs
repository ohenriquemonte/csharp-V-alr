using System;
namespace ByteBank.Modelos
{
	internal class AutenticacaoHelper
	{
		public AutenticacaoHelper()
		{
		}

		public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
		{
			return senhaVerdadeira == senhaTentativa;
		}
	}
}
