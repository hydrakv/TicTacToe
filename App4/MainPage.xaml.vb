' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim a As Integer = 0

    Private Sub Clr_Click(sender As Object, e As RoutedEventArgs) Handles clr.Click
        a = 0
        a11.Content = ""
        a12.Content = ""
        a13.Content = ""
        a21.Content = ""
        a22.Content = ""
        a23.Content = ""
        a31.Content = ""
        a32.Content = ""
        a33.Content = ""
        w.Text = ""
        a11.IsEnabled = True
        a12.IsEnabled = True
        a13.IsEnabled = True
        a21.IsEnabled = True
        a22.IsEnabled = True
        a23.IsEnabled = True
        a31.IsEnabled = True
        a32.IsEnabled = True
        a33.IsEnabled = True
    End Sub
    Private Sub A11_Click(sender As Object, e As RoutedEventArgs) Handles a11.Click
        a = a Mod 2
        If a = 0 Then
            a11.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a11.Content = "O"
            a = a + 1


        End If
        If (a11.Content = "X" And a22.Content = "X" And a33.Content = "X") Or (a11.Content = "O" And a22.Content = "O" And a33.Content = "O") Then
            If a11.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a11.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False

            End If
        ElseIf (a11.Content = "X" And a21.Content = "X" And a31.Content = "X") Or (a11.Content = "O" And a21.Content = "O" And a31.Content = "O") Then
            If a11.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a11.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a11.Content = "X" And a12.Content = "X" And a13.Content = "X") Or (a11.Content = "O" And a12.Content = "O" And a13.Content = "O") Then
            If a11.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a11.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a11.IsEnabled = False



    End Sub

    Private Sub A12_Click(sender As Object, e As RoutedEventArgs) Handles a12.Click
        a = a Mod 2
        If a = 0 Then
            a12.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a12.Content = "O"
            a = a + 1


        End If
        If (a12.Content = "X" And a22.Content = "X" And a32.Content = "X") Or (a12.Content = "O" And a22.Content = "O" And a32.Content = "O") Then
            If a12.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a12.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a11.Content = "X" And a12.Content = "X" And a13.Content = "X") Or (a11.Content = "O" And a12.Content = "O" And a13.Content = "O") Then
            If a12.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a12.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a12.IsEnabled = False
    End Sub

    Private Sub A13_Click(sender As Object, e As RoutedEventArgs) Handles a13.Click
        a = a Mod 2
        If a = 0 Then
            a13.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a13.Content = "O"
            a = a + 1


        End If
        If (a13.Content = "X" And a22.Content = "X" And a31.Content = "X") Or (a13.Content = "O" And a22.Content = "O" And a31.Content = "O") Then
            If a13.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a13.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a13.Content = "X" And a23.Content = "X" And a33.Content = "X") Or (a13.Content = "O" And a23.Content = "O" And a33.Content = "O") Then
            If a13.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a13.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a11.Content = "X" And a12.Content = "X" And a13.Content = "X") Or (a11.Content = "O" And a12.Content = "O" And a13.Content = "O") Then
            If a13.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a13.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a13.IsEnabled = False

    End Sub

    Private Sub A21_Click(sender As Object, e As RoutedEventArgs) Handles a21.Click
        a = a Mod 2
        If a = 0 Then
            a21.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a21.Content = "O"
            a = a + 1


        End If
        If (a11.Content = "X" And a21.Content = "X" And a31.Content = "X") Or (a11.Content = "O" And a21.Content = "O" And a31.Content = "O") Then
            If a21.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a11.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a21.Content = "X" And a22.Content = "X" And a23.Content = "X") Or (a21.Content = "O" And a22.Content = "O" And a23.Content = "O") Then
            If a21.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a21.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a21.IsEnabled = False
    End Sub

    Private Sub A22_Click(sender As Object, e As RoutedEventArgs) Handles a22.Click
        a = a Mod 2
        If a = 0 Then
            a22.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a22.Content = "O"
            a = a + 1


        End If
        If (a11.Content = "X" And a22.Content = "X" And a33.Content = "X") Or (a11.Content = "O" And a22.Content = "O" And a33.Content = "O") Then
            If a22.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a22.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a21.Content = "X" And a22.Content = "X" And a23.Content = "X") Or (a21.Content = "O" And a22.Content = "O" And a23.Content = "O") Then
            If a22.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a22.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a12.Content = "X" And a22.Content = "X" And a32.Content = "X") Or (a12.Content = "O" And a22.Content = "O" And a32.Content = "O") Then
            If a22.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a22.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a13.Content = "X" And a23.Content = "X" And a33.Content = "X") Or (a13.Content = "O" And a23.Content = "O" And a33.Content = "O") Then
            If a22.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a22.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a22.IsEnabled = False
    End Sub



    Private Sub A31_Click(sender As Object, e As RoutedEventArgs) Handles a31.Click
        a = a Mod 2
        If a = 0 Then
            a31.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a31.Content = "O"
            a = a + 1


        End If
        If (a31.Content = "X" And a22.Content = "X" And a13.Content = "X") Or (a31.Content = "O" And a22.Content = "O" And a13.Content = "O") Then
            If a31.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a31.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a31.Content = "X" And a32.Content = "X" And a33.Content = "X") Or (a31.Content = "O" And a32.Content = "O" And a33.Content = "O") Then
            If a31.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a31.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a11.Content = "X" And a21.Content = "X" And a31.Content = "X") Or (a11.Content = "O" And a21.Content = "O" And a31.Content = "O") Then
            If a31.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a31.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a31.IsEnabled = False
    End Sub

    Private Sub A32_Click(sender As Object, e As RoutedEventArgs) Handles a32.Click
        a = a Mod 2
        If a = 0 Then
            a32.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a32.Content = "O"
            a = a + 1

        End If
        If (a12.Content = "X" And a22.Content = "X" And a32.Content = "X") Or (a12.Content = "O" And a22.Content = "O" And a32.Content = "O") Then
            If a32.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a32.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a31.Content = "X" And a32.Content = "X" And a33.Content = "X") Or (a31.Content = "O" And a32.Content = "O" And a33.Content = "O") Then
            If a32.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a32.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a32.IsEnabled = False



    End Sub

    Private Sub A33_Click(sender As Object, e As RoutedEventArgs) Handles a33.Click
        a = a Mod 2
        If a = 0 Then
            a33.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a33.Content = "O"
            a = a + 1


        End If
        If (a11.Content = "X" And a22.Content = "X" And a33.Content = "X") Or (a11.Content = "O" And a22.Content = "O" And a33.Content = "O") Then
            If a33.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a33.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a13.Content = "X" And a23.Content = "X" And a33.Content = "X") Or (a13.Content = "O" And a23.Content = "O" And a33.Content = "O") Then
            If a33.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a33.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a31.Content = "X" And a32.Content = "X" And a33.Content = "X") Or (a31.Content = "O" And a32.Content = "O" And a33.Content = "O") Then
            If a33.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a33.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        End If
        a33.IsEnabled = False
    End Sub

    Private Sub A23_Click(sender As Object, e As RoutedEventArgs) Handles a23.Click
        a = a Mod 2
        If a = 0 Then
            a23.Content = "X"
            a = a + 1

        ElseIf a = 1 Then
            a23.Content = "O"
            a = a + 1


        End If
        If (a21.Content = "X" And a22.Content = "X" And a23.Content = "X") Or (a21.Content = "O" And a22.Content = "O" And a23.Content = "O") Then
            If a23.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a23.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            End If
        ElseIf (a13.Content = "X" And a23.Content = "X" And a33.Content = "X") Or (a13.Content = "O" And a23.Content = "O" And a33.Content = "O") Then
            If a23.Content = "X" Then
                w.Text = plyr1.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False
            ElseIf a23.Content = "O" Then
                w.Text = plyr2.Text + " wins🎉🎊"
                a11.IsEnabled = False
                a12.IsEnabled = False
                a13.IsEnabled = False
                a21.IsEnabled = False
                a22.IsEnabled = False
                a23.IsEnabled = False
                a31.IsEnabled = False
                a32.IsEnabled = False
                a33.IsEnabled = False


            End If
        End If
        a23.IsEnabled = False
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If v.Text = "" Then
            v.Text = "Made by Varun Vinod"
        Else
            v.Text = ""

        End If

    End Sub
End Class
