<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_main))
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.Btn_officer = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton3 = New C1.Win.C1Ribbon.RibbonButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem_exit = New DevExpress.XtraNavBar.NavBarItem()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonButton1 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton4 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton5 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup3 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonButton6 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton7 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup4 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonButton8 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton9 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton10 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton11 = New C1.Win.C1Ribbon.RibbonButton()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(929, 156)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup4)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup3)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "การจัดการ"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.Btn_officer)
        Me.RibbonGroup1.Items.Add(Me.RibbonButton2)
        Me.RibbonGroup1.Items.Add(Me.RibbonButton3)
        Me.RibbonGroup1.Items.Add(Me.RibbonButton10)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "การตั้งค่าระบบ"
        '
        'Btn_officer
        '
        Me.Btn_officer.LargeImage = CType(resources.GetObject("Btn_officer.LargeImage"), System.Drawing.Image)
        Me.Btn_officer.Name = "Btn_officer"
        Me.Btn_officer.SmallImage = CType(resources.GetObject("Btn_officer.SmallImage"), System.Drawing.Image)
        Me.Btn_officer.Text = "ผู้ใช้งาน"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.LargeImage = CType(resources.GetObject("RibbonButton2.LargeImage"), System.Drawing.Image)
        Me.RibbonButton2.Name = "RibbonButton2"
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "จัดการข้อมูลทั่วไป"
        '
        'RibbonButton3
        '
        Me.RibbonButton3.LargeImage = CType(resources.GetObject("RibbonButton3.LargeImage"), System.Drawing.Image)
        Me.RibbonButton3.Name = "RibbonButton3"
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "เพิ่มเติม"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(929, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelStatus
        '
        Me.ToolStripStatusLabelStatus.Name = "ToolStripStatusLabelStatus"
        Me.ToolStripStatusLabelStatus.Size = New System.Drawing.Size(147, 17)
        Me.ToolStripStatusLabelStatus.Text = "ToolStripStatusLabelStatus"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup
        Me.NavBarControl1.Appearance.Background.BackColor = System.Drawing.Color.White
        Me.NavBarControl1.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem_exit})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 156)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 140
        Me.NavBarControl1.Size = New System.Drawing.Size(140, 268)
        Me.NavBarControl1.TabIndex = 8
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Money Twins")
        '
        'NavBarGroup
        '
        Me.NavBarGroup.Caption = "ทางลัด"
        Me.NavBarGroup.Expanded = True
        Me.NavBarGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavBarGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.NavBarGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem_exit)})
        Me.NavBarGroup.LargeImage = CType(resources.GetObject("NavBarGroup.LargeImage"), System.Drawing.Image)
        Me.NavBarGroup.Name = "NavBarGroup"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "การเชื่อมต่อฐานข้อมูล"
        Me.NavBarItem1.LargeImage = CType(resources.GetObject("NavBarItem1.LargeImage"), System.Drawing.Image)
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "www.oag.go.th"
        Me.NavBarItem2.LargeImage = CType(resources.GetObject("NavBarItem2.LargeImage"), System.Drawing.Image)
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Intranet"
        Me.NavBarItem3.LargeImage = CType(resources.GetObject("NavBarItem3.LargeImage"), System.Drawing.Image)
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "DPIS"
        Me.NavBarItem4.LargeImage = CType(resources.GetObject("NavBarItem4.LargeImage"), System.Drawing.Image)
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'NavBarItem_exit
        '
        Me.NavBarItem_exit.Caption = "ออกจากโปรแกรม"
        Me.NavBarItem_exit.LargeImage = CType(resources.GetObject("NavBarItem_exit.LargeImage"), System.Drawing.Image)
        Me.NavBarItem_exit.Name = "NavBarItem_exit"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.RibbonButton1)
        Me.RibbonGroup2.Items.Add(Me.RibbonButton4)
        Me.RibbonGroup2.Items.Add(Me.RibbonButton5)
        Me.RibbonGroup2.Items.Add(Me.RibbonButton11)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "รายงาน"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.LargeImage = CType(resources.GetObject("RibbonButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "Button"
        '
        'RibbonButton4
        '
        Me.RibbonButton4.LargeImage = CType(resources.GetObject("RibbonButton4.LargeImage"), System.Drawing.Image)
        Me.RibbonButton4.Name = "RibbonButton4"
        Me.RibbonButton4.SmallImage = CType(resources.GetObject("RibbonButton4.SmallImage"), System.Drawing.Image)
        Me.RibbonButton4.Text = "Button"
        '
        'RibbonButton5
        '
        Me.RibbonButton5.LargeImage = CType(resources.GetObject("RibbonButton5.LargeImage"), System.Drawing.Image)
        Me.RibbonButton5.Name = "RibbonButton5"
        Me.RibbonButton5.SmallImage = CType(resources.GetObject("RibbonButton5.SmallImage"), System.Drawing.Image)
        Me.RibbonButton5.Text = "Button"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Items.Add(Me.RibbonButton6)
        Me.RibbonGroup3.Items.Add(Me.RibbonButton7)
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "การบริหารกรอบอัตรากำลัง"
        '
        'RibbonButton6
        '
        Me.RibbonButton6.LargeImage = CType(resources.GetObject("RibbonButton6.LargeImage"), System.Drawing.Image)
        Me.RibbonButton6.Name = "RibbonButton6"
        Me.RibbonButton6.SmallImage = CType(resources.GetObject("RibbonButton6.SmallImage"), System.Drawing.Image)
        Me.RibbonButton6.Text = "Button"
        '
        'RibbonButton7
        '
        Me.RibbonButton7.LargeImage = CType(resources.GetObject("RibbonButton7.LargeImage"), System.Drawing.Image)
        Me.RibbonButton7.Name = "RibbonButton7"
        Me.RibbonButton7.SmallImage = CType(resources.GetObject("RibbonButton7.SmallImage"), System.Drawing.Image)
        Me.RibbonButton7.Text = "Button"
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.Items.Add(Me.RibbonButton8)
        Me.RibbonGroup4.Items.Add(Me.RibbonButton9)
        Me.RibbonGroup4.Name = "RibbonGroup4"
        Me.RibbonGroup4.Text = "ข้อมูลลูกจ้าง"
        '
        'RibbonButton8
        '
        Me.RibbonButton8.LargeImage = CType(resources.GetObject("RibbonButton8.LargeImage"), System.Drawing.Image)
        Me.RibbonButton8.Name = "RibbonButton8"
        Me.RibbonButton8.SmallImage = CType(resources.GetObject("RibbonButton8.SmallImage"), System.Drawing.Image)
        Me.RibbonButton8.Text = "ลูกจ้างชั่วคราว"
        '
        'RibbonButton9
        '
        Me.RibbonButton9.LargeImage = CType(resources.GetObject("RibbonButton9.LargeImage"), System.Drawing.Image)
        Me.RibbonButton9.Name = "RibbonButton9"
        Me.RibbonButton9.SmallImage = CType(resources.GetObject("RibbonButton9.SmallImage"), System.Drawing.Image)
        Me.RibbonButton9.Text = "ลูกจ้างสมทบตรวจเงินแผ่นดิน"
        '
        'RibbonButton10
        '
        Me.RibbonButton10.LargeImage = CType(resources.GetObject("RibbonButton10.LargeImage"), System.Drawing.Image)
        Me.RibbonButton10.Name = "RibbonButton10"
        Me.RibbonButton10.SmallImage = CType(resources.GetObject("RibbonButton10.SmallImage"), System.Drawing.Image)
        Me.RibbonButton10.Text = "เกี่ยวกับระบบ"
        '
        'RibbonButton11
        '
        Me.RibbonButton11.LargeImage = CType(resources.GetObject("RibbonButton11.LargeImage"), System.Drawing.Image)
        Me.RibbonButton11.Name = "RibbonButton11"
        Me.RibbonButton11.SmallImage = CType(resources.GetObject("RibbonButton11.SmallImage"), System.Drawing.Image)
        Me.RibbonButton11.Text = "ประวัติการใช้งาน"
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(929, 446)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารกรอบอัตรากำลังลูกจ้างภาครัฐ กรณีศึกษาสำนักงานการตรวจเงินแผ่นดิน"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Btn_officer As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton3 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents ToolStripStatusLabelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem_exit As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton1 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton4 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton5 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup3 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton6 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton7 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup4 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton8 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton9 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton10 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton11 As C1.Win.C1Ribbon.RibbonButton

End Class
