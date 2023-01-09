using Microsoft.VisualBasic.Logging;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsyncCsharp
{
    public partial class Form1 : Form
    {
        ArrayList directories_one = new ArrayList();
        ArrayList directories_two = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_showHora_Click(object sender, EventArgs e)
        {

            tb_hora.Text = getHora();
        }

        private async void btn_OpenFolderOne_ClickA(object sender, EventArgs e)
        {
                tb_TimerFolderOne.Text = await ReturnRutaFolder();
                
                
        }

        private Task<String> ReturnRutaFolder()
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    return Task.FromResult(fd.SelectedPath.ToString());
                }
                else
                {
                    return Task.FromResult("");
                }
            }
        }

        private async void btn_OpenFolderTwo_Click(object sender, EventArgs e)
        {
            tb_TimerFolderTwo.Text = await ReturnRutaFolder();
        }


        private async Task getFileFromDirectories(string Folder, int folder_num)
        {
            if (folder_num == 1)
            {
                lock (directories_one)
                {
                    directories_one.Clear();
                }
            }
            else if (folder_num == 2)
            {
                lock (directories_two)
                {
                    directories_two.Clear();
                }
            }
            try
            {
                if ( folder_num == 1)
                {

                    foreach (string d in Directory.GetDirectories(Folder))
                    {
                        try
                        {
                            foreach (string s in Directory.GetFiles(d))
                                {
                            
                                string V = s.ToString();
                                if (cb_show_path_collection.CheckState.ToString() != "Checked")
                                {
                                    V = s.Split('\\')[s.Split('\\').Count() - 1].ToString();
                                }
                                if (folder_num == 1)
                                {
                                    directories_one.Add(V);
                                }
                                else if (folder_num == 2)
                                {
                                    directories_two.Add(V);
                                }
                                System.Threading.Thread.Sleep(1);
                             }
                         }
                        catch (Exception e)
                        {

                        }
        }
                }
                else if (folder_num == 2)
                {
                    string[] directories = Directory.GetDirectories(Folder);

                    Parallel.ForEach(directories, d =>
                    {
                        try
                        {
                            string[] files = Directory.GetFiles(d);
                            Parallel.ForEach(files, s =>
                            {
                                string V = s.ToString();
                                if (cb_show_path_collection.CheckState.ToString() != "Checked")
                                {
                                    V = s.Split('\\')[s.Split('\\').Count() - 1].ToString();
                                }
                                if (folder_num == 1)
                                {
                                    lock (directories_one)
                                    {
                                        directories_one.Add(V);
                                    }
                                }
                                else if (folder_num == 2)
                                {
                                    lock (directories_two)
                                    {
                                        directories_two.Add(V);
                                    }
                                }
                            });
                        }
                        catch(Exception e)
                        {
                            
                        }
                    });

                }
                if (folder_num == 1)
                {
                    lstb_FolderOne.Items.Clear();
                    lstb_FolderOne.Items.AddRange(directories_one.ToArray());
                    if (lstb_FolderOne.Items.Count < 1)
                    {
                        lstb_FolderOne.Items.Add("Empty");
                    }
                }
                else if (folder_num == 2)
                {
                    lstb_FolderTwo.Items.Clear();
                    lstb_FolderTwo.Items.AddRange(directories_two.ToArray());
                    if (lstb_FolderTwo.Items.Count < 1)
                    {
                        lstb_FolderTwo.Items.Add("Empty");
                    }
                }
            }
            catch (Exception)
            {
                switch (folder_num)
                {
                    case 1: tb_time_folderOne.Text = "ERROR - NO SE SELECCIONO CARPETA"; break;
                    case 2: tb_time_folderTwo.Text = "ERROR - NO SE SELECCIONO CARPETA"; break;
                }
            }
                
        }
        private String getHora()
        {   
            return "Són les " + DateTime.Now.ToString("HH:mm:ss");
        }
        public void LimpiarArchivos(int folder_num = 1)
        {
            switch (folder_num)
            {
                case 1:
                    directories_one.Clear();
                    break;
                case 2:
                    directories_two.Clear();
                    break;
                default:
                    directories_one.Clear();
                    directories_two.Clear();
                    break;
            }
        }

        private async void btn_FileListOne_Click(object sender, EventArgs e)
        {
            tb_time_folderOne.Text = "Processing";

            if (tb_time_folderOne.Text.Length > 0)
            {
                Stopwatch clock = new Stopwatch();
                clock.Restart();
                await getFileFromDirectories(tb_TimerFolderOne.Text, 1);
                clock.Stop();
                if (tb_time_folderOne.Text != "ERROR - NO SE SELECCIONO CARPETA")
                {
                    tb_time_folderOne.Text = clock.Elapsed.TotalSeconds.ToString() + " segons";
                }
            }
            else
            {
                tb_time_folderOne.Text = "ERROR - NO SE SELECCIONO CARPETA";

            }
        }

        private async void btn_FileListTwo_Click(object sender, EventArgs e)
        {
            tb_time_folderTwo.Text = "Processing";

            if (tb_time_folderTwo.Text.Length > 0)
            {
                Stopwatch clock = new Stopwatch();
                clock.Restart();
                await getFileFromDirectories(tb_TimerFolderTwo.Text, 2);
                clock.Stop();
                if (tb_time_folderTwo.Text != "ERROR - NO SE SELECCIONO CARPETA")
                {
                    tb_time_folderTwo.Text = clock.Elapsed.TotalSeconds.ToString() + " segons";
                }
            }
            else
            {
                tb_time_folderTwo.Text = "ERROR - NO SE SELECCIONO CARPETA";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //tv_CarpetaOne.Text = cb_show_path_collection.CheckState.ToString();
        }
    }
}