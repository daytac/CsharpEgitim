using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud-->create-read-update-delete

            Console.WriteLine("Menü Sipariş İşlem");
            Console.WriteLine();
            Console.WriteLine("--------");

            #region kategori ekleme işlemi
            //Console.Write("Kategori adi: ");
            //string categoryName=Console.ReadLine(); 
            //SqlConnection connection =new SqlConnection("Data Source=DOA\\SQLEXPRESS ; " +
            //    "initial catalog=EgitimKampi; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand(
            //    "insert into TblCategory (categoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.Write("kategori eklendi");
            #endregion

            #region ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adi: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyati: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(
            //    "Data Source=DOA\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) " +
            //    "values (@productName, @productPrice, @productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("ürün ekleme başarılı");

            #endregion

            #region ürün listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DOA\\SQLEXPRESS; " +
            //    "initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item  in row.ItemArray)
            //    {
            //      Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();    
            //}

            //connection.Close();

            #endregion

            #region ürün silme
            //Console.Write("Silinecek ürün id si:");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DOA\\SQLEXPRESS; " +
            //    "initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();  
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı");
            #endregion

            #region ürün güncelleme
            Console.Write("güncellenecek ürün idsi: ");
            int productId=int.Parse(Console.ReadLine());

            Console.Write("güncellenecek ürün adi: ");
            string productName = Console.ReadLine();

            Console.Write("güncellenecek ürün fiyati: ");
            decimal productPrice=decimal.Parse(Console.ReadLine()); 

            SqlConnection connection = new SqlConnection("Data Source=DOA\\SQLEXPRESS; " +
                "initial catalog=EgitimKampi; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand(
                "update TblProduct set ProductName=@productName, ProductPrice=@productPrice" +
                " where ProductId=@productId", connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("güncellendi");
            #endregion

            Console.Read();
        }
    }
}
