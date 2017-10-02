using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace ServiceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Multiline = true;      //Multiline for Multiple Entries
            textBox1.ScrollBars = ScrollBars.Vertical;      //Scrollable Space

        }

        private void Query_Click(object sender, EventArgs e)
        {

            string providerPath;
            ConnectionOptions Options = new ConnectionOptions();
            int top = 200;
            int top2 = 160;

           

            string[] lines = textBox1.Lines;

            for (int i = 0; i < lines.Length; i++)
            {


                int left = 50;
                int left2 = 140;

                string s = lines[i];

                Button butto = new Button();
                butto.Width = 200;
                butto.Text = s;

                butto.Top = top2;
                butto.Left = 50;
                this.Controls.Add(butto);




                providerPath = String.Format(@"\\{0}\root\CIMv2", s);
                ManagementScope scope = new ManagementScope(providerPath, Options);
                try
                {
                    scope.Connect();
                }
                catch {
                    Button button3 = new Button();
                    button3.Left = left2;
                    button3.Top = top;
                    button3.Text = "Server is unreachable";
                    button3.Width = 150;
                    Controls.Add(button3);

                    top += button3.Height + 52;
                    top2 += button3.Height + 52;
                    
                    continue;
                }


                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Service WHERE StartMode LIKE 'Auto' AND State = 'Stopped'");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                foreach (ManagementObject o in searcher.Get())

                {
                    string DisplayName = o["DisplayName"].ToString();
                    string name = o["Name"].ToString();
                    Button button = new Button();
                    button.Left = left2;
                    button.Top = top;
                    button.Width = 200;
                    button.Text = DisplayName;

                    Button button2 = new Button();
                    button2.Left = left;
                    button2.Top = top;
                    button2.Text = "Start";

                    this.Controls.Add(button);
                    this.Controls.Add(button2);

                    top += button.Height + 2;
                    top2 += button.Height + 2;
                    button2.Click += new EventHandler(button2_Click);

                    void button2_Click(object sender1, EventArgs e1)
                    {
                        
                        ManagementPath path = new ManagementPath(string.Format("Win32_Service.Name='{0}'", name));
                        ManagementObject obj = new ManagementObject(scope, path, new ObjectGetOptions());
                        ManagementBaseObject outParams = obj.InvokeMethod("StartService", (ManagementBaseObject)null, null);
                        uint returnCode = System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
                    }
                }

                top += 50;
                top2 += 50;

                
            }

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
