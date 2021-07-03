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

            var game = DropDownList1.SelectedItem.Text;
            string count = DropDownList2.SelectedItem.Value;
            int rcount = int.Parse(count);
            int i = 0;

            if (game == "Final Fantasy Tactics Ps1")
            {
                string path = Server.MapPath("fftps1.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path));
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(0, 18 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Final Fantasy Tactics PSP")
            {
                string path = Server.MapPath("fftpsp.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path));
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(0, 20 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre Ps1/SNES")
            {
                string path = Server.MapPath("topssnes.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path));
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(0, 19 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre PSP")
            {
                string path = Server.MapPath("topsp.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path));
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(0, 15 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Tactics Ogre: Knights of Lodis")
            {
                string path = Server.MapPath("tokol.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path));
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(0, 13 - i);
                    writer.WriteLine(klass[num]);
                    klass.Remove(klass[num]);
                }
                i = 0;
            }
            if (game == "Fell Seal")
            {
                string path = Server.MapPath("fellseal.txt");
                StreamReader reader = new StreamReader(File.OpenRead(path));
                string line;
                var klass = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    klass.Add(line);
                }
                for (i = 0; i < rcount; i++)
                {
                    int num = random.Next(0, 18 - i);
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