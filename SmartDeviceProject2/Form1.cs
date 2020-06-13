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
        public String bck = @"\";
        private String currentPath = "\\";


        public Form1()
        {
            InitializeComponent();
            
            populateListView("\\");
        }
        public void populateListView(String path){
            statusBar1.Text = currentPath;
            listView1.Items.Clear();
           // listView1.Items.Add(new ListViewItem(".."));
            try
            {
                String[] dirs = Directory.GetDirectories(path);
                FileInfo[] files = new DirectoryInfo(path).GetFiles();
                
                foreach (String d in dirs)
                {
                    String name = d.Substring(d.LastIndexOf('\\'));
                    ListViewItem i = new ListViewItem(name);
                    i.SubItems.Add("");
                    i.SubItems.Add("<DIR>");
                    listView1.Items.Add(i);
                }
                 
                foreach (FileInfo f in files)
                {
                    ListViewItem i = new ListViewItem();
                    i.Text = f.Name;
                    if(currentPath.Substring(currentPath.Length-1)=="\\")
                        i.SubItems.Add(File.GetLastWriteTime(currentPath + f.Name).ToString());
                    else
                        i.SubItems.Add(File.GetLastWriteTime(currentPath +"\\"+ f.Name).ToString());
                        //String g = currentPath + @"\" + f.Name;
                    
                    
                    i.SubItems.Add(f.Length.ToString() + " bytes");
                    
                    listView1.Items.Add(i);
                }
            }
            catch (IOException ex)
            {
                //Debug.Write(f.Name);
                Debug.Write("\r\n=============================");
                Debug.Write("\nIOEXCEPTION " + ex.GetBaseException() + "\n");
                Debug.Write(ex.StackTrace + "\n");
                Debug.Write("=============================");
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
           /* if (item== "..")
            {
               // Debug.Write("\r\n"+";"+currentPath+";"+"\r\n");
                currentPath = currentPath.Substring(currentPath.IndexOf('\\'), currentPath.LastIndexOf('\\'));
                if(currentPath == "")
                    currentPath = '\\' + currentPath;

                //currentPath = currentPath.Substring(1);
                populateListView(currentPath);
                return;
            }*/
            if (item.Substring(0, 1) == "\\")
            {
                item = item.Substring(1);
                //Debug.Write("\r\n" + ";" + currentPath + ";" + "\r\n");
                if(currentPath != "\\")
                    currentPath += '\\' + item;
                else
                    currentPath += item;

                //Debug.Write(" " + currentPath + " "); 
                populateListView(currentPath);
                return;
            }
            
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
           //listView1.Items = new Sort
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            e.Button.


        }
    }
}