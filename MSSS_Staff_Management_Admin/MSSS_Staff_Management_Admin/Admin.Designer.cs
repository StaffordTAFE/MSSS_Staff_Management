namespace MSSS_Staff_Management_System
{
	partial class Admin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			toolStrip1 = new ToolStrip();
			toolStripLabel1 = new ToolStripLabel();
			textBox3 = new TextBox();
			label2 = new Label();
			textBox2 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(223, 25);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip";
			// 
			// toolStripLabel1
			// 
			toolStripLabel1.Name = "toolStripLabel1";
			toolStripLabel1.Size = new Size(109, 22);
			toolStripLabel1.Text = "Admin Information";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(12, 87);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(200, 23);
			textBox3.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 69);
			label2.Name = "label2";
			label2.Size = new Size(18, 15);
			label2.TabIndex = 7;
			label2.Text = "ID";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(12, 43);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(200, 23);
			textBox2.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 25);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 6;
			label1.Text = "Name";
			// 
			// button1
			// 
			button1.Location = new Point(12, 116);
			button1.Name = "button1";
			button1.Size = new Size(200, 23);
			button1.TabIndex = 10;
			button1.Text = "Create";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(12, 145);
			button2.Name = "button2";
			button2.Size = new Size(200, 23);
			button2.TabIndex = 11;
			button2.Text = "Update By ID";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(12, 174);
			button3.Name = "button3";
			button3.Size = new Size(200, 23);
			button3.TabIndex = 12;
			button3.Text = "Delete By ID";
			button3.UseVisualStyleBackColor = true;
			// 
			// Admin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(223, 206);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(toolStrip1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Admin";
			ShowIcon = false;
			ShowInTaskbar = false;
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Admin";
			TopMost = true;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripLabel toolStripLabel1;
		private TextBox textBox3;
		private Label label2;
		private TextBox textBox2;
		private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}