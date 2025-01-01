using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.Location.Count().ToString();
            #endregion

            #region Toplam Kapasite
            lblSumCapacity.Text = db.Location.Sum(X=> X.Capacity).ToString();
            #endregion

            #region Rehber Sayısı
            lblGuideCount.Text = db.Guide.Count().ToString();
            #endregion

            #region Ortalama Kapasite
            lblAvarageCapacity.Text = db.Location.Average(X=> X.Capacity).ToString();
            #endregion

            #region Ortalama Fiyat
            lblAvaragePrice.Text = db.Location.Average(x=> x.Price).ToString();
            #endregion

            #region Son Eklenen Ülke
            int lastCountryId = db.Location.Max(X => X.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            #endregion

            #region Kapadokya Kapasitesi
            lblCappadociaCapacity.Text = db.Location.Where(x=> x.City == "Kapadokya").Select(y => y.City).FirstOrDefault().ToString();
            #endregion

            #region Türkiye Tur Kapasitesi Ortalaması
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(z=>  z.Capacity).ToString();
            #endregion
            
            #region Roma Rehberi Adı
            var romeGuideId = db.Location.Where(x=> x.City == "Roma").Select(y=> y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x=> x.GuideId==romeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            #endregion

            #region En Fazla Kapasiteli Tur
            var maxCapacityTur = db.Location.Max(x => x.Capacity);
            lblMaxCapacityTur.Text = db.Location.Where(x => x.Capacity == maxCapacityTur).Select(y => y.City).FirstOrDefault().ToString();
            #endregion

            #region En Pahalı Tur
            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceTur.Text = db.Location.Where(x=> x.Price == maxPrice).Select(y=> y.City).FirstOrDefault().ToString();
            #endregion
        }

        private void lblLastCountry_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
