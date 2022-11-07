using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Crypto
{
    // 키로 사용하기 위한 암호
    private static readonly string PASSWORD = "gyeonggigamemeisterhighschool";
    // 인증키 정의
    private static readonly string KEY = PASSWORD.Substring(0, 128 / 8);

    // 암호화
    public static string AESEncrypt128(string plain)
    {
        byte[] plainBytes = Encoding.UTF8.GetBytes(plain);

        // AES : 고급 암호화 표준
        // 레인달(Rijndael) : 벨기에 공학자들 이름을 합쳐 만든 알고리즘 이름
        RijndaelManaged rijndael = new RijndaelManaged();

        // CipherMode : 암호화 모드 지정
        // https://learn.microsoft.com/ko-kr/dotnet/api/system.security.cryptography.ciphermode?view=net-6.0
        rijndael.Mode = CipherMode.CBC;

        // PaddingMode : 메시지 데이터 블록이 암호화 작업에 필요한 전체 길이보다 짧을 때 뭘로 채울 것인지 결정
        // https://learn.microsoft.com/ko-kr/dotnet/api/system.security.cryptography.paddingmode?view=net-6.0
        rijndael.Padding = PaddingMode.PKCS7;

        // KeySize : 패스워드 키 사이즈
        // https://learn.microsoft.com/ko-kr/dotnet/api/system.security.cryptography.rijndaelmanaged.keysize?view=net-6.0#system-security-cryptography-rijndaelmanaged-keysize
        rijndael.KeySize = 128;

        MemoryStream memoryStream = new MemoryStream();

        ICryptoTransform encryptor = rijndael.CreateEncryptor(Encoding.UTF8.GetBytes(KEY), Encoding.UTF8.GetBytes(KEY));

        CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
        cryptoStream.FlushFinalBlock();

        byte[] encryptBytes = memoryStream.ToArray();
        string encryptString = Convert.ToBase64String(encryptBytes);

        cryptoStream.Close();
        memoryStream.Close();

        return encryptString;
    }

    public static string AESDecrypt128(string encrypt)
    {
        byte[] encryptBytes = Convert.FromBase64String(encrypt);

        RijndaelManaged rijndael = new RijndaelManaged();
        rijndael.Mode = CipherMode.CBC;
        rijndael.Padding = PaddingMode.PKCS7;
        rijndael.KeySize = 128;

        MemoryStream memoryStream = new MemoryStream(encryptBytes);
        ICryptoTransform decryptor = rijndael.CreateDecryptor(Encoding.UTF8.GetBytes(KEY), Encoding.UTF8.GetBytes(KEY));
        CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

        byte[] plainBytes = new byte[encryptBytes.Length];

        int plainCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);

        string plainString = Encoding.UTF8.GetString(plainBytes, 0, plainCount);

        cryptoStream.Close();
        memoryStream.Close();

        return plainString;
    }
}
