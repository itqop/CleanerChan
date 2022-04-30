using System.Threading;
using System.ComponentModel;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.ServiceProcess;
using System.Diagnostics;

namespace WinFormsApp
{
    public partial class Antimalware : Form
    {
        public Antimalware()
        {
            InitializeComponent();
            CenterToScreen(); 
        }
        int DIR = 0;
        string Viruses = "";
        string Path_Signatures = "C:\\Users\\leonk\\source\\repos\\CleanerChan\\WinFormsApp\\bin\\Debug\\net6.0-windows\\34ieiennd2j";
        private int x, y;
        private int canWeGo = 0;
        String ResInfoPath = @"Result/Log.txt";
        String QuarInfoPath = "C:\\Users\\leonk\\source\\repos\\CleanerChan\\WinFormsApp\\bin\\Debug\\net6.0-windows\\Quarantine\\";
        private static Mutex objMutex = null;
        const string myAppName = "CleanerChan";
        bool isCreatedNew;
        string zips = "";
        bool iss = true;
        private async Task scanAsync(string item)
        {
            string signature = "";
            FileStream fs;

            try
            {
                fs = new FileStream(item, FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                return;
            }
            using (fs)
            {
                var temp = 0;
                int q = 1;
                var buffer = new byte[5000];
                string virus = "";
                bool All = true;
                bool exe = false;
                while (q != 0 && All)
                {
                    q = fs.Read(buffer, 0, buffer.Length);
                    temp += 4000;

                    signature = string.Join(" ", buffer.Select(b => b.ToString("X2")));
                    if (!signature.StartsWith("4D 5A 90") && !exe)
                    {
                        break;
                    }
                    exe = true;
                    while (!iss)
                    {
                        Thread.Sleep(200);
                    }
                    using (var reader = new StreamReader(Path_Signatures))
                    {
                        while (!reader.EndOfStream)
                        {
                            virus = reader.ReadLine();
                            if (signature.Contains(virus))
                            {
                                if (item.StartsWith("temp"))
                                {
                                    if (!Viruses.Contains(zips)) {
                                        Viruses += zips + "\n";
                                        if (!Quar_Box.Items.Contains(item))
                                        {
                                            Quar_Box.Items.Add(zips);
                                        }
                                    }
                                }
                                else
                                {
                                    Viruses += item + "\n";
                                    if (!Quar_Box.Items.Contains(item))
                                    {
                                        Quar_Box.Items.Add(item);
                                    }
                                    
                                }
                                All = false;
                            }
                        }
                    }
                    fs.Position = temp;
                }
            }
        }
        
        private void Mover(string item, string Quar_new)
        {
            File.Move(item, QuarInfoPath + Quar_new);
            //File.Move("C:\\Users\\leonk\\Desktop\\v\\q\\w\\9.exe", "C:\\Users\\leonk\\source\\repos\\CleanerChan\\WinFormsApp\\bin\\Debug\\net6.0-windows\\Quarantine\\9.exe");
        }
 
        private void btn_Explore_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();
            opd.ValidateNames = false;
            opd.CheckFileExists = false;
            opd.CheckPathExists = true;
            opd.FileName = "Folder Selection.";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                if (opd.FileName.Contains("."))
                {
                    txt_Line.Text = opd.FileName;
                    DIR = 0;
                }
                else
                {
                    txt_Line.Text = Path.GetDirectoryName(opd.FileName);
                    DIR = 1;
                }

            }
        }

        private async void btn_Scan_Click(object sender, EventArgs e)
        {
            canWeGo = 0;
            //Thread scanThread = new Thread(back_Scan);
            btn_Play.Enabled = false;
            btn_Stop.Enabled = true;
            btn_Pause.Enabled = true;
  
            btn_FullScan.Enabled = false;
            btn_Scan.Enabled = false;
            btn_Explore.Enabled = false;

            Viruses = "";
            if (sender.ToString().EndsWith("\\"))
            {
                DIR = 1;
                txt_Line.Text = sender.ToString();
            }
            if (DIR == 1)
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    backgroundWorker1.RunWorkerAsync();
                }
                // scanThread.IsBackground = true;
                //scanThread.Start();

            }
            else
            {
                if (txt_Line.Text.EndsWith(".zip")){
                    if (!Directory.Exists(temppath))
                    {
                        Directory.CreateDirectory(temppath);
                    }
                    zips = txt_Line.Text;
                    string destFile = Path.Combine(temppath, "test.zip");
                    File.Copy(txt_Line.Text, destFile);
                    ZipChecker(destFile);
                }
                else { 
                    scanAsync(txt_Line.Text);
                }

                string dater = DateTime.Now.ToString("g");
                string letter = "";
                if (Viruses.Length > 0)
                {

                    MessageBox.Show("Найдены вирусы в файлах");
                    using (StreamWriter writer = new StreamWriter(ResInfoPath, true))
                    {
                        letter = "\n" + dater + ":" + "Найдены вирусы по адресам -\n" + Viruses;
                        await writer.WriteAsync(letter);
                        //Journal.Items.Add(letter);
                    }
                }
                else
                {
                    MessageBox.Show("Вирусы не найдены");
                    using (StreamWriter writer = new StreamWriter(ResInfoPath, true))
                    {
                       letter = "\n" + dater + ":" + "Вирусы не найдены";
                       await writer.WriteLineAsync(letter);
                       //Journal.Items.Add(letter);
                    }
                }
                await ReadResult();
                btn_Stop_Click(null, EventArgs.Empty);
                
            }
            canWeGo = 1;
           

        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Directory.Delete(temppath, true);
            Directory.CreateDirectory(temppath);
            Application.Exit();
        }

        private void btn_Svor_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Enter(object sender, EventArgs e)
        {
            btn_Close.BackColor = System.Drawing.Color.Red;
        }

        private void btn_Close_Leave(object sender, EventArgs e)
        {
            btn_Close.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            btn_Main.BackColor = System.Drawing.Color.ForestGreen;
            btn_Logs.BackColor = System.Drawing.Color.DarkSlateGray;
            btn_Quarantine.BackColor = System.Drawing.Color.DarkSlateGray;
            panel_Scan.Visible = true;
            panel4.Visible = false;
            panel_Quar.Visible = false;
        }

        private void btn_Logs_Click(object sender, EventArgs e)
        {
            btn_Logs.BackColor = System.Drawing.Color.ForestGreen;
            btn_Main.BackColor = System.Drawing.Color.DarkSlateGray;
            btn_Quarantine.BackColor = System.Drawing.Color.DarkSlateGray;
            panel_Scan.Visible = false;
            panel4.Visible = true;
            panel_Quar.Visible = false;
        }
        private async void btn_Quarantine_Click(object sender, EventArgs e)
        {
            btn_Main.BackColor = System.Drawing.Color.DarkSlateGray;
            btn_Logs.BackColor = System.Drawing.Color.DarkSlateGray;
            btn_Quarantine.BackColor = System.Drawing.Color.ForestGreen;
            panel_Scan.Visible = false;
            panel4.Visible = false;
            panel_Quar.Visible = true;
            string? line;
            using (StreamReader reader = new StreamReader(QuarInfoPath + "Logs.txt"))
            {
                line = await reader.ReadToEndAsync();

            }
            foreach (string item in Quar_Box.Items)
            {
                if (line.Contains(item)){
                    continue;
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(QuarInfoPath + "Logs.txt", true))
                    {
                        await writer.WriteAsync(item + "\n");

                    }
                }
                string Quar_new = item.Replace(":", ".01").Replace("\\", ".02");
                Mover(item, Quar_new);
                Thread.Sleep(100);
                string str;
                using (StreamReader sreader = new StreamReader(QuarInfoPath + Quar_new, System.Text.Encoding.GetEncoding(20127)))
                {
                    str = sreader.ReadToEnd();
                }
                File.Delete(QuarInfoPath + Quar_new);

                using (StreamWriter swriter = new StreamWriter(QuarInfoPath + Quar_new, false, System.Text.Encoding.GetEncoding(20127)))
                {
                    str = "0" + Environment.NewLine + str;
                    swriter.Write(str);
                }
                /*
                FileStream fs;

                try
                {
                    fs = new FileStream(QuarInfoPath+Quar_new, FileMode.Open, FileAccess.ReadWrite);
                }
                catch (Exception ex)
                {
                    return;
                }
                using (fs)
                {
                    fs.Rea
                }*/
            }
        }

        private async void btn_FullScan_Click(object sender, EventArgs e)
        {
            //Thread scanThread = new Thread(FullScan);
            btn_Scan_Click("C:\\", EventArgs.Empty);
            //btn_Scan_Click("D:\\", EventArgs.Empty);
            //btn_Scan_Click("E:\\", EventArgs.Empty);

        }

        private void Wait()
        {
            do
            {
                Thread.Sleep(10000);
            } while (canWeGo == 0);
        }
        private async Task FullScan()
        { 
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                btn_Scan_Click(drive.Name, EventArgs.Empty);
                await Task.Run(() => Wait());
            }
            
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            btn_Play.Enabled = false;
            btn_Stop.Enabled = true;
            btn_Pause.Enabled = true;
            iss = true;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            btn_Play.Enabled = true;
            btn_Stop.Enabled = true;
            btn_Pause.Enabled = false;
            iss = false;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            btn_Play.Enabled = false;
            btn_Stop.Enabled = false;
            btn_Pause.Enabled = false;
            btn_FullScan.Enabled = true;
            btn_Scan.Enabled = true;
            btn_Explore.Enabled = true;
            progress_Scan.Value = 0;
                // Cancel the asynchronous operation.
            backgroundWorker1.CancelAsync();
        }

        private void txt_Line_TextChanged(object sender, EventArgs e)
        {
            if (txt_Line.Text == "")
            {
                btn_Scan.Enabled = false;
            }
            else
            {
                btn_Scan.Enabled = true;
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (txt_Line.Text == "C:\\" || txt_Line.Text == "E:\\"  ||txt_Line.Text == "E:\\")
            {
                var directoryList = new DirectoryInfo(txt_Line.Text)
            .EnumerateDirectories()
            .Where(dirInfo => !dirInfo.Name.Equals("Documents and Settings") && !dirInfo.Name.Equals("System Volume Information")
            && !dirInfo.Name.Equals("$Recycle.Bin") && !dirInfo.Name.Equals("Intel") && !dirInfo.Name.Equals("ProgramData") && !dirInfo.Name.Equals("Users") && !dirInfo.Name.Equals("Windows"))
            .ToArray();
                int count1 = 0;
                foreach (var directory in directoryList)
                {
                    var filess = Directory.GetFiles(directory.FullName, "*", SearchOption.AllDirectories);
                    count1 += filess.Length;
                }
                foreach (var file in directoryList)
                {
                    var files = Directory.GetFiles(file.FullName, "*", SearchOption.AllDirectories);
                    double step = 100d / (double)count1;
                    double process = 0;
                    foreach (var item in files)
                    {
                        if (worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        else
                        {
                            zips = (string)item;
                            // Perform a time consuming operation and report progress.
                            if (item.EndsWith(".zip"))
                            {
                                string destFile = Path.Combine(temppath, "test.zip");
                                File.Copy(item, destFile);
                                ZipChecker(destFile);
                            }
                            scanAsync(item);
                            process += step;
                            if ((int)Math.Floor(process) >= progress_Scan.Value)
                            {
                                worker.ReportProgress((int)Math.Floor(process));

                            }
                        }


                    }
                }
            }
            else
            {
                var files = Directory.GetFiles(txt_Line.Text, "*", SearchOption.AllDirectories);
                double step = 100d / (double)files.Length;
                double process = 0;
                foreach (var item in files)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        zips = (string)item;
                        // Perform a time consuming operation and report progress.
                        if (item.EndsWith(".zip"))
                        {
                            string destFile = Path.Combine(temppath, "test.zip");
                            File.Copy(item, destFile);
                            ZipChecker(destFile);
                        }
                        scanAsync(item);
                        process += step;
                        if ((int)Math.Floor(process) >= progress_Scan.Value)
                        {
                            worker.ReportProgress((int)Math.Floor(process));

                        }
                    }


                }
            }
            //var files = Directory.GetFiles(txt_Line.Text, "*", SearchOption.TopDirectoryOnly);
            


        }

        private async void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string dater = DateTime.Now.ToString("g");
            string letter = "";
            if (Viruses.Length > 0)
            {

                MessageBox.Show("Найдены вирусы в файлах");
                using (StreamWriter writer = new StreamWriter(ResInfoPath, true))
                {
                    letter = "\n" + dater + ":" + "Найдены вирусы по адресам -\n" + Viruses;
                    await writer.WriteAsync(letter);
                    //Journal.Items.Add(letter);

                }
            }
            else
            {
                MessageBox.Show("Вирусы не найдены");
                using (StreamWriter writer = new StreamWriter(ResInfoPath, true))
                {
                    letter = "\n" + dater + ":" + "Вирусы не найдены";
                    await writer.WriteLineAsync(letter);
                    //Journal.Items.Add(letter);
                    
                }
            }
            await ReadResult();
            btn_Stop_Click(null, EventArgs.Empty);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progress_Scan.Value = e.ProgressPercentage;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Antimalware.ActiveForm.Left = (Antimalware.ActiveForm.Left + e.X) - x;
                Antimalware.ActiveForm.Top = (Antimalware.ActiveForm.Top + e.Y) - y;
            }
        }

        string temppath = @"temp";
        ZipArchive archive;

        private void btn_Delete_Viruses_Click(object sender, EventArgs e)
        {
            foreach(string item in Viruses.Split("\n"))
            {
                if (item == "")
                {
                    break;
                }
                File.Delete(item);
            }
            MessageBox.Show("Вирусы удалены");
        }
        ServiceController[] scServices;
        private async void Antimalware_Load(object sender, EventArgs e)
        {
            
           

            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {
                if ((scTemp.Status == ServiceControllerStatus.Stopped || scTemp.Status == ServiceControllerStatus.StopPending)
                        && (scTemp.ServiceName == "TestService" || scTemp.ServiceName == "TestService1"))
                {
                    scTemp.Start();
                    //scTemp.WaitForStatus(ServiceControllerStatus.Running);
                    scTemp.Refresh();
                }
            }
            objMutex = new Mutex(true, myAppName, out isCreatedNew);

            if (!isCreatedNew)
            {
                MessageBox.Show("Already running!");

                Application.Exit();
            }

            Directory.Delete(temppath, true);
            Directory.CreateDirectory(temppath);
            string? line;
            using (StreamReader reader = new StreamReader(QuarInfoPath + "Logs.txt"))
            {
                line = await reader.ReadToEndAsync();

            }
            foreach (string l in line.Split("\n"))
            {
                Quar_Box.Items.Add(l);
            }


            Journal.View = View.Details;
            Journal.FullRowSelect = true;
            Journal.Columns.Add("Logs", -2);

            await ReadResult();
        }
        public async Task ReadResult()
        {
            using (StreamReader reader = new StreamReader(ResInfoPath))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    ListViewItem item;
                    item = new ListViewItem(line);
                    Journal.Items.Add(item);
                }

            }
        }

        private async void btn_Recovery_Click(object sender, EventArgs e)
        {
            if(Quar_Box.SelectedItems.Count != 0)
            {
                
                foreach(string item in Quar_Box.SelectedItems)
                {
                    if (Quar_Box.SelectedItem.ToString() == "")
                {
                        continue;
                    
                }
                    string Quar_new = item.Replace(":", ".01").Replace("\\", ".02");
                    string str;
                    using (StreamReader sreader = new StreamReader(QuarInfoPath + Quar_new, System.Text.Encoding.GetEncoding(20127)))
                    {
                        str = sreader.ReadToEnd();
                    }
                    File.Delete(QuarInfoPath + Quar_new);

                    using (StreamWriter swriter = new StreamWriter(QuarInfoPath + Quar_new, false, System.Text.Encoding.GetEncoding(20127)))
                    {
                        str = str.Substring(3);
                        swriter.Write(str);
                    }
                    File.Move(QuarInfoPath + Quar_new ,item);
                    string? line;
                    using (StreamReader reader = new StreamReader(QuarInfoPath + "Logs.txt"))
                    {
                        line = await reader.ReadToEndAsync();
                        line = line.Replace(item + "\n", "");

                    }
                    Thread.Sleep(100);
                    using (StreamWriter writer = new StreamWriter(QuarInfoPath + "Logs.txt", false))
                    {
                        await writer.WriteAsync(line);

                    }
                    
                }
                Quar_Box.Items.Remove(Quar_Box.SelectedItem);
            }
        }

        private async void btn_Del_One_Click(object sender, EventArgs e)
        {
            if (Quar_Box.SelectedItems.Count != 0)
            {

                foreach (string item in Quar_Box.SelectedItems)
                {
                    if (Quar_Box.SelectedItem.ToString() == "")
                    {
                        continue;

                    }
                    string Quar_new = item.Replace(":", ".01").Replace("\\", ".02");
                    File.Move(QuarInfoPath + Quar_new, item);
                    string? line;
                    using (StreamReader reader = new StreamReader(QuarInfoPath + "Logs.txt"))
                    {
                        line = await reader.ReadToEndAsync();
                        line = line.Replace(item + "\n", "");

                    }
                    Thread.Sleep(100);
                    using (StreamWriter writer = new StreamWriter(QuarInfoPath + "Logs.txt", false))
                    {
                        await writer.WriteAsync(line);

                    }

                }
                Quar_Box.Items.Remove(Quar_Box.SelectedItem);
            }
        }

        public void ZipChecker(string path)
        {
            try
            {
                archive = ZipFile.OpenRead(path);
                
            }
            catch (Exception ex)
            {
                return;
            }

            foreach (var entry in archive.Entries)
            {
                
                string fullPath = Path.Combine(temppath, entry.FullName);
                //MessageBox.Show(entry.FullName);
                if (entry.FullName.EndsWith(".zip"))
                {
                    
                    if (String.IsNullOrEmpty(entry.Name))
                    {
                        Directory.CreateDirectory(fullPath);
                    }
                    else
                    {
                        try
                        {
                            entry.ExtractToFile(fullPath);
                        }
                        catch (InvalidDataException)
                        {
                            File.Delete(fullPath);
                            break;
                        }
                    }
                }
                else
                {
                    link1:
                    try
                    {
                        entry.ExtractToFile(fullPath);
                    }
                    catch (IOException e)
                    {
                        var rand = new Random();
                        fullPath = fullPath.Insert(fullPath.IndexOf("."), rand.Next(100000, 9000000).ToString());
                        goto link1;
                        //entry.ExtractToFile(fullPath);
                       
                    }
                    catch (InvalidDataException e)
                    {
                        File.Delete(fullPath);
                        break;
                    }
                    scanAsync(fullPath);
                    

                }
            }
            archive.Dispose();
            File.Delete(path);
            if (Directory.EnumerateFiles(temppath, "*.*", SearchOption.AllDirectories).Any())
            {
                string[] fileNames = Directory.GetFiles(temppath, "*.*", SearchOption.AllDirectories);
                foreach (var fileName in fileNames)
                {
                    //MessageBox.Show(fileName);
                    ZipChecker(Path.GetFullPath(fileName));
                }
            }
        }
    }
}