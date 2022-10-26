using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//DataTable today = DateTime.Today;
			//label1.Text  = DateTime.Now.ToString();
			DateTime now = DateTime.Now;
			int Hour = now.Hour;

			string msg = string.Empty;
			string dt24 = now.ToString("yyyy-MM-dd   HH:mm:ss");
			//int Hour = DateTime.Today.Hour;
			if (Hour <12)
			{
				msg = "早安";
			}
			else if (Hour <18 )
			{
				msg = "午安";
			}
			else
			{
				msg = "晚安";
			}
			
			label1.Text = DateTime.Now.ToString() + "\r\n"+msg;
			MessageBox.Show(dt24);
		}
	}
}
