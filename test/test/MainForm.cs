using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.ComponentModel;
using System.Net.Mail;
using nmspace;

namespace test
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}		
		
		private void BSendClick(object sender, EventArgs e)
		{
			try
			{
				if(tbMailadress.Text.Contains("@gmail.com"))
				{
					MessageBox.Show("Just gmail as sender sry");
					return;
				}
				bSend.Enabled = false;
				MailMessage message = new MailMessage();
				message.From = new MailAddress(tbMailadress.Text);
				message.Subject = tbSubject.Text;
				message.Body = tbMessage.Text;
				foreach ( string recipian in tbRecipiants.Text.Split(';'))
					message.To.Add(recipian);
				SmtpClient client = new SmtpClient();
				client.Credentials = new NetworkCredential(tbMailadress.Text,tbPass.Text);
				client.Host = "smtp.gmail.com";
				client.Port = 587;
				client.EnableSsl = true;
				client.Send(message);
			}
			catch{ MessageBox.Show("There was an Error...", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);}
			finally{bSend = true;}
		}
	}
}
