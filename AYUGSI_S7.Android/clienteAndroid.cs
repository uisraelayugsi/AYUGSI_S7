﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using AYUGSI_S7.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(clienteAndroid))]
namespace AYUGSI_S7.Droid
{
    public class clienteAndroid : database
    {

        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var rutaBase = Path.Combine(ruta, "base.db3");
            return new SQLiteAsyncConnection(rutaBase); 
        }
   }

}