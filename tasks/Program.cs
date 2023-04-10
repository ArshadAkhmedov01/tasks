using System;
using System.Collections.Generic;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //task1
            //var addressBook = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("1. Kişi ekle\n2. Kişi sil\n3. Kişileri göster\n4. Çıxış");
            //    switch (Console.ReadLine())
            //    {
            //        case "1":
            //            Console.Write("Ad girin: ");
            //            string name = Console.ReadLine();
            //            Console.Write("Telefon nomresi girin: ");
            //            string phone = Console.ReadLine();
            //            addressBook.Add($"{name} ({phone})");
            //            Console.WriteLine("Kişi eklendi");
            //            break;

            //        case "2":
            //            Console.Write("Silmey istediğiniz kişinin ismini girin: ");
            //            string nameToRemove = Console.ReadLine();
            //            bool isRemoved = false;
            //            for (int i = 0; i < addressBook.Count; i++)
            //            {
            //                if (addressBook[i].StartsWith(nameToRemove))
            //                {
            //                    addressBook.RemoveAt(i);
            //                    isRemoved = true;
            //                    break;
            //                }
            //            }
            //            Console.WriteLine(isRemoved ? "Kişi silindi" : "Kişi tapilmadi");
            //            break;

            //        case "3":
            //            Console.WriteLine("Kişiler:");
            //            foreach (var contact in addressBook)
            //                Console.WriteLine(contact);
            //            break;

            //        case "4":
            //            return;

            //        default:
            //            Console.WriteLine("sef secim seçim");
            //            break;
            //    }
            //}
            #endregion
            #region task2
            //task2
            //Console.Write("Please enter text: ");
            //string text = Console.ReadLine();

            //Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            //string[] words = text.Split(' ');

            //foreach (string word in words)
            //{
            //    if (wordFrequencies.ContainsKey(word))
            //    {
            //        wordFrequencies[word]++;
            //    }
            //    else
            //    {
            //        wordFrequencies.Add(word, 1);
            //    }
            //}

            //foreach (KeyValuePair<string, int> wordFrequency in wordFrequencies)
            //{
            //    Console.WriteLine("{0}: {1}", wordFrequency.Key, wordFrequency.Value);
            //}

            //Console.ReadKey();
            #endregion
            #region task3
            //task3
            //Stack<string> history = new Stack<string>();
            //string text = "";

            //while (true)
            //{
            //    Console.Write("> ");
            //    string command = Console.ReadLine();

            //    if (command == "undo")
            //    {
            //        if (history.Count > 0)
            //        {
            //            text = history.Pop();
            //            Console.WriteLine(text);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Nothing to undo.");
            //        }
            //    }
            //    else
            //    {
            //        history.Push(text);
            //        text += command + "\n";
            //        Console.WriteLine(text);
            //    }
            //}
            #endregion

        }

    }
    #region task4
    //task4
    //class Document
    //{
    //    public string Name { get; set; }
    //    public int PageCount { get; set; }
    //    public Document(string name, int pageCount) { Name = name; PageCount = pageCount; }
    //}

    //class Program1
    //{
    //    static void Main1(string[] args)
    //    {
    //        var printerQueue = new Queue<Document>(new[] {
    //        new Document("Document 1", 5),
    //        new Document("Document 2", 3),
    //        new Document("Document 3", 7)
    //        });
    //        while (printerQueue.Count > 0)
    //        {
    //            var nextDoc = printerQueue.Dequeue();
    //            Console.WriteLine($"Printing {nextDoc.Name} ({nextDoc.PageCount} pages)");
    //        }
    //        Console.WriteLine("Printer queue is empty.");
    //    }



    //}
    #endregion
    #region task5
    //task5
    //class Product
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }
    //    public int Quantity { get; set; }

    //    public Product(string name, double price, int quantity)
    //    {
    //        Name = name;
    //        Price = price;
    //        Quantity = quantity;
    //    }

    //    class Program
    //    {
    //        static void Main1(string[] args)
    //        {
    //            Dictionary<string, Product> inventory = new Dictionary<string, Product>();
    //            inventory.Add("Urun adi 1", new Product("Urun 1", 10.0, 5));
    //            inventory.Add("Urun adi 2", new Product("Urun 2", 20.0, 3));
    //            inventory.Add("Urun adi 3", new Product("Urun 3", 30.0, 7));

    //            Console.WriteLine("Depo Durumu:");
    //            Console.WriteLine("------------------");
    //            foreach (KeyValuePair<string, Product> item in inventory)
    //            {
    //                Console.WriteLine("Urun adı: {0}, Qiymeti: {1}, Cekisi: {2}", item.Value.Name, item.Value.Price, item.Value.Quantity);
    //            }
    //            Console.WriteLine("------------------");

    //            List<Product> reorderList = new List<Product>();
    //            foreach (KeyValuePair<string, Product> item in inventory)
    //            {
    //                if (item.Value.Quantity < 2)
    //                {
    //                    reorderList.Add(item.Value);
    //                }
    //            }

    //            Console.WriteLine("Yenidən Təminat Ehtiyacı Olan Məhsullar:");
    //            Console.WriteLine("------------------");
    //            foreach (Product product in reorderList)
    //            {
    //                Console.WriteLine("Urun Adı: {0}, Qiymeti: {1}, Cekisi: {2}", product.Name, product.Price, product.Quantity);
    //            }
    //            Console.WriteLine("------------------");

    //            inventory.Remove("Urun 2");
    //            inventory["Urun 1"].Quantity += 2;
    //            inventory["Urun 3"].Price *= 1.1;

    //            Console.WriteLine("Depo Güncellendi:");
    //            Console.WriteLine("------------------");
    //            foreach (KeyValuePair<string, Product> item in inventory)
    //            {
    //                Console.WriteLine("Urun Adı: {0}, Qiymeti: {1}, Ceksi: {2}", item.Value.Name, item.Value.Price, item.Value.Quantity);
    //            }
    //            Console.WriteLine("------------------");

    #endregion
}
