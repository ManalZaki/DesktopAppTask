
namespace ViewingImagesTask
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label addressLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label nameLabel;
			this.PicstreeView = new System.Windows.Forms.TreeView();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.PicDetailspanel = new System.Windows.Forms.Panel();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.imageDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
			addressLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.PicDetailspanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageDetailBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// PicstreeView
			// 
			this.PicstreeView.Location = new System.Drawing.Point(12, 61);
			this.PicstreeView.Name = "PicstreeView";
			this.PicstreeView.Size = new System.Drawing.Size(198, 377);
			this.PicstreeView.TabIndex = 0;
			this.PicstreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PicstreeView_NodeMouseClick);
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(224, 61);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(417, 377);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// PicDetailspanel
			// 
			this.PicDetailspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PicDetailspanel.Controls.Add(addressLabel);
			this.PicDetailspanel.Controls.Add(this.addressTextBox);
			this.PicDetailspanel.Controls.Add(emailLabel);
			this.PicDetailspanel.Controls.Add(this.emailTextBox);
			this.PicDetailspanel.Controls.Add(nameLabel);
			this.PicDetailspanel.Controls.Add(this.nameTextBox);
			this.PicDetailspanel.Controls.Add(this.SaveBtn);
			this.PicDetailspanel.ForeColor = System.Drawing.Color.Black;
			this.PicDetailspanel.Location = new System.Drawing.Point(657, 61);
			this.PicDetailspanel.Name = "PicDetailspanel";
			this.PicDetailspanel.Size = new System.Drawing.Size(272, 377);
			this.PicDetailspanel.TabIndex = 2;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Location = new System.Drawing.Point(112, 171);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(75, 23);
			this.SaveBtn.TabIndex = 6;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			addressLabel.Location = new System.Drawing.Point(193, 84);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(59, 16);
			addressLabel.TabIndex = 6;
			addressLabel.Text = "Address";
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageDetailBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(28, 81);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(159, 20);
			this.addressTextBox.TabIndex = 7;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel.Location = new System.Drawing.Point(193, 109);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(42, 16);
			emailLabel.TabIndex = 8;
			emailLabel.Text = "Email";
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageDetailBindingSource, "Email", true));
			this.emailTextBox.Location = new System.Drawing.Point(28, 106);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(159, 20);
			this.emailTextBox.TabIndex = 9;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nameLabel.Location = new System.Drawing.Point(193, 58);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(45, 16);
			nameLabel.TabIndex = 10;
			nameLabel.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageDetailBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(28, 55);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(159, 20);
			this.nameTextBox.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(13, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(197, 28);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(224, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(417, 28);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gainsboro;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(657, 32);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(272, 28);
			this.panel3.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(16, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "Panel 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(43, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Panel 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(48, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Panel 3";
			// 
			// imageDetailBindingSource
			// 
			this.imageDetailBindingSource.DataSource = typeof(ViewingImagesTask.ImageDetail);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 450);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.PicDetailspanel);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.PicstreeView);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Viewing Images";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.PicDetailspanel.ResumeLayout(false);
			this.PicDetailspanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageDetailBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView PicstreeView;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Panel PicDetailspanel;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.BindingSource imageDetailBindingSource;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
	}
}

