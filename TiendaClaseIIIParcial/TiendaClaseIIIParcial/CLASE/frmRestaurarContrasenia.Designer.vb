﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurarContrasenia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestaurarContrasenia))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.rtxHtml = New System.Windows.Forms.RichTextBox()
        Me.txtPswMostra = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnEnviarCorreo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel9.Controls.Add(Me.rtxHtml)
        Me.Panel9.Controls.Add(Me.txtPswMostra)
        Me.Panel9.Controls.Add(Me.txtCorreo)
        Me.Panel9.Controls.Add(Me.btnEnviarCorreo)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.Panel4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 76)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(484, 160)
        Me.Panel9.TabIndex = 619
        '
        'rtxHtml
        '
        Me.rtxHtml.Location = New System.Drawing.Point(345, 42)
        Me.rtxHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxHtml.Name = "rtxHtml"
        Me.rtxHtml.Size = New System.Drawing.Size(126, 105)
        Me.rtxHtml.TabIndex = 617
        Me.rtxHtml.Text = resources.GetString("rtxHtml.Text")
        '
        'txtPswMostra
        '
        Me.txtPswMostra.AutoSize = True
        Me.txtPswMostra.BackColor = System.Drawing.Color.White
        Me.txtPswMostra.Location = New System.Drawing.Point(280, 107)
        Me.txtPswMostra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPswMostra.Name = "txtPswMostra"
        Me.txtPswMostra.Size = New System.Drawing.Size(39, 13)
        Me.txtPswMostra.TabIndex = 616
        Me.txtPswMostra.Text = "Label2"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtCorreo.ForeColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(79, 23)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(271, 31)
        Me.txtCorreo.TabIndex = 615
        Me.txtCorreo.Tag = "Ingresar contraseña"
        '
        'btnEnviarCorreo
        '
        Me.btnEnviarCorreo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarCorreo.FlatAppearance.BorderSize = 0
        Me.btnEnviarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEnviarCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(79, 85)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(252, 52)
        Me.btnEnviarCorreo.TabIndex = 614
        Me.btnEnviarCorreo.Text = "Recuperar"
        Me.btnEnviarCorreo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-7, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 26)
        Me.Label1.TabIndex = 605
        Me.Label1.Text = "Correo"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(28, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 1)
        Me.Panel4.TabIndex = 547
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(484, 76)
        Me.Label3.TabIndex = 620
        Me.Label3.Text = "Recuperar contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRestaurarContrasenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 235)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRestaurarContrasenia"
        Me.Text = "frmRestaurarContrasenia"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents rtxHtml As RichTextBox
    Friend WithEvents txtPswMostra As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnEnviarCorreo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
End Class
