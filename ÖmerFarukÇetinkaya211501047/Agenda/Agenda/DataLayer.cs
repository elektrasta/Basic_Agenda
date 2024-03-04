using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using DatabaseCreate;
using CrossCutting;
using BusinessLayer;

using System.Data.Entity.Validation;

namespace DataLayer
{
    class ManagerFisiere
    {
        public static DataTable get_fisiere_pr(int uid)
        {
            try
            {
                DataTable dt = new DataTable();

                using (var db = new AgendaDBContext())
                {
                    var query = (from a in db.Fisiere
                                 where a.UserId == uid
                                 select new { Nume_Fisier=a.NumeReal,a.data_si_ora, SharedWith=a.ShareList ,a.FisierId,a.NumeCriptat}
                                 ).ToList();

                    // Anonim bir sorgu listesi döndüremediğiniz için tabloyu buraya dönüştürdüm
                    //datatable nesnesine ekler
                    dt.Columns.Add().ColumnName = "File_Id";
                    dt.Columns.Add().ColumnName ="Nume_Fisier";
                    dt.Columns.Add().ColumnName = "Data_si_Ora";
                    
                    dt.Columns.Add().ColumnName = "ShareList";
                    dt.Columns.Add().ColumnName = "Nume_Criptat";

                    //string ora = "";
                    //string data = "";

                    foreach (var item in query)
                    {
                    //    string[] words = Convert.ToString(item.data_si_ora).Split(' ');
                    //    data = words[0];
                    //    ora = words[1];
                        dt.Rows.Add(item.FisierId,item.Nume_Fisier,item.data_si_ora,item.SharedWith,item.NumeCriptat);

                    }


                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK);
                return null;
            }
        }

        public static DataTable get_fisiere_ext(int uid)
        {//kullanıcıların paylaştığı dosyaları döndürür
            try
            {//dosyalar ve kullanıcıları birbirine bağladım
                DataTable dt = new DataTable();
                dt.Columns.Add().ColumnName ="Nume_Fisier";
                dt.Columns.Add().ColumnName ="Owner";
                dt.Columns.Add().ColumnName ="Data_si_Ora";
                dt.Columns.Add().ColumnName = "File_Id";
                dt.Columns.Add().ColumnName = "Nume_Criptat";
                using (var db = new AgendaDBContext())
                {
                    var query = from f in db.Fisiere
                                join u in db.Users on f.UserId equals u.UserId
                                select new { f.NumeReal, f.NumeCriptat, f.FisierId, f.ShareList, u.Username ,f.data_si_ora };
                    foreach (var intrare in query)
                    {
                        if (intrare.ShareList.Contains('#'))
                        {
                            string[] shared = intrare.ShareList.Split('#');//kullanıcı kimlikleri # saklanır
                            foreach (var x in shared)
                            {
                                if (String.Compare(intrare.ShareList, "") == 0) continue;
                                if (Convert.ToInt32(x) == uid)
                                {

                                    dt.Rows.Add(intrare.NumeReal,intrare.Username,intrare.data_si_ora,intrare.FisierId,intrare.NumeCriptat);
                                   

                                    break;
                                }
                            }
                        }
                        else//boşsa eklenmez
                        {
                            if (String.Compare(intrare.ShareList, "") == 0) continue;
                            if (Convert.ToInt32(intrare.ShareList) == uid)
                                dt.Rows.Add(intrare.NumeReal, intrare.Username, intrare.data_si_ora, intrare.FisierId, intrare.NumeCriptat);
                        }
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK);
                return null;
            }
        }

        public static void share(string username, string fis_nume)
        {//dosya paylaşımı için
            using (var db = new AgendaDBContext())//veritabanını çağırdım
            {
                int userid;
                var query = (from u in db.Users
                             where u.Username.CompareTo(username) == 0
                             select u);
                if (query.Count() == 0)//kullanoco varmı kontrol eder
                {
                    MessageBox.Show("kullanıcı yok");
                    return;
                }
                var query2 = (from u in db.Users
                              where u.Username.CompareTo(username) == 0
                              select u).First();
                userid = query2.UserId;
                var query3 = (from f in db.Fisiere
                              where f.NumeReal.CompareTo(fis_nume) == 0
                              select f).First();
                //eğer daha önce paylaşılmışsa normal yapıyormuş gibi olur ama 2. kez eklemez
                int fis_id = query3.FisierId;
                int uid = query3.UserId;
                var query4 = (from f in db.Fisiere
                              where f.FisierId == fis_id
                              select f).First();
                string sharelist = query4.ShareList;
                if (sharelist.Contains(Convert.ToString(userid)))
                    return;
                if (String.Compare(sharelist,"")!=0)
                sharelist = sharelist + "#";
                sharelist = sharelist + Convert.ToString(userid);
                var us = (from u in db.Users
                          where u.UserId == uid
                          select u).First();
                query4.Users = us;
                query4.ShareList = sharelist;
                try
                {
                    db.SaveChanges();//db ye kaydeder
                }
                catch (DbEntityValidationException e)
                {
                    string err = "";
                    foreach (var eve in e.EntityValidationErrors)
                    {//hata olursa ata mesajı gelir
                        err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " aşağıdaki doğrulama hatalarına sahiptir:\n\n";

                        foreach (var ve in eve.ValidationErrors)
                        {
                            err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Hata: " + Convert.ToString(ve.ErrorMessage) + "\n";

                        }
                    }
                    MessageBox.Show(err);

                }
            }
        }

        public static void insert(int uid, string data_ora, string nume_real, string nume_criptat)
        {//bir dosyanın veritabanına kaydedilmesini sağlar
            using (var db = new AgendaDBContext())
            {
                // Bunun için Sınıf Gündemine eklemek için oturum açmış kullanıcıyı devralıcaz
                var query = from u in db.Users
                            select u;
                Users us_logat = null;
                foreach (var user in query)
                {
                    if (user.UserId == uid)
                        us_logat = user;
                }


                int fid = DatabaseManagement.get_next_fisier_id();
                DatabaseCreate.Fisier a = new DatabaseCreate.Fisier { FisierId = fid, UserId = uid, data_si_ora = Convert.ToDateTime(data_ora), NumeReal = nume_real, NumeCriptat = nume_criptat, Open = false, ShareList = "", Users = us_logat };
                db.Fisiere.Add(a);
                db.SaveChanges();//kaydeder
                DatabaseManagement.increment_next_agenda_id();//id değerini arttırır
            }


        }

        public static void remove_access(string fisier)
        {//dosya erişimini kaybetmeye yarar
            int user = ManageAgenda.get_userid();
            using (var db = new AgendaDBContext())
            {//gerçek adını bulur ve erişimi kaybetirir
                var query = (from f in db.Fisiere
                              where f.NumeReal.CompareTo(fisier) == 0
                              select f).First();
                int fis_id = query.FisierId;
                int uid = query.UserId;
                if (query.ShareList.Contains('#'))
                {
                    string[] sharelist = query.ShareList.Split('#');
                    string newsharelist="";
                    foreach (string x in sharelist)
                        if (Convert.ToInt32(x) != user)
                        {
                            newsharelist += x;
                            newsharelist+="#";
                        }
                    newsharelist=newsharelist.Substring(0,newsharelist.Length-1);
                    query.ShareList = newsharelist;
                }
                else
                {
                    if (Convert.ToInt32(query.ShareList) == user)
                        query.ShareList = "";
                }
                var us = (from u in db.Users
                          where u.UserId == uid
                          select u).First();
                query.Users=us;
                try
                {
                    db.SaveChanges();//değişiklilikleri kaydeder
                }

                catch (DbEntityValidationException e)
                {//hata olursa hatayı gösterir
                    string err = "";
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " aşağıdaki doğrulama hatalarına sahiptir:\n\n";

                        foreach (var ve in eve.ValidationErrors)
                        {
                            err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Hata: " + Convert.ToString(ve.ErrorMessage) + "\n";

                        }
                    }
                    MessageBox.Show(err);

                }
            }
        }


        public static void delete(string filename)
        {//veritabanından dosya silmeye yarar
            try
            {
                using (var db = new AgendaDBContext())
                {//veritabanın varmı bu dosya
                    var x = (from n in db.Fisiere where n.NumeReal == filename select n).FirstOrDefault();
                    db.Fisiere.Remove(x);//sil
                    db.SaveChanges();//kaydedder
                    MessageBox.Show("Dosya başarıyla silindi!");
                }
            }
            catch (DbEntityValidationException e)
            {//hata mesajı için
                string err = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " aşağıdaki doğrulama hatalarına sahiptir:\n\n";

                    foreach (var ve in eve.ValidationErrors)
                    {
                        err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Hata: " + Convert.ToString(ve.ErrorMessage) + "\n";

                    }
                }
                MessageBox.Show(err);
            }
        }
    }


    class ManagerAgenda
    {
        public static void insert(int uid,string data_ora,string titl,string detalii)
        {//yeni bir plan ekler burası
            try
            {
                using (var db = new AgendaDBContext())
                {
                    // Bunun için Sınıf Gündemine eklemek için oturum açmış kullanıcıyı devralıcaz
                    var query = from u in db.Users
                                select u;
                    Users us_logat = null;
                    foreach (var user in query)
                    {
                        if (user.UserId == uid)
                            us_logat = user;
                    }

                    int agid = DatabaseManagement.get_next_agenda_id();
                    DatabaseCreate.Agenda a = new DatabaseCreate.Agenda { Id = agid, UserId = uid,data_si_ora= Convert.ToDateTime(data_ora), titlu = titl, notita = detalii,Users=us_logat };
                    db.Agenda.Add(a);
                    db.SaveChanges();
                    DatabaseManagement.increment_next_agenda_id();
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //MessageBox.Show("Eroare la inserare in agenda!");
            //}

            catch (DbEntityValidationException e)
            {//hata mesajı
                string err = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " aşağıdaki doğrulama hatalarına sahiptir:\n\n";

                    foreach (var ve in eve.ValidationErrors)
                    {
                        err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Hata: " + Convert.ToString(ve.ErrorMessage) + "\n";

                    }
                }
                MessageBox.Show(err);

            }
        }

        public static void updated(int uid, int index, string data_si_ora, string titlu, string detalii)
        {//planın güncellenmesi sağlanır
            try
            {


                using (var db = new AgendaDBContext())
                {//bilgileri getiriri ve kullanıcı günceller
                    var query = from u in db.Users
                                select u;
                    Users us_logat = null;
                    foreach (var user in query)
                    {
                        if (user.UserId == uid)
                            us_logat = user;
                    }

                    var intrare = (from s in db.Agenda
                                   where s.Id == index
                                   select s).FirstOrDefault();
                    intrare.notita = detalii;
                    intrare.titlu = titlu;
                    intrare.data_si_ora = Convert.ToDateTime(data_si_ora);
                    intrare.Users = us_logat;

                    db.SaveChanges();//değişikliği kaydeder
                }

            }

            catch (DbEntityValidationException e)
            {
                string err = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " aşağıdaki doğrulama hatalarına sahiptir:\n\n";

                    foreach (var ve in eve.ValidationErrors)
                    {
                        err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Hata: " + Convert.ToString(ve.ErrorMessage) + "\n";

                    }
                }
                MessageBox.Show(err);

            }
        }

        public static void delete(int ind)
        {//silmeye yarar planı
            try
            {
                using (var db = new AgendaDBContext())
                {
                    var x=(from n in db.Agenda where n.Id==ind select n).FirstOrDefault();//bulur lanı
                    db.Agenda.Remove(x);//siler
                    db.SaveChanges();//değişiklikler kaydeolur
                    MessageBox.Show("Giriş başarıyla temizlendi!");
                }
            }
            catch (DbEntityValidationException e)
            {
                string err = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    err += "Entity of type " + Convert.ToString(eve.Entry.Entity.GetType().Name) + " in state " + Convert.ToString(eve.Entry.State) + " aşağıdaki doğrulama hatalarına sahiptir:\n\n";

                    foreach (var ve in eve.ValidationErrors)
                    {
                        err += "- Property: " + Convert.ToString(ve.PropertyName) + ", Hata: " + Convert.ToString(ve.ErrorMessage) + "\n";

                    }
                }
                MessageBox.Show(err);
            }
        }

        public static DataTable get_agenda_for_uid(int uid)
        {//planların bir datatablede toplanmasını sağlar
            try
            {
                DataTable dt = new DataTable();
                
                using (var db = new AgendaDBContext())
                {
                    var query = (from a in db.Agenda
                                 where a.UserId == uid
                                 select new {Id_intrare=a.Id, a.data_si_ora , Titlu=a.titlu, Detalii=a.notita }
                                 ).ToList();

                    // Anonim bir sorgu listesi döndüremediğiniz için tabloyu veri katmanında dönüştürdüm


                    dt.Columns.Add().ColumnName="Id_intrare";
                dt.Columns.Add().ColumnName = "Data";
                dt.Columns.Add().ColumnName = "Ora";
                dt.Columns.Add().ColumnName = "Titlu";
                dt.Columns.Add().ColumnName = "Detalii";

                string ora = "";
                string data = "";

                foreach (var item in query)
                {
                    string[] words = Convert.ToString(item.data_si_ora).Split(' ');
                    data = words[0];//tarih ve saati ayrıştırmak için kullanıdım
                    ora = words[1];
                    dt.Rows.Add(item.Id_intrare, data, ora, item.Titlu, item.Detalii);
                    
                }
                

                }
                return dt;//datatableyi döndürür
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK);
                return null;
            }
        }
    }

    class ManageUsers
    {
        public static void insert(string username,string password)
        {//yeni bir kullanıcı eklemeye yarar bu kod
            try
            {
                using (var db = new AgendaDBContext())
                {
                    int userid = DatabaseManagement.get_next_user_id();
                    Users u = new Users { Username = username, Password = password, UserId = userid };
                    db.Users.Add(u);//ekler
                    db.SaveChanges();//kaydeder
                    DatabaseManagement.increment_next_user_id();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata", MessageBoxButtons.OK);
            }

            
        }
    }
}
