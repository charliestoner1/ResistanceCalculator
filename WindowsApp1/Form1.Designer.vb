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
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgLoad = New System.Windows.Forms.OpenFileDialog()
        Me.Resi = New System.Windows.Forms.GroupBox()
        Me.lvwResistors = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxBranch = New System.Windows.Forms.GroupBox()
        Me.lblBranchCount = New System.Windows.Forms.Label()
        Me.lblBranchResistance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCircuitCount = New System.Windows.Forms.Label()
        Me.lblCircuitResistance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.Resi.SuspendLayout()
        Me.gbxBranch.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgLoad
        '
        Me.dlgLoad.FileName = "OpenFileDialog1"
        '
        'Resi
        '
        Me.Resi.Controls.Add(Me.lvwResistors)
        Me.Resi.Location = New System.Drawing.Point(22, 82)
        Me.Resi.Name = "Resi"
        Me.Resi.Size = New System.Drawing.Size(506, 305)
        Me.Resi.TabIndex = 0
        Me.Resi.TabStop = False
        Me.Resi.Text = "Resistors"
        '
        'lvwResistors
        '
        Me.lvwResistors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwResistors.FullRowSelect = True
        Me.lvwResistors.GridLines = True
        Me.lvwResistors.HideSelection = False
        Me.lvwResistors.Location = New System.Drawing.Point(27, 42)
        Me.lvwResistors.Name = "lvwResistors"
        Me.lvwResistors.Size = New System.Drawing.Size(453, 234)
        Me.lvwResistors.TabIndex = 0
        Me.lvwResistors.UseCompatibleStateImageBehavior = False
        Me.lvwResistors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "R1"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "R2"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "R3"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "R4"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "R5"
        '
        'gbxBranch
        '
        Me.gbxBranch.Controls.Add(Me.lblBranchCount)
        Me.gbxBranch.Controls.Add(Me.lblBranchResistance)
        Me.gbxBranch.Controls.Add(Me.Label2)
        Me.gbxBranch.Controls.Add(Me.Label1)
        Me.gbxBranch.Enabled = False
        Me.gbxBranch.Location = New System.Drawing.Point(568, 82)
        Me.gbxBranch.Name = "gbxBranch"
        Me.gbxBranch.Size = New System.Drawing.Size(362, 147)
        Me.gbxBranch.TabIndex = 1
        Me.gbxBranch.TabStop = False
        Me.gbxBranch.Text = "Branch"
        '
        'lblBranchCount
        '
        Me.lblBranchCount.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBranchCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBranchCount.Location = New System.Drawing.Point(240, 86)
        Me.lblBranchCount.Name = "lblBranchCount"
        Me.lblBranchCount.Size = New System.Drawing.Size(100, 43)
        Me.lblBranchCount.TabIndex = 3
        Me.lblBranchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBranchResistance
        '
        Me.lblBranchResistance.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBranchResistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBranchResistance.Location = New System.Drawing.Point(240, 31)
        Me.lblBranchResistance.Name = "lblBranchResistance"
        Me.lblBranchResistance.Size = New System.Drawing.Size(100, 43)
        Me.lblBranchResistance.TabIndex = 2
        Me.lblBranchResistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Resistors"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch Resistance (Ohms)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCircuitCount)
        Me.GroupBox2.Controls.Add(Me.lblCircuitResistance)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(568, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 152)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Circuit"
        '
        'lblCircuitCount
        '
        Me.lblCircuitCount.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblCircuitCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCircuitCount.Location = New System.Drawing.Point(240, 91)
        Me.lblCircuitCount.Name = "lblCircuitCount"
        Me.lblCircuitCount.Size = New System.Drawing.Size(100, 43)
        Me.lblCircuitCount.TabIndex = 5
        Me.lblCircuitCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCircuitResistance
        '
        Me.lblCircuitResistance.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblCircuitResistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCircuitResistance.Location = New System.Drawing.Point(240, 31)
        Me.lblCircuitResistance.Name = "lblCircuitResistance"
        Me.lblCircuitResistance.Size = New System.Drawing.Size(100, 43)
        Me.lblCircuitResistance.TabIndex = 4
        Me.lblCircuitResistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Resistors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Resistance (Ohms)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 33)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileLoad, Me.mnuFileSave})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 29)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'mnuFileLoad
        '
        Me.mnuFileLoad.Name = "mnuFileLoad"
        Me.mnuFileLoad.Size = New System.Drawing.Size(153, 34)
        Me.mnuFileLoad.Text = "Load"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(153, 34)
        Me.mnuFileSave.Tag = ""
        Me.mnuFileSave.Text = "Save"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 442)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxBranch)
        Me.Controls.Add(Me.Resi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Resi.ResumeLayout(False)
        Me.gbxBranch.ResumeLayout(False)
        Me.gbxBranch.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents dlgLoad As OpenFileDialog
    Friend WithEvents Resi As GroupBox
    Friend WithEvents gbxBranch As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuFileLoad As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents lvwResistors As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lblBranchCount As Label
    Friend WithEvents lblBranchResistance As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCircuitCount As Label
    Friend WithEvents lblCircuitResistance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
