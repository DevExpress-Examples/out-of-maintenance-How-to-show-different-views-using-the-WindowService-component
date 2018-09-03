Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace WindowServiceExample.ViewModels
    Public Class WindowViewModel
        Protected Sub New()
        End Sub

        Public Shared Function Create() As WindowViewModel
            Return ViewModelSource.Create(Function() New WindowViewModel())
        End Function
    End Class
End Namespace
