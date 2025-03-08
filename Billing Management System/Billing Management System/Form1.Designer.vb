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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumItem = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numMilk = New System.Windows.Forms.NumericUpDown()
        Me.txtMilk = New System.Windows.Forms.TextBox()
        Me.lblItemMilk = New System.Windows.Forms.Label()
        Me.numWine = New System.Windows.Forms.NumericUpDown()
        Me.txtWine = New System.Windows.Forms.TextBox()
        Me.lblItemWine = New System.Windows.Forms.Label()
        Me.numBeans = New System.Windows.Forms.NumericUpDown()
        Me.txtBeans = New System.Windows.Forms.TextBox()
        Me.lblItemBeans = New System.Windows.Forms.Label()
        Me.numRice = New System.Windows.Forms.NumericUpDown()
        Me.txtRice = New System.Windows.Forms.TextBox()
        Me.lblItemRice = New System.Windows.Forms.Label()
        Me.numBread = New System.Windows.Forms.NumericUpDown()
        Me.txtBread = New System.Windows.Forms.TextBox()
        Me.lblItemBread = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rtReceipt = New System.Windows.Forms.RichTextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.numMilk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBeans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtNumItem)
        Me.Panel2.Controls.Add(Me.txtTotalCost)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.numMilk)
        Me.Panel2.Controls.Add(Me.txtMilk)
        Me.Panel2.Controls.Add(Me.lblItemMilk)
        Me.Panel2.Controls.Add(Me.numWine)
        Me.Panel2.Controls.Add(Me.txtWine)
        Me.Panel2.Controls.Add(Me.lblItemWine)
        Me.Panel2.Controls.Add(Me.numBeans)
        Me.Panel2.Controls.Add(Me.txtBeans)
        Me.Panel2.Controls.Add(Me.lblItemBeans)
        Me.Panel2.Controls.Add(Me.numRice)
        Me.Panel2.Controls.Add(Me.txtRice)
        Me.Panel2.Controls.Add(Me.lblItemRice)
        Me.Panel2.Controls.Add(Me.numBread)
        Me.Panel2.Controls.Add(Me.txtBread)
        Me.Panel2.Controls.Add(Me.lblItemBread)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(14, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 369)
        Me.Panel2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 35)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Total Cost"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumItem
        '
        Me.txtNumItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumItem.Location = New System.Drawing.Point(169, 313)
        Me.txtNumItem.Multiline = True
        Me.txtNumItem.Name = "txtNumItem"
        Me.txtNumItem.ReadOnly = True
        Me.txtNumItem.Size = New System.Drawing.Size(155, 35)
        Me.txtNumItem.TabIndex = 24
        Me.txtNumItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(345, 313)
        Me.txtTotalCost.Multiline = True
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(138, 35)
        Me.txtTotalCost.TabIndex = 23
        Me.txtTotalCost.Text = "₱0.00"
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(345, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 35)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Cost Item"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(45, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 35)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Items"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(175, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 35)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Number of Items"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 35)
        Me.Label7.TabIndex = 19
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numMilk
        '
        Me.numMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMilk.Location = New System.Drawing.Point(179, 263)
        Me.numMilk.Name = "numMilk"
        Me.numMilk.Size = New System.Drawing.Size(145, 35)
        Me.numMilk.TabIndex = 18
        Me.numMilk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMilk
        '
        Me.txtMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMilk.Location = New System.Drawing.Point(345, 261)
        Me.txtMilk.Multiline = True
        Me.txtMilk.Name = "txtMilk"
        Me.txtMilk.ReadOnly = True
        Me.txtMilk.Size = New System.Drawing.Size(138, 35)
        Me.txtMilk.TabIndex = 17
        Me.txtMilk.Text = "₱0.00"
        Me.txtMilk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemMilk
        '
        Me.lblItemMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemMilk.Location = New System.Drawing.Point(45, 261)
        Me.lblItemMilk.Name = "lblItemMilk"
        Me.lblItemMilk.Size = New System.Drawing.Size(71, 35)
        Me.lblItemMilk.TabIndex = 16
        Me.lblItemMilk.Text = "Milk"
        Me.lblItemMilk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numWine
        '
        Me.numWine.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numWine.Location = New System.Drawing.Point(179, 205)
        Me.numWine.Name = "numWine"
        Me.numWine.Size = New System.Drawing.Size(145, 35)
        Me.numWine.TabIndex = 15
        Me.numWine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWine
        '
        Me.txtWine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWine.Location = New System.Drawing.Point(345, 203)
        Me.txtWine.Multiline = True
        Me.txtWine.Name = "txtWine"
        Me.txtWine.ReadOnly = True
        Me.txtWine.Size = New System.Drawing.Size(138, 35)
        Me.txtWine.TabIndex = 14
        Me.txtWine.Text = "₱0.00"
        Me.txtWine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemWine
        '
        Me.lblItemWine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemWine.Location = New System.Drawing.Point(45, 203)
        Me.lblItemWine.Name = "lblItemWine"
        Me.lblItemWine.Size = New System.Drawing.Size(71, 35)
        Me.lblItemWine.TabIndex = 13
        Me.lblItemWine.Text = "Wine"
        Me.lblItemWine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numBeans
        '
        Me.numBeans.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBeans.Location = New System.Drawing.Point(179, 155)
        Me.numBeans.Name = "numBeans"
        Me.numBeans.Size = New System.Drawing.Size(145, 35)
        Me.numBeans.TabIndex = 12
        Me.numBeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBeans
        '
        Me.txtBeans.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeans.Location = New System.Drawing.Point(345, 153)
        Me.txtBeans.Multiline = True
        Me.txtBeans.Name = "txtBeans"
        Me.txtBeans.ReadOnly = True
        Me.txtBeans.Size = New System.Drawing.Size(138, 35)
        Me.txtBeans.TabIndex = 11
        Me.txtBeans.Text = "₱0.00"
        Me.txtBeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemBeans
        '
        Me.lblItemBeans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemBeans.Location = New System.Drawing.Point(45, 153)
        Me.lblItemBeans.Name = "lblItemBeans"
        Me.lblItemBeans.Size = New System.Drawing.Size(71, 35)
        Me.lblItemBeans.TabIndex = 10
        Me.lblItemBeans.Text = "Beans"
        Me.lblItemBeans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numRice
        '
        Me.numRice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numRice.Location = New System.Drawing.Point(179, 96)
        Me.numRice.Name = "numRice"
        Me.numRice.Size = New System.Drawing.Size(145, 35)
        Me.numRice.TabIndex = 9
        Me.numRice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRice
        '
        Me.txtRice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRice.Location = New System.Drawing.Point(345, 94)
        Me.txtRice.Multiline = True
        Me.txtRice.Name = "txtRice"
        Me.txtRice.ReadOnly = True
        Me.txtRice.Size = New System.Drawing.Size(138, 35)
        Me.txtRice.TabIndex = 8
        Me.txtRice.Text = "₱0.00"
        Me.txtRice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemRice
        '
        Me.lblItemRice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemRice.Location = New System.Drawing.Point(45, 94)
        Me.lblItemRice.Name = "lblItemRice"
        Me.lblItemRice.Size = New System.Drawing.Size(71, 35)
        Me.lblItemRice.TabIndex = 7
        Me.lblItemRice.Text = "Rice"
        Me.lblItemRice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numBread
        '
        Me.numBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBread.Location = New System.Drawing.Point(179, 39)
        Me.numBread.Name = "numBread"
        Me.numBread.Size = New System.Drawing.Size(145, 35)
        Me.numBread.TabIndex = 6
        Me.numBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBread
        '
        Me.txtBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBread.Location = New System.Drawing.Point(345, 37)
        Me.txtBread.Multiline = True
        Me.txtBread.Name = "txtBread"
        Me.txtBread.ReadOnly = True
        Me.txtBread.Size = New System.Drawing.Size(138, 35)
        Me.txtBread.TabIndex = 5
        Me.txtBread.Text = "₱0.00"
        Me.txtBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemBread
        '
        Me.lblItemBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemBread.Location = New System.Drawing.Point(45, 37)
        Me.lblItemBread.Name = "lblItemBread"
        Me.lblItemBread.Size = New System.Drawing.Size(71, 35)
        Me.lblItemBread.TabIndex = 4
        Me.lblItemBread.Text = "Bread"
        Me.lblItemBread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Location = New System.Drawing.Point(26, 375)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(419, 51)
        Me.Panel5.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.rtReceipt)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(544, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 369)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(957, 51)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label1.Location = New System.Drawing.Point(166, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 541)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.btnExit)
        Me.Panel6.Controls.Add(Me.btnReset)
        Me.Panel6.Controls.Add(Me.btnReceipt)
        Me.Panel6.Controls.Add(Me.btnTotal)
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(14, 436)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(943, 90)
        Me.Panel6.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CadetBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(749, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 59)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.CadetBlue
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(513, 15)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(190, 59)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.CadetBlue
        Me.btnReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.Location = New System.Drawing.Point(255, 15)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(209, 59)
        Me.btnReceipt.TabIndex = 1
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.CadetBlue
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(17, 15)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(190, 59)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(140, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 35)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Cost Item"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtReceipt
        '
        Me.rtReceipt.AccessibleDescription = "Billing Management System"
        Me.rtReceipt.AccessibleName = ""
        Me.rtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtReceipt.Location = New System.Drawing.Point(18, 36)
        Me.rtReceipt.Name = "rtReceipt"
        Me.rtReceipt.ReadOnly = True
        Me.rtReceipt.Size = New System.Drawing.Size(373, 309)
        Me.rtReceipt.TabIndex = 24
        Me.rtReceipt.Text = "Billing Management System"
        '
        'Form1
        '
        Me.AccessibleDescription = "Billing Management System"
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Management System"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.numMilk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBeans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBread As TextBox
    Friend WithEvents lblItemBread As Label
    Friend WithEvents numBread As NumericUpDown
    Friend WithEvents numMilk As NumericUpDown
    Friend WithEvents txtMilk As TextBox
    Friend WithEvents lblItemMilk As Label
    Friend WithEvents numWine As NumericUpDown
    Friend WithEvents txtWine As TextBox
    Friend WithEvents lblItemWine As Label
    Friend WithEvents numBeans As NumericUpDown
    Friend WithEvents txtBeans As TextBox
    Friend WithEvents lblItemBeans As Label
    Friend WithEvents numRice As NumericUpDown
    Friend WithEvents txtRice As TextBox
    Friend WithEvents lblItemRice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNumItem As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rtReceipt As RichTextBox
End Class
