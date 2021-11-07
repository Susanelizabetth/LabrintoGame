Public Class Form2
    Dim y As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Start()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Finish(sender As Object, e As EventArgs) Handles LabelFinish.MouseEnter
        'El timer para'
        Timer1.Stop()

        Dim v As Integer
        v = 500 - y
        User(i - 1).points = v

        'Colocar el mejor puntuaje'
        Dim Mayor As Integer
        Mayor = User(0).points
        For l = 0 To i - 1
            If Mayor < User(l + 1).points Then
                Mayor = User(l + 1).points
            End If
        Next l
        LabelBest.Text = Mayor

        'Si el usuario desea jugar nuevamente debe tener el mismo nombre que el anterior user'
        User(i).nombre = User(i - 1).nombre

        'agregar a la tabla de puntuaciones'
        rangking.Items.Add(User(i - 1).nombre)
        rangking.Items.Add(User(i - 1).points)
        rangking.Items.Add("")

        Dim dialogResult1 = MessageBox.Show("FELICIDADES, LO HAS LOGRADO " + Chr(13) + Chr(10) + "Tiempo:" + CStr(y))
        y = 0
        'inicia el timer'
        Timer1.Start()
        i = i + 1
    End Sub
    Private Sub Start()
        'Devuelve el cursor a la localización de Panel1'
        Dim StartPoint = Panel1.Location
        StartPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartPoint)

        'Comienza el conteo del rejoj'
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Start(sender As Object, e As EventArgs) Handles Label45.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label44.MouseEnter, Label42.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Conteo para el timer'
        y = y + 1
        Tiempo1.Text = y
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
