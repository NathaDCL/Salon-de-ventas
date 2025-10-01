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
        Label1 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        rbDomingo = New RadioButton()
        rbSabado = New RadioButton()
        rbViernes = New RadioButton()
        chMozos = New CheckBox()
        txtHoras = New TextBox()
        txtInvi = New TextBox()
        txtNombre = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Panel3 = New Panel()
        rbFull = New RadioButton()
        rbCatering = New RadioButton()
        rbEvento = New RadioButton()
        Label5 = New Label()
        Panel4 = New Panel()
        rbPremium = New RadioButton()
        rbBasico = New RadioButton()
        Label11 = New Label()
        Panel5 = New Panel()
        txtAnim = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        btnConfirm = New Button()
        btnCancel = New Button()
        lbDatos = New ListBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(176, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(447, 32)
        Label1.TabIndex = 0
        Label1.Text = "Salón de ventas****  Sistema de reservas"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(47, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(535, 100)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(36, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(359, 16)
        Label4.TabIndex = 2
        Label4.Text = "Para finalizar, presione ""CONFIRMAR RESERVA"""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(36, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(391, 16)
        Label2.TabIndex = 0
        Label2.Text = "Seleccione el Tipo de Reserva que desea realizar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(36, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 16)
        Label3.TabIndex = 1
        Label3.Text = "y complete los datos correspondientes. "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(rbDomingo)
        Panel2.Controls.Add(rbSabado)
        Panel2.Controls.Add(rbViernes)
        Panel2.Controls.Add(chMozos)
        Panel2.Controls.Add(txtHoras)
        Panel2.Controls.Add(txtInvi)
        Panel2.Controls.Add(txtNombre)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(47, 215)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(535, 225)
        Panel2.TabIndex = 2
        ' 
        ' rbDomingo
        ' 
        rbDomingo.AutoSize = True
        rbDomingo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbDomingo.Location = New Point(259, 201)
        rbDomingo.Name = "rbDomingo"
        rbDomingo.Size = New Size(68, 19)
        rbDomingo.TabIndex = 10
        rbDomingo.TabStop = True
        rbDomingo.Text = "Domigo"
        rbDomingo.UseVisualStyleBackColor = True
        ' 
        ' rbSabado
        ' 
        rbSabado.AutoSize = True
        rbSabado.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbSabado.Location = New Point(259, 176)
        rbSabado.Name = "rbSabado"
        rbSabado.Size = New Size(64, 19)
        rbSabado.TabIndex = 9
        rbSabado.TabStop = True
        rbSabado.Text = "Sábado"
        rbSabado.UseVisualStyleBackColor = True
        ' 
        ' rbViernes
        ' 
        rbViernes.AutoSize = True
        rbViernes.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbViernes.Location = New Point(259, 151)
        rbViernes.Name = "rbViernes"
        rbViernes.Size = New Size(63, 19)
        rbViernes.TabIndex = 8
        rbViernes.TabStop = True
        rbViernes.Text = "Viernes"
        rbViernes.UseVisualStyleBackColor = True
        ' 
        ' chMozos
        ' 
        chMozos.AutoSize = True
        chMozos.Location = New Point(344, 115)
        chMozos.Name = "chMozos"
        chMozos.Size = New Size(97, 19)
        chMozos.TabIndex = 7
        chMozos.Text = "Incluir Mozos"
        chMozos.UseVisualStyleBackColor = True
        ' 
        ' txtHoras
        ' 
        txtHoras.Location = New Point(194, 108)
        txtHoras.Name = "txtHoras"
        txtHoras.Size = New Size(66, 23)
        txtHoras.TabIndex = 6
        ' 
        ' txtInvi
        ' 
        txtInvi.Location = New Point(194, 68)
        txtInvi.Name = "txtInvi"
        txtInvi.Size = New Size(66, 23)
        txtInvi.TabIndex = 5
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(129, 30)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(333, 23)
        txtNombre.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(47, 108)
        Label10.Name = "Label10"
        Label10.Size = New Size(121, 21)
        Label10.TabIndex = 3
        Label10.Text = "Cantidad de Horas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(47, 66)
        Label9.Name = "Label9"
        Label9.Size = New Size(141, 21)
        Label9.TabIndex = 2
        Label9.Text = "Cantidad de Invitados"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(36, 169)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 21)
        Label8.TabIndex = 2
        Label8.Text = "Dia en que se realizará el evento"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(47, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 21)
        Label7.TabIndex = 1
        Label7.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 15)
        Label6.TabIndex = 0
        Label6.Text = "Viaje"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel3.Controls.Add(rbFull)
        Panel3.Controls.Add(rbCatering)
        Panel3.Controls.Add(rbEvento)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(621, 91)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(269, 100)
        Panel3.TabIndex = 3
        ' 
        ' rbFull
        ' 
        rbFull.AutoSize = True
        rbFull.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbFull.Location = New Point(74, 71)
        rbFull.Name = "rbFull"
        rbFull.Size = New Size(64, 25)
        rbFull.TabIndex = 3
        rbFull.TabStop = True
        rbFull.Text = "FULL"
        rbFull.UseVisualStyleBackColor = True
        ' 
        ' rbCatering
        ' 
        rbCatering.AutoSize = True
        rbCatering.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbCatering.Location = New Point(74, 47)
        rbCatering.Name = "rbCatering"
        rbCatering.Size = New Size(105, 25)
        rbCatering.TabIndex = 2
        rbCatering.TabStop = True
        rbCatering.Text = "CATERING"
        rbCatering.UseVisualStyleBackColor = True
        ' 
        ' rbEvento
        ' 
        rbEvento.AutoSize = True
        rbEvento.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbEvento.Location = New Point(74, 22)
        rbEvento.Name = "rbEvento"
        rbEvento.Size = New Size(90, 25)
        rbEvento.TabIndex = 1
        rbEvento.TabStop = True
        rbEvento.Text = "EVENTO"
        rbEvento.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 0
        Label5.Text = "Tipo de Reserva"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveBorder
        Panel4.Controls.Add(rbPremium)
        Panel4.Controls.Add(rbBasico)
        Panel4.Controls.Add(Label11)
        Panel4.Location = New Point(621, 215)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(269, 100)
        Panel4.TabIndex = 4
        ' 
        ' rbPremium
        ' 
        rbPremium.AutoSize = True
        rbPremium.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbPremium.Location = New Point(74, 59)
        rbPremium.Name = "rbPremium"
        rbPremium.Size = New Size(98, 25)
        rbPremium.TabIndex = 13
        rbPremium.TabStop = True
        rbPremium.Text = "Premium"
        rbPremium.UseVisualStyleBackColor = True
        ' 
        ' rbBasico
        ' 
        rbBasico.AutoSize = True
        rbBasico.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbBasico.Location = New Point(75, 28)
        rbBasico.Name = "rbBasico"
        rbBasico.Size = New Size(77, 25)
        rbBasico.TabIndex = 12
        rbBasico.TabStop = True
        rbBasico.Text = "Básico"
        rbBasico.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(17, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 15)
        Label11.TabIndex = 11
        Label11.Text = "Catering"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveBorder
        Panel5.Controls.Add(txtAnim)
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(Label12)
        Panel5.Location = New Point(621, 340)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(269, 100)
        Panel5.TabIndex = 4
        ' 
        ' txtAnim
        ' 
        txtAnim.Location = New Point(79, 61)
        txtAnim.Name = "txtAnim"
        txtAnim.Size = New Size(100, 23)
        txtAnim.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(17, 26)
        Label13.Name = "Label13"
        Label13.Size = New Size(230, 21)
        Label13.TabIndex = 13
        Label13.Text = "Cantidad de animaciones a contratar"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(26, 15)
        Label12.TabIndex = 12
        Label12.Text = "Full"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnConfirm.FlatStyle = FlatStyle.Popup
        btnConfirm.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirm.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnConfirm.Location = New Point(47, 459)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(535, 53)
        btnConfirm.TabIndex = 5
        btnConfirm.Text = "CONFIRMAR RESERVA"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Red
        btnCancel.Location = New Point(621, 459)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(269, 53)
        btnCancel.TabIndex = 6
        btnCancel.Text = "CANCELAR " & vbCrLf
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lbDatos
        ' 
        lbDatos.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbDatos.FormattingEnabled = True
        lbDatos.ItemHeight = 30
        lbDatos.Items.AddRange(New Object() {""})
        lbDatos.Location = New Point(47, 550)
        lbDatos.Name = "lbDatos"
        lbDatos.Size = New Size(843, 94)
        lbDatos.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(924, 669)
        Controls.Add(lbDatos)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Salón de ventas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbFull As RadioButton
    Friend WithEvents rbCatering As RadioButton
    Friend WithEvents rbEvento As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chMozos As CheckBox
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtInvi As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents rbDomingo As RadioButton
    Friend WithEvents rbSabado As RadioButton
    Friend WithEvents rbViernes As RadioButton
    Friend WithEvents rbPremium As RadioButton
    Friend WithEvents rbBasico As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAnim As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbDatos As ListBox

End Class
