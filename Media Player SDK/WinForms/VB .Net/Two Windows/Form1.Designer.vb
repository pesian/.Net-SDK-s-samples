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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim VideoRendererSettingsWinForms1 As VisioForge.Types.VideoRendererSettingsWinForms = New VisioForge.Types.VideoRendererSettingsWinForms()
        Me.label14 = New System.Windows.Forms.Label()
        Me.btSelectFile = New System.Windows.Forms.Button()
        Me.edFilename = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btNextFrame = New System.Windows.Forms.Button()
        Me.btStop = New System.Windows.Forms.Button()
        Me.btPause = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.btStart = New System.Windows.Forms.Button()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.label16 = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.tbTimeline = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbBalance1 = New System.Windows.Forms.TrackBar()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tbVolume1 = New System.Windows.Forms.TrackBar()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MediaPlayer1 = New VisioForge.Controls.UI.WinForms.MediaPlayer()
        Me.groupBox2.SuspendLayout
        CType(Me.tbSpeed,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbTimeline,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.tbBalance1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbVolume1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'label14
        '
        Me.label14.AutoSize = true
        Me.label14.Location = New System.Drawing.Point(12, 9)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(79, 13)
        Me.label14.TabIndex = 27
        Me.label14.Text = "Video file name"
        '
        'btSelectFile
        '
        Me.btSelectFile.Location = New System.Drawing.Point(408, 23)
        Me.btSelectFile.Name = "btSelectFile"
        Me.btSelectFile.Size = New System.Drawing.Size(23, 23)
        Me.btSelectFile.TabIndex = 26
        Me.btSelectFile.Text = "..."
        Me.btSelectFile.UseVisualStyleBackColor = true
        '
        'edFilename
        '
        Me.edFilename.Location = New System.Drawing.Point(15, 25)
        Me.edFilename.Name = "edFilename"
        Me.edFilename.Size = New System.Drawing.Size(387, 20)
        Me.edFilename.TabIndex = 25
        Me.edFilename.Text = "c:\1.avi"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btNextFrame)
        Me.groupBox2.Controls.Add(Me.btStop)
        Me.groupBox2.Controls.Add(Me.btPause)
        Me.groupBox2.Controls.Add(Me.btResume)
        Me.groupBox2.Controls.Add(Me.btStart)
        Me.groupBox2.Controls.Add(Me.tbSpeed)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.lbTime)
        Me.groupBox2.Controls.Add(Me.tbTimeline)
        Me.groupBox2.Location = New System.Drawing.Point(15, 61)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(416, 90)
        Me.groupBox2.TabIndex = 28
        Me.groupBox2.TabStop = false
        Me.groupBox2.Text = "Controls"
        '
        'btNextFrame
        '
        Me.btNextFrame.Location = New System.Drawing.Point(249, 58)
        Me.btNextFrame.Name = "btNextFrame"
        Me.btNextFrame.Size = New System.Drawing.Size(75, 23)
        Me.btNextFrame.TabIndex = 8
        Me.btNextFrame.Text = "Next frame"
        Me.btNextFrame.UseVisualStyleBackColor = true
        '
        'btStop
        '
        Me.btStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStop.Location = New System.Drawing.Point(180, 58)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(46, 23)
        Me.btStop.TabIndex = 7
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = true
        '
        'btPause
        '
        Me.btPause.Location = New System.Drawing.Point(122, 58)
        Me.btPause.Name = "btPause"
        Me.btPause.Size = New System.Drawing.Size(52, 23)
        Me.btPause.TabIndex = 6
        Me.btPause.Text = "Pause"
        Me.btPause.UseVisualStyleBackColor = true
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(55, 58)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(61, 23)
        Me.btResume.TabIndex = 5
        Me.btResume.Text = "Resume"
        Me.btResume.UseVisualStyleBackColor = true
        '
        'btStart
        '
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStart.Location = New System.Drawing.Point(6, 58)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(43, 23)
        Me.btStart.TabIndex = 4
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = true
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(321, 27)
        Me.tbSpeed.Maximum = 25
        Me.tbSpeed.Minimum = 5
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(89, 45)
        Me.tbSpeed.TabIndex = 3
        Me.tbSpeed.Value = 10
        '
        'label16
        '
        Me.label16.AutoSize = true
        Me.label16.Location = New System.Drawing.Point(322, 11)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(38, 13)
        Me.label16.TabIndex = 2
        Me.label16.Text = "Speed"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = true
        Me.lbTime.Location = New System.Drawing.Point(219, 27)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(96, 13)
        Me.lbTime.TabIndex = 1
        Me.lbTime.Text = "00:00:00/00:00:00"
        '
        'tbTimeline
        '
        Me.tbTimeline.Location = New System.Drawing.Point(6, 19)
        Me.tbTimeline.Maximum = 100
        Me.tbTimeline.Name = "tbTimeline"
        Me.tbTimeline.Size = New System.Drawing.Size(207, 45)
        Me.tbTimeline.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.tbBalance1)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.tbVolume1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 100)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Audio output"
        '
        'label7
        '
        Me.label7.AutoSize = true
        Me.label7.Location = New System.Drawing.Point(109, 22)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(46, 13)
        Me.label7.TabIndex = 11
        Me.label7.Text = "Balance"
        '
        'tbBalance1
        '
        Me.tbBalance1.BackColor = System.Drawing.SystemColors.Window
        Me.tbBalance1.Location = New System.Drawing.Point(112, 38)
        Me.tbBalance1.Maximum = 100
        Me.tbBalance1.Minimum = -100
        Me.tbBalance1.Name = "tbBalance1"
        Me.tbBalance1.Size = New System.Drawing.Size(85, 45)
        Me.tbBalance1.TabIndex = 10
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(16, 22)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 9
        Me.label6.Text = "Volume"
        '
        'tbVolume1
        '
        Me.tbVolume1.BackColor = System.Drawing.SystemColors.Window
        Me.tbVolume1.Location = New System.Drawing.Point(19, 38)
        Me.tbVolume1.Maximum = 100
        Me.tbVolume1.Minimum = 20
        Me.tbVolume1.Name = "tbVolume1"
        Me.tbVolume1.Size = New System.Drawing.Size(85, 45)
        Me.tbVolume1.TabIndex = 8
        Me.tbVolume1.Value = 80
        '
        'timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(577, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Much more features shown in Main Demo!"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Location = New System.Drawing.Point(321, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Watch video tutorials!"
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Audio_Channel_Mapper = Nothing
        Me.MediaPlayer1.Audio_Effects_Enabled = false
        Me.MediaPlayer1.Audio_Effects_UseLegacyEffects = false
        Me.MediaPlayer1.Audio_Enhancer_Enabled = false
        Me.MediaPlayer1.Audio_OutputDevice = ""
        Me.MediaPlayer1.Audio_PlayAudio = false
        Me.MediaPlayer1.Audio_Sample_Grabber_Enabled = false
        Me.MediaPlayer1.Audio_VUMeter_Enabled = false
        Me.MediaPlayer1.Audio_VUMeter_Pro_Enabled = false
        Me.MediaPlayer1.Audio_VUMeter_Pro_Volume = 0
        Me.MediaPlayer1.BackColor = System.Drawing.Color.Black
        Me.MediaPlayer1.Barcode_Reader_Enabled = false
        Me.MediaPlayer1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.[Auto]
        Me.MediaPlayer1.ChromaKey = Nothing
        Me.MediaPlayer1.Custom_Audio_Decoder = Nothing
        Me.MediaPlayer1.Custom_Splitter = Nothing
        Me.MediaPlayer1.Custom_Video_Decoder = Nothing
        Me.MediaPlayer1.Debug_DeepCleanUp = false
        Me.MediaPlayer1.Debug_Dir = Nothing
        Me.MediaPlayer1.Debug_Mode = false
        Me.MediaPlayer1.Encryption_Key = ""
        Me.MediaPlayer1.Encryption_KeyType = VisioForge.Types.VFEncryptionKeyType.[String]
        Me.MediaPlayer1.FilenamesOrURL = CType(resources.GetObject("MediaPlayer1.FilenamesOrURL"),System.Collections.Generic.List(Of String))
        Me.MediaPlayer1.Info_UseLibMediaInfo = false
        Me.MediaPlayer1.Location = New System.Drawing.Point(447, 9)
        Me.MediaPlayer1.Loop = false
        Me.MediaPlayer1.MaximalSpeedPlayback = false
        Me.MediaPlayer1.Motion_Detection = Nothing
        Me.MediaPlayer1.MultiScreen_Enabled = false
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.Motion_DetectionEx = Nothing
        Me.MediaPlayer1.ReversePlayback_CacheSize = 0
        Me.MediaPlayer1.ReversePlayback_Enabled = false
        Me.MediaPlayer1.Selection_Active = false
        Me.MediaPlayer1.Selection_Start = 0
        Me.MediaPlayer1.Selection_Stop = 0
        Me.MediaPlayer1.Size = New System.Drawing.Size(463, 349)
        Me.MediaPlayer1.Source_Custom_CLSID = Nothing
        Me.MediaPlayer1.Source_Mode = VisioForge.Types.VFMediaPlayerSource.File_DS
        Me.MediaPlayer1.Source_Stream = Nothing
        Me.MediaPlayer1.Source_Stream_AudioPresent = true
        Me.MediaPlayer1.Source_Stream_Size = CType(0,Long)
        Me.MediaPlayer1.Source_Stream_VideoPresent = true
        Me.MediaPlayer1.Start_DelayEnabled = false
        Me.MediaPlayer1.TabIndex = 32
        Me.MediaPlayer1.Video_Effects_Enabled = false
        VideoRendererSettingsWinForms1.Aspect_Ratio_Override = false
        VideoRendererSettingsWinForms1.Aspect_Ratio_X = 0
        VideoRendererSettingsWinForms1.Aspect_Ratio_Y = 0
        VideoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Black
'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        VideoRendererSettingsWinForms1.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.[Auto]
        VideoRendererSettingsWinForms1.Deinterlace_VMR9_Mode = Nothing
        VideoRendererSettingsWinForms1.Deinterlace_VMR9_UseDefault = true
        VideoRendererSettingsWinForms1.Flip_Horizontal = false
        VideoRendererSettingsWinForms1.Flip_Vertical = false
        VideoRendererSettingsWinForms1.RotationAngle = 0
        VideoRendererSettingsWinForms1.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox
        VideoRendererSettingsWinForms1.Video_Renderer = VisioForge.Types.VFVideoRenderer.EVR
        VideoRendererSettingsWinForms1.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.EVR
        VideoRendererSettingsWinForms1.Zoom_Ratio = 0
        VideoRendererSettingsWinForms1.Zoom_ShiftX = 0
        VideoRendererSettingsWinForms1.Zoom_ShiftY = 0
        Me.MediaPlayer1.Video_Renderer = VideoRendererSettingsWinForms1
        Me.MediaPlayer1.Video_Sample_Grabber_UseForVideoEffects = true
        Me.MediaPlayer1.Video_Stream_Index = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 384)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.btSelectFile)
        Me.Controls.Add(Me.edFilename)
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.Text = "Media Player SDK .Net - Two Windows Demo"
        Me.groupBox2.ResumeLayout(false)
        Me.groupBox2.PerformLayout
        CType(Me.tbSpeed,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbTimeline,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.tbBalance1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbVolume1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents btSelectFile As System.Windows.Forms.Button
    Private WithEvents edFilename As System.Windows.Forms.TextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btNextFrame As System.Windows.Forms.Button
    Private WithEvents btStop As System.Windows.Forms.Button
    Private WithEvents btPause As System.Windows.Forms.Button
    Private WithEvents btResume As System.Windows.Forms.Button
    Private WithEvents btStart As System.Windows.Forms.Button
    Private WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents lbTime As System.Windows.Forms.Label
    Private WithEvents tbTimeline As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents tbBalance1 As System.Windows.Forms.TrackBar
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents tbVolume1 As System.Windows.Forms.TrackBar
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents MediaPlayer1 As VisioForge.Controls.UI.WinForms.MediaPlayer
End Class
