Public Class shareDrink
    Private _newCountDrink As Integer
    Private _oldCountDrink As Integer
    Private _idDrink As Integer
    Public Sub New(newCountDrink As Integer, oldCountDrink As Integer, idDrink As Integer)
        Me._newCountDrink = newCountDrink
        Me._oldCountDrink = oldCountDrink
        Me._idDrink = idDrink
    End Sub

    Public Property NewCountDrink As Integer
        Get
            Return _newCountDrink
        End Get
        Set(value As Integer)
            _newCountDrink = value
        End Set
    End Property

    Public Property OldCountDrink As Integer
        Get
            Return _oldCountDrink
        End Get
        Set(value As Integer)
            _oldCountDrink = value
        End Set
    End Property

    Public Property IdDrink As Integer
        Get
            Return _idDrink
        End Get
        Set(value As Integer)
            _idDrink = value
        End Set
    End Property
End Class
