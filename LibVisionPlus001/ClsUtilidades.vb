Imports System.Linq
Imports System.Text
Imports System.Security.Cryptography
Public Class ClsUtilidades
    Public key As String = "AaBbCcDdEe@1!2#3$4%5&6/7(8)9=.z,Z{X}x°ÑñCAHSA$1"
    Public Function FnxProcEC000(cadena As String) As String
        Dim keyArray As Byte()
        Dim Arreglo_a_Cifrar As Byte() = UTF8Encoding.UTF8.GetBytes(cadena)
        Dim hashmd5 As New MD5CryptoServiceProvider()
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
        hashmd5.Clear()
        Dim tdes As New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7
        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
        Dim ArrayResultado As Byte() = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length)
        tdes.Clear()
        Return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length)
    End Function

    Public Function FnxProcDC001(clave As String) As String
        Dim keyArray As Byte()
        Dim Array_a_Descifrar As Byte() = Convert.FromBase64String(clave)
        Dim hashmd5 As New MD5CryptoServiceProvider()
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
        hashmd5.Clear()
        Dim tdes As New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7
        Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length)
        tdes.Clear()
        Return UTF8Encoding.UTF8.GetString(resultArray)
    End Function
End Class
