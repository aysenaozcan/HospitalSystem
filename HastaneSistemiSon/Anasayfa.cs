using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemiSon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiLogin fr = new YoneticiLogin();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAl fr = new RandevuAl();
            fr.Show();
            this.Hide();
        }

        private void mustafaHatiboğluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyin ve Sinir Cerrahisi diğer bir deyişle beyin ve sinir hastalıkları, beyin ve omurilik dokusundan kaynaklanan ya da bu dokulara baskı yapan tümörlerin tedavisinin yanı sıra bel ve boyun fıtığı başta olmak üzere, kafa ve omurilik yaralanmaları, beyin damar tıkanıklıkları ve beyin kanamaları, beyni ve omuriliği besleyen damarlarda oluşan anevrizma yani baloncuklaşma gibi hastalıkların tanı ve tedavisi ile ilgilenen bilim dalıdır.");
        }

        private void kulakBurunBoğazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kulak, Burun ve Boğaz Hastalıkları bölümleri tıp merkezlerimizde hizmet vermektedir. Multidisiplinler yaklaşım ile kulak, burun, boğaz ve ilgili baş boyun hastalıklarının hem medikal hem de cerrahi tedavisi yapılmaktadır. ");
        }

        private void önderAltınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Önder ALTUN Bölüm:Kulak Burun ve Boğaz Hastalıkları");
        }

        private void selçukKayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Selçuk KAYA Bölüm:Kulak Burun ve Boğaz Hastalıkları");
        }

        private void içHastalıklarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemiz genel iç hastalıklarının yanında hematoloji, onkoloji, nefroloji, endokrinoloji, kardiyoloji, romatoloji ve gastroenteroloji dallarında hizmet verilmektedir. Hastanelerimizde yatan hastaların tedavilerini, konsültasyonlarını, ameliyat öncesi hazırlıklarını ve gerekli girişimlerini İç Hastalıkları bölümümüz gerçekleştirmektedir.");
        }

        private void zehraKranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Zehra KIRAN Bölüm:İç Hastalıkları");
        }

        private void yasinTosunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Yasin TOSUN Bölüm:İç Hastalıkları");
        }

        private void genelCerrahiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Genel cerrahi, vücutta sistemik ve yerel sorunların cerrahi yöntemlerle tedavisi yanında, genel prensipler (yara iyileşmesi, yaralanmaya metabolik ve endokrin cevap gibi) konuları içeren ve gelişimleri açısından pek çok cerrahi ve temel tıp dalını etkilemiş bir teknik disiplindir.");
        }

        private void emreKocaoğluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Emre Kocaoğlu Bölüm:Genel Cerrahi");
        }

        private void zeynepDereliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Zeynep Dereli Bölüm:Genel Cerrahi");
        }

        private void çocukCerrahisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemizin Çocuk Cerrahisi bölümlerinde; çocuk hastalarımız için tanı ve tedavi hizmetleri sunulurken cerrahi müdahale öncesi ve sonrasında çocuk psikolojisinin önemi üzerinde de önemle durulmaktadır.");
        }

        private void esmaKeçikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Esma Keçik Bölüm:Çocuk Cerrahisi");
        }

        private void hayrettinÖztürkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Hayrettin Öztürk Bölüm:Çocuk Cerrahisi");
        }

        private void mustafaHatiboğluToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Mustafa Hatiboğlu Bölüm:Beyin ve Sinir Cerrahisi");
        }

        private void erdinçÖzekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prof.Dr.Erdinç Özek Bölüm:Beyin ve Sinir Cerrahisi");
        }

        private void tARIHÇEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemiz, 1920 yılında Türkiye’nin ilk kar amacı gütmeyen özel hastanesi olarak kuruldu. Hastaneyle eş zamanlı olarak açılan Türkiye’nin ilk Hemşirelik Okulu da hastanenin ayrılmaz bir parçası haline geldi.");
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hastanemiz organ nakillerinde ülkemizin en önde gelen merkezlerinden biridir.Onkoloji kardiyovasküler cerrahi, acil yardım ve travmatoloji, reanimasyon, yoğun bakım ve diğer tıbbi alanlarda da etkin, verimli ve kaliteli sağlık hizmeti vermektedir. Ayrıca Günübirlik Cerrahi Merkezi’mizde küçük cerrahi operasyonlar gerçekleştirilebilmekte ve hastalar ameliyat olduktan sonra aynı gün taburcu olabilmektedirler.");
        }

        private void kONUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzelbahçe Sok. No.: 20, 34365, Nişantaşı, İstanbul, Türkiye");
        }

        private void tELEFONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("444 3 777");
        }
    }
}
