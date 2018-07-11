<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AetherTabControl1 = New BasicCrypter.AetherTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AetherGroupBox2 = New BasicCrypter.AetherGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSleep = New BasicCrypter.AetherTextbox()
        Me.chkboxStartup = New BasicCrypter.AetherCheckBox()
        Me.AetherGroupBox1 = New BasicCrypter.AetherGroupBox()
        Me.btnCrypt = New BasicCrypter.AetherButton()
        Me.btnBrowser = New BasicCrypter.AetherButton()
        Me.txtbox_file = New BasicCrypter.AetherTextbox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtKey = New BasicCrypter.AetherTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AetherTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.AetherGroupBox2.SuspendLayout()
        Me.AetherGroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AetherTabControl1
        '
        Me.AetherTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.AetherTabControl1.Controls.Add(Me.TabPage1)
        Me.AetherTabControl1.Controls.Add(Me.TabPage2)
        Me.AetherTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AetherTabControl1.ItemSize = New System.Drawing.Size(40, 190)
        Me.AetherTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.AetherTabControl1.Multiline = True
        Me.AetherTabControl1.Name = "AetherTabControl1"
        Me.AetherTabControl1.SelectedIndex = 0
        Me.AetherTabControl1.Size = New System.Drawing.Size(737, 450)
        Me.AetherTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.AetherTabControl1.TabIndex = 0
        Me.AetherTabControl1.UpperText = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.AetherGroupBox2)
        Me.TabPage1.Controls.Add(Me.AetherGroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(194, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(539, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        '
        'AetherGroupBox2
        '
        Me.AetherGroupBox2.Controls.Add(Me.Label2)
        Me.AetherGroupBox2.Controls.Add(Me.Label1)
        Me.AetherGroupBox2.Controls.Add(Me.txtSleep)
        Me.AetherGroupBox2.Controls.Add(Me.chkboxStartup)
        Me.AetherGroupBox2.Footer = False
        Me.AetherGroupBox2.FooterText = Nothing
        Me.AetherGroupBox2.Location = New System.Drawing.Point(9, 233)
        Me.AetherGroupBox2.Name = "AetherGroupBox2"
        Me.AetherGroupBox2.Size = New System.Drawing.Size(522, 186)
        Me.AetherGroupBox2.TabIndex = 3
        Me.AetherGroupBox2.Text = "Options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Second"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sleep"
        '
        'txtSleep
        '
        Me.txtSleep.EnabledCalc = True
        Me.txtSleep.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSleep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtSleep.Location = New System.Drawing.Point(64, 110)
        Me.txtSleep.MaxLength = 32767
        Me.txtSleep.MultiLine = False
        Me.txtSleep.Name = "txtSleep"
        Me.txtSleep.ReadOnly = False
        Me.txtSleep.Size = New System.Drawing.Size(60, 29)
        Me.txtSleep.TabIndex = 3
        Me.txtSleep.Text = "5"
        Me.txtSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSleep.UseSystemPasswordChar = False
        '
        'chkboxStartup
        '
        Me.chkboxStartup.Checked = False
        Me.chkboxStartup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkboxStartup.EnabledCalc = True
        Me.chkboxStartup.Location = New System.Drawing.Point(3, 56)
        Me.chkboxStartup.Name = "chkboxStartup"
        Me.chkboxStartup.Size = New System.Drawing.Size(121, 35)
        Me.chkboxStartup.TabIndex = 0
        Me.chkboxStartup.Text = "Startup"
        '
        'AetherGroupBox1
        '
        Me.AetherGroupBox1.Controls.Add(Me.txtKey)
        Me.AetherGroupBox1.Controls.Add(Me.btnCrypt)
        Me.AetherGroupBox1.Controls.Add(Me.btnBrowser)
        Me.AetherGroupBox1.Controls.Add(Me.txtbox_file)
        Me.AetherGroupBox1.Footer = False
        Me.AetherGroupBox1.FooterText = Nothing
        Me.AetherGroupBox1.Location = New System.Drawing.Point(6, 23)
        Me.AetherGroupBox1.Name = "AetherGroupBox1"
        Me.AetherGroupBox1.Size = New System.Drawing.Size(527, 189)
        Me.AetherGroupBox1.TabIndex = 2
        Me.AetherGroupBox1.Text = "Select File"
        '
        'btnCrypt
        '
        Me.btnCrypt.EnabledCalc = True
        Me.btnCrypt.Location = New System.Drawing.Point(427, 119)
        Me.btnCrypt.Name = "btnCrypt"
        Me.btnCrypt.Size = New System.Drawing.Size(97, 29)
        Me.btnCrypt.TabIndex = 2
        Me.btnCrypt.Text = "Crypt"
        '
        'btnBrowser
        '
        Me.btnBrowser.EnabledCalc = True
        Me.btnBrowser.Location = New System.Drawing.Point(3, 119)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(97, 29)
        Me.btnBrowser.TabIndex = 1
        Me.btnBrowser.Text = "Browser"
        '
        'txtbox_file
        '
        Me.txtbox_file.EnabledCalc = True
        Me.txtbox_file.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbox_file.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtbox_file.Location = New System.Drawing.Point(3, 66)
        Me.txtbox_file.MaxLength = 32767
        Me.txtbox_file.MultiLine = False
        Me.txtbox_file.Name = "txtbox_file"
        Me.txtbox_file.ReadOnly = False
        Me.txtbox_file.Size = New System.Drawing.Size(521, 29)
        Me.txtbox_file.TabIndex = 0
        Me.txtbox_file.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtbox_file.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(194, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(539, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "About"
        '
        'txtKey
        '
        Me.txtKey.EnabledCalc = True
        Me.txtKey.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtKey.Location = New System.Drawing.Point(167, 119)
        Me.txtKey.MaxLength = 32767
        Me.txtKey.MultiLine = False
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(184, 29)
        Me.txtKey.TabIndex = 3
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtKey.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Coded By :NYAN CAT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(354, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "https://github.com/NYAN-x-CAT/Lime-RAT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 450)
        Me.Controls.Add(Me.AetherTabControl1)
        Me.Name = "Form1"
        Me.Text = "BasicCrypter"
        Me.AetherTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.AetherGroupBox2.ResumeLayout(False)
        Me.AetherGroupBox2.PerformLayout()
        Me.AetherGroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AetherTabControl1 As AetherTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtbox_file As AetherTextbox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AetherGroupBox1 As AetherGroupBox
    Friend WithEvents btnBrowser As AetherButton
    Friend WithEvents AetherGroupBox2 As AetherGroupBox
    Friend WithEvents chkboxStartup As AetherCheckBox
    Friend WithEvents btnCrypt As AetherButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSleep As AetherTextbox
    Friend WithEvents txtKey As AetherTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
