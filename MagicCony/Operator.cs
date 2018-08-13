using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using System.Diagnostics;
using System.Drawing;
using System.Data.OleDb;
using System.IO;

namespace MagicCony
{
    class Operator
    {
        public static List<Form> listForms = new List<Form>();//���弯�ϣ���Ҫ������������������ʱʹ��

        /// <summary>
        /// �����������Ӷ���
        /// </summary>
        /// <returns>OleDbConnection����</returns>
        public static OleDbConnection getCon()
        {
            OleDbConnection conn;
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ConyData.accdb;");//����Access2007�����ϰ汾
            }
            catch
            {
                conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ConyData.mdb;");//����Access2000��2003�汾
            }
            return conn;//����OleDbConnection����
        }

        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="sql">Ҫִ�е�SQL���</param>
        public void ExecSQL(string sql)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ConyData.accdb;");//����Access2007�����ϰ汾
            conn.Open();//�����ݿ�����
            OleDbCommand cmd = new OleDbCommand(sql, conn);//����ִ���������
            cmd.ExecuteNonQuery();//ִ��SQL����
            conn.Close();//�ر����ݿ�����
        }

        /// <summary>
        /// ��Ӣ��ת��Ϊ��Ӧ����
        /// </summary>
        /// <param name="str">Ҫת����Ӣ���ַ���</param>
        /// <returns>ת����ĺ����ַ���</returns>
        private string EngtoCH(string str)
        {
            string strCH = "";//��¼ת����ĺ����ַ���
            switch (str)
            {
                case "AddressWidth":
                    strCH = "��ַ���";
                    break;
                case "Architecture":
                    strCH = "�ṹ";
                    break;
                case "Availability":
                    strCH = "����";
                    break;
                case "Caption":
                    strCH = "�ڲ����";
                    break;
                case "CpuStatus":
                    strCH = "���������";
                    break;
                case "CreationClassName":
                    strCH = "����������";
                    break;
                case "CurrentClockSpeed":
                    strCH = "��ǰʱ���ٶ�";
                    break;
                case "CurrentVoltage":
                    strCH = "��ǰ��ѹ";
                    break;
                case "DataWidth":
                    strCH = "���ݿ��";
                    break;
                case "Description":
                    strCH = "����";
                    break;
                case "DeviceID":
                    strCH = "�汾";
                    break;
                case "ExtClock":
                    strCH = "�ⲿʱ��";
                    break;
                case "L2CacheSize":
                    strCH = "��������";
                    break;
                case "L2CacheSpeed":
                    strCH = "���������ٶ�";
                    break;
                case "Level":
                    strCH = "����";
                    break;
                case "LoadPercentage":
                    strCH = "���ϰٷֱ�";
                    break;
                case "Manufacturer":
                    strCH = "������";
                    break;
                case "MaxClockSpeed":
                    strCH = "���ʱ���ٶ�";
                    break;
                case "Name":
                    strCH = "����";
                    break;
                case "PowerManagementSupported":
                    strCH = "��Դ����֧��";
                    break;
                case "ProcessorId":
                    strCH = "����������";
                    break;
                case "ProcessorType":
                    strCH = "����������";
                    break;
                case "Role":
                    strCH = "����";
                    break;
                case "SocketDesignation":
                    strCH = "�������";
                    break;
                case "Status":
                    strCH = "״̬";
                    break;
                case "StatusInfo":
                    strCH = "״̬��Ϣ";
                    break;
                case "Stepping":
                    strCH = "�ּ�";
                    break;
                case "SystemCreationClassName":
                    strCH = "ϵͳ����������";
                    break;
                case "SystemName":
                    strCH = "ϵͳ����";
                    break;
                case "UpgradeMethod":
                    strCH = "��������";
                    break;
                case "Version":
                    strCH = "�ͺ�";
                    break;
                case "Family":
                    strCH = "����";
                    break;
                case "Revision":
                    strCH = "�޶��汾��";
                    break;
                case "PoweredOn":
                    strCH = "��Դ����";
                    break; 
                case "Product":
                    strCH = "��Ʒ";
                    break; 
                    
            }
            if (strCH == "")//��������ַ���Ϊ��
                strCH = str;//ֱ����ʾӢ���ַ���
            return strCH;//���غ����ַ���
        }

        /// <summary>
        /// ��ȡӲ����ص�һЩ��Ϣ
        /// </summary>
        /// <param name="Key">Ҫ���ҵ�</param>
        /// <param name="lst">��ʾ��Ϣ��ListView���</param>
        /// <param name="DontInsertNull">��ʶ�Ƿ�����Ϣ</param>
        public void InsertInfo(string Key, ref DevComponents.DotNetBar.Controls.ListViewEx lst, bool DontInsertNull)
        {
            lst.Items.Clear();//����б�
            //����ManagementObjectSearcher����ʹ����Ҳ���Key������
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
            try
            {
                //����ManagementObjectSearcher������ҵ�����
                foreach (ManagementObject share in searcher.Get())
                {
                    ListViewGroup grp;//����ListViewGroup����
                    try
                    { 
                        //���������
                        grp = lst.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = lst.Groups.Add(share.ToString(), share.ToString());
                    }
                    //���û�в��ҵ���Ϣ���򵯳���ʾ
                    if (share.Properties.Count <= 0)
                    {
                        MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    foreach (PropertyData PC in share.Properties)//������ȡ��������
                    {
                        ListViewItem item = new ListViewItem(grp);//������ӵ�ListViewItem��
                        item.BackColor = Color.FromArgb(21, 49, 63);//����ÿ�еı�����ɫ
                        item.Text =EngtoCH(PC.Name); //������Ŀ����
                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())//�ж�ֵ������
                            {
                                case "System.String[]"://������ַ�������
                                    string[] str = (string[])PC.Value;//��¼����ֵ
                                    string str2 = "";//���������������¼�����д洢����������ֵ
                                    foreach (string st in str)//��������
                                        str2 += st + " ";//�м��ÿո�ָ�����¼����ֵ
                                    item.SubItems.Add(str2);//��ӵ��б���
                                    break;
                                case "System.UInt16[]"://�������������
                                    ushort[] shortData = (ushort[])PC.Value;
                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";
                                    item.SubItems.Add(tstr2);
                                    break;
                                default:
                                    item.SubItems.Add(PC.Value.ToString());//ֱ����ӵ��б�����
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)//���û����Ϣ������ӡ�û����Ϣ������ʾ
                                item.SubItems.Add("û����Ϣ");
                            else
                                continue;
                        }
                        lst.Items.Add(item); //��������ӵ�ListView�ؼ���
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// ��ListView�������ʾ����
        /// </summary>
        /// <param name="info">Ҫ��ʾ������</param>
        /// <param name="remark">�б�������</param>
        /// <param name="lv">ListView���</param>
        private void ShowInfo(string[] info,string remark, ListView lv)
        {
            ListViewItem item = new ListViewItem(info, remark);//��ӵ��б���
            lv.Items.Add(item);//��ʾ�б�
        }

        /// <summary>
        /// ��ȡWidnows��Ϣ
        /// </summary>
        /// <param name="lv">��ʾWindows��Ϣ��ListView���</param>
        public void GetInfo(ListView lv)
        {
            string[] info = new string[2];//����һ���ַ������飬�����洢Windows��ص���Ϣ
            info[0] = "����ϵͳ";//������
            info[1]=Environment.OSVersion.VersionString;//����ϵͳ�汾
            ShowInfo(info, "����ϵͳ",lv);//�����Զ��巽����ʾ����
            string strUser = "";
            try
            {
                RegistryKey mykey = Registry.LocalMachine;//��ȡע����еı��ػ�����
                mykey = mykey.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");//��λע�������
                strUser = (string)mykey.GetValue("RegisteredOrganization");//��ȡָ��ע������ֵ
                mykey.Close();//�ر�ע���
            }
            catch
            {}
            info[0] = "ע���û�";
            info[1] = strUser;//ע���û�
            ShowInfo(info, "ע���û�", lv);

            info[0] = "Windows�ļ���";
            info[1] = Environment.GetEnvironmentVariable("WinDir");//Windows�ļ���
            ShowInfo(info, "Windows�ļ���", lv);

            info[0] = "ϵͳ�ļ���";
            info[1] = Environment.SystemDirectory.ToString();//ϵͳ�ļ���
            ShowInfo(info, "ϵͳ�ļ���", lv);

            info[0] = "���������";
            info[1] = Environment.MachineName.ToString();//���������
            ShowInfo(info, "���������", lv);

            info[0] = "��������ʱ��";
            info[1] = DateTime.Now.ToString();//��������ʱ��
            ShowInfo(info, "��������ʱ��", lv);

            string strIDate = "";//�����������¼ϵͳ��װ����
            string strTime = "";//�����������¼ϵͳ����ʱ��
            //��WMI�в�ѯ����ϵͳ�����Ϣ
            ManagementObjectSearcher MySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject MyObject in MySearcher.Get())//������ѯ���
            {
                strIDate += MyObject["InstallDate"].ToString().Substring(0, 8);//��ȡϵͳ��װ����
                strTime += MyObject["LastBootUpTime"].ToString().Substring(0, 8);//��ȡ�������ʱ��
            }
            strIDate = strIDate.Insert(4, "-");//�����ڸ�ʽ���д���
            strIDate = strIDate.Insert(7,"-");
            info[0] = "ϵͳ��װ����";
            info[1] = strIDate;//ϵͳ��װ����
            ShowInfo(info, "ϵͳ��װ����", lv);

            strTime = strTime.Insert(4, "-");//��ʱ���ʽ���д���
            strTime = strTime.Insert(7, "-");
            info[0] = "ϵͳ����ʱ��";
            info[1] = strTime;//ϵͳ����ʱ��
            ShowInfo(info, "ϵͳ����ʱ��", lv);

            Microsoft.VisualBasic.Devices.Computer My = new Microsoft.VisualBasic.Devices.Computer();
            info[0]="�����ڴ�����(M)";
            info[1] = (My.Info.TotalPhysicalMemory / 1024 / 1024).ToString();//�����ڴ�����(M)
            ShowInfo(info, "�����ڴ�����(M)", lv);

            info[0] = "�����ڴ�����(M)";
            info[1] = (My.Info.TotalVirtualMemory / 1024 / 1024).ToString();//�����ڴ�����(M)
            ShowInfo(info, "�����ڴ�����(M)", lv);

            info[0] = "���������ڴ�����(M)";
            info[1] =(My.Info.AvailablePhysicalMemory / 1024 / 1024).ToString();//���������ڴ�����(M)
            ShowInfo(info, "���������ڴ�����(M)", lv);

            info[0] = "���������ڴ�����(M)";
            info[1] = (My.Info.AvailableVirtualMemory / 1024 / 1024).ToString();//���������ڴ�����(M)
            ShowInfo(info, "���������ڴ�����(M)", lv);

            info[0] = "ϵͳ������";
            info[1] = Environment.GetEnvironmentVariable("SystemDrive");//ϵͳ������
            ShowInfo(info, "ϵͳ������", lv);

            info[0] = "����Ŀ¼";
            info[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//����Ŀ¼
            ShowInfo(info, "����Ŀ¼", lv);

            info[0] = "�û�������Ŀ¼";
            info[1] = Environment.GetFolderPath(Environment.SpecialFolder.Programs);//�û�������Ŀ¼
            ShowInfo(info, "�û�������Ŀ¼", lv);

            info[0] = "�ղؼ�Ŀ¼";
            info[1] = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);//�ղؼ�Ŀ¼
            ShowInfo(info, "�ղؼ�Ŀ¼", lv);

            info[0] = "Internet��ʷ��¼";
            info[1] = Environment.GetFolderPath(Environment.SpecialFolder.History);//Internet��ʷ��¼
            ShowInfo(info, "Internet��ʷ��¼", lv);

            info[0] = "Internet��ʱ�ļ�";
            info[1] = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);//Internet��ʱ�ļ�
            ShowInfo(info, "Internet��ʱ�ļ�", lv);
        }

        /// <summary>
        /// ��ȡָ��·���������ļ�����ͼ��
        /// </summary>
        /// <param name="path">·��</param>
        /// <param name="imglist">�洢�ļ�����ͼ��</param>
        /// <param name="lv">Ҫ��ʾ��ListView�ؼ�</param>
        public void GetListViewItem(string path, ImageList imglist, ListView lv)
        {
            lv.Items.Clear();//���ListView�ؼ�
            Win32.SHFILEINFO shfi = new Win32.SHFILEINFO();
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < dirs.Length; i++)
                {
                    string[] info = new string[4];
                    DirectoryInfo dir = new DirectoryInfo(dirs[i]);
                    if (dir.Name == "RECYCLER" || dir.Name == "RECYCLED" || dir.Name == "Recycled" || dir.Name == "System Volume Information")
                    { }
                    else
                    {
                        //���ͼ��
                        Win32.SHGetFileInfo(dirs[i],
                                            (uint)0x80,
                                            ref shfi,
                                            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                                            (uint)(0x100 | 0x400)); //ȡ��Icon��TypeName
                        //���ͼ��
                        imglist.Images.Add(dir.Name, (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                        info[0] = dir.Name.Remove(dir.Name.LastIndexOf("."));
                        info[1] = "";
                        info[2] = "�ļ���";
                        info[3] = dir.LastWriteTime.ToString();
                        ListViewItem item = new ListViewItem(info, dir.Name);
                        lv.Items.Add(item);
                        //����ͼ��
                        Win32.DestroyIcon(shfi.hIcon);
                    }
                }
                for (int i = 0; i < files.Length; i++)
                {
                    string[] info = new string[4];
                    FileInfo fi = new FileInfo(files[i]);
                    string Filetype = fi.Name.Substring(fi.Name.LastIndexOf(".") + 1, fi.Name.Length - fi.Name.LastIndexOf(".") - 1);
                    string newtype = Filetype.ToLower();
                    if (newtype == "sys" || newtype == "ini" || newtype == "bin" || newtype == "log" || newtype == "com" || newtype == "bat" || newtype == "db")
                    { }
                    else
                    {
                        //���ͼ��
                        Win32.SHGetFileInfo(files[i],
                                            (uint)0x80,
                                            ref shfi,
                                            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                                            (uint)(0x100 | 0x400)); //ȡ��Icon��TypeName
                        //���ͼ��
                        imglist.Images.Add(fi.Name, (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                        info[0] = fi.Name.Remove(fi.Name.LastIndexOf("."));
                        info[1] = fi.Length.ToString();
                        info[2] = fi.Extension.ToString();
                        info[3] = fi.LastWriteTime.ToString();
                        ListViewItem item = new ListViewItem(info, fi.Name);
                        lv.Items.Add(item);
                        //����ͼ��
                        Win32.DestroyIcon(shfi.hIcon);
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// ��ȡ���н�����Ϣ
        /// </summary>
        /// <param name="lv">Ҫ��ʾ������Ϣ��ListView���</param>
        public void GetProcessInfo(ListView lv)
        {
            try
            {
                lv.Items.Clear();//���ListView�б�
                Process[] MyProcesses = Process.GetProcesses();//��ȡ���н���
                string[] Minfo = new string[6];//�����ַ������飬�����洢���̵���ϸ��Ϣ
                foreach (Process MyProcess in MyProcesses)//�������н���
                {
                    Minfo[0] = MyProcess.ProcessName;//��������
                    Minfo[1] = MyProcess.Id.ToString();//����ID
                    Minfo[2] = MyProcess.Threads.Count.ToString();//�߳���
                    Minfo[3] = MyProcess.BasePriority.ToString();//���ȼ�
                    Minfo[4] = Convert.ToString(MyProcess.WorkingSet / 1024) + "K";//�����ڴ�
                    Minfo[5] = Convert.ToString(MyProcess.VirtualMemorySize / 1024) + "K";//�����ڴ�
                    ListViewItem lvItem = new ListViewItem(Minfo, "process");//��������Ϣ������ӵ��б�����
                    lv.Items.Add(lvItem);//��ʾ�б�
                }
            }
            catch { }
        }

        /// <summary>
        /// ��ȡ�������е����г�����Ϣ
        /// </summary>
        /// <param name="lv">Ҫ��ʾ������Ϣ��ListView���</param>
        public void GetWindowsInfo(ListView lv)
        {
            try
            {
                lv.Items.Clear();//���ListView�б�
                Process[] MyProcesses = Process.GetProcesses();//��ȡ���н���
                string[] Minfo = new string[4];//�����ַ������飬�����洢�������ϸ��Ϣ
                foreach (Process MyProcess in MyProcesses)//�������н���
                {
                    if (MyProcess.MainWindowTitle.Length > 0)//�жϳ����Ƿ���������ڱ���
                    {
                        Minfo[0] = MyProcess.MainWindowTitle;//���ڱ���
                        Minfo[1] = MyProcess.Id.ToString();//����ID
                        Minfo[2] = MyProcess.ProcessName;//��������
                        Minfo[3] = MyProcess.StartTime.ToString();//����ʱ��
                        ListViewItem lvItem = new ListViewItem(Minfo, "process");//��������Ϣ������ӵ��б�����
                        lv.Items.Add(lvItem);//��ʾ�б�
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// ���ָ���ļ���
        /// </summary>
        /// <param name="path">Ҫ��յ��ļ���·��</param>
        private void ClearFolder(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);//����ָ��·�������ļ��ж���
            if (dir.Exists)//�ж��ļ����Ƿ����
            {
                dir.Delete(true);//ɾ���ļ��м������ļ���
                dir.Create();//���´����ļ���
            }
        }

        /// <summary>
        /// ϵͳ��������
        /// </summary>
        /// <param name="handle">���ھ��������ջ���վʱʹ��</param>
        /// <param name="str">Ҫ�������</param>
        public void ClearSystem(IntPtr handle, string str)
        {
            string dir = "";//����һ�������������洢Ҫ��յ��ļ���·��
            RegistryKey currentReg = Registry.CurrentUser;//��ȡע����еĵ�ǰ�û���
            try
            {
                switch (str)
                {
                    case "��ջ���վ":
                        Win32.SHEmptyRecycleBin(handle, 0, 7);//����API������ջ���վ
                        break;
                    case "���IE������":
                        dir = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);//��ȡIE������·��
                        ClearFolder(dir);//���÷������IE������
                        break;
                    case "���IE��Cookies":
                        dir= Environment.GetFolderPath(Environment.SpecialFolder.Cookies);//��ȡIE Cookies�洢·��
                        ClearFolder(dir);//���÷������IE��Cookies
                        break;
                    case "���Windows��ʱ�ļ���":
                        dir = Environment.GetEnvironmentVariable("WinDir") + "\\Temp";//��ȡϵͳĿ¼�µ���ʱ�ļ���·��
                        ClearFolder(dir);//���÷������Windows��ʱ�ļ���
                        dir = Environment.GetEnvironmentVariable("TEMP");//��ȡ���������ļ���·��
                        ClearFolder(dir);//���÷�����ջ��������ļ���
                        break;
                    case "��մ򿪵��ļ���¼":
                        dir = Environment.GetFolderPath(Environment.SpecialFolder.Recent);//��ȡ����򿪵��ļ���¼�洢·��
                        ClearFolder(dir);//���÷�����մ򿪵��ļ���¼
                        break;
                    case "���IE��ַ���е���ʷ��ַ":
                        RegistryKey software = currentReg.OpenSubKey(@"Software\Microsoft\Internet Explorer", true);//��ȡIEע�����
                        software.DeleteSubKeyTree("TypedURLs");//���IE��ַ���е���ʷ��ַ
                        break;
                    case "������жԻ���":
                        currentReg = currentReg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU");//��ȡ���жԻ���ע�����
                        string MyMRU = (String)currentReg.GetValue("MRULIST");//��ȡ���жԻ���ļ�¼
                        for (int i = 0; i < MyMRU.Length; i++)//����
                        {
                            currentReg.DeleteValue(MyMRU[i].ToString());//ɾ��ע�����
                        }
                        currentReg.SetValue("MRUList", "");//�������жԻ���ļ�¼Ϊ��
                        break;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// �����������ִ��ϵͳ����
        /// </summary>
        /// <param name="cmd">�ַ�������ʾҪִ�е�����</param>
        public void CMDOperator(string cmd)
        {
            Process myProcess = new Process();//�������̶���
            myProcess.StartInfo.FileName = "cmd.exe";//���ô�cmd�����
            myProcess.StartInfo.UseShellExecute = false;//��ʹ�ò���ϵͳshell�������̵�ֵ
            myProcess.StartInfo.RedirectStandardInput = true;//���ÿ��Դӱ�׼��������ȡֵ
            myProcess.StartInfo.RedirectStandardOutput = true;//���ÿ������׼�����д��ֵ
            myProcess.StartInfo.RedirectStandardError = true;//���ÿ�����ʾ����������г��ֵĴ���
            myProcess.StartInfo.CreateNoWindow = true;//�������´�������������
            myProcess.Start();//��������
            myProcess.StandardInput.WriteLine(cmd);//����Ҫִ�е�����
        }

        /// <summary>
        /// ͨ����ע���ĵ�ǰ�û��ڵ��´����Ӽ����Ż�ϵͳ
        /// </summary>
        /// <param name="regkey">�Ӽ�����</param>
        /// <param name="key">��</param>
        /// <param name="value">ֵ</param>
        /// <param name="flag">��ʶ������ȷ���Ƿ��е�3������</param>
        public void CurrentRegOptimize(string regkey, string key, object value, int flag)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser;//��ȡע����еĵ�ǰ�û��ڵ�
                reg = reg.CreateSubKey(regkey);//�����Ӽ�
                if (flag == 0)//�жϱ�ʶ�����Ƿ�Ϊ0
                    reg.SetValue(key, value);//����ע�����ֵ
                else
                    reg.SetValue(key, value, RegistryValueKind.DWord);//����ע�����ֵ
                reg.Close();
            }
            catch { }
        }
       
        /// <summary>
        /// ͨ����ע���ı��ػ����ڵ��´����Ӽ����Ż�ϵͳ
        /// </summary>
        /// <param name="regkey">�Ӽ�����</param>
        /// <param name="key">��</param>
        /// <param name="value">ֵ</param>
        /// <param name="flag">��ʶ������ȷ���Ƿ��е�3������</param>
        public void LocalRegOptimize(string regkey, string key, object value, int flag)
        {
            try
            {
                RegistryKey reg = Registry.LocalMachine; ;//��ȡע����еı��ػ����ڵ�
                reg = reg.CreateSubKey(regkey);//�����Ӽ�
                if (flag == 0)//�жϱ�ʶ�����Ƿ�Ϊ0
                    reg.SetValue(key, value);//����ע�����ֵ
                else
                    reg.SetValue(key, value, RegistryValueKind.DWord);//����ע�����ֵ
                reg.Close();
            }
            catch { }
        }
    }

}
