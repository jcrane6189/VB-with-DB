<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LaTablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalonEspecificoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoEspecificoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromedioMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreosElectronicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaFuncionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromedioGPAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromedioCreditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPAMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumaDeDatos1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DEPTO_COMPDataSet_Facultad = New Tarea_Programa_3.DEPTO_COMPDataSet_Facultad()
        Me.FacultadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacultadTableAdapter = New Tarea_Programa_3.DEPTO_COMPDataSet_FacultadTableAdapters.FacultadTableAdapter()
        Me.DEPTO_COMPDataSet_Student = New Tarea_Programa_3.DEPTO_COMPDataSet_Student()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New Tarea_Programa_3.DEPTO_COMPDataSet_StudentTableAdapters.StudentTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DEPTO_COMPDataset_Curso = New Tarea_Programa_3.DEPTO_COMPDataset_Curso()
        Me.CursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursoTableAdapter = New Tarea_Programa_3.DEPTO_COMPDataset_CursoTableAdapters.CursoTableAdapter()
        Me.DEPTO_COMPDataSet_StudentCurso = New Tarea_Programa_3.DEPTO_COMPDataSet_StudentCurso()
        Me.StudentCursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentCursoTableAdapter = New Tarea_Programa_3.DEPTO_COMPDataSet_StudentCursoTableAdapters.StudentCursoTableAdapter()
        Me.SumaCreditosCSISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPTO_COMPDataSet_Facultad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPTO_COMPDataSet_Student, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPTO_COMPDataset_Curso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPTO_COMPDataSet_StudentCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentCursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaTablaToolStripMenuItem, Me.ElQueryToolStripMenuItem, Me.LaFuncionToolStripMenuItem, Me.CursoStudentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(870, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LaTablaToolStripMenuItem
        '
        Me.LaTablaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.SalonEspecificoToolStripMenuItem, Me.CursoEspecificoToolStripMenuItem, Me.MatriculaToolStripMenuItem, Me.PromedioMatriculaToolStripMenuItem})
        Me.LaTablaToolStripMenuItem.Name = "LaTablaToolStripMenuItem"
        Me.LaTablaToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.LaTablaToolStripMenuItem.Text = "Tabla Curso"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'SalonEspecificoToolStripMenuItem
        '
        Me.SalonEspecificoToolStripMenuItem.Name = "SalonEspecificoToolStripMenuItem"
        Me.SalonEspecificoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SalonEspecificoToolStripMenuItem.Text = "Salon TC-109"
        '
        'CursoEspecificoToolStripMenuItem
        '
        Me.CursoEspecificoToolStripMenuItem.Name = "CursoEspecificoToolStripMenuItem"
        Me.CursoEspecificoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CursoEspecificoToolStripMenuItem.Text = "Curso Computer Lit."
        '
        'MatriculaToolStripMenuItem
        '
        Me.MatriculaToolStripMenuItem.Name = "MatriculaToolStripMenuItem"
        Me.MatriculaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MatriculaToolStripMenuItem.Text = "Matricula > 30"
        '
        'PromedioMatriculaToolStripMenuItem
        '
        Me.PromedioMatriculaToolStripMenuItem.Name = "PromedioMatriculaToolStripMenuItem"
        Me.PromedioMatriculaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PromedioMatriculaToolStripMenuItem.Text = "Promedio Matricula"
        '
        'ElQueryToolStripMenuItem
        '
        Me.ElQueryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem1, Me.CorreosElectronicosToolStripMenuItem})
        Me.ElQueryToolStripMenuItem.Name = "ElQueryToolStripMenuItem"
        Me.ElQueryToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ElQueryToolStripMenuItem.Text = "Tabla Facultad"
        '
        'DatosToolStripMenuItem1
        '
        Me.DatosToolStripMenuItem1.Name = "DatosToolStripMenuItem1"
        Me.DatosToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.DatosToolStripMenuItem1.Text = "Datos "
        '
        'CorreosElectronicosToolStripMenuItem
        '
        Me.CorreosElectronicosToolStripMenuItem.Name = "CorreosElectronicosToolStripMenuItem"
        Me.CorreosElectronicosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CorreosElectronicosToolStripMenuItem.Text = "Correos Electronicos"
        '
        'LaFuncionToolStripMenuItem
        '
        Me.LaFuncionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem2, Me.PrepasToolStripMenuItem, Me.PromedioGPAToolStripMenuItem, Me.PromedioCreditosToolStripMenuItem, Me.GPAMayorToolStripMenuItem})
        Me.LaFuncionToolStripMenuItem.Name = "LaFuncionToolStripMenuItem"
        Me.LaFuncionToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.LaFuncionToolStripMenuItem.Text = "Tabla Estudiante"
        '
        'DatosToolStripMenuItem2
        '
        Me.DatosToolStripMenuItem2.Name = "DatosToolStripMenuItem2"
        Me.DatosToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.DatosToolStripMenuItem2.Text = "Datos"
        '
        'PrepasToolStripMenuItem
        '
        Me.PrepasToolStripMenuItem.Name = "PrepasToolStripMenuItem"
        Me.PrepasToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PrepasToolStripMenuItem.Text = "Estudiantes Senior"
        '
        'PromedioGPAToolStripMenuItem
        '
        Me.PromedioGPAToolStripMenuItem.Name = "PromedioGPAToolStripMenuItem"
        Me.PromedioGPAToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PromedioGPAToolStripMenuItem.Text = "Promedio GPA"
        '
        'PromedioCreditosToolStripMenuItem
        '
        Me.PromedioCreditosToolStripMenuItem.Name = "PromedioCreditosToolStripMenuItem"
        Me.PromedioCreditosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PromedioCreditosToolStripMenuItem.Text = "Promedio Creditos"
        '
        'GPAMayorToolStripMenuItem
        '
        Me.GPAMayorToolStripMenuItem.Name = "GPAMayorToolStripMenuItem"
        Me.GPAMayorToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.GPAMayorToolStripMenuItem.Text = "GPA Mayor"
        '
        'CursoStudentToolStripMenuItem
        '
        Me.CursoStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem3, Me.SumaDeDatos1ToolStripMenuItem, Me.SumaCreditosCSISToolStripMenuItem})
        Me.CursoStudentToolStripMenuItem.Name = "CursoStudentToolStripMenuItem"
        Me.CursoStudentToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.CursoStudentToolStripMenuItem.Text = "CursoStudent"
        '
        'DatosToolStripMenuItem3
        '
        Me.DatosToolStripMenuItem3.Name = "DatosToolStripMenuItem3"
        Me.DatosToolStripMenuItem3.Size = New System.Drawing.Size(163, 22)
        Me.DatosToolStripMenuItem3.Text = "Datos"
        '
        'SumaDeDatos1ToolStripMenuItem
        '
        Me.SumaDeDatos1ToolStripMenuItem.Name = "SumaDeDatos1ToolStripMenuItem"
        Me.SumaDeDatos1ToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SumaDeDatos1ToolStripMenuItem.Text = "Concentracion CE"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(842, 286)
        Me.DataGridView1.TabIndex = 1
        '
        'DEPTO_COMPDataSet_Facultad
        '
        Me.DEPTO_COMPDataSet_Facultad.DataSetName = "DEPTO_COMPDataSet_Facultad"
        Me.DEPTO_COMPDataSet_Facultad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacultadBindingSource
        '
        Me.FacultadBindingSource.DataMember = "Facultad"
        Me.FacultadBindingSource.DataSource = Me.DEPTO_COMPDataSet_Facultad
        '
        'FacultadTableAdapter
        '
        Me.FacultadTableAdapter.ClearBeforeFill = True
        '
        'DEPTO_COMPDataSet_Student
        '
        Me.DEPTO_COMPDataSet_Student.DataSetName = "DEPTO_COMPDataSet_Student"
        Me.DEPTO_COMPDataSet_Student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.DEPTO_COMPDataSet_Student
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(12, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'DEPTO_COMPDataset_Curso
        '
        Me.DEPTO_COMPDataset_Curso.DataSetName = "DEPTO_COMPDataset_Curso"
        Me.DEPTO_COMPDataset_Curso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CursoBindingSource
        '
        Me.CursoBindingSource.DataMember = "Curso"
        Me.CursoBindingSource.DataSource = Me.DEPTO_COMPDataset_Curso
        '
        'CursoTableAdapter
        '
        Me.CursoTableAdapter.ClearBeforeFill = True
        '
        'DEPTO_COMPDataSet_StudentCurso
        '
        Me.DEPTO_COMPDataSet_StudentCurso.DataSetName = "DEPTO_COMPDataSet_StudentCurso"
        Me.DEPTO_COMPDataSet_StudentCurso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentCursoBindingSource
        '
        Me.StudentCursoBindingSource.DataMember = "StudentCurso"
        Me.StudentCursoBindingSource.DataSource = Me.DEPTO_COMPDataSet_StudentCurso
        '
        'StudentCursoTableAdapter
        '
        Me.StudentCursoTableAdapter.ClearBeforeFill = True
        '
        'SumaCreditosCSISToolStripMenuItem
        '
        Me.SumaCreditosCSISToolStripMenuItem.Name = "SumaCreditosCSISToolStripMenuItem"
        Me.SumaCreditosCSISToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SumaCreditosCSISToolStripMenuItem.Text = "Suma Creditos CS/IS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 359)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPTO_COMPDataSet_Facultad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPTO_COMPDataSet_Student, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPTO_COMPDataset_Curso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPTO_COMPDataSet_StudentCurso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentCursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LaTablaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElQueryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaFuncionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DEPTO_COMPDataset_Curso As DEPTO_COMPDataset_Curso
    Friend WithEvents CursoBindingSource As BindingSource
    Friend WithEvents CursoTableAdapter As DEPTO_COMPDataset_CursoTableAdapters.CursoTableAdapter
    Friend WithEvents DEPTO_COMPDataSet_Facultad As DEPTO_COMPDataSet_Facultad
    Friend WithEvents FacultadBindingSource As BindingSource
    Friend WithEvents FacultadTableAdapter As DEPTO_COMPDataSet_FacultadTableAdapters.FacultadTableAdapter
    Friend WithEvents DEPTO_COMPDataSet_Student As DEPTO_COMPDataSet_Student
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As DEPTO_COMPDataSet_StudentTableAdapters.StudentTableAdapter
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalonEspecificoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursoEspecificoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromedioMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CorreosElectronicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PrepasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromedioGPAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromedioCreditosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GPAMayorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursoStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents SumaDeDatos1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DEPTO_COMPDataSet_StudentCurso As DEPTO_COMPDataSet_StudentCurso
    Friend WithEvents StudentCursoBindingSource As BindingSource
    Friend WithEvents StudentCursoTableAdapter As DEPTO_COMPDataSet_StudentCursoTableAdapters.StudentCursoTableAdapter
    Friend WithEvents SumaCreditosCSISToolStripMenuItem As ToolStripMenuItem
End Class
