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

namespace PropertyManagementSystem
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Community> communities = new Dictionary<string, Community>();
        public Form1()
        {
            AddCommunities();

            InitializeComponent();
        }

        private void AddCommunities()
        {
            string[] communityArr = new string[] { "Dekalb", "Sycamore" };
            foreach(string communityStr in communityArr)
            {
                Community community = new Community(communityStr);
                AddResidents(community);
                AddProperties(community);

                communities.Add(communityStr, community);
            }
        }

        private void AddResidents(Community community)
        {
            string residentFile = $"../../Community/{community.name}/p.txt";

            StreamReader sr = new StreamReader(residentFile);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] person = line.Split('\t');
                community.addResident(new Person(person));
                line = sr.ReadLine();
            }

            sr.Close();
        }

        private void AddProperties(Community community)
        {
            string[] propertyFiles = new string[] {
                $"../../Community/{community.name}/a.txt",
                $"../../Community/{community.name}/r.txt",
            };

            StreamReader sr;
            string line;
            for (int i = 0; i < propertyFiles.Length; i++)
            {
                string filePath = propertyFiles[i];
                sr = new StreamReader(filePath);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] property = line.Split('\t');
                    if (i == 0)
                    {
                        community.addProperty(new Apartment(property));
                    }
                    else
                    {
                        community.addProperty(new House(property));
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
            }
        }

        private void communityOptionsChanged(object sender, EventArgs e)
        {
            string communityName = (string)communityOptions.SelectedItem;
            Community community = communities[communityName];

            if (community != null)
            {
                residenceDropDown.DataSource = community.Props.ToArray();
                personListBox.DataSource = community.Residents.ToArray();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
