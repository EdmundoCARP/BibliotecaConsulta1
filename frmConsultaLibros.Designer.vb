<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaLibros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblCategoria = New Label()
        cboCategoria = New ComboBox()
        dgvLibros = New DataGridView()
        ssEstado = New StatusStrip()
        lblRegistros = New ToolStripStatusLabel()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        txtCategoria = New TextBox()
        txtPrecio = New TextBox()
        txtBuscar = New TextBox()
        lblBuscar = New Label()
        txtaAnio = New TextBox()
        txtEjemplares = New TextBox()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        ssEstado.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(6, 4)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(41, 15)
        lblCategoria.TabIndex = 0
        lblCategoria.Text = "Label1"
        ' 
        ' cboCategoria
        ' 
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(53, 1)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(121, 23)
        cboCategoria.TabIndex = 1
        ' 
        ' dgvLibros
        ' 
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(263, 151)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(240, 150)
        dgvLibros.TabIndex = 2
        ' 
        ' ssEstado
        ' 
        ssEstado.Items.AddRange(New ToolStripItem() {lblRegistros})
        ssEstado.Location = New Point(0, 428)
        ssEstado.Name = "ssEstado"
        ssEstado.Size = New Size(800, 22)
        ssEstado.TabIndex = 3
        ssEstado.Text = "StatusStrip1"
        ' 
        ' lblRegistros
        ' 
        lblRegistros.Name = "lblRegistros"
        lblRegistros.Size = New Size(120, 17)
        lblRegistros.Text = "ToolStripStatusLabel1"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.BorderStyle = BorderStyle.FixedSingle
        txtTitulo.Location = New Point(262, 315)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.ReadOnly = True
        txtTitulo.Size = New Size(100, 23)
        txtTitulo.TabIndex = 4
        txtTitulo.TabStop = False
        ' 
        ' txtAutor
        ' 
        txtAutor.BorderStyle = BorderStyle.FixedSingle
        txtAutor.Location = New Point(393, 315)
        txtAutor.Name = "txtAutor"
        txtAutor.ReadOnly = True
        txtAutor.Size = New Size(100, 23)
        txtAutor.TabIndex = 5
        txtAutor.TabStop = False
        ' 
        ' txtCategoria
        ' 
        txtCategoria.BorderStyle = BorderStyle.FixedSingle
        txtCategoria.Location = New Point(263, 354)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.ReadOnly = True
        txtCategoria.Size = New Size(100, 23)
        txtCategoria.TabIndex = 6
        txtCategoria.TabStop = False
        ' 
        ' txtPrecio
        ' 
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Location = New Point(393, 354)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 7
        txtPrecio.TabStop = False
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(319, 122)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Escriba parte del titulo"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 8
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(219, 125)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(94, 15)
        lblBuscar.TabIndex = 9
        lblBuscar.Text = "Buscar por titulo"
        ' 
        ' txtaAnio
        ' 
        txtaAnio.BorderStyle = BorderStyle.FixedSingle
        txtaAnio.Location = New Point(262, 402)
        txtaAnio.Name = "txtaAnio"
        txtaAnio.ReadOnly = True
        txtaAnio.Size = New Size(100, 23)
        txtaAnio.TabIndex = 10
        txtaAnio.TabStop = False
        ' 
        ' txtEjemplares
        ' 
        txtEjemplares.BorderStyle = BorderStyle.FixedSingle
        txtEjemplares.Location = New Point(393, 402)
        txtEjemplares.Name = "txtEjemplares"
        txtEjemplares.ReadOnly = True
        txtEjemplares.Size = New Size(100, 23)
        txtEjemplares.TabIndex = 11
        txtEjemplares.TabStop = False
        ' 
        ' frmConsultaLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtEjemplares)
        Controls.Add(txtaAnio)
        Controls.Add(lblBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(txtPrecio)
        Controls.Add(txtCategoria)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(ssEstado)
        Controls.Add(dgvLibros)
        Controls.Add(cboCategoria)
        Controls.Add(lblCategoria)
        Name = "frmConsultaLibros"
        Text = "Form1"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ssEstado.ResumeLayout(False)
        ssEstado.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCategoria As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents ssEstado As StatusStrip
    Friend WithEvents lblRegistros As ToolStripStatusLabel
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtaAnio As TextBox
    Friend WithEvents txtEjemplares As TextBox

End Class
