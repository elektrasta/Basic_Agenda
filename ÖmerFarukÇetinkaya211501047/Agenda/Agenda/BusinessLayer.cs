using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Data;

using DataLayer;

using System;
using System.IO;


namespace BusinessLayer
{
    class ManageFisiere
    {
        public static DataView dv_fisiere_proprii;
        public static DataView dv_fisiere_externe;
        static DataTable t_fis_proprii;
        static DataTable t_fis_externe;
        static string fis_selectat;

        public static void get_dvs()//iki data wiev nesnesi alır
        {
            //getirir
            t_fis_proprii = ManagerFisiere.get_fisiere_pr(ManageAgenda.get_userid());
            DataView view = new DataView(t_fis_proprii);
            DataTable table2 = view.ToTable("proprii", false, "Nume_Fisier", "Data_si_Ora"); 
            dv_fisiere_proprii = new DataView(table2);

            t_fis_externe = ManagerFisiere.get_fisiere_ext(ManageAgenda.get_userid());
            view = new DataView(t_fis_externe);
            DataTable table3 = view.ToTable("shared", false, "Nume_Fisier", "Owner", "Data_si_Ora");
            dv_fisiere_externe = new DataView(table3);


        }


        public static void upload_fisier(string filename)
        {//siteme dosya yükler
            string nume_criptat = criptare_fis(filename);//şifrelenir
            string[] words = filename.Split('\\');
            string filename2 = words[words.Length - 1];
            words = nume_criptat.Split('\\');
            string nume_criptat2 = words[words.Length - 1];
            //ekler 
            ManagerFisiere.insert(ManageAgenda.get_userid(), DateTime.Now.ToString(), filename2, nume_criptat2);
        }

        public static void upload_revision(int index, string filename)
        {//dosyayı revizyon etmek için yazdım
            DataRow dr = t_fis_externe.Rows[index];

            string cript = dr["Nume_Criptat"].ToString();

            string cript_veche = criptare_fis(filename);//şifrelenmiş dosya

            string path = @".\data\";

            //File.Delete(path + cript);
            File.Replace(cript_veche,path+ cript, null);//tekrar isimlendiririz
        }

        public static bool download(int index,string filename)
        {
            DataRow dr = t_fis_proprii.Rows[index];

            string cript = dr["Nume_Criptat"].ToString();

            decriptare_fisier(cript, filename);


            return true;
        }

        public static bool download_ext(int index, string filename)
        {
            DataRow dr = t_fis_externe.Rows[index];

            string cript = dr["Nume_Criptat"].ToString();

            decriptare_fisier(cript, filename);


            return true;
        }

        private static void decriptare_fisier(string cript, string decript)
        {//dosyaların şifresini çözmesi için
            string pathOld = @".\data\" + cript;


            using (FileStream fsSource = new FileStream(pathOld,
            FileMode.Open, FileAccess.Read))
            {

                // Kaynak dosyayı bir bayt dizisine okucak
                byte[] bytes = new byte[fsSource.Length];
                //byte r=15;
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Okuma, 0'dan numbytestoread'e herhangi bir şey döndürebilme ihtimali var
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Dosyanın sonuna ulaşıldığında ara vericez
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;
                for (int i = 0; i < numBytesToRead; i++) bytes[i] = (byte)(bytes[i] ^ 'r');

                Directory.CreateDirectory(Path.GetDirectoryName(decript));

                using (FileStream fsNew = new FileStream(decript,
                FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }


            }


        }

        private static string criptare_fis(string filename)
        {

            string pathNew = @".\data\aaa";
            string data = DateTime.Now.ToString();
            string[] words;
            words = data.Split(' ', '.', ':');
            foreach (string word in words)
                pathNew = pathNew + word;
            // pathNew=pathNew+".txt";


            using (FileStream fsSource = new FileStream(filename,
            FileMode.Open, FileAccess.Read))
            {

                // Kaynak dosyayı bir bayt dizisine okucak
                byte[] bytes = new byte[fsSource.Length];
                //byte r=15;
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Okuma, 0 dan numbytestoread e herhangi bir şey döndürebilme ihtimali var
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Dosyanın sonuna ulaşıldığında ara vericez
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;
                for (int i = 0; i < numBytesToRead; i++) bytes[i] = (byte)(bytes[i] ^ 'r');

                Directory.CreateDirectory(Path.GetDirectoryName(pathNew));

                using (FileStream fsNew = new FileStream(pathNew,
                FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }


            }
            return pathNew;
        }

        public static void del_fis_selectat(string fisnume,int index)
        {
            ManagerFisiere.delete(fisnume);
            
            string path = "";
            
            DataRow dr = t_fis_proprii.Rows[index];
            string nume = dr["Nume_Criptat"].ToString();
            
            path = @".\data\" + nume;
           
            //MessageBox.Show(path);
            File.Delete(path);
        }

        public static void set_fis_selectat(string fisid)
        {
            fis_selectat = fisid;
        }

        public static string get_fis_selectat()
        {
            return fis_selectat;
        }

        public static void share(string username, string fis_nume)
        {
            ManagerFisiere.share(username, fis_nume);
        }

        public static void remove_access(string fisier)
        {
            ManagerFisiere.remove_access(fisier);
        }

    }

    class ManageAgenda
    {
        static int userid_logat;
        public static DataTable intrari_agenda;
        public static DataView intrari_zilnice;//tarihe göre filtreler
        public static DataView intrari_zilnice2;//tarihe göre filtreler

        public static void set_userid(int id)
        {
            userid_logat = id;
        }

        public static int get_userid()
        {
            return userid_logat;
        }

        public static void set_rowfilter(string s)
        {
            intrari_zilnice.RowFilter = String.Format("Data = '{0}'", s);
            intrari_zilnice2.RowFilter = String.Format("Data = '{0}'", s);
        }

        public static void get_datatable()
        {
            intrari_agenda = ManagerAgenda.get_agenda_for_uid(userid_logat);

            DataView view = new DataView(intrari_agenda);
            DataTable table2 = view.ToTable("proprii", false, "Data", "Ora","Titlu","Detalii");  
            //dv_fisiere_proprii = new DataView(table2);
            intrari_zilnice = new DataView(intrari_agenda);
            intrari_zilnice2 = new DataView(table2);
        }

        public static void add_inregistrare(string data,string ora,string minut,string titlu,string detalii)
        {//kullanıcı ajandaya yeni bir plan ekle

            ManagerAgenda.insert(userid_logat, data + " " + ora + ":" + minut, titlu, detalii);
        }

        public static void update(int index, string data, string ora, string minut, string titlu, string detalii)
        {//güncelleme
            ManagerAgenda.updated(userid_logat, index, data + " " + ora + ":" + minut, titlu, detalii);
        }

        public static void del_inregistrare(int ind)
        {//silme
            ManagerAgenda.delete(ind);
        }

        public static string get_titlu(int ind)
        {//ayrıntıları döndürür
            for (int i = 0; i < intrari_agenda.Rows.Count; i++)
            {
                if (Convert.ToInt32(intrari_agenda.Rows[i].ItemArray[0]) == ind)
                    return intrari_agenda.Rows[i].ItemArray[3].ToString();
            }
            return null;
        }

        public static string get_detalii(int ind)
        {//ayrıntıları döndürr
            for (int i = 0; i < intrari_agenda.Rows.Count; i++)
            {
                if (Convert.ToInt32(intrari_agenda.Rows[i].ItemArray[0]) == ind)
                    return intrari_agenda.Rows[i].ItemArray[4].ToString();
            }
            return null;
        }
    }

    

    class ManageUsers
    {
        public static bool insert(string username, string passwd1, string passwd2)
        {//iki şifre eşleşiyorr mu onu kontrol eder
            string passwd3 = criptare_pass(passwd1);
            if (passwd1 != passwd2)
            {
                MessageBox.Show("Şifreler eşleşmiyor", "Hata", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                DataLayer.ManageUsers.insert(username, passwd3);
                return true;
            }
        }

        public static string criptare_pass(string pass)        //önemsiz şifreleme. Gerektiğinde değişecek
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            data = x.ComputeHash(data);
            String md5Hash = System.Text.Encoding.ASCII.GetString(data);
            int nr = md5Hash.Length;

            return md5Hash;
        }
    }
}
