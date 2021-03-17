using Advokati.Model.Requests;
using Advokati.WinUI.Izvjestaji;
using Advokati.WinUI.Klijenti;
using Advokati.WinUI.Predmeti;
using Advokati.WinUI.RadniSati;
using Advokati.WinUI.Rocista;
using Advokati.WinUI.Sastanci;
using Advokati.WinUI.Troskovi;
using Advokati.WinUI.Ugovori;
using Advokati.WinUI.Ured;
using Advokati.WinUI.Zadaci;
using Advokati.WinUI.Zaposlenici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advokati.WinUI
{
    public partial class frmIndex : Form
    {

        private readonly APIService _aPIService = new APIService("Sastanci");
        private readonly APIService _aPIService1 = new APIService("Zaposlenici");

        private int childFormNumber = 0;
        public static string User { get; set; }
        private bool _ulogaAdvokat = false, _ulogaMenadzer = false, _ulogaSekretar = false;
        private string _ulogaAdvokatIme = null, _ulogaMenadzerIme = null, _ulogaSekretarIme = null;

        public frmIndex(bool ulogaAdvokat, bool ulogaMenadzer, bool ulogaSekretar,string ulogaAdvokatIme,string ulogaMenadzerIme,string ulogaSekretarIme)
        {
            InitializeComponent();
            _ulogaAdvokat = ulogaAdvokat;
            _ulogaMenadzer = ulogaMenadzer;
            _ulogaSekretar = ulogaSekretar;
            _ulogaAdvokatIme = ulogaAdvokatIme;
            _ulogaMenadzerIme = ulogaMenadzerIme;
            _ulogaSekretarIme = ulogaSekretarIme;
            

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void UredToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UgovoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PredmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RočištaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     

        private async void FrmIndex_Load(object sender, EventArgs e)
        {
           
            

            if (_ulogaAdvokat)
            {

                var search1 = new KorisniciSearchRequest
                {
                    Status  = false
                };

                var BrojZahtjeva1 = await _aPIService1.Get<List<Model.Korisnici>>(search1);
                if (BrojZahtjeva1.Count > 0)
                {
                    notifyIcon2.Visible = true;
                    notifyIcon2.Icon = SystemIcons.Information;
                    notifyIcon2.BalloonTipTitle = "Zahtjevi za registraciju";
                    notifyIcon2.BalloonTipText = "imate " + BrojZahtjeva1.Count + " novih zahtjeva za registraciju klijenata!";
                    notifyIcon2.ShowBalloonTip(5000);
                    search1 = new KorisniciSearchRequest { };
                }


                label1.Text = _ulogaAdvokatIme; ;

                tsmSastanci.Visible = false;
                tspTroskovi.Visible = false;
                tsmUgovori.Visible = false;
                tsmUred.Visible = false;
                tsmZadaci.Visible = false;
                tsmZaposlenici.Visible = false;
                
            }
            else if(_ulogaMenadzer)
            {
                label1.Text = _ulogaMenadzerIme;

                tsmKlijenti.Visible = false;
                tsmPredmeti.Visible = false;
                tsmRocista.Visible = false;
                tsmRadniSati.Visible = false;
                tsmSastanci.Visible = false;
                tspTroskovi.Visible = false;
                tsmUred.Visible = false;
            

            }
            else
            {
                var search = new SastanciSearchRequest
                {
                    Odobreno = false,
                    DatumSastanka = DateTime.MinValue
                };

                var BrojZahtjeva = await _aPIService.Get<List<Model.Sastanci>>(search);
                if (BrojZahtjeva.Count > 0)
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipTitle = "Zahtjevi za satanak";
                    notifyIcon1.BalloonTipText = "imate " + BrojZahtjeva.Count + " neodobrenih satanaka!";
                    notifyIcon1.ShowBalloonTip(5000);
                    search = new SastanciSearchRequest { };
                }
                label1.Text =_ulogaSekretarIme;

                tsmKlijenti.Visible = false;
                tsmPredmeti.Visible = false;
                tsmRocista.Visible = false;
                tsmRadniSati.Visible = false;
                tsmUgovori.Visible = false;
                tsmZadaci.Visible = false;
                tsmZaposlenici.Visible = false;
                
            }

        }

        private void PretragaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
           
                frmZaposlenici frm = new frmZaposlenici();
                frm.MdiParent = this;
                frm.Show();
            
         
        }

        private void NoviZaposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                frmZaposleniciDetalji frm = new frmZaposleniciDetalji();
                frm.MdiParent = this;
                frm.Show();
            
      }
        

        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredmeti frm = new frmPredmeti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRocista frm = new frmRocista();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmKlijenti frm = new frmKlijenti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmTroskovi frm = new frmTroskovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmSastanci frm = new frmSastanci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmUred frm = new frmUred();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Zadaci.frmZadaci frm = new Zadaci.frmZadaci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmUgovori frm = new frmUgovori();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRadniSati frm = new frmRadniSati();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviUgovorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUredDetalji frm = new frmUredDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredmetiDetalji frm = new frmPredmetiDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NovoRočišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRocistaDetalji frm = new frmRocistaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviRadniSatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadniSatiDetalji frm = new frmRadniSatiDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviTrošakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroskoviDetalji frm = new frmTroskoviDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviKlijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKlijentiDetalji frm = new frmKlijentiDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void IzvještajZaOdređeniPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroskoviOdDo frm = new frmTroskoviOdDo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            frmSastanci frm = new frmSastanci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NotifyIcon2_BalloonTipClicked(object sender, EventArgs e)
        {
            frmKlijenti frm = new frmKlijenti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

       

        private void NoviZadatakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZadaciDetalji frm = new frmZadaciDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

   
    

        private void NoviSastanakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSastanciDetalji frm = new frmSastanciDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NoviUgovorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUgovoriDetalji frm = new frmUgovoriDetalji();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
