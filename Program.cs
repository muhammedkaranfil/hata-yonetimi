﻿// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

namespace HATAYÖNETİMİ// Note: actual namespace depends on the project name.
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
              finally
             {
               Console.WriteLine("İşlem tamamlandı");
            }
         try
        {
        //   int  a = int.Parse(null);
         //   int  a = int.Parse("test");
           int  a =  int.Parse("20000000000");

         }
         catch (ArgumentNullException ex)
         {
             Console.WriteLine("Boş değer girdiniz");
             Console.WriteLine("ex");

             
         }
         catch(FormatException ex)
         {
           Console.WriteLine("veri tipi uygun değil."); 
           Console.WriteLine("ex");
         }
        catch(OverflowException ex)
       {
              Console.WriteLine("çok küçük yada çok büyük değer girdiniz.");
            Console.WriteLine("ex");

         }
        }
    }
}
   


