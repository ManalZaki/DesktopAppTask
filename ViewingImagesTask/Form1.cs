using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewingImagesTask
{
	public partial class Form1 : Form
	{
		string txtDirectoryPath;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//specific Path
			txtDirectoryPath = @"C:\Users\Manal\Downloads\picsTest";
			LoadFolder(txtDirectoryPath);
			//binding
			imageDetailBindingSource.DataSource = new ImageDetail();
		}
		public void LoadFolder(string Dir)
		{
			DirectoryInfo di = new DirectoryInfo(Dir);
			TreeNode tds = PicstreeView.Nodes.Add(di.Name);
			GetFiles(Dir, tds);
			LoadSubFolders(Dir, tds);
		}
		//get folders inside
		private void LoadSubFolders(string dir, TreeNode td)
		{
			// Get all subdirectories  
			string[] subdirectoryEntries = Directory.GetDirectories(dir);
			// Loop through them to see if they have any other subdirectories  
			foreach (string subdirectory in subdirectoryEntries)
			{
				DirectoryInfo di = new DirectoryInfo(subdirectory);
				TreeNode tds = td.Nodes.Add(di.Name);
				GetFiles(subdirectory, tds);
				LoadSubFolders(subdirectory, tds);
			}
		}
		//Get Files
		private void GetFiles(string dir, TreeNode td)
		{
			string[] Files = Directory.GetFiles(dir, "*.*");
			// Loop through them to see files  
			foreach (string file in Files)
			{
				FileInfo fi = new FileInfo(file);
				TreeNode tds = td.Nodes.Add(fi.Name);
			}
		}

		//Click on the image from Panel 1 and display it in the Panel 2
		private void PicstreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			string SelectedImage = txtDirectoryPath.Replace("picsTest", e.Node.FullPath);
			pictureBox.ImageLocation = SelectedImage;
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		//Save data..
		private async void SaveBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(emailTextBox.Text)
				|| string.IsNullOrEmpty(nameTextBox.Text)
				|| string.IsNullOrEmpty(addressTextBox.Text))
			{
				MessageBox.Show("Plz Fill Data ..");
			}
			else
			{
				//Save image details in db
				PicAppTaskEntities DB = new PicAppTaskEntities();
				DB.ImageDetails.Add(imageDetailBindingSource.Current as ImageDetail);
				int Res=await DB.SaveChangesAsync();
				if(Res>0)
				{
					MessageBox.Show("Data Saved Done ...");
					//Empty boxes
					emailTextBox.Text = "";
					nameTextBox.Text = "";
					addressTextBox.Text = "";
				}
			}
		}
	}
}
