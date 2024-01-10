using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Utilities
{
    public static class NativePaths
    {
        public static  string GetFilePath(IHostingEnvironment _env = null)
        {
                    string path = "";
            if (_env != null && _env.IsProduction())
            {
                path = "http://109.73.162.9:5010/Files/";
            }
            else if (_env != null && _env.IsDevelopment())
            {
                path = "http://localhost:63232/Files/";
            }
            else
            {
                path = "/Files/";
            }

            return path;
        }
    }
}
