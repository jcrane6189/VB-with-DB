Public Class Form1
    Dim sqlstr As String
    Dim connect_str As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DEPTO_COMPDataSet_StudentCurso.StudentCurso' table. You can move, or remove it, as needed.
        Me.StudentCursoTableAdapter.Fill(Me.DEPTO_COMPDataSet_StudentCurso.StudentCurso)
        'TODO: This line of code loads data into the 'DEPTO_COMPDataSet_Student.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.DEPTO_COMPDataSet_Student.Student)
        'TODO: This line of code loads data into the 'DEPTO_COMPDataSet_Facultad.Facultad' table. You can move, or remove it, as needed.
        Me.FacultadTableAdapter.Fill(Me.DEPTO_COMPDataSet_Facultad.Facultad)
        'TODO: This line of code loads data into the 'DEPTO_COMPDataset_Curso.Curso' table. You can move, or remove it, as needed.
        Me.CursoTableAdapter.Fill(Me.DEPTO_COMPDataset_Curso.Curso)

    End Sub



    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT * FROM Curso"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub DatosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem1.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT * FROM Facultad"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub DatosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem2.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT * FROM Student"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub SalonEspecificoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalonEspecificoToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT course, classroom, schedule, enrollment FROM Curso WHERE classroom = 'TC-109' "
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub CursoEspecificoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursoEspecificoToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT course, classroom, schedule, enrollment FROM Curso WHERE course = 'computer literacy' "
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub MatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriculaToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT * FROM Curso WHERE enrollment > 30 "
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub PromedioMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioMatriculaToolStripMenuItem.Click
        Dim Total As Double
        Total = Me.CursoTableAdapter.ScalarQuery_Avg_Enr()
        Label1.Visible = True
        Label1.Text = "Promedio de Matricula: " & Total




        Dim dt_Depto As New DataTable
        sqlstr = "SELECT course, classroom, schedule, enrollment FROM Curso"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto

    End Sub

    Private Sub CorreosElectronicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorreosElectronicosToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT faculty_name, email  FROM Facultad"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub PrepasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepasToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "SELECT * FROM Student WHERE schoolYear = 'senior'"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub PromedioGPAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioGPAToolStripMenuItem.Click
        Dim Total As Double
        Total = Me.StudentTableAdapter.Query_AVG_GPA_Student()
        Label1.Visible = True
        Label1.Text = "Promedio de GPA: " & Total



        Dim dt_Depto As New DataTable
        sqlstr = "SELECT student_name, gpa, major FROM Student"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto

    End Sub

    Private Sub PromedioCreditosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioCreditosToolStripMenuItem.Click
        Dim Total As Double
        Total = Me.StudentTableAdapter.Query_AVG_Cred_Student()
        Label1.Visible = True
        Label1.Text = "Promedio de Creditos: " & Total




        Dim dt_Depto As New DataTable
        sqlstr = "SELECT student_name, email, credits, schoolYear FROM Student"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto

    End Sub

    Private Sub GPAMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GPAMayorToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "Select * FROM Student WHERE gpa = (Select MAX(gpa) FROM student)"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub DatosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem3.Click
        Dim dt_Depto As New DataTable
        sqlstr = "Select * FROM StudentCurso"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub SumaDeDatos1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDeDatos1ToolStripMenuItem.Click
        Dim dt_Depto As New DataTable
        sqlstr = "Select * FROM StudentCurso WHERE major = 'CE'"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto
        Label1.Text = ""
    End Sub

    Private Sub SumaCreditosCSISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaCreditosCSISToolStripMenuItem.Click

        Dim Total As Double
        Total = Me.StudentCursoTableAdapter.Quere_SUM_CRED_STUDCURS()
        Label1.Visible = True
        Label1.Text = "Suma de Creditos: " & Total


        Dim dt_Depto As New DataTable
        sqlstr = "Select * FROM StudentCurso WHERE major = 'CS/IS'"
        connect_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DEPTO_COMP.mdb"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlstr, connect_str)
        dataAdapter.Fill(dt_Depto)
        DataGridView1.DataSource = dt_Depto

    End Sub
End Class
