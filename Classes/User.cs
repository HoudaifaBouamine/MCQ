using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public class User
    {

        public bool havePermation(ucQCM_box QCM_box)
        {
            // Note (Houdaifa) add validation accounrding to user permation
            return true;
        }
        public static User get_Teacher()
        {

            // Note (Houdaifa) this function is just for testing and must be deleted 

            User user = new User("A001",enUser.eTeacher);
            user.email = "houdaifa@gmail.com";
            user.FirstName = "Houdaifa";
            user.LastName = "Bouamine";
            user.password = "1234";

            return user;
        }

        public static User get_Student()
        {

            // Note (Houdaifa) this function is just for testing and must be deleted 
            User user = new User("B003", enUser.eStudent);
            user.email = "h.student@gmail.com";
            user.FirstName = "Hareth";
            user.LastName = "Bouamine";
            user.password = "1234";

            return user;
        }

        public void Save()
        {

            // Note (Houdaifa) there you save new Users or update existed users

        }
        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if(isValidEmail(value))
                    this.email = value;
            }
        }

        public bool isValidEmail(string email)
        {
            // Note (Houdaifa) add validation for email format( @gmail.com , @somthing.dz ...)
            if (email == null)
                return false;

            if (email == "")
                return false;

            return true;
        }

        public string Password
        {
            set 
            {
                this.password = value;
            }
        }

        public bool isCorrectPassword(string password)
        {
            return this.password == password;
        }
        public bool isStudent()
        {
            return this.userType == enUser.eStudent;
        }

        public bool isTeacher()
        {
            return this.userType == enUser.eTeacher;
        }
        public User(string id,enUser userType)
        {
            this.id = id;
            this.userType = userType;
        }

        public User()
        {
            
        }


        public enum enUser { eStudent = 1, eTeacher = 2};

        private string id;
        private enUser userType;
        private string firstName;
        private string lastName;
        private string email;
        private string password;

    }
}
