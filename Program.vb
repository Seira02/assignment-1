Imports System.Console

Module Program

    Public Class Student                                'class is created


        Public Rollno, Age As Integer
        Public name As String

        Public Sub Details()                          'Default constructor -value is assigned as default value
            name = "Seira Ann Varghese"
            Rollno = 55
            Age = 21
        End Sub

        Public Function display()                     'function is created and called
            WriteLine(name)
            WriteLine(Rollno)
            WriteLine(Age)
        End Function

    End Class


    Sub Main()                                      'object is created in submain 

        Dim u As Student = New Student()
        u.Details()
        u.display()

    End Sub
End Module