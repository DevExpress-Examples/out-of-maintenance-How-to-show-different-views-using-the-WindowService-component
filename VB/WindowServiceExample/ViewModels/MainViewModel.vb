Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace WindowServiceExample.ViewModels

    Public Class MainViewModel

        Protected Sub New()
        End Sub

        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function

        Public Sub ShowFirst()
            WindowService.Show("FirstWindowView", Nothing, Me)
        End Sub

        Public Sub ShowSecond()
            WindowService.Show("SecondWindowView", Nothing, Me)
        End Sub

        Public ReadOnly Property WindowService As IWindowService
            Get
                Return GetService(Of IWindowService)()
            End Get
        End Property
    End Class
End Namespace
