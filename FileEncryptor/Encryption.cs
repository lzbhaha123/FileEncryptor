using System;
using System.IO;


namespace FileEncryptor
{
    class Encryption
    {
        private string targetPath;

        public string TargetPath
        {
            get { return targetPath; }
            set { targetPath = value; }
        }

        private string outputPath;

        public string OutputPath
        {
            get { return outputPath; }
            set { outputPath = value; }
        }

        private string passwd;

        public string Passwd
        {
            get { return passwd; }
            set { passwd = value; }
        }

        public string GetExtension(String fileName) {
            string[] parts = fileName.Split('.');
            return parts[parts.Length - 1];
        }
        public string GetName(String fileName) {
            string[] parts = fileName.Split('\\');
            return parts[parts.Length - 1].Replace("."+GetExtension(parts[parts.Length - 1]),"");
        }
        public void EncryptFile()
        {
            //Convert file to binary
            byte[] pwb = new byte[passwd.Length * sizeof(char)];
            System.Buffer.BlockCopy(passwd.ToCharArray(), 0, pwb, 0, pwb.Length);
            byte[] b;
            using (FileStream fs = File.OpenRead(targetPath))
            {
                b = File.ReadAllBytes(targetPath);
                fs.Read(b, 0, b.Length);
                fs.Close();
            }
            //Convert password to binary and add to file binary 
            byte[] temb = new byte[b.Length + pwb.Length];
            for (int i = 0; i < pwb.Length; i++)
            {
                temb[i] = pwb[i];
            }
            for (int i = pwb.Length; i < temb.Length; i++)
            {
                temb[i] = b[i - pwb.Length];
            }
            using (var fs = new FileStream(outputPath + "/"+GetName(targetPath) +"."+ GetExtension(targetPath), FileMode.Create, FileAccess.ReadWrite))
            {
                fs.Write(temb, 0, temb.Length);

            }
        }
        public bool isSuccess = false;
        public void DecryptFile()
        {
            //Convert password to binary
            byte[] pwb = new byte[passwd.Length * sizeof(char)];
            System.Buffer.BlockCopy(passwd.ToCharArray(), 0, pwb, 0, pwb.Length);
            //Convert encrypted file to binary and get extra byte( password which has been converted to binary ) 
            byte[] b;
            using (FileStream fs = File.OpenRead(targetPath))
            {
                b = File.ReadAllBytes(targetPath);
                fs.Read(b, 0, b.Length);
                fs.Close();
            }
            // compare 2 passwords
            byte[] epwb = new byte[pwb.Length];
            for (int i = 0; i < epwb.Length; i++) {
                epwb[i] = b[i];
            }
           
            if (System.Text.Encoding.UTF8.GetString(pwb)== System.Text.Encoding.UTF8.GetString(epwb)) {
                // Convert file binary to file
                byte[] temb = new byte[b.Length - pwb.Length];
                for (int i = 0; i < temb.Length; i++)
                {
                    temb[i] = b[i + pwb.Length];
                }
                using (var fs = new FileStream(outputPath + "/" + GetName(targetPath) + "." + GetExtension(targetPath), FileMode.Create, FileAccess.ReadWrite))
                {
                    fs.Write(temb, 0, temb.Length);

                }
                isSuccess = true;
            }
            
        }
    }
}
