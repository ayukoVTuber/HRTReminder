<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reminder
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(reminder))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-11, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(370, 301)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cocogoose Pro Light", 24F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(443, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 38)
        Label1.TabIndex = 1
        Label1.Text = "Time to take your HRT! :3"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(594, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 32)
        Button1.TabIndex = 2
        Button1.Text = "I took it -w-"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' reminder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(4), CByte(2), CByte(4))
        ClientSize = New Size(966, 277)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "reminder"
        Text = "Reminder to take your HRT :3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
