namespace Chronos.Windows.Library.Util
{
    public class Validacao
    {
        public static bool ValidarCpf(string cpf)
        {
            try
            {
                byte primeiroDig, segundoDig, i;
                int soma;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "");
                cpf = cpf.Replace(",", "");
                cpf = cpf.Replace("-", "");
                cpf = cpf.Replace("_", "");

                if (cpf.Length != 11)
                {
                    return false;
                }

                for (i = 1; i < cpf.Length; i++)
                {
                    if (cpf.Substring(i, 1) != cpf.Substring(0, 1))
                    {
                        break;
                    }
                }
                if (i == cpf.Length)
                {
                    return false;
                }

                soma = 0;
                for (i = 0; i < 9; i++)
                {
                    soma += (10 - i) * byte.Parse(cpf.Substring(i, 1));
                }
                primeiroDig = (byte)((soma % 11 < 2) ? 0 : (11 - (soma % 11)));

                soma = 0;
                for (i = 0; i < 9; i++)
                {
                    soma += (11 - i) * byte.Parse(cpf.Substring(i, 1));
                }
                soma += primeiroDig * 2;
                segundoDig = (byte)((soma % 11 < 2) ? 0 : (11 - (soma % 11)));

                return (cpf.Substring(9, 2) == primeiroDig.ToString() + segundoDig.ToString());
            }
            catch { }
            return false;
        }
    }
}