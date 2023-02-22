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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblNights = New System.Windows.Forms.Label()
        Me.LblCost = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnCost = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtNumberOfNights = New System.Windows.Forms.TextBox()
        Me.LblCostNum = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(422, 452)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.Location = New System.Drawing.Point(447, 24)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(328, 48)
        Me.LblHeader.TabIndex = 1
        Me.LblHeader.Text = "Orlando AirBnB"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(518, 85)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(159, 17)
        Me.LblPrice.TabIndex = 2
        Me.LblPrice.Text = "Only $79.00 per night"
        '
        'LblNights
        '
        Me.LblNights.AutoSize = True
        Me.LblNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblNights.Location = New System.Drawing.Point(452, 145)
        Me.LblNights.Name = "LblNights"
        Me.LblNights.Size = New System.Drawing.Size(118, 17)
        Me.LblNights.TabIndex = 3
        Me.LblNights.Text = "Number of Nights"
        '
        'LblCost
        '
        Me.LblCost.AutoSize = True
        Me.LblCost.Location = New System.Drawing.Point(452, 225)
        Me.LblCost.Name = "LblCost"
        Me.LblCost.Size = New System.Drawing.Size(88, 17)
        Me.LblCost.TabIndex = 4
        Me.LblCost.Text = "Cost of Stay:"
        '
        'BtnClear
        '
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Location = New System.Drawing.Point(568, 301)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(99, 41)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnCost
        '
        Me.BtnCost.Location = New System.Drawing.Point(442, 301)
        Me.BtnCost.Name = "BtnCost"
        Me.BtnCost.Size = New System.Drawing.Size(98, 41)
        Me.BtnCost.TabIndex = 6
        Me.BtnCost.Text = "Display Cost"
        Me.BtnCost.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.Location = New System.Drawing.Point(690, 301)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(98, 41)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtNumberOfNights
        '
        Me.TxtNumberOfNights.Location = New System.Drawing.Point(655, 142)
        Me.TxtNumberOfNights.Multiline = True
        Me.TxtNumberOfNights.Name = "TxtNumberOfNights"
        Me.TxtNumberOfNights.Size = New System.Drawing.Size(22, 22)
        Me.TxtNumberOfNights.TabIndex = 8
        Me.TxtNumberOfNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCostNum
        '
        Me.LblCostNum.AutoSize = True
        Me.LblCostNum.Location = New System.Drawing.Point(652, 225)
        Me.LblCostNum.Name = "LblCostNum"
        Me.LblCostNum.Size = New System.Drawing.Size(44, 17)
        Me.LblCostNum.TabIndex = 9
        Me.LblCostNum.Text = "$0.00"
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblCostNum)
        Me.Controls.Add(Me.TxtNumberOfNights)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCost)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblCost)
        Me.Controls.Add(Me.LblNights)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblHeader As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents LblNights As Label
    Friend WithEvents LblCost As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnCost As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtNumberOfNights As TextBox
    Friend WithEvents LblCostNum As Label
End Class
