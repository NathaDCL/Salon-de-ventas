Public Class FULL
    Inherits CATERING
    Private _Animaciones As Integer
    Public Property Animaciones As Integer
        Get
            Return _Animaciones
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Animaciones = value
            Else
                MsgBox("Error con las animaciones")
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Animaciones As Integer, Menu As Char, Nombre As String, Invitados As Integer, Horas As Integer, Mozos As Boolean, Dia As Char)
        MyBase.New(Menu, Nombre, Invitados, Horas, Mozos, Dia)
        Me.Animaciones = Animaciones
    End Sub
    Public Overrides Function Valor() As Integer
        Dim Total As Double
        Total = MyBase.Valor() + (Animaciones * Valor_animacion)
        Return Total


    End Function
End Class
