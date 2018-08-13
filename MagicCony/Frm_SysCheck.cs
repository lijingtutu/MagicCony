using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MagicCony
{
    public partial class Frm_SysCheck : DevComponents.DotNetBar.OfficeForm
    {
        public Frm_SysCheck()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void Frm_SysCheck_Load(object sender, EventArgs e)
        {
            #region ����TreeNode������Ϊ���ڵ�
            TreeNode tn1 = new TreeNode("Windows");
            TreeNode tn2 = new TreeNode("CPU������");
            TreeNode tn3 = new TreeNode("��Ƶ�豸");
            TreeNode tn4 = new TreeNode("��Ƶ�豸");
            TreeNode tn5 = new TreeNode("�洢�豸");
            TreeNode tn6 = new TreeNode("�����豸");
            TreeNode tn8 = new TreeNode("������ӿ�");
            TreeNode tn9 = new TreeNode("�����豸");
            TreeNode tn10 = new TreeNode("��ӡ�봫��");
            #endregion
            #region Windows���ڵ���ӽڵ�
            tn1.Nodes.Add("Windows��Ϣ");
            tn1.Nodes.Add("Windows�û�");
            tn1.Nodes.Add("�û����");
            tn1.Nodes.Add("��ǰ����");
            tn1.Nodes.Add("ϵͳ����");
            tn1.Nodes.Add("ϵͳ����");
            #endregion
            #region CPU�����常�ڵ���ӽڵ�
            tn2.Nodes.Add("���봦����");
            tn2.Nodes.Add("����");
            tn2.Nodes.Add("BIOS��Ϣ");
            #endregion
            #region ��Ƶ�豸���ڵ���ӽڵ�
            tn3.Nodes.Add("�Կ�");
            #endregion
            #region �洢�豸���ڵ���ӽڵ�
            tn5.Nodes.Add("�����ڴ�");
            tn5.Nodes.Add("����");
            #endregion
            #region �����豸���ڵ���ӽڵ�
            tn6.Nodes.Add("����������");
            tn6.Nodes.Add("����Э��");
            #endregion
            #region ������ӿڸ��ڵ���ӽڵ�
            tn8.Nodes.Add("����");
            tn8.Nodes.Add("IDE������");
            tn8.Nodes.Add("����������");
            tn8.Nodes.Add("USB������");
            tn8.Nodes.Add("SCSI������");
            tn8.Nodes.Add("PCMCIA��������");
            tn8.Nodes.Add("1394������");
            tn8.Nodes.Add("���弴���豸");
            #endregion
            #region �����豸���ڵ���ӽڵ�
            tn9.Nodes.Add("���");
            tn9.Nodes.Add("����");
            #endregion
            #region �������ĸ��ڵ���ӵ����б���
            tvItem.Nodes.Add(tn1);
            tvItem.Nodes.Add(tn10);
            tvItem.Nodes.Add(tn2);
            tvItem.Nodes.Add(tn3);
            tvItem.Nodes.Add(tn4);
            tvItem.Nodes.Add(tn5);
            tvItem.Nodes.Add(tn6);
            tvItem.Nodes.Add(tn8);
            tvItem.Nodes.Add(tn9);
            #endregion
            GetInfo("");				    	//Ĭ�ϻ�ȡWindows��Ϣ�������Ϣ
        }

        private void GetInfo(string node)
        {
            Operator oper = new Operator();             //��������������Ķ���
            switch (node)                       //�ж�ѡ�еĽڵ�����
            {
                case "Windows��Ϣ":
                    oper.GetInfo(lvInfo);
                    break;
                case "Windows�û�":
                    oper.InsertInfo("Win32_UserAccount", ref lvInfo, true);
                    break;
                case "�û����":
                    oper.InsertInfo("Win32_Group", ref lvInfo, true);
                    break;
                case "��ǰ����":
                    oper.InsertInfo("Win32_Process", ref lvInfo, true);
                    break;
                case "ϵͳ����":
                    oper.InsertInfo("Win32_Service", ref lvInfo, true);
                    break;
                case "ϵͳ����":
                    oper.InsertInfo("Win32_SystemDriver", ref lvInfo, true);
                    break;
                case "���봦����":
                    oper.InsertInfo("Win32_Processor", ref lvInfo, true);
                    break;
                case "����":
                    oper.InsertInfo("Win32_BaseBoard", ref lvInfo, true);
                    break;
                case "BIOS��Ϣ":
                    oper.InsertInfo("Win32_BIOS", ref lvInfo, true);
                    break;
                case "�Կ�":
                    oper.InsertInfo("Win32_VideoController", ref lvInfo, true);
                    break;
                case "��Ƶ�豸":
                    oper.InsertInfo("Win32_SoundDevice", ref lvInfo, true);
                    break;
                case "�����ڴ�":
                    oper.InsertInfo("Win32_PhysicalMemory", ref lvInfo, true);
                    break;
                case "����":
                    oper.InsertInfo("Win32_LogicalDisk", ref lvInfo, true);
                    break;
                case "����������":
                    oper.InsertInfo("Win32_NetworkAdapter", ref lvInfo, true);
                    break;
                case "����Э��":
                    oper.InsertInfo("Win32_NetworkProtocol", ref lvInfo, true);
                    break;
                case "��ӡ�봫��":
                    oper.InsertInfo("Win32_Printer", ref lvInfo, true);
                    break;
                case "����":
                    oper.InsertInfo("Win32_Keyboard", ref lvInfo, true);
                    break;
                case "���":
                    oper.InsertInfo("Win32_PointingDevice", ref lvInfo, true);
                    break;
                case "����":
                    oper.InsertInfo("Win32_SerialPort", ref lvInfo, true);
                    break;
                case "IDE������":
                    oper.InsertInfo("Win32_IDEController", ref lvInfo, true);
                    break;
                case "����������":
                    oper.InsertInfo("Win32_FloppyController", ref lvInfo, true);
                    break;
                case "USB������":
                    oper.InsertInfo("Win32_USBController", ref lvInfo, true);
                    break;
                case "SCSI������":
                    oper.InsertInfo("Win32_SCSIController", ref lvInfo, true);
                    break;
                case "PCMCIA��������":
                    oper.InsertInfo("Win32_PCMCIAController", ref lvInfo, true);
                    break;
                case "1394������":
                    oper.InsertInfo("Win32_1394Controller", ref lvInfo, true);
                    break;
                case "���弴���豸":
                    oper.InsertInfo("Win32_PnPEntity", ref lvInfo, true);
                    break;
                default:
                    oper.GetInfo(lvInfo);                   //Ĭ����ʾWindows��Ϣ
                    break;
            }
        }

        private void tvItem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strText = tvItem.SelectedNode.Text;
            this.Text = strText;
            lvInfo.Items.Clear();
            GetInfo(strText);
        }
    }
}