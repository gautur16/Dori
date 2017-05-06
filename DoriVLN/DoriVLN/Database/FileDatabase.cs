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
            var retFile = _db.Files.SingleOrDefault(f => f.ID == fileID);
            return retFile;
        }

        public void removeFileFromDB(int fileID)
        {
            var file = _db.Files.SingleOrDefault(f => f.ID == fileID);
            if(file == null)
            {
                //TODO: Throw Null Exception
            }

            _db.Files.Attach(file);
            _db.Files.Remove(file);
            _db.SaveChanges();
        }

        public void  editFileInDB(int fileID, File newfile)
        {
            var file = _db.Files.SingleOrDefault(f => f.ID == fileID);

            file.name = newfile.name;
            file.fileType = newfile.fileType;
            _db.SaveChanges();

        }

        public bool fileExists(File file)
        {
            var retFile = _db.Files.SingleOrDefault(f => f.name == file.name && f.fileType == file.fileType && file.ownerID == f.ownerID);
            if(retFile != null)
            {
                return true;
            }

            return false;
        }

        public int getFileID(File file)
        {
            
            var retFile = _db.Files.SingleOrDefault(f => f.name == file.name && f.fileType == file.fileType && file.ownerID == f.ownerID);
            if (retFile == null)
            {
                //TODO: throw NotFoundException...
            }
            
                return retFile.ID;
            
        }
    }
}