using System;
using MiniORMLive.Attributes;

namespace MiniORMLive.Entities
{
    [Entity(TableName = "Users")]
    class User
    {
        [Id]
        private int id;

        [Column(ColumnName = "Username")]
        private string username;

        [Column(ColumnName = "Pass")]
        private string password;

        [Column(ColumnName = "Age")]
        private int age;

        [Column(ColumnName = "RegistrationDate")]
        private DateTime registrationDate;

        [Column(ColumnName = "LastLoginTime")]
        private DateTime lastLoginTime;

        [Column(ColumnName = "IsActive")]
        private bool isActive;

        public User(string username, string password, int age, DateTime registrationDate, DateTime lastLoginTime, bool isActive)
        {
            Username = username;
            Password = password;
            Age = age;
            RegistrationDate = registrationDate;
            LastLoginTime = lastLoginTime;
            IsActive = isActive;
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return registrationDate;
            }

            set
            {
                registrationDate = value;
            }
        }

        public DateTime LastLoginTime
        {
            get
            {
                return lastLoginTime;
            }

            set
            {
                lastLoginTime = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }
    }
}
