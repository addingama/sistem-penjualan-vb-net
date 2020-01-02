

Public Class Application
	 Sub Main()
		DoLoop()
	End Sub
    
    
    Sub DoLoop()
        Dim a As Integer = 10
        Do 
            System.Console.WriteLine(a)
            a = a + 1
            
        Loop While (a < 20)
    End Sub
End Class
