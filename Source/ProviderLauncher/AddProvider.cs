using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DfBAdminToolkit.Common.Extensions;

namespace ProviderLauncher
{
    public partial class AddProvider : Form
    {
        public static string appName = "Dropbox Partner Launchpad for Admin Toolkit";

        public AddProvider()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFileAccessToken.Text != string.Empty && textBoxManagementToken.Text != string.Empty && textBoxName.Text != string.Empty)
            {
                try
                {
                    //add code to save to xml and refresh listbox on launcher
                    string filename = "Providers.xml";

                    //create new instance of XmlDocument
                    XmlDocument doc = new XmlDocument();

                    //load from file
                    doc.Load(filename);

                    //create node and add value
                    XmlNode node = doc.CreateNode(XmlNodeType.Element, "Provider", null);

                    //create XML nodes
                    XmlNode nodeName = doc.CreateElement("Name");
                    nodeName.InnerText = textBoxName.Text.Trim();

                    XmlNode nodeFileAccessToken = doc.CreateElement("FileAccessToken");
                    nodeFileAccessToken.InnerText = textBoxFileAccessToken.Text.Trim().Encrypt();

                    XmlNode nodeManagementToken = doc.CreateElement("ManagementToken");
                    nodeManagementToken.InnerText = textBoxManagementToken.Text.Trim().Encrypt();

                    //add to parent node
                    node.AppendChild(nodeName);
                    node.AppendChild(nodeFileAccessToken);
                    node.AppendChild(nodeManagementToken);

                    //add to elements collection
                    doc.DocumentElement.AppendChild(node);

                    //save xml file
                    doc.Save(filename);

                    //hide form
                    this.Hide();

                    //new instance of main to have refreshed listbox
                    Form newMain = new Main();
                    newMain.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, appName);
                }
            }
            else
            {
                MessageBox.Show("You must provide a name, and both tokens for your new customer entry.", appName);
                textBoxName.Focus();
            }
        }
    }
}
