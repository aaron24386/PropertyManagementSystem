using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagementSystem
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /*

        static private bool ExecuteAction(int action)
        {
            bool returnVal = true;
            string input = "";
            switch (action)
            {
                case 1:
                    community.DisplayPropertyList();
                    break;
                case 2:
                    DetermineAddressType();
                    break;
                case 3:
                    community.DisplayForSaleProperties();
                    break;
                case 4:
                    community.DisplayAllResidents();
                    break;
                case 5:
                    input = CollectAddressName();
                    community.DisplayResidentsByAddress(input);
                    break;
                case 6:
                    input = CollectAddressName();
                    community.ToggleForSaleStatus(input);
                    break;
                case 7:
                    input = CollectAddressName();
                    community.PurchaseProperty(input);
                    break;
                default:
                    Console.WriteLine($"{action} is an invalid action, please try again.");
                    returnVal = false;
                    break;
            }

            return returnVal;
        }*/
    }
}
