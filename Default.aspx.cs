using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tactical_Gautlet
{
    public partial class _Default : Page
    {
        private readonly Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            string tmppath = Server.MapPath("temptext.txt");
            File.WriteAllText(tmppath, String.Empty);
            StreamWriter writer = new StreamWriter(File.OpenWrite(tmppath));

            var game = DropDownList1.SelectedItem.Value;
            string count = DropDownList2.SelectedItem.Value;
            int rcount = int.Parse(count);

            if(game == "Final Fantasy Tactics")
            {
                string path1 = Server.MapPath("TextFile1.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path1));
                int i = 0;
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(19);
                    writer.WriteLine(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre")
            {
                string path2 = Server.MapPath("TextFile2.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path2));
                int i = 0;
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(30);
                    writer.WriteLine(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre: Knights of Lodis")
            {
                string path3 = Server.MapPath("TextFile3.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path3));
                int i = 0;
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(14);
                    writer.WriteLine(klass[num]);
                }
                i = 0;
            }
            writer.Close();
            StreamReader readers = new StreamReader(File.OpenRead(tmppath));
            TextBox1.Text = readers.ReadToEnd();
            readers.Close();
            File.WriteAllText(tmppath, String.Empty);
        }
    }
}