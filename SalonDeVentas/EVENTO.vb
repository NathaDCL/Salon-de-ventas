Public Class EVENTO
    Public Const Valor_hora = 6000
    Public Const Valor_mozo = 3000
    Public Const Valor_menubasico = 5000
    Public Const Valor_menupremium = 11000
    Public Const Valor_animacion = 18000
    Private _Nombre As String
    Private _Invitados As Integer
    Private _Horas As Integer
    Private _Mozos As Boolean
    Private _Dia As Char
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            Dim Longi As Integer
            Dim aux As Integer

            Longi = Len(value)
            For i = 0 To Longi - 1
                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Error con el nombre")
            Else
                _Nombre = value
            End If
        End Set
    End Property
    Public Property Invitados As Integer
        Get
            Return _Invitados
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Invitados = value
            Else
                MsgBox("Error con los invitados")
            End If
        End Set
    End Property
    Public Property Horas As Integer
        Get
            Return _Horas
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Horas = value
            Else
                MsgBox("Error con las horas")
            End If
        End Set
    End Property
    Public Property Mozos As Boolean
        Get
            Return _Mozos
        End Get
        Set(value As Boolean)
            _Mozos = value
        End Set
    End Property
    Public Property Dia As Char
        Get
            Return _Dia
        End Get
        Set(value As Char)
            If value = "V" Or value = "S" Or value = "D" Then
                _Dia = value
            Else
                MsgBox("Error con el dia")
            End If
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(Nombre As String, Invitados As Integer, Horas As Integer, Mozos As Boolean, Dia As Char)
        Me.Nombre = Nombre
        Me.Invitados = Invitados
        Me.Horas = Horas
        Me.Mozos = Mozos
        Me.Dia = Dia
    End Sub
    Public Overridable Function Valor() As Integer
        Dim cantMozos As Integer
        Dim costoTotal As Double
        cantMozos = Invitados \ 15
        If Dia = "S" Then
            costoTotal = (Horas * Valor_hora) + ((Horas * Valor_hora) * 0.8) + ((cantMozos * Valor_mozo) + (cantMozos * Valor_mozo) * 0.8)
        End If
        If Dia = "D" Then
            costoTotal = (Horas * Valor_hora) + ((Horas * Valor_hora) * 0.5) + ((cantMozos * Valor_mozo) + (cantMozos * Valor_mozo) * 0.5)
        End If
        If Dia = "V" Then
            costoTotal = (Horas * Valor_hora) + (cantMozos * Valor_mozo)
        End If
        Return costoTotal
    End Function
    Public Function Datos() As String
        Return Nombre & " - " & "Inv: " & " " & Invitados & " - " & "Horas: " & Horas & " - " & " Precio: $" & Valor()
    End Function
End Class
