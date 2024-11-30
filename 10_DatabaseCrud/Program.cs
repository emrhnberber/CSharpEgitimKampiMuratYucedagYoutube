using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");

            #region Yeni Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adını Giriniz: ");
            //string newCategoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = EMIRHAN\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);  //INSER İNTO KOMUTU SQLDE YENİ VERİ EKLEMEK İÇİN KULLANILIR.
            //command.Parameters.AddWithValue("@p1", newCategoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarı İle Veritabanına Eklendi.");
            #endregion

            #region Yeni Ürün Ekleme İşlemi
            //String productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adını Giriniz: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = EMIRHAN\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName, @productPrice, @productStatus)", connection);

            ////PARAMETRELER İLE GİRİLEN DEĞERİ ATIYORUZ
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery(); //DEĞİŞİKLERİ KAYDET VE VERİ TABANINA YANSIT
            //connection.Close();
            //Console.Write("Ürün Başarıyla Eklendi!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) {

            //    foreach (var item in row.ItemArray)
            //    { 
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //Console.Write("Silinecek Ürünün Id Numarasını Girin: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Silme İşlemi Başarılı!");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürünün Id Bilgisini Giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adını Giriniz: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatını Giriniz: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            
            //SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Güncelleme İşlemi Başarılı!");
            #endregion

            Console.Read();
        }
    }
}
