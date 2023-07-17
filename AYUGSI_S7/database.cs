using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AYUGSI_S7
{
    public  interface database
    {
        SQLiteAsyncConnection GetConnection();  
    }
}
