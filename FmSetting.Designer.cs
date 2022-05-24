namespace TrOCR
{

	public sealed partial class FmSetting : global::System.Windows.Forms.Form
	{

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.Page_代理 = new global::System.Windows.Forms.TabPage();
			this.代理Button = new global::System.Windows.Forms.Button();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.chbox_代理服务器 = new global::System.Windows.Forms.CheckBox();
			this.text_密码 = new global::System.Windows.Forms.TextBox();
			this.text_端口 = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.text_账号 = new global::System.Windows.Forms.TextBox();
			this.text_服务器 = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.combox_代理 = new global::System.Windows.Forms.ComboBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.Page_Key = new global::System.Windows.Forms.TabPage();
			this.Baidu_btn = new global::System.Windows.Forms.Button();
			this.KeyButton_apply = new global::System.Windows.Forms.Button();
			this.KeyButton = new global::System.Windows.Forms.Button();
			this.tabControl2 = new global::System.Windows.Forms.TabControl();
			this.inPage_BaiduInterface = new global::System.Windows.Forms.TabPage();
			this.text_baidupassword = new global::System.Windows.Forms.TextBox();
			this.text_baiduaccount = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.Page_快捷键 = new global::System.Windows.Forms.TabPage();
			this.快捷键Button = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.pictureBox_识别界面 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_记录界面 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_翻译文本 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_文字识别 = new global::System.Windows.Forms.PictureBox();
			this.txtBox_识别界面 = new global::System.Windows.Forms.TextBox();
			this.txtBox_记录界面 = new global::System.Windows.Forms.TextBox();
			this.txtBox_翻译文本 = new global::System.Windows.Forms.TextBox();
			this.txtBox_文字识别 = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.page_常规 = new global::System.Windows.Forms.TabPage();
			this.groupBox10 = new global::System.Windows.Forms.GroupBox();
			this.chbox_save = new global::System.Windows.Forms.CheckBox();
			this.chbox_copy = new global::System.Windows.Forms.CheckBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.btn_音效路径 = new global::System.Windows.Forms.Button();
			this.btn_音效 = new global::System.Windows.Forms.Button();
			this.text_音效path = new global::System.Windows.Forms.TextBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.btn_浏览 = new global::System.Windows.Forms.Button();
			this.textBox_path = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbBox_保存 = new global::System.Windows.Forms.CheckBox();
			this.pic_help = new global::System.Windows.Forms.PictureBox();
			this.常规Button = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.numbox_记录 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.cobBox_动画 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chbox_取色 = new global::System.Windows.Forms.CheckBox();
			this.cbBox_弹窗 = new global::System.Windows.Forms.CheckBox();
			this.cbBox_翻译 = new global::System.Windows.Forms.CheckBox();
			this.cbBox_开机 = new global::System.Windows.Forms.CheckBox();
			this.tab_标签 = new global::System.Windows.Forms.TabControl();
		
			
			
			this.Page_代理.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.Page_Key.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.inPage_BaiduInterface.SuspendLayout();
			this.Page_快捷键.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_识别界面).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_记录界面).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_翻译文本).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_文字识别).BeginInit();
			this.page_常规.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic_help).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numbox_记录).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tab_标签.SuspendLayout();
			
			base.SuspendLayout();
			this.Page_代理.BackColor = global::System.Drawing.Color.White;
			this.Page_代理.Controls.Add(this.代理Button);
			this.Page_代理.Controls.Add(this.groupBox4);
			this.Page_代理.Location = new global::System.Drawing.Point(4, 22);
			this.Page_代理.Name = "Page_代理";
			this.Page_代理.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_代理.Size = new global::System.Drawing.Size(390, 329);
			this.Page_代理.TabIndex = 4;
			this.Page_代理.Text = "Proxy";
			this.代理Button.BackColor = global::System.Drawing.Color.White;
			this.代理Button.Location = new global::System.Drawing.Point(239, 193);
			this.代理Button.Name = "代理Button";
			this.代理Button.Size = new global::System.Drawing.Size(145, 23);
			this.代理Button.TabIndex = 9;
			this.代理Button.Text = "Restore default";
			this.代理Button.UseVisualStyleBackColor = false;
			this.代理Button.Click += new global::System.EventHandler(this.代理Button_Click);
			this.groupBox4.Controls.Add(this.chbox_代理服务器);
			this.groupBox4.Controls.Add(this.text_密码);
			this.groupBox4.Controls.Add(this.text_端口);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.text_账号);
			this.groupBox4.Controls.Add(this.text_服务器);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.combox_代理);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Location = new global::System.Drawing.Point(3, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(381, 183);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Proxy";
			this.chbox_代理服务器.AutoSize = true;
			this.chbox_代理服务器.Location = new global::System.Drawing.Point(78, 84);
			this.chbox_代理服务器.Name = "chbox_代理服务器";
			this.chbox_代理服务器.Size = new global::System.Drawing.Size(132, 16);
			this.chbox_代理服务器.TabIndex = 12;
			this.chbox_代理服务器.Text = "Proxy server requires password";
			this.chbox_代理服务器.UseVisualStyleBackColor = true;
			this.text_密码.Location = new global::System.Drawing.Point(78, 144);
			this.text_密码.Name = "text_密码";
			this.text_密码.Size = new global::System.Drawing.Size(128, 21);
			this.text_密码.TabIndex = 11;
			this.text_密码.TextChanged += new global::System.EventHandler(this.text_密码_TextChanged);
			this.text_端口.Location = new global::System.Drawing.Point(248, 52);
			this.text_端口.Name = "text_端口";
			this.text_端口.Size = new global::System.Drawing.Size(55, 21);
			this.text_端口.TabIndex = 10;
			this.text_端口.Text = " ";
			this.text_端口.TextChanged += new global::System.EventHandler(this.text_端口_TextChanged);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(212, 57);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(41, 12);
			this.label15.TabIndex = 9;
			this.label15.Text = "Port：";
			this.text_账号.Location = new global::System.Drawing.Point(78, 110);
			this.text_账号.Name = "text_账号";
			this.text_账号.Size = new global::System.Drawing.Size(128, 21);
			this.text_账号.TabIndex = 8;
			this.text_账号.TextChanged += new global::System.EventHandler(this.text_账号_TextChanged);
			this.text_服务器.Location = new global::System.Drawing.Point(78, 52);
			this.text_服务器.Name = "text_服务器";
			this.text_服务器.Size = new global::System.Drawing.Size(128, 21);
			this.text_服务器.TabIndex = 7;
			this.text_服务器.TextChanged += new global::System.EventHandler(this.text_服务器_TextChanged);
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(9, 147);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(41, 12);
			this.label14.TabIndex = 6;
			this.label14.Text = "Password：";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(9, 114);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(53, 12);
			this.label13.TabIndex = 5;
			this.label13.Text = "User name：";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(9, 57);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(53, 12);
			this.label12.TabIndex = 4;
			this.label12.Text = "Server：";
			this.combox_代理.BackColor = global::System.Drawing.Color.White;
			this.combox_代理.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combox_代理.FormattingEnabled = true;
			this.combox_代理.Items.AddRange(new object[]
			{
				"no proxy",
				"system proxy",
				"custom proxy"
			});
			this.combox_代理.Location = new global::System.Drawing.Point(78, 18);
			this.combox_代理.Name = "combox_代理";
			this.combox_代理.Size = new global::System.Drawing.Size(95, 20);
			this.combox_代理.TabIndex = 3;
			this.combox_代理.SelectedIndexChanged += new global::System.EventHandler(this.combox_代理_SelectedIndexChanged);
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(7, 22);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(65, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "Proxy type：";
			this.Page_Key.BackColor = global::System.Drawing.Color.White;
			this.Page_Key.Controls.Add(this.Baidu_btn);
			this.Page_Key.Controls.Add(this.KeyButton_apply);
			this.Page_Key.Controls.Add(this.KeyButton);
			this.Page_Key.Controls.Add(this.tabControl2);
			this.Page_Key.Location = new global::System.Drawing.Point(4, 22);
			this.Page_Key.Name = "Page_Key";
			this.Page_Key.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_Key.Size = new global::System.Drawing.Size(390, 329);
			this.Page_Key.TabIndex = 3;
			this.Page_Key.Text = "Key";
			this.Baidu_btn.BackColor = global::System.Drawing.Color.White;
			this.Baidu_btn.Location = new global::System.Drawing.Point(158, 136);
			this.Baidu_btn.Name = "Baidu_btn";
			this.Baidu_btn.Size = new global::System.Drawing.Size(75, 23);
			this.Baidu_btn.TabIndex = 10;
			this.Baidu_btn.Text = "KeyTest";
			this.Baidu_btn.UseVisualStyleBackColor = false;
			this.Baidu_btn.Click += new global::System.EventHandler(this.Baidu_btn_Click);
			this.KeyButton_apply.BackColor = global::System.Drawing.Color.White;
			this.KeyButton_apply.Location = new global::System.Drawing.Point(6, 136);
			this.KeyButton_apply.Name = "KeyButton_apply";
			this.KeyButton_apply.Size = new global::System.Drawing.Size(145, 23);
			this.KeyButton_apply.TabIndex = 9;
			this.KeyButton_apply.Text = "Interface application";
			this.KeyButton_apply.UseVisualStyleBackColor = false;
			this.KeyButton_apply.Click += new global::System.EventHandler(this.Baidu申请_Click);
			this.KeyButton.BackColor = global::System.Drawing.Color.White;
			this.KeyButton.Location = new global::System.Drawing.Point(239, 136);
			this.KeyButton.Name = "KeyButton";
			this.KeyButton.Size = new global::System.Drawing.Size(145, 23);
			this.KeyButton.TabIndex = 8;
			this.KeyButton.Text = "Restore default";
			this.KeyButton.UseVisualStyleBackColor = false;
			this.KeyButton.Click += new global::System.EventHandler(this.KeyButton_Click);
			this.tabControl2.Controls.Add(this.inPage_BaiduInterface);
			this.tabControl2.Location = new global::System.Drawing.Point(6, 6);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new global::System.Drawing.Size(378, 124);
			this.tabControl2.TabIndex = 0;
			this.inPage_BaiduInterface.BackColor = global::System.Drawing.Color.White;
			this.inPage_BaiduInterface.Controls.Add(this.text_baidupassword);
			this.inPage_BaiduInterface.Controls.Add(this.text_baiduaccount);
			this.inPage_BaiduInterface.Controls.Add(this.label10);
			this.inPage_BaiduInterface.Controls.Add(this.label9);
			this.inPage_BaiduInterface.Location = new global::System.Drawing.Point(4, 22);
			this.inPage_BaiduInterface.Name = "inPage_BaiduInterface";
			this.inPage_BaiduInterface.Padding = new global::System.Windows.Forms.Padding(3);
			this.inPage_BaiduInterface.Size = new global::System.Drawing.Size(370, 98);
			this.inPage_BaiduInterface.TabIndex = 0;
			this.inPage_BaiduInterface.Text = "Baidu identification interface";
			this.text_baidupassword.BackColor = global::System.Drawing.Color.White;
			this.text_baidupassword.Location = new global::System.Drawing.Point(56, 55);
			this.text_baidupassword.Name = "text_baidupassword";
			this.text_baidupassword.Size = new global::System.Drawing.Size(260, 21);
			this.text_baidupassword.TabIndex = 3;
			this.text_baidupassword.TextChanged += new global::System.EventHandler(this.text_baidupassword_TextChanged);
			this.text_baiduaccount.BackColor = global::System.Drawing.Color.White;
			this.text_baiduaccount.Location = new global::System.Drawing.Point(56, 20);
			this.text_baiduaccount.Name = "text_baiduaccount";
			this.text_baiduaccount.Size = new global::System.Drawing.Size(260, 21);
			this.text_baiduaccount.TabIndex = 2;
			this.text_baiduaccount.TextChanged += new global::System.EventHandler(this.text_baiduaccount_TextChanged);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(1, 58);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(65, 12);
			this.label10.TabIndex = 1;
			this.label10.Text = "Password：";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(1, 23);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(59, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "Account：";
			this.Page_快捷键.BackColor = global::System.Drawing.Color.White;
			this.Page_快捷键.Controls.Add(this.快捷键Button);
			this.Page_快捷键.Controls.Add(this.label8);
			this.Page_快捷键.Controls.Add(this.groupBox3);
			this.Page_快捷键.Location = new global::System.Drawing.Point(4, 22);
			this.Page_快捷键.Name = "Page_快捷键";
			this.Page_快捷键.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_快捷键.Size = new global::System.Drawing.Size(390, 329);
			this.Page_快捷键.TabIndex = 2;
			this.Page_快捷键.Text = "Shortcut key";
			this.快捷键Button.BackColor = global::System.Drawing.Color.White;
			this.快捷键Button.Location = new global::System.Drawing.Point(239, 175);
			this.快捷键Button.Name = "快捷键Button";
			this.快捷键Button.Size = new global::System.Drawing.Size(145, 23);
			this.快捷键Button.TabIndex = 7;
			this.快捷键Button.Text = "Restore default";
			this.快捷键Button.UseVisualStyleBackColor = false;
			this.快捷键Button.Click += new global::System.EventHandler(this.快捷键Button_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 170);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(221, 24);
			this.label8.TabIndex = 1;
			this.label8.Text = "Description:Press the Backspace key \n to clear the current shortcut key";
			this.groupBox3.Controls.Add(this.pictureBox_识别界面);
			this.groupBox3.Controls.Add(this.pictureBox_记录界面);
			this.groupBox3.Controls.Add(this.pictureBox_翻译文本);
			this.groupBox3.Controls.Add(this.pictureBox_文字识别);
			this.groupBox3.Controls.Add(this.txtBox_识别界面);
			this.groupBox3.Controls.Add(this.txtBox_记录界面);
			this.groupBox3.Controls.Add(this.txtBox_翻译文本);
			this.groupBox3.Controls.Add(this.txtBox_文字识别);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(378, 163);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Global shortcut keys";
			this.pictureBox_识别界面.Image = global::TrOCR.Properties.Resources.快捷键_1;
			this.pictureBox_识别界面.Location = new global::System.Drawing.Point(351, 122);
			this.pictureBox_识别界面.Name = "pictureBox_识别界面";
			this.pictureBox_识别界面.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_识别界面.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_识别界面.TabIndex = 11;
			this.pictureBox_识别界面.TabStop = false;
			this.pictureBox_记录界面.Image = global::TrOCR.Properties.Resources.快捷键_1;
			this.pictureBox_记录界面.Location = new global::System.Drawing.Point(351, 89);
			this.pictureBox_记录界面.Name = "pictureBox_记录界面";
			this.pictureBox_记录界面.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_记录界面.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_记录界面.TabIndex = 10;
			this.pictureBox_记录界面.TabStop = false;
			this.pictureBox_翻译文本.Image = global::TrOCR.Properties.Resources.快捷键_1;
			this.pictureBox_翻译文本.Location = new global::System.Drawing.Point(351, 52);
			this.pictureBox_翻译文本.Name = "pictureBox_翻译文本";
			this.pictureBox_翻译文本.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_翻译文本.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_翻译文本.TabIndex = 9;
			this.pictureBox_翻译文本.TabStop = false;
			this.pictureBox_文字识别.Image = global::TrOCR.Properties.Resources.快捷键_1;
			this.pictureBox_文字识别.Location = new global::System.Drawing.Point(351, 19);
			this.pictureBox_文字识别.Name = "pictureBox_文字识别";
			this.pictureBox_文字识别.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_文字识别.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_文字识别.TabIndex = 8;
			this.pictureBox_文字识别.TabStop = false;
			this.txtBox_识别界面.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_识别界面.Location = new global::System.Drawing.Point(78, 122);
			this.txtBox_识别界面.Name = "txtBox_识别界面";
			this.txtBox_识别界面.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_识别界面.TabIndex = 7;
			this.txtBox_识别界面.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_识别界面.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_识别界面.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.txtBox_记录界面.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_记录界面.Location = new global::System.Drawing.Point(78, 89);
			this.txtBox_记录界面.Name = "txtBox_记录界面";
			this.txtBox_记录界面.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_记录界面.TabIndex = 6;
			this.txtBox_记录界面.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_记录界面.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_记录界面.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.txtBox_翻译文本.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_翻译文本.Location = new global::System.Drawing.Point(78, 52);
			this.txtBox_翻译文本.Name = "txtBox_翻译文本";
			this.txtBox_翻译文本.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_翻译文本.TabIndex = 5;
			this.txtBox_翻译文本.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_翻译文本.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_翻译文本.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.txtBox_文字识别.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_文字识别.Location = new global::System.Drawing.Point(78, 19);
			this.txtBox_文字识别.Name = "txtBox_文字识别";
			this.txtBox_文字识别.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_文字识别.TabIndex = 4;
			this.txtBox_文字识别.TabStop = false;
			this.txtBox_文字识别.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_文字识别.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_文字识别.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 125);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(65, 12);
			this.label7.TabIndex = 3;
			this.label7.Text = "Window：";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(7, 92);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(65, 12);
			this.label6.TabIndex = 2;
			this.label6.Text = "Record：";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 58);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(65, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "Translate：";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 24);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(65, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "OCR：";
			this.page_常规.BackColor = global::System.Drawing.Color.White;
			this.page_常规.Controls.Add(this.groupBox10);
			this.page_常规.Controls.Add(this.groupBox6);
			this.page_常规.Controls.Add(this.pic_help);
			this.page_常规.Controls.Add(this.常规Button);
			this.page_常规.Controls.Add(this.groupBox2);
			this.page_常规.Controls.Add(this.groupBox1);
			this.page_常规.Location = new global::System.Drawing.Point(4, 22);
			this.page_常规.Name = "page_常规";
			this.page_常规.Padding = new global::System.Windows.Forms.Padding(3);
			this.page_常规.Size = new global::System.Drawing.Size(390, 329);
			this.page_常规.TabIndex = 0;
			this.page_常规.Text = "Regular";
			this.groupBox10.Controls.Add(this.chbox_save);
			this.groupBox10.Controls.Add(this.chbox_copy);
			this.groupBox10.Controls.Add(this.label20);
			this.groupBox10.Controls.Add(this.btn_音效路径);
			this.groupBox10.Controls.Add(this.btn_音效);
			this.groupBox10.Controls.Add(this.text_音效path);
			this.groupBox10.Controls.Add(this.label18);
			this.groupBox10.Location = new global::System.Drawing.Point(6, 136);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new global::System.Drawing.Size(378, 86);
			this.groupBox10.TabIndex = 8;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Sound effect";
			this.chbox_save.AutoSize = true;
			this.chbox_save.Checked = true;
			this.chbox_save.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chbox_save.Location = new global::System.Drawing.Point(187, 54);
			this.chbox_save.Name = "chbox_save";
			this.chbox_save.Size = new global::System.Drawing.Size(96, 16);
			this.chbox_save.TabIndex = 10;
			this.chbox_save.Text = "Save pictures";
			this.chbox_save.UseVisualStyleBackColor = true;
			this.chbox_save.CheckedChanged += new global::System.EventHandler(this.chbox_save_CheckedChanged);
			this.chbox_copy.AutoSize = true;
			this.chbox_copy.Location = new global::System.Drawing.Point(53, 54);
			this.chbox_copy.Name = "chbox_copy";
			this.chbox_copy.Size = new global::System.Drawing.Size(96, 16);
			this.chbox_copy.TabIndex = 6;
			this.chbox_copy.Text = "Copy to pasteboard";
			this.chbox_copy.UseVisualStyleBackColor = true;
			this.chbox_copy.CheckedChanged += new global::System.EventHandler(this.chbox_copy_CheckedChanged);
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(14, 55);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(41, 12);
			this.label20.TabIndex = 9;
			this.label20.Text = "When：";
			this.btn_音效路径.BackColor = global::System.Drawing.Color.White;
			this.btn_音效路径.Location = new global::System.Drawing.Point(312, 49);
			this.btn_音效路径.Name = "btn_音效路径";
			this.btn_音效路径.Size = new global::System.Drawing.Size(60, 23);
			this.btn_音效路径.TabIndex = 8;
			this.btn_音效路径.Text = "Change";
			this.btn_音效路径.UseVisualStyleBackColor = false;
			this.btn_音效路径.Click += new global::System.EventHandler(this.btn_音效路径_Click);
			this.btn_音效.BackColor = global::System.Drawing.Color.White;
			this.btn_音效.Image = global::TrOCR.Properties.Resources.语音按钮;
			this.btn_音效.Location = new global::System.Drawing.Point(344, 17);
			this.btn_音效.Name = "btn_音效";
			this.btn_音效.Size = new global::System.Drawing.Size(26, 23);
			this.btn_音效.TabIndex = 7;
			this.btn_音效.UseVisualStyleBackColor = false;
			this.btn_音效.Click += new global::System.EventHandler(this.btn_音效_Click);
			this.text_音效path.BackColor = global::System.Drawing.Color.White;
			this.text_音效path.Location = new global::System.Drawing.Point(51, 19);
			this.text_音效path.Name = "text_音效path";
			this.text_音效path.ReadOnly = true;
			this.text_音效path.Size = new global::System.Drawing.Size(288, 21);
			this.text_音效path.TabIndex = 4;
			this.text_音效path.Text = "Data\\screenshot.wav";
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(13, 22);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(41, 12);
			this.label18.TabIndex = 3;
			this.label18.Text = "File：";
			this.groupBox6.Controls.Add(this.btn_浏览);
			this.groupBox6.Controls.Add(this.textBox_path);
			this.groupBox6.Controls.Add(this.label1);
			this.groupBox6.Controls.Add(this.cbBox_保存);
			this.groupBox6.Location = new global::System.Drawing.Point(6, 227);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(378, 63);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.btn_浏览.BackColor = global::System.Drawing.Color.White;
			this.btn_浏览.Location = new global::System.Drawing.Point(312, 24);
			this.btn_浏览.Name = "btn_浏览";
			this.btn_浏览.Size = new global::System.Drawing.Size(60, 23);
			this.btn_浏览.TabIndex = 7;
			this.btn_浏览.Text = "Browse";
			this.btn_浏览.UseVisualStyleBackColor = false;
			this.btn_浏览.Click += new global::System.EventHandler(this.btn_浏览_Click);
			this.textBox_path.BackColor = global::System.Drawing.Color.White;
			this.textBox_path.Location = new global::System.Drawing.Point(41, 26);
			this.textBox_path.Name = "textBox_path";
			this.textBox_path.ReadOnly = true;
			this.textBox_path.Size = new global::System.Drawing.Size(265, 21);
			this.textBox_path.TabIndex = 4;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(5, 29);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(41, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "File：";
			this.cbBox_保存.AutoSize = true;
			this.cbBox_保存.BackColor = global::System.Drawing.Color.White;
			this.cbBox_保存.Location = new global::System.Drawing.Point(6, 0);
			this.cbBox_保存.Name = "cbBox_保存";
			this.cbBox_保存.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_保存.TabIndex = 2;
			this.cbBox_保存.Text = "Auto save";
			this.cbBox_保存.UseVisualStyleBackColor = false;
			this.cbBox_保存.CheckedChanged += new global::System.EventHandler(this.cbBox_保存_CheckedChanged);
			this.pic_help.Image = global::TrOCR.Properties.Resources.帮助;
			this.pic_help.Location = new global::System.Drawing.Point(7, 296);
			this.pic_help.Name = "pic_help";
			this.pic_help.Size = new global::System.Drawing.Size(27, 23);
			this.pic_help.TabIndex = 7;
			this.pic_help.TabStop = false;
			this.pic_help.Click += new global::System.EventHandler(this.pic_help_Click);
			this.常规Button.BackColor = global::System.Drawing.Color.White;
			this.常规Button.Location = new global::System.Drawing.Point(310, 297);
			this.常规Button.Name = "常规Button";
			this.常规Button.Size = new global::System.Drawing.Size(75, 23);
			this.常规Button.TabIndex = 6;
			this.常规Button.Text = "Reset";
			this.常规Button.UseVisualStyleBackColor = false;
			this.常规Button.Click += new global::System.EventHandler(this.常规Button_Click);
			this.groupBox2.Controls.Add(this.numbox_记录);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.cobBox_动画);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new global::System.Drawing.Point(6, 82);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(378, 48);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Interface";
			this.numbox_记录.Location = new global::System.Drawing.Point(310, 19);
			this.numbox_记录.Name = "numbox_记录";
			this.numbox_记录.Size = new global::System.Drawing.Size(63, 21);
			this.numbox_记录.TabIndex = 5;
			this.numbox_记录.ValueChanged += new global::System.EventHandler(this.numbox_记录_ValueChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(195, 22);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(65, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "Number of records：";
			this.cobBox_动画.BackColor = global::System.Drawing.Color.White;
			this.cobBox_动画.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cobBox_动画.FormattingEnabled = true;
			this.cobBox_动画.Items.AddRange(new object[]
			{
				"Ordinary",
				"Girl",
				"Cat"
			});
			this.cobBox_动画.Location = new global::System.Drawing.Point(84, 19);
			this.cobBox_动画.Name = "cobBox_动画";
			this.cobBox_动画.Size = new global::System.Drawing.Size(63, 20);
			this.cobBox_动画.TabIndex = 3;
			this.cobBox_动画.SelectedIndexChanged += new global::System.EventHandler(this.cobBox_动画_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(13, 22);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Animation：";
			this.groupBox1.Controls.Add(this.chbox_取色);
			this.groupBox1.Controls.Add(this.cbBox_弹窗);
			this.groupBox1.Controls.Add(this.cbBox_翻译);
			this.groupBox1.Controls.Add(this.cbBox_开机);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(378, 70);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			this.chbox_取色.AutoSize = true;
			this.chbox_取色.Location = new global::System.Drawing.Point(204, 40);
			this.chbox_取色.Name = "chbox_取色";
			this.chbox_取色.Size = new global::System.Drawing.Size(66, 16);
			this.chbox_取色.TabIndex = 6;
			this.chbox_取色.Text = "Extract color";
			this.chbox_取色.UseVisualStyleBackColor = true;
			this.chbox_取色.CheckedChanged += new global::System.EventHandler(this.chbox_取色_CheckedChanged);
			this.cbBox_弹窗.AutoSize = true;
			this.cbBox_弹窗.Location = new global::System.Drawing.Point(204, 20);
			this.cbBox_弹窗.Name = "cbBox_弹窗";
			this.cbBox_弹窗.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_弹窗.TabIndex = 5;
			this.cbBox_弹窗.Text = "Recognition popup";
			this.cbBox_弹窗.UseVisualStyleBackColor = true;
			this.cbBox_弹窗.CheckedChanged += new global::System.EventHandler(this.cbBox_弹窗_CheckedChanged);
			this.cbBox_翻译.AutoSize = true;
			this.cbBox_翻译.Location = new global::System.Drawing.Point(17, 40);
			this.cbBox_翻译.Name = "cbBox_翻译";
			this.cbBox_翻译.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_翻译.TabIndex = 4;
			this.cbBox_翻译.Text = "Translation";
			this.cbBox_翻译.UseVisualStyleBackColor = true;
			this.cbBox_翻译.CheckedChanged += new global::System.EventHandler(this.cbBox_翻译_CheckedChanged);
			this.cbBox_开机.AutoSize = true;
			this.cbBox_开机.Location = new global::System.Drawing.Point(17, 20);
			this.cbBox_开机.Name = "cbBox_开机";
			this.cbBox_开机.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_开机.TabIndex = 2;
			this.cbBox_开机.Text = "Automatic start";
			this.cbBox_开机.UseVisualStyleBackColor = true;
			this.cbBox_开机.CheckedChanged += new global::System.EventHandler(this.cbBox_开机_CheckedChanged);
			this.tab_标签.Controls.Add(this.page_常规);
			this.tab_标签.Controls.Add(this.Page_快捷键);
			this.tab_标签.Controls.Add(this.Page_Key);
			this.tab_标签.Controls.Add(this.Page_代理);
			this.tab_标签.Location = new global::System.Drawing.Point(10, 2);
			this.tab_标签.Name = "tab_标签";
			this.tab_标签.SelectedIndex = 0;
			this.tab_标签.Size = new global::System.Drawing.Size(398, 355);
			this.tab_标签.TabIndex = 0;
			this.tab_标签.SelectedIndexChanged += new global::System.EventHandler(this.tab_标签_SelectedIndexChanged);
			
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(417, 368);
			base.Controls.Add(this.tab_标签);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FmSetting";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.Page_代理.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.Page_Key.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.inPage_BaiduInterface.ResumeLayout(false);
			this.inPage_BaiduInterface.PerformLayout();
			this.Page_快捷键.ResumeLayout(false);
			this.Page_快捷键.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_识别界面).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_记录界面).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_翻译文本).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_文字识别).EndInit();
			this.page_常规.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic_help).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numbox_记录).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tab_标签.ResumeLayout(false);
			
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TabPage Page_代理;

		private global::System.Windows.Forms.TabPage Page_Key;

		private global::System.Windows.Forms.TabPage Page_快捷键;

		private global::System.Windows.Forms.TabPage page_常规;

		private global::System.Windows.Forms.PictureBox pic_help;

		private global::System.Windows.Forms.Button 常规Button;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.NumericUpDown numbox_记录;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.ComboBox cobBox_动画;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.CheckBox cbBox_开机;

		private global::System.Windows.Forms.TabControl tab_标签;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.PictureBox pictureBox_翻译文本;

		private global::System.Windows.Forms.PictureBox pictureBox_文字识别;

		private global::System.Windows.Forms.TextBox txtBox_识别界面;

		private global::System.Windows.Forms.TextBox txtBox_记录界面;

		private global::System.Windows.Forms.TextBox txtBox_翻译文本;

		private global::System.Windows.Forms.TextBox txtBox_文字识别;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.PictureBox pictureBox_识别界面;

		private global::System.Windows.Forms.PictureBox pictureBox_记录界面;

		private global::System.Windows.Forms.Label label8;

		private global::System.Windows.Forms.CheckBox cbBox_翻译;

		private global::System.Windows.Forms.TabControl tabControl2;

		private global::System.Windows.Forms.TabPage inPage_BaiduInterface;

		private global::System.Windows.Forms.TextBox text_baidupassword;

		private global::System.Windows.Forms.TextBox text_baiduaccount;

		private global::System.Windows.Forms.Label label10;

		private global::System.Windows.Forms.Label label9;

		private global::System.Windows.Forms.Button 快捷键Button;

		private global::System.Windows.Forms.Button KeyButton_apply;

		private global::System.Windows.Forms.Button KeyButton;

		private global::System.Windows.Forms.GroupBox groupBox4;

		private global::System.Windows.Forms.ComboBox combox_代理;

		private global::System.Windows.Forms.Label label11;

		private global::System.Windows.Forms.Button 代理Button;

		private global::System.Windows.Forms.CheckBox chbox_代理服务器;

		private global::System.Windows.Forms.TextBox text_密码;

		private global::System.Windows.Forms.TextBox text_端口;

		private global::System.Windows.Forms.Label label15;

		private global::System.Windows.Forms.TextBox text_账号;

		private global::System.Windows.Forms.TextBox text_服务器;

		private global::System.Windows.Forms.Label label14;

		private global::System.Windows.Forms.Label label13;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.CheckBox cbBox_弹窗;

		private global::System.Windows.Forms.GroupBox groupBox6;

		private global::System.Windows.Forms.TextBox textBox_path;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.CheckBox cbBox_保存;

		private global::System.Windows.Forms.Button btn_浏览;

		private global::System.Windows.Forms.Button Baidu_btn;

		private global::System.Windows.Forms.GroupBox groupBox10;

		private global::System.Windows.Forms.Button btn_音效;

		private global::System.Windows.Forms.TextBox text_音效path;

		private global::System.Windows.Forms.Label label18;

		private global::System.Windows.Forms.CheckBox chbox_save;

		private global::System.Windows.Forms.CheckBox chbox_copy;

		private global::System.Windows.Forms.Label label20;

		private global::System.Windows.Forms.Button btn_音效路径;

		private global::System.Windows.Forms.CheckBox chbox_取色;
	}
}
