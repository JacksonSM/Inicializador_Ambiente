namespace InicializadorAmbiente.Models;

public static class ValidacaoURL
{
    public static bool Validar(string UrlText, out string errorMessage)
    {
        bool result;

        try
        {
            Uri check = new Uri(UrlText);
            result = true;
            errorMessage = "";
        }
        catch (UriFormatException)
        {
            result = false;
            errorMessage = "URL inválido !!";
        }

        return result;
    }
}