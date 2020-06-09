using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace SmartDeviceProject2
{
    public partial class Form1 : Form
    {
        private String currentPath = "\\";


        public Form1()
        {
            InitializeComponent();
            populateListView("\\");
        }
        public void populateListView(String path){
            statusBar1.Text = currentPath;
            listView1.Clear();
            listView1.Items.Add(new ListViewItem(".."));
            try
            {
                String[] dirs = Directory.GetDirectories(path);
                String[] files = Directory.GetFiles(path);

                foreach (String d in dirs)
                {
                    String s = d.Substring(d.LastIndexOf('\\'));
                    ListViewItem i = new ListViewItem(s);
                    listView1.Items.Add(i);
                }
                foreach (String f in files)
                {
                    ListViewItem i = new ListViewItem(Path.GetFileName(f));
                    listView1.Items.Add(i);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("IOEXCEPTION" + ex.StackTrace);
            }

        }
        private void menuItem2_Click(object sender, EventArgs e)
        {
            /*String path = Microsoft.VisualBasic.Interaction.InputBox("path", "path", "/", 0, 0);
            populateListView(path);
             * */
           // populateListView("/SDMMC");
        }

        private String getSelectedItem()
        {
            Debug.Write("\r\n"+listView1.Items[listView1.SelectedIndices[0]].Text);
            return listView1.Items[listView1.SelectedIndices[0]].Text;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            String item = getSelectedItem();
            if (item== "..")
            {
                Debug.Write(currentPath);
                currentPath = currentPath.Substring(currentPath.IndexOf('\\'), currentPath.LastIndexOf('\\'));
                currentPath = '\\' + currentPath;
                //currentPath = currentPath.Substring(1);
                populateListView(currentPath);
            }
            if (item.Substring(0, 1) == "\\")
            {
                currentPath += item;
                currentPath = currentPath.Substring(1);
                Debug.Write(" " + currentPath + " "); 
                populateListView(currentPath);
            }
            
        }

    }
}