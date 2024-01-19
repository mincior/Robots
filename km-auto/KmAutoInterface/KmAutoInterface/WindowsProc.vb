Imports System.Runtime.InteropServices
Imports System.Windows.Automation
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module WindowsProc
    <DllImport("User32.dll")>
    Private Function SetForegroundWindow(ByVal point As IntPtr) As Integer

    End Function
    <DllImport("User32")>
    Private Function ShowWindow(ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer

    End Function
    <DllImport("user32.dll")>
    Private Function GetWindowPlacement(ByVal hWnd As IntPtr, ByRef lpwndpl As Windowplacement) As Boolean

    End Function

    Private Structure Windowplacement
        Public length As Integer
        Public flags As Integer
        Public showCmd As Integer
        Public ptMinPosition As System.Drawing.Point
        Public ptMaxPosition As System.Drawing.Point
        Public rcNormalPosition As System.Drawing.Rectangle
    End Structure
    Public Function tabExists(url As String) As String
        tabExists = ""
        Try
            Dim procs As Process() = Process.GetProcesses()
            For Each p As Process In procs
                If p.MainWindowHandle = IntPtr.Zero Then Continue For
                If p.ProcessName = "msedge" Then
                    'Stop
                    Dim TabUrl As String = ""
                    Dim TabTitle As String = ""
                    'Dim root As AutomationElement = FromHandle(p.MainWindowHandle)

                    Dim root As AutomationElement = AutomationElement.FromHandle(p.MainWindowHandle)
                    If root Is Nothing Then Continue For
                    Dim condTabItem As Condition = New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.TabItem)
                    For Each tabitem As AutomationElement In root.FindAll(TreeScope.Subtree, condTabItem)
                        Dim SearchBar = root.FindFirst(TreeScope.Descendants, New PropertyCondition(AutomationElement.NameProperty, "Address and search bar"))
                        TabUrl = SearchBar.GetCurrentPropertyValue(ValuePatternIdentifiers.ValueProperty).ToString
                        TabTitle = tabitem.Current.Name
                        If TabUrl.IndexOf(url, 0) <> -1 Then
                            tabExists = TabTitle
                            Exit Function
                        End If
                        SetForegroundWindow(p.MainWindowHandle)
                        SendKeys.SendWait("^{Tab}")
                    Next
                    'Dim conditions As Condition = New AndCondition(New PropertyCondition(AutomationElement.ProcessIdProperty, p.Id), New PropertyCondition(AutomationElement.IsControlElementProperty, True), New PropertyCondition(AutomationElement.IsContentElementProperty, True), New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.TabItem))
                    'Dim elementx As AutomationElement = element.FindFirst(TreeScope.Descendants, conditions)
                End If

            Next
        Catch ex As System.Exception
        End Try

    End Function
End Module
