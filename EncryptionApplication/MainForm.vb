Imports EncryptionAlgorithms
Imports System.Text

Public Class MainForm

    Private _encryptionType As EncryptionType = EncryptionType.CeaserCipher

    Private Sub btn_encrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_encrypt.Click
        Try
            SelectEncryptionType(tc_algos.SelectedIndex)
            Select Case _encryptionType
                Case EncryptionType.CeaserCipher
                    Dim ceaser As CeaserCipher = New CeaserCipher()
                    Try
                        ceaser.Shift = Integer.Parse(ceaserShiftNUD.Value)
                    Catch ex As Exception
                        MessageBox.Show("Error: Invalid key. Key must be integer values for Ceaser Cipher.", "Error: Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    rtbx_cipher.Text = Encoding.ASCII.GetString(ceaser.Encrypt(Encoding.ASCII.GetBytes(rtbx_plain.Text)))
                Case EncryptionType.OneTimePad
                    Dim cipher As ICipher = New OneTimePad()
                    cipher.Key = oneTimePadKeyTBX.Text()
                    rtbx_cipher.Text = Encoding.ASCII.GetString(cipher.Encrypt(Encoding.ASCII.GetBytes(rtbx_plain.Text)))
                Case EncryptionType.VernamCipher
                    Dim cipher As ICipher = New VernamCipher()
                    cipher.Key = vernamKeyTBX.Text
                    rtbx_cipher.Text = Encoding.ASCII.GetString(cipher.Encrypt(Encoding.ASCII.GetBytes(rtbx_plain.Text)))
                Case EncryptionType.MonoAlphabetic
                    Dim cipher As MonoAlphabetic = New MonoAlphabetic(monoAlphabetKeyTBX.Text)
                    rtbx_cipher.Text = cipher.Encrypt(rtbx_plain.Text)
                Case EncryptionType.AutoKey
                    Dim cipher As AutoKey = New AutoKey(autoKeyKeyTBX.Text)
                    rtbx_cipher.Text = cipher.Encrypt(rtbx_plain.Text)
                Case EncryptionType.PlayFair
                    Dim cipher As PlayFair = New PlayFair(playfairKeyTbx.Text)
                    rtbx_cipher.Text = cipher.Encrypt(rtbx_plain.Text)
                Case EncryptionType.RailFence
                    Dim cipher As RailFence = New RailFence(railFenceKeyNUD.Text)
                    rtbx_cipher.Text = cipher.Encrypt(rtbx_plain.Text)
                Case EncryptionType.Vigenere
                    Dim cipher As ICipher = New Vigenere()
                    cipher.Key = vigenereKayTBX.Text
                    rtbx_cipher.Text = Encoding.ASCII.GetString(cipher.Encrypt(Encoding.ASCII.GetBytes(rtbx_plain.Text)))
                Case Else
                    MessageBox.Show("Error: Invalid encryption type. Select encryption type first.", "Error: Invalid encryption type", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
            End Select
            'rtbx_plain.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_decrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_decrypt.Click
        Try
            SelectEncryptionType(tc_algos.SelectedIndex)
            Select Case _encryptionType
                Case EncryptionType.CeaserCipher
                    Dim ceaser As CeaserCipher = New CeaserCipher()
                    Try
                        ceaser.Shift = Integer.Parse(ceaserShiftNUD.Value)
                    Catch ex As Exception
                        MessageBox.Show("Error: Invalid key. Key must be integer value for Ceaser Cipher.", "Error: Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    rtbx_plain.Text = Encoding.ASCII.GetString(ceaser.Decrypt(Encoding.ASCII.GetBytes(rtbx_cipher.Text)))
                Case EncryptionType.OneTimePad
                    Dim cipher As ICipher = New OneTimePad()
                    cipher.Key = oneTimePadKeyTBX.Text
                    rtbx_plain.Text = Encoding.ASCII.GetString(cipher.Decrypt(Encoding.ASCII.GetBytes(rtbx_cipher.Text)))
                Case EncryptionType.VernamCipher
                    Dim cipher As ICipher = New VernamCipher()
                    cipher.Key = vernamKeyTBX.Text
                    rtbx_plain.Text = Encoding.ASCII.GetString(cipher.Decrypt(Encoding.ASCII.GetBytes(rtbx_cipher.Text)))
                Case EncryptionType.MonoAlphabetic
                    Dim cipher As MonoAlphabetic = New MonoAlphabetic(monoAlphabetKeyTBX.Text)
                    rtbx_plain.Text = cipher.Decrypt(rtbx_cipher.Text)
                Case EncryptionType.AutoKey
                    Dim cipher As AutoKey = New AutoKey(autoKeyKeyTBX.Text)
                    rtbx_plain.Text = cipher.Decrypt(rtbx_cipher.Text)
                Case EncryptionType.PlayFair
                    Dim cipher As PlayFair = New PlayFair(playfairKeyTbx.Text)
                    rtbx_plain.Text = cipher.Decrypt(rtbx_cipher.Text)
                Case EncryptionType.RailFence
                    Dim cipher As RailFence = New RailFence(railFenceKeyNUD.Text)
                    rtbx_plain.Text = cipher.Decrypt(rtbx_cipher.Text)
                Case EncryptionType.Vigenere
                    Dim cipher As ICipher = New Vigenere()
                    cipher.Key = vigenereKayTBX.Text
                    rtbx_plain.Text = Encoding.ASCII.GetString(cipher.Decrypt(Encoding.ASCII.GetBytes(rtbx_cipher.Text)))
            End Select
            'rtbx_cipher.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_clearPlain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clearPlain.Click
        rtbx_plain.Text = ""
    End Sub

    Private Sub btn_clearCipher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clearCipher.Click
        rtbx_cipher.Text = ""
    End Sub

    Private Sub SelectEncryptionType(ByVal tabIndex As Integer)
        Select Case tabIndex
            Case 0
                _encryptionType = EncryptionType.CeaserCipher
            Case 1
                _encryptionType = EncryptionType.MonoAlphabetic
            Case 2
                _encryptionType = EncryptionType.OneTimePad
            Case 3
                _encryptionType = EncryptionType.VernamCipher
            Case 4
                _encryptionType = EncryptionType.Vigenere
            Case 5
                _encryptionType = EncryptionType.AutoKey
            Case 6
                _encryptionType = EncryptionType.RailFence
            Case 7
                _encryptionType = EncryptionType.PlayFair
        End Select
    End Sub
End Class