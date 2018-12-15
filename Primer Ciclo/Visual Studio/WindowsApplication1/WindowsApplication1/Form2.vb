Public Class Form2
    Private Sub RegistroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegistroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_DatosDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_DatosDataSet.Registro' Puede moverla o quitarla según sea necesario.
        Me.RegistroTableAdapter.Fill(Me.Base_DatosDataSet.Registro)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Button1 As New Form1
        Button1.Show()
        Me.Hide()
    End Sub

    Private Sub NombreLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class