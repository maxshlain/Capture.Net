using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Capture.Net
{


    

    public partial class MainForm : Form
    {



        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        delegate void SimpleDelegeate();
        
        // The original bitmap
        Bitmap bitmap = null;

        // The bitmap after we've drawn on it
        Bitmap bitmapWithStrokes = null;

        // Declare an array to hold the bytes of the bitmap.
        int numberOfBytes = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeginInvoke(new SimpleDelegeate(CaptureFull));

        }

        private void CaptureFull()
        {
            Delay();

            // Current screen
            //Screen screen = Screen.FromControl(this);
            //CaptureBitmap(screen.Bounds);

            CaptureForeground();

            this.Show();
        }

        private void Delay()
        {
            // delay...
            System.Threading.Thread.Sleep(500 + (1000 * (int)numericUpDownDelay.Value));
        }

        private void CaptureForeground()
        {

            Delay();

            // Get foreground window rect using native calls
            IntPtr hWnd = GetForegroundWindow();
            RECT rct = new RECT();
            GetWindowRect(hWnd, ref rct);

            Rectangle r = new Rectangle();
            r.Location = new Point(rct.Left, rct.Top);
            r.Size = new Size(rct.Right - rct.Left, rct.Bottom - rct.Top);
            CaptureBitmap(r);

            this.Show();
        }

        private void CaptureBitmap(Rectangle r)
        {
            bitmap = new Bitmap(r.Width, r.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            }

            this.pictureBox1.Image = bitmap;

            if (bitmapWithStrokes != null)
            {
                bitmapWithStrokes.Dispose();
                bitmapWithStrokes = null;
            }

            System.Drawing.Imaging.BitmapData bitmapData =
                bitmap.LockBits(
                    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    bitmap.PixelFormat);

            numberOfBytes = Math.Abs(bitmapData.Stride) * bitmap.Height;

            bitmap.UnlockBits(bitmapData);

            EnableDisable(true);

        }

        private void EnableDisable(bool EnabledOrDisabled)
        {
            //// disable toolbar
            //this.toolStripButtonCopy.Enabled = EnabledOrDisabled;
            //this.toolStripButtonSaveAs.Enabled = EnabledOrDisabled;
            //this.toolStripButtonUndo.Enabled = EnabledOrDisabled;
            //this.toolStripComboBoxPenType.Enabled = EnabledOrDisabled;

            //// disable send fields
            //buttonSend.Enabled = EnabledOrDisabled;
            //labelDescription.Enabled = EnabledOrDisabled;
            //textBoxShortDescription.Enabled = EnabledOrDisabled;
            //radioButtonCreateNew.Enabled = EnabledOrDisabled;
            //radioButtonUpdateExisting.Enabled = EnabledOrDisabled;
            //labelBugId.Enabled = EnabledOrDisabled;
            //textBoxBugId.Enabled = EnabledOrDisabled;

            //btn_CopyAndClose.Enabled = EnabledOrDisabled;
            //btn_SaveAndClose.Enabled = EnabledOrDisabled;

            //enableDisableDelay();

            return;
        }
    }
}
