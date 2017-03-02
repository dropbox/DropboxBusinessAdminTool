using System;
using System.Diagnostics;
using System.Configuration;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProviderLauncher
{
    public partial class Main : Form
    {
        public static string appName = "Dropbox Partner Launchpad for Admin Toolkit";

        public Main()
        {
            InitializeComponent();
            listBoxProviderList.MouseDoubleClick += new MouseEventHandler(listBoxProviderList_DoubleClick);
            StartPosition = FormStartPosition.CenterScreen;
            LoadProviderNames();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            LaunchProvider();
        }

        private void LoadProviderNames()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Providers.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Providers/Provider");
                //load Name of each entry in xml file
                foreach (XmlNode node in nodeList)
                {
                    listBoxProviderList.Items.Add(node.SelectSingleNode("Name").InnerText);
                }
                //select first item if at least one item in xml file
                if (listBoxProviderList.Items.Count > 0)
                {
                    listBoxProviderList.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, appName);
            }
        }

        private void LaunchProvider()
        {
            if (listBoxProviderList.Items.Count > 0)
            {
                DialogResult d;

                d = MessageBox.Show("Are you sure you want to launch the Admin Toolkit for the customer " + listBoxProviderList.SelectedItem.ToString() + "?", appName, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    string filePath = System.IO.Path.GetFullPath("DfBAdminToolkit.exe.config");
                    string selectedProvider = listBoxProviderList.SelectedItem.ToString();
                    string selectedAccessToken = string.Empty;
                    string selectedProvisionToken = string.Empty;

                    //grab tokens of selected item
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Providers.xml");
                    XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Providers/Provider");
                    //load Name of each entry in xml file
                    foreach (XmlNode node in nodeList)
                    {
                        string providerName = node.SelectSingleNode("Name").InnerText;
                        string defaultAccessToken = node.SelectSingleNode("FileAccessToken").InnerText;
                        string defaultProvisionToken = node.SelectSingleNode("ManagementToken").InnerText;

                        if (providerName == selectedProvider)
                        {
                            selectedAccessToken = defaultAccessToken;
                            selectedProvisionToken = defaultProvisionToken;
                        }
                    }
                    //write tokens to admin toolkit's config file
                    var map = new ExeConfigurationFileMap { ExeConfigFilename = filePath };
                    try
                    {
                        //Kill any existing running instances of admin toolkit
                        foreach (var process in Process.GetProcessesByName("DfBAdminToolkit"))
                        {
                            process.Kill();
                        }
                        // Open App.Config of executable
                        Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

                        //update the token keys
                        config.AppSettings.Settings["DefaultAccessToken"].Value = selectedAccessToken;
                        config.AppSettings.Settings["DefaultProvisionToken"].Value = selectedProvisionToken;

                        // Save the changes in App.config file.
                        config.Save(ConfigurationSaveMode.Modified);

                        // Force a reload of a changed section.
                        ConfigurationManager.RefreshSection("appSettings");

                        //launch Admin Toolkit with new tokens
                        Process.Start("DfBAdminToolkit.exe");
                    }
                    catch (ConfigurationErrorsException ex)
                    {
                        MessageBox.Show(ex.Message, appName);
                    }
                }
                else if (d == DialogResult.Cancel)
                {
                    //do nothing
                }
            }
            else
            {
                MessageBox.Show("You must select an account you have added to launch.", appName);
            }   
        }

        void listBoxProviderList_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxProviderList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                LaunchProvider();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //new instance of add customer
            Form addProvider = new AddProvider();
            addProvider.Show();

            //hide this form so we can reload later with refreshed listbox after adding new one
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;

            if (listBoxProviderList.SelectedItem.ToString() != string.Empty)
            {
                try
                {
                    d = MessageBox.Show("Are you sure you want to delete the customer " + listBoxProviderList.SelectedItem.ToString() + "?", appName, MessageBoxButtons.OKCancel);
                    if (d == DialogResult.OK)
                    {
                        //get selected name
                        string selectedProvider = listBoxProviderList.SelectedItem.ToString();
                        //grab node values form xml file based on name selected in listbox
                        string fileName = "Providers.xml";
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(fileName);
                        XmlNodeList providerNodes = xmlDoc.DocumentElement.SelectNodes("/Providers/Provider");
                        foreach (XmlNode node in providerNodes)
                        {
                            string providerName = node.SelectSingleNode("Name").InnerText;

                            if (providerName == selectedProvider)
                            {
                                node.ParentNode.RemoveChild(node);
                            }
                        }
                        xmlDoc.Save(fileName);

                        //remove item from listbox
                        listBoxProviderList.Items.Remove(listBoxProviderList.Items[listBoxProviderList.SelectedIndex]);
                        //refresh listbox
                        listBoxProviderList.Update();
                    }
                    else if (d == DialogResult.Cancel)
                    {
                        //do nothing
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, appName);
                }
            }
            else
            {
                MessageBox.Show("You must select a customer first to delete.", appName);
            }
        }
    }
}
