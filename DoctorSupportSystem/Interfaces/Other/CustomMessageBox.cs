using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSupportSystem.Interfaces.Other
{
    public partial class CustomMessageBox : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        static CustomMessageBox mbox;
        static DialogResult result = DialogResult.No;


        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public static DialogResult Show(string text)
        {
            mbox = new CustomMessageBox();
            mbox.lbMessage.Text = text;                
            mbox.ShowDialog();
            return result;

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            mbox.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
