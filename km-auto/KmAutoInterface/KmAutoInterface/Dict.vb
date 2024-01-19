Public Class Dict
	Private _properties As New Dictionary(Of String, Object)
	Public Property propByName() As Dictionary(Of String, Object)
		Get
			Return _properties
		End Get
		Set(ByVal value As Dictionary(Of String, Object))
			_properties = value
		End Set

	End Property

	Public Property myDict As Dictionary(Of String, List(Of String))
		Get
			On Error Resume Next
			Return _properties("myDict")
		End Get
		Set(ByVal value As Dictionary(Of String, List(Of String)))
			_properties("myDict") = value
		End Set

	End Property

End Class

