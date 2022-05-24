using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrOCR
{

	public partial class FmHelp : Form
	{

		public FmHelp()
		{
			components = null;
			InitializeComponent();
			panel_快捷键.Location = dpi_size();
			panel_快捷键.Visible = true;
			panel_常见问题.Visible = false;
			listBox1.Font = new Font("宋体", 10f / Program.factor);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem.ToString().Trim() == "Shortcut keys")
			{
				panel_快捷键.Location = dpi_size();
				panel_快捷键.Visible = true;
				panel_常见问题.Visible = false;
			}
			if (listBox1.SelectedItem.ToString() == "Common problem")
			{
				panel_常见问题.Location = dpi_size();
				panel_快捷键.Visible = false;
				panel_常见问题.Visible = true;
			}
		}

		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			var index = e.Index;
			var graphics = e.Graphics;
			var bounds = e.Bounds;
			var flag = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
			if (flag)
			{
				var rect = new Rectangle(bounds.Left, bounds.Top + 1, bounds.Width, bounds.Height - 4);
				graphics.FillRectangle(Brushes.LightSkyBlue, rect);
			}
			else
			{
				graphics.FillRectangle(Brushes.White, bounds);
			}
			var stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), e.Bounds, stringFormat);
		}

		private void FmHelp_Load(object sender, EventArgs e)
		{
			webBrowser1.DocumentText = "<p>\t&nbsp;<strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\"><strong>Common problem</strong></span></strong><strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\">：</span></strong> </p><p style=\"margin-left:8pt;\">\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;line-height:1;\"> \t<p style=\"margin-left:8pt;\">\t\t<strong>1.</strong><strong>&nbsp;Recognition appears: --No text found in this area--</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\t<span id=\"__kindeditor_bookmark_start_217__\" style=\"display:none;\"></span>Possibility 1: The network connection is not normal<span id=\"__kindeditor_bookmark_end_218__\" style=\"display:none;\"></span> \t</p>\t<p style=\"margin-left:8pt;\">\t\tPossibility 2: The interface is temporarily unavailable, please replace the interface\t</p>\t<p style=\"margin-left:8pt;\">\t\tPossibility 3: Please check if there is a network proxy\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>2.</strong><strong>&nbsp;How to replace the interface</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\tToggle in the right-click menu of the text box\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>3. How to translate immediately after taking a screenshot</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\t Find '翻'in the text box and right-click it to turn red. \t</p>\t</span>";
			webBrowser2.DocumentText = "<p>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr class=\"firstRow\">\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Shortcut keys</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Function Description</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">A</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Automatically save screenshots</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">B</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Baidu after identification</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">C</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Screen color picker</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">E</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Advanced screenshot function</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Q</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Paste the image</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">S</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Save screenshot as</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">1</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Split text after recognition</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">2</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Merge text after recognition</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Space</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Copy image to clipboard</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" cellspacing=\"0\" cellpadding=\"8\" style=\"width:444px;\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Tab</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Multi-selection recognition or screenshot</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table></p><p>\t<br /></p>";
			webBrowser2.ScrollBarsEnabled = false;
			webBrowser1.IsWebBrowserContextMenuEnabled = false;
			webBrowser2.IsWebBrowserContextMenuEnabled = false;
			var componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			using (var streamWriter = new StreamWriter("52.txt", true))
			{
				streamWriter.Write("<p>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr class=\"firstRow\">\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Shortcut keys</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Function Description</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">A</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Automatically save screenshots</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">B</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Baidu after identification</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">C</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Screen color picker</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">E</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Advanced screenshot function</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Q</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Paste the image</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">S</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Save screenshot as</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">1</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Split text after recognition</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">2</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Merge text after recognition</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Space</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Copy image to clipboard</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" cellspacing=\"0\" cellpadding=\"8\" style=\"width:444px;\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Tab</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Multi-selection recognition or screenshot</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table></p><p>\t<br /></p>");
			}
		}

		public Point dpi_size()
		{
			return new Point(109, 5);
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		private void webBrowser_NewWindow(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			var document = ((WebBrowser)sender).Document;
			if (document != null && document.ActiveElement != null)
			{
				var attribute = document.ActiveElement.GetAttribute("href");
				Help.ShowHelp(this, attribute);
			}
		}
	}
}
