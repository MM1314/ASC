using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASC.UI.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {           
            
            Graphics g = e.Graphics;
            Font font = new Font("微软雅黑", 10.0f);
            if (e.Index== tabControl1.SelectedIndex)
            {
                font = new Font("微软雅黑", 11.0f, FontStyle.Bold);
                //默认的控件边框颜色
                Pen border = new Pen(SystemBrushes.ActiveBorder, 3);
                g.DrawRectangle(border, tabControl1.GetTabRect(e.Index));
                border.Dispose();
            }
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);
            tabTextArea.Offset(10, 20);
            g.DrawString(tabControl1.Controls[e.Index].Text, font, brush, tabTextArea);


          
        }
    }
}
