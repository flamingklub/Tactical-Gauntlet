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

            if(game == "Final Fantasy Tactics Ps1")
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
                    int num = random.Next(1, 20 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Final Fantasy Tactics PSP")
            {
                string path5 = Server.MapPath("TextFile5.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path5));
                int i = 0;
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(1, 22 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre Ps1/SNES")
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
                    int num = random.Next(1, 21 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre PSP")
            {
                string path6 = Server.MapPath("TextFile6.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path6));
                int i = 0;
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(1, 17 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
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
                    int num = random.Next(1, 15 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Fell Seal")
            {
                string path4 = Server.MapPath("TextFile4.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path4));
                int i = 0;
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(1, 20 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
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