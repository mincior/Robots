Public Class Masini
	Private _properties As New Dictionary(Of String, Object)
	Public Property propByName() As Dictionary(Of String, Object)
		Get
			Return _properties
		End Get
		Set(ByVal value As Dictionary(Of String, Object))
			_properties = value
		End Set

	End Property

	Public Property id As Long
		Get
			On Error Resume Next
			Return _properties("id")
		End Get
		Set(ByVal value As Long)
			_properties("id") = value
		End Set

	End Property

	Public Property Numar As String
		Get
			On Error Resume Next
			Return _properties("Numar")
		End Get
		Set(ByVal value As String)
			_properties("Numar") = value
		End Set

	End Property

	Public Property DataInrolarii As Double
		Get
			On Error Resume Next
			Return _properties("DataInrolarii")
		End Get
		Set(ByVal value As Double)
			_properties("DataInrolarii") = value
		End Set

	End Property

	Public Property Marca As String
		Get
			On Error Resume Next
			Return _properties("Marca")
		End Get
		Set(ByVal value As String)
			_properties("Marca") = value
		End Set

	End Property

	Public Property Model As String
		Get
			On Error Resume Next
			Return _properties("Model")
		End Get
		Set(ByVal value As String)
			_properties("Model") = value
		End Set

	End Property

	Public Property ConsumMediu As String
		Get
			On Error Resume Next
			Return _properties("ConsumMediu")
		End Get
		Set(ByVal value As String)
			_properties("ConsumMediu") = value
		End Set

	End Property

	Public Property FilialaId As Long
		Get
			On Error Resume Next
			Return _properties("FilialaId")
		End Get
		Set(ByVal value As Long)
			_properties("FilialaId") = value
		End Set

	End Property

	Public Property Carburant As String
		Get
			On Error Resume Next
			Return _properties("Carburant")
		End Get
		Set(ByVal value As String)
			_properties("Carburant") = value
		End Set

	End Property

	Public Property Activ As String
		Get
			On Error Resume Next
			Return _properties("Activ")
		End Get
		Set(ByVal value As String)
			_properties("Activ") = value
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
	Public Property Observatii As String
		Get
			On Error Resume Next
			Return _properties("Observatii")
		End Get
		Set(ByVal value As String)
			_properties("Observatii") = value
		End Set

	End Property

End Class

