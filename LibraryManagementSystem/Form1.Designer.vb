<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DgvBooks = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublished = New TextBox()
        txtGenre = New TextBox()
        CType(DgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(111, 258)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(211, 258)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 2
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(325, 258)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 3
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DgvBooks
        ' 
        DgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvBooks.Location = New Point(488, 28)
        DgvBooks.Name = "DgvBooks"
        DgvBooks.RowHeadersWidth = 51
        DgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvBooks.Size = New Size(300, 188)
        DgvBooks.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 5
        Label1.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 6
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(97, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 7
        Label3.Text = "Year Published"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 8
        Label4.Text = "Genre"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(202, 21)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(125, 27)
        txtTitle.TabIndex = 9
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(202, 61)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(125, 27)
        txtAuthor.TabIndex = 10
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(202, 104)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(125, 27)
        txtYearPublished.TabIndex = 11
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(202, 147)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGenre)
        Controls.Add(txtYearPublished)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DgvBooks)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(DgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DgvBooks As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox

End Class
