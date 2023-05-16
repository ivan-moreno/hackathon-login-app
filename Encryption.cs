using System.Security.Cryptography;
using System.Text;

namespace HackathonLoginApp;

public static class Encryption
{
    public static string Encrypt(string rawText)
    {
        if (rawText.Length == 0)
            return string.Empty;

        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawText));
        var stringBuilder = new StringBuilder();

        foreach (byte b in bytes)
            stringBuilder.Append(b.ToString("x2"));

        return stringBuilder.ToString();
    }
}
