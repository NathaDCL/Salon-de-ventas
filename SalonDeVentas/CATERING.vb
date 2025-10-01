Public Class CATERING
    Inherits EVENTO
    Private _Menu As Char
    Public Property Menu As Char
        Get
            Return _Menu
        End Get
        Set(value As Char)
            If value = "B" Or value = "P" Then
                _Menu = value
            Else
                MsgBox("Error con el menu")
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Menu As Char, Nombre As String, Invitados As Integer, Horas As Integer, Mozos As Boolean, Dia As Char)
        MyBase.New(Nombre, Invitados, Horas, Mozos, Dia)
        Me.Menu = Menu
    End Sub
    Public Overrides Function Valor() As Integer
        Dim CostoEvento As Double
        CostoEvento = MyBase.Valor()
        If (Menu = "B") Then
            CostoEvento = CostoEvento + (Valor_menubasico * Invitados)
        End If
        If (Menu = "P") Then
            CostoEvento = CostoEvento + (Valor_menupremium * Invitados)
        End If
        Return CostoEvento
    End Function
End Class
