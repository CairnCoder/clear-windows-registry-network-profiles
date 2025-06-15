using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Clear_Registry_Network_Profiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Icon = Properties.Resources.icon;
            InitializeComponent();
            try
            {
                showNetworkProfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<NetworkProfile> getNetworkProfileNames()
        {
            List<NetworkProfile> networkProfileNames = new List<NetworkProfile>();

            string profilesKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
            using (RegistryKey rkLocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                // Get profile names
                using (RegistryKey rk = rkLocalMachine.OpenSubKey(profilesKeyPath, false))
                {
                    foreach (var profile in rk.GetSubKeyNames())
                    {
                        string profileKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles" + @"\" + profile;

                        // Delete network profiles
                        using (RegistryKey rk2 = rkLocalMachine.OpenSubKey(profileKeyPath, false))
                        {
                           networkProfileNames.Add(new NetworkProfile(profile, rk2.GetValue("ProfileName").ToString()));
                        }
                    }
                }
            }
            return networkProfileNames;
        }

        private void deleteNetworkProfiles(List<NetworkProfile> networkProfiles)
        {
            foreach (var profile in networkProfiles)
            {
                if (profile.profileName.Contains("Network"))
                {
                    using (RegistryKey rkLocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    {
                        string profileKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles" + @"\" + profile.registoryPath;
                        rkLocalMachine.DeleteSubKey(profileKeyPath, false);
                    }
                }
            }
        }

        public void showNetworkProfiles()
        {
            //dgViewNetworkProfiles.AutoGenerateColumns = false;
            dgViewNetworkProfiles.DataSource = getNetworkProfileNames();
        }

        private void btnGetNetworkProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                showNetworkProfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveNetworks_Click(object sender, EventArgs e)
        {
            try
            {
                deleteNetworkProfiles(getNetworkProfileNames());
                showNetworkProfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgViewNetworkProfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clipboard.SetText(dgViewNetworkProfiles[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
            catch { }
        }

        private void dgViewNetworkProfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clipboard.SetText(dgViewNetworkProfiles[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
            catch { }
        }
    }
}
