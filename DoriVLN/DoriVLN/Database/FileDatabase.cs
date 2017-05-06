using DoriVLN.Models.Entity;
using DoriVLN.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Database
{
    public class FileDatabase: BaseDatabase
    {
        public void addFileToDB(File file)
        {
            _db.Files.Add(file);
            _db.SaveChanges();
        }
        
        public File getFileFromDB(int fileID)
        {
            File retFile = new File();
            foreach (File f in _db.Files)
            {
                if (f.ID == fileID)
                {
                    retFile = f;
                }
                else
                {
                    //TODO: throw exception
                }
               
            }
            return retFile;
        }

        public void removeFileFromDB(int fileID)
        {
            File file = new File();
            foreach(File f in _db.Files)
            {
                if (f.ID == fileID)
                {
                    file = f;
                }
            }
            if(file == null)
            {
                //TODO: Throw Null Exception
            }

            _db.Files.Attach(file);
            _db.Files.Remove(file);
            _db.SaveChanges();


            //TODO: Throw some kind of "File is non-existent" exception
        }

        public void  editFileInDB(int fileID, File file)
        {

            foreach(File f in _db.Files)
            {
                if(f.ID == fileID)
                {
                }
            }

        }
    }
}