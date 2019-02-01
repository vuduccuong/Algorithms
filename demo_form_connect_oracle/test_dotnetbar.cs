using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_form_connect_oracle
{
    public partial class test_dotnetbar : Form
    {
        public test_dotnetbar()
        {
            InitializeComponent();
            //var audio = new  CoreAudioController().DefaultPlaybackDevice;
            slider1.Value = 80;
        }

        private void colorCombControl1_SelectedColorChanged(object sender, EventArgs e)
        {
        }

        private void metroAppButton1_Click(object sender, EventArgs e)
        {

        }

        private void qatCustomizePanel1_Load(object sender, EventArgs e)
        {
  
        }

        private void listBoxAdv1_ItemClick(object sender, EventArgs e)
        {

        }

        private void ratingStar1_RatingChanged(object sender, EventArgs e)
        {
            
        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            slider1.Text = slider1.Value.ToString();
            CoreAudioDevice audio = new CoreAudioController().DefaultPlaybackDevice;
            audio.Volume = slider1.Value;
        }

        private void test_dotnetbar_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var i = 0;
            do
            {
                if (i == circularProgress1.Maximum)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
                circularProgress1.Value = i;
            } while (true);
        }
    }
}
