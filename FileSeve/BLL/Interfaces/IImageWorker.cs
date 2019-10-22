using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSeve.BLL.Interfaces
{
    public interface IImageWorker
    {
        /// <summary>
        /// Adding images into file
        /// </summary>
        /// <param name="base64">image in base64 format</param>
        /// <returns>name of photo</returns>
        string SaveImage(string base64);
    }
}
