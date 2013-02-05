/*
 * Created by SharpDevelop.
 * User: Chris
 * Date: 31.01.2013
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.tbRecipiants = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSubject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMessage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbMailadress = new System.Windows.Forms.TextBox();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.bSend = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Recipiants";
			// 
			// tbRecipiants
			// 
			this.tbRecipiants.Location = new System.Drawing.Point(13, 40);
			this.tbRecipiants.Multiline = true;
			this.tbRecipiants.Name = "tbRecipiants";
			this.tbRecipiants.Size = new System.Drawing.Size(291, 49);
			this.tbRecipiants.TabIndex = 1;
			this.toolTip1.SetToolTip(this.tbRecipiants, "When providing multiple email adresses you must seperete each with a \";\"");
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Subject:";
			// 
			// tbSubject
			// 
			this.tbSubject.Location = new System.Drawing.Point(67, 110);
			this.tbSubject.Name = "tbSubject";
			this.tbSubject.Size = new System.Drawing.Size(237, 20);
			this.tbSubject.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Message:";
			// 
			// tbMessage
			// 
			this.tbMessage.Location = new System.Drawing.Point(13, 164);
			this.tbMessage.Multiline = true;
			this.tbMessage.Name = "tbMessage";
			this.tbMessage.Size = new System.Drawing.Size(291, 211);
			this.tbMessage.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Email:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Password:";
			// 
			// tbMailadress
			// 
			this.tbMailadress.Location = new System.Drawing.Point(88, 25);
			this.tbMailadress.Name = "tbMailadress";
			this.tbMailadress.Size = new System.Drawing.Size(197, 20);
			this.tbMailadress.TabIndex = 8;
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(88, 52);
			this.tbPass.Name = "tbPass";
			this.tbPass.PasswordChar = '●';
			this.tbPass.Size = new System.Drawing.Size(197, 20);
			this.tbPass.TabIndex = 9;
			// 
			// bSend
			// 
			this.bSend.Image = ((System.Drawing.Image)(resources.GetObject("bSend.Image")));
			this.bSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bSend.Location = new System.Drawing.Point(178, 472);
			this.bSend.Name = "bSend";
			this.bSend.Size = new System.Drawing.Size(126, 37);
			this.bSend.TabIndex = 10;
			this.bSend.Text = "Send Mail";
			this.bSend.UseVisualStyleBackColor = true;
			this.bSend.Click += new System.EventHandler(this.BSendClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbPass);
			this.groupBox1.Controls.Add(this.tbMailadress);
			this.groupBox1.Location = new System.Drawing.Point(13, 381);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 85);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Credentials";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 511);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bSend);
			this.Controls.Add(this.tbMessage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSubject);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbRecipiants);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "test";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bSend;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.TextBox tbMailadress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMessage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbSubject;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbRecipiants;
		private System.Windows.Forms.Label label1;
	}
}
