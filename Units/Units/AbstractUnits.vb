Namespace Global.Units.Units

    Public Interface IAbstractUnits
        ReadOnly Property Symbol As String
        ReadOnly Property FullName As String
    End Interface

    Public MustInherit Class AbstractUnits : Implements IAbstractUnits

        Public MustOverride ReadOnly Property Symbol As String Implements IAbstractUnits.Symbol
        Public MustOverride ReadOnly Property FullName As String Implements IAbstractUnits.FullName

        Public Overrides Function ToString() As String
            Return ToString("u")
        End Function
        Public Overloads Function ToString(format As String) As String
            If format Is Nothing Then Return Symbol
            If format = "U" Then Return FullName
            If format = "u" Then Return Symbol
            Return Symbol
        End Function
    End Class

End Namespace
