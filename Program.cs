using System;
using System.Collections.Generic;

namespace Pelnomocnik
{

    public class User
    {

        private bool HasAdminPrivilages;

        
        public User(bool uprawnienia)
        {
            HasAdminPrivilages = uprawnienia;
        }

        public void MakeAdmin()
        {
            HasAdminPrivilages=true;
        }

        public bool IsAdmin()
        {
            HasAdminPrivilages = false;
        }

    }

    public interface Information
    {
        public abstract void DisplayData();
        public abstract void DisplayRestrictedData();
    }

    public class Database : Information
    {

        private Dictionary<string, double> Map;

        public Database()
        {
            // stworzenie bazy użytkowników
            // i uzupełnienie wartości
        }

        // wyświetlenie listy użytkowników

        // wyświetlenie ujawniające zarobki

    }

    public class DatabaseGuard : Information
    {

        private Database DB;
        private User user;

        public DatabaseGuard(User u)
        {
            // stworzenie obiektu DB i przypisanie do pola
            // u? pewnie pole ;)
        }

        public void DisplayData()
        {
            DB.DisplayData();
        }

        public void DisplayRestrictedData()
        {
            // sprawdzenie uprawnień i odpowienie działanie
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var Zbyszek = new User(false);
            var db = new DatabaseGuard(Zbyszek);

            db.DisplayData();

            Console.WriteLine("---------------------------------------------------------");

            db.DisplayRestrictedData();

            Console.WriteLine("---------------------------------------------------------");

            Zbyszek.MakeAdmin();
            db.DisplayRestrictedData();

        }
    }

}