<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tc_algos = New System.Windows.Forms.TabControl()
        Me.tab_ceaser = New System.Windows.Forms.TabPage()
        Me.ceaserShiftNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_monoAlphabatic = New System.Windows.Forms.TabPage()
        Me.monoAlphabetKeyTBX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tab_oneTimePad = New System.Windows.Forms.TabPage()
        Me.oneTimePadKeyTBX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab_vernam = New System.Windows.Forms.TabPage()
        Me.vernamKeyTBX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab_vigenere = New System.Windows.Forms.TabPage()
        Me.vigenereKayTBX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tab_autokey = New System.Windows.Forms.TabPage()
        Me.autoKeyKeyTBX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tab_railfence = New System.Windows.Forms.TabPage()
        Me.railFenceKeyNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tab_playfair = New System.Windows.Forms.TabPage()
        Me.playfairKeyTbx = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_clearPlain = New System.Windows.Forms.Button()
        Me.btn_clearCipher = New System.Windows.Forms.Button()
        Me.btn_decrypt = New System.Windows.Forms.Button()
        Me.btn_encrypt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbx_plain = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtbx_cipher = New System.Windows.Forms.RichTextBox()
        Me.gbx_encryption = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tc_algos.SuspendLayout()
        Me.tab_ceaser.SuspendLayout()
        CType(Me.ceaserShiftNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_monoAlphabatic.SuspendLayout()
        Me.tab_oneTimePad.SuspendLayout()
        Me.tab_vernam.SuspendLayout()
        Me.tab_vigenere.SuspendLayout()
        Me.tab_autokey.SuspendLayout()
        Me.tab_railfence.SuspendLayout()
        CType(Me.railFenceKeyNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_playfair.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbx_encryption.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_algos
        '
        Me.tc_algos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tc_algos.Controls.Add(Me.tab_ceaser)
        Me.tc_algos.Controls.Add(Me.tab_monoAlphabatic)
        Me.tc_algos.Controls.Add(Me.tab_oneTimePad)
        Me.tc_algos.Controls.Add(Me.tab_vernam)
        Me.tc_algos.Controls.Add(Me.tab_vigenere)
        Me.tc_algos.Controls.Add(Me.tab_autokey)
        Me.tc_algos.Controls.Add(Me.tab_railfence)
        Me.tc_algos.Controls.Add(Me.tab_playfair)
        Me.tc_algos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc_algos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tc_algos.Location = New System.Drawing.Point(4, 109)
        Me.tc_algos.Name = "tc_algos"
        Me.tc_algos.SelectedIndex = 0
        Me.tc_algos.Size = New System.Drawing.Size(843, 135)
        Me.tc_algos.TabIndex = 0
        '
        'tab_ceaser
        '
        Me.tab_ceaser.Controls.Add(Me.ceaserShiftNUD)
        Me.tab_ceaser.Controls.Add(Me.Label1)
        Me.tab_ceaser.Location = New System.Drawing.Point(4, 33)
        Me.tab_ceaser.Name = "tab_ceaser"
        Me.tab_ceaser.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ceaser.Size = New System.Drawing.Size(835, 98)
        Me.tab_ceaser.TabIndex = 0
        Me.tab_ceaser.Text = "Ceaser"
        Me.tab_ceaser.UseVisualStyleBackColor = True
        '
        'ceaserShiftNUD
        '
        Me.ceaserShiftNUD.Location = New System.Drawing.Point(190, 50)
        Me.ceaserShiftNUD.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ceaserShiftNUD.Name = "ceaserShiftNUD"
        Me.ceaserShiftNUD.Size = New System.Drawing.Size(200, 29)
        Me.ceaserShiftNUD.TabIndex = 1
        Me.ceaserShiftNUD.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ceaser Shift :"
        '
        'tab_monoAlphabatic
        '
        Me.tab_monoAlphabatic.Controls.Add(Me.monoAlphabetKeyTBX)
        Me.tab_monoAlphabatic.Controls.Add(Me.Label2)
        Me.tab_monoAlphabatic.Location = New System.Drawing.Point(4, 33)
        Me.tab_monoAlphabatic.Name = "tab_monoAlphabatic"
        Me.tab_monoAlphabatic.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_monoAlphabatic.Size = New System.Drawing.Size(835, 98)
        Me.tab_monoAlphabatic.TabIndex = 1
        Me.tab_monoAlphabatic.Text = "Mono Alphabetic"
        Me.tab_monoAlphabatic.UseVisualStyleBackColor = True
        '
        'monoAlphabetKeyTBX
        '
        Me.monoAlphabetKeyTBX.Location = New System.Drawing.Point(70, 50)
        Me.monoAlphabetKeyTBX.Name = "monoAlphabetKeyTBX"
        Me.monoAlphabetKeyTBX.Size = New System.Drawing.Size(300, 29)
        Me.monoAlphabetKeyTBX.TabIndex = 2
        Me.monoAlphabetKeyTBX.Text = "zyxwvutsrqponmlkjihgfedcba"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Key :"
        '
        'tab_oneTimePad
        '
        Me.tab_oneTimePad.Controls.Add(Me.oneTimePadKeyTBX)
        Me.tab_oneTimePad.Controls.Add(Me.Label3)
        Me.tab_oneTimePad.Location = New System.Drawing.Point(4, 33)
        Me.tab_oneTimePad.Name = "tab_oneTimePad"
        Me.tab_oneTimePad.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_oneTimePad.Size = New System.Drawing.Size(835, 98)
        Me.tab_oneTimePad.TabIndex = 2
        Me.tab_oneTimePad.Text = "One Time Pad"
        Me.tab_oneTimePad.UseVisualStyleBackColor = True
        '
        'oneTimePadKeyTBX
        '
        Me.oneTimePadKeyTBX.Location = New System.Drawing.Point(70, 50)
        Me.oneTimePadKeyTBX.Name = "oneTimePadKeyTBX"
        Me.oneTimePadKeyTBX.Size = New System.Drawing.Size(300, 29)
        Me.oneTimePadKeyTBX.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Key :"
        '
        'tab_vernam
        '
        Me.tab_vernam.Controls.Add(Me.vernamKeyTBX)
        Me.tab_vernam.Controls.Add(Me.Label4)
        Me.tab_vernam.Location = New System.Drawing.Point(4, 33)
        Me.tab_vernam.Name = "tab_vernam"
        Me.tab_vernam.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_vernam.Size = New System.Drawing.Size(835, 98)
        Me.tab_vernam.TabIndex = 3
        Me.tab_vernam.Text = "Vernam"
        Me.tab_vernam.UseVisualStyleBackColor = True
        '
        'vernamKeyTBX
        '
        Me.vernamKeyTBX.Location = New System.Drawing.Point(70, 50)
        Me.vernamKeyTBX.Name = "vernamKeyTBX"
        Me.vernamKeyTBX.Size = New System.Drawing.Size(300, 29)
        Me.vernamKeyTBX.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Key :"
        '
        'tab_vigenere
        '
        Me.tab_vigenere.Controls.Add(Me.vigenereKayTBX)
        Me.tab_vigenere.Controls.Add(Me.Label5)
        Me.tab_vigenere.Location = New System.Drawing.Point(4, 33)
        Me.tab_vigenere.Name = "tab_vigenere"
        Me.tab_vigenere.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_vigenere.Size = New System.Drawing.Size(835, 98)
        Me.tab_vigenere.TabIndex = 4
        Me.tab_vigenere.Text = "Vigenere"
        Me.tab_vigenere.UseVisualStyleBackColor = True
        '
        'vigenereKayTBX
        '
        Me.vigenereKayTBX.Location = New System.Drawing.Point(70, 50)
        Me.vigenereKayTBX.Name = "vigenereKayTBX"
        Me.vigenereKayTBX.Size = New System.Drawing.Size(300, 29)
        Me.vigenereKayTBX.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Key :"
        '
        'tab_autokey
        '
        Me.tab_autokey.Controls.Add(Me.autoKeyKeyTBX)
        Me.tab_autokey.Controls.Add(Me.Label6)
        Me.tab_autokey.Location = New System.Drawing.Point(4, 33)
        Me.tab_autokey.Name = "tab_autokey"
        Me.tab_autokey.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_autokey.Size = New System.Drawing.Size(835, 98)
        Me.tab_autokey.TabIndex = 5
        Me.tab_autokey.Text = "Auto Key"
        Me.tab_autokey.UseVisualStyleBackColor = True
        '
        'autoKeyKeyTBX
        '
        Me.autoKeyKeyTBX.Location = New System.Drawing.Point(70, 50)
        Me.autoKeyKeyTBX.Name = "autoKeyKeyTBX"
        Me.autoKeyKeyTBX.Size = New System.Drawing.Size(300, 29)
        Me.autoKeyKeyTBX.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Key :"
        '
        'tab_railfence
        '
        Me.tab_railfence.Controls.Add(Me.railFenceKeyNUD)
        Me.tab_railfence.Controls.Add(Me.Label7)
        Me.tab_railfence.Location = New System.Drawing.Point(4, 33)
        Me.tab_railfence.Name = "tab_railfence"
        Me.tab_railfence.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_railfence.Size = New System.Drawing.Size(835, 98)
        Me.tab_railfence.TabIndex = 6
        Me.tab_railfence.Text = "Rail Fence"
        Me.tab_railfence.UseVisualStyleBackColor = True
        '
        'railFenceKeyNUD
        '
        Me.railFenceKeyNUD.Location = New System.Drawing.Point(170, 50)
        Me.railFenceKeyNUD.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.railFenceKeyNUD.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.railFenceKeyNUD.Name = "railFenceKeyNUD"
        Me.railFenceKeyNUD.Size = New System.Drawing.Size(200, 29)
        Me.railFenceKeyNUD.TabIndex = 4
        Me.railFenceKeyNUD.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Number of Rails:"
        '
        'tab_playfair
        '
        Me.tab_playfair.Controls.Add(Me.playfairKeyTbx)
        Me.tab_playfair.Controls.Add(Me.Label8)
        Me.tab_playfair.Location = New System.Drawing.Point(4, 33)
        Me.tab_playfair.Name = "tab_playfair"
        Me.tab_playfair.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_playfair.Size = New System.Drawing.Size(835, 98)
        Me.tab_playfair.TabIndex = 7
        Me.tab_playfair.Text = "Playfair"
        Me.tab_playfair.UseVisualStyleBackColor = True
        '
        'playfairKeyTbx
        '
        Me.playfairKeyTbx.Location = New System.Drawing.Point(70, 50)
        Me.playfairKeyTbx.Name = "playfairKeyTbx"
        Me.playfairKeyTbx.Size = New System.Drawing.Size(300, 29)
        Me.playfairKeyTbx.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Key :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_clearPlain)
        Me.GroupBox4.Controls.Add(Me.btn_clearCipher)
        Me.GroupBox4.Controls.Add(Me.btn_decrypt)
        Me.GroupBox4.Controls.Add(Me.btn_encrypt)
        Me.GroupBox4.Location = New System.Drawing.Point(341, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 360)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Operation"
        '
        'btn_clearPlain
        '
        Me.btn_clearPlain.Location = New System.Drawing.Point(6, 241)
        Me.btn_clearPlain.Name = "btn_clearPlain"
        Me.btn_clearPlain.Size = New System.Drawing.Size(138, 53)
        Me.btn_clearPlain.TabIndex = 3
        Me.btn_clearPlain.Text = "Clear Plain Text"
        Me.btn_clearPlain.UseVisualStyleBackColor = True
        '
        'btn_clearCipher
        '
        Me.btn_clearCipher.Location = New System.Drawing.Point(6, 300)
        Me.btn_clearCipher.Name = "btn_clearCipher"
        Me.btn_clearCipher.Size = New System.Drawing.Size(138, 53)
        Me.btn_clearCipher.TabIndex = 2
        Me.btn_clearCipher.Text = "Clear Cipher Text"
        Me.btn_clearCipher.UseVisualStyleBackColor = True
        '
        'btn_decrypt
        '
        Me.btn_decrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decrypt.Location = New System.Drawing.Point(6, 91)
        Me.btn_decrypt.Name = "btn_decrypt"
        Me.btn_decrypt.Size = New System.Drawing.Size(138, 53)
        Me.btn_decrypt.TabIndex = 1
        Me.btn_decrypt.Text = "Decrypt"
        Me.btn_decrypt.UseVisualStyleBackColor = True
        '
        'btn_encrypt
        '
        Me.btn_encrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encrypt.Location = New System.Drawing.Point(6, 32)
        Me.btn_encrypt.Name = "btn_encrypt"
        Me.btn_encrypt.Size = New System.Drawing.Size(138, 53)
        Me.btn_encrypt.TabIndex = 0
        Me.btn_encrypt.Text = "Encrypt"
        Me.btn_encrypt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbx_plain)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 360)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plain Text"
        '
        'rtbx_plain
        '
        Me.rtbx_plain.Location = New System.Drawing.Point(7, 32)
        Me.rtbx_plain.Name = "rtbx_plain"
        Me.rtbx_plain.Size = New System.Drawing.Size(313, 321)
        Me.rtbx_plain.TabIndex = 0
        Me.rtbx_plain.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtbx_cipher)
        Me.GroupBox3.Location = New System.Drawing.Point(497, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(324, 360)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cipher Text"
        '
        'rtbx_cipher
        '
        Me.rtbx_cipher.Location = New System.Drawing.Point(6, 32)
        Me.rtbx_cipher.Name = "rtbx_cipher"
        Me.rtbx_cipher.Size = New System.Drawing.Size(313, 321)
        Me.rtbx_cipher.TabIndex = 1
        Me.rtbx_cipher.Text = ""
        '
        'gbx_encryption
        '
        Me.gbx_encryption.Controls.Add(Me.GroupBox3)
        Me.gbx_encryption.Controls.Add(Me.GroupBox2)
        Me.gbx_encryption.Controls.Add(Me.GroupBox4)
        Me.gbx_encryption.Location = New System.Drawing.Point(4, 250)
        Me.gbx_encryption.Name = "gbx_encryption"
        Me.gbx_encryption.Size = New System.Drawing.Size(831, 392)
        Me.gbx_encryption.TabIndex = 3
        Me.gbx_encryption.TabStop = False
        Me.gbx_encryption.Text = "Encryption"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(8, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 100)
        Me.Panel1.TabIndex = 4
        Me.Panel1.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(39, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(754, 56)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Symmetric Encryption Algorithms"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 648)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbx_encryption)
        Me.Controls.Add(Me.tc_algos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Symmetric Encryption Algorithms"
        Me.tc_algos.ResumeLayout(False)
        Me.tab_ceaser.ResumeLayout(False)
        Me.tab_ceaser.PerformLayout()
        CType(Me.ceaserShiftNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_monoAlphabatic.ResumeLayout(False)
        Me.tab_monoAlphabatic.PerformLayout()
        Me.tab_oneTimePad.ResumeLayout(False)
        Me.tab_oneTimePad.PerformLayout()
        Me.tab_vernam.ResumeLayout(False)
        Me.tab_vernam.PerformLayout()
        Me.tab_vigenere.ResumeLayout(False)
        Me.tab_vigenere.PerformLayout()
        Me.tab_autokey.ResumeLayout(False)
        Me.tab_autokey.PerformLayout()
        Me.tab_railfence.ResumeLayout(False)
        Me.tab_railfence.PerformLayout()
        CType(Me.railFenceKeyNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_playfair.ResumeLayout(False)
        Me.tab_playfair.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.gbx_encryption.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_algos As System.Windows.Forms.TabControl
    Friend WithEvents tab_ceaser As System.Windows.Forms.TabPage
    Friend WithEvents tab_monoAlphabatic As System.Windows.Forms.TabPage
    Friend WithEvents ceaserShiftNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_clearPlain As System.Windows.Forms.Button
    Friend WithEvents btn_clearCipher As System.Windows.Forms.Button
    Friend WithEvents btn_decrypt As System.Windows.Forms.Button
    Friend WithEvents btn_encrypt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbx_plain As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbx_cipher As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_encryption As System.Windows.Forms.GroupBox
    Friend WithEvents tab_oneTimePad As System.Windows.Forms.TabPage
    Friend WithEvents tab_vernam As System.Windows.Forms.TabPage
    Friend WithEvents tab_vigenere As System.Windows.Forms.TabPage
    Friend WithEvents tab_autokey As System.Windows.Forms.TabPage
    Friend WithEvents tab_railfence As System.Windows.Forms.TabPage
    Friend WithEvents tab_playfair As System.Windows.Forms.TabPage
    Friend WithEvents monoAlphabetKeyTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents oneTimePadKeyTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents vernamKeyTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents vigenereKayTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents autoKeyKeyTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents playfairKeyTbx As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents railFenceKeyNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
