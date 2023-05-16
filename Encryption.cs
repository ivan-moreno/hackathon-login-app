using System.Security.Cryptography;
using System.Text;

namespace HackathonLoginApp;

/// <summary>
/// Provides useful methods for text encryption.
/// </summary>
public static class Encryption
{
    /// <summary>
    /// Encrypts a string using SHA256 Hashing.
    /// </summary>
    /// <returns>An encrypted version of the passed string.</returns>
    public static string Encrypt(string rawText)
    {
        if (rawText.Length == 0)
            return string.Empty;

        rawText = rawText.Normalize(NormalizationForm.FormKC);
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawText));
        var stringBuilder = new StringBuilder();

        foreach (byte b in bytes)
            stringBuilder.Append(b.ToString("x2"));

        return stringBuilder.ToString();
    }
}
