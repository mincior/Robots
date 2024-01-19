Public Class Filiala
	Private _properties As New Dictionary(Of String, Object)
	Public Property propByName() As Dictionary(Of String, Object)
		Get
			Return _properties
		End Get
		Set(ByVal value As Dictionary(Of String, Object))
			_properties = value
		End Set

	End Property

	Public Property Nume As String
		Get
			On Error Resume Next
			Return _properties("Nume")
		End Get
		Set(ByVal value As String)
			_properties("Nume") = value
		End Set

	End Property

	Public Property Email As String
		Get
			On Error Resume Next
			Return _properties("Email")
		End Get
		Set(ByVal value As String)
			_properties("Email") = value
		End Set

	End Property

	Public Property Responsabil As String
		Get
			On Error Resume Next
			Return _properties("Responsabil")
		End Get
		Set(ByVal value As String)
			_properties("Responsabil") = value
		End Set

	End Property

	Public Property Operatie As String
		Get
			On Error Resume Next
			Return _properties("Operatie")
		End Get
		Set(ByVal value As String)
			_properties("Operatie") = value
		End Set

	End Property

End Class

