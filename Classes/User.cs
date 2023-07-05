using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QCM.Classes;

namespace QCM
{

    public class User
    { 
        static string sep = ":";

        public bool havePermation(ucQCM_box QCM_box)
        {
            // Note (Houdaifa) add validation accounrding to user permation
            return true;
        }


        static public User find_teacher_by_email(string email)
        {

            List<User> teachers = load_users_list(App.fTeacher_List);

            for (int i = 0; i < teachers.Count; i++)
            {

                if (teachers[i].email == email)
                {
                    if(teachers[i].email == "admin")
                    {
                        teachers[i].userType = enUser.eAdmin;
                    }
                    
                    return teachers[i];

                }

            }

            return null;
        }

        static public User find_student_by_email(string email)
        {

            List<User> students = load_users_list(App.fTeacher_List);

            for (int i = 0; i < students.Count; i++)
            {

                if (students[i].email == email) return students[i];

            }

            return null;
        }

        static public User find_teacher_by_id(string id)
        {

            List<User> teachers = load_users_list(App.fTeacher_List);

            for(int i = 0; i < teachers.Count; i++)
            {

                if (teachers[i].id == id) return teachers[i];

            }

            return null;
        }

        static public User find_student_by_id(string id)
        {

            List<User> students = load_users_list(App.fTeacher_List);

            for (int i = 0; i < students.Count; i++)
            {

                if (students[i].id == id) return students[i];

            }

            return null;
        }

        public void Save()
        {

            switch(this.mode)
            {
                case enMode.eAddNew:
                    {
                        add_new_user(this);
                        return;
                    }

                case enMode.eUpdate:
                    {

                        update_user(this);
                        return;
                    }

                case enMode.eDelete:
                    {
                        delete_user(this);
                        return;
                    }
            }


        }

        private void update_user(User user)
        {

            if (user.isTeacher())
            {
                update_teacher(user);
            }
            else if (user.isStudent())
            {
                update_student(user);
            }
        }

        private void update_teacher(User user)
        {
            List<User> list_Teachers = load_users_list(App.fTeacher_List);
            string[] list_data_lines = new string[list_Teachers.Count];


            for (int i = 0; i < list_Teachers.Count; i++)
            {
                if (list_Teachers[i].id == user.id)
                {

                    list_Teachers[i].become_copy(user);
                }

                list_data_lines[i] = list_Teachers[i].to_data_line();
            }



            File.WriteAllLines(App.fTeacher_List, list_data_lines);

        }

        private void update_student(User user)
        {
            List<User> list_Students = load_users_list(App.fStudent_List);
            string[] list_data_lines = new string[list_Students.Count];


            for (int i = 0; i < list_Students.Count; i++)
            {
                if (list_Students[i].id == user.id)
                {

                    list_Students[i].become_copy(user);
                }

                list_data_lines[i] = list_Students[i].to_data_line();
            }



            File.WriteAllLines(App.fStudent_List, list_data_lines);
        }



        private void delete_user(User user)
        {

            if (user.isTeacher())
            {
                delete_teacher(user);
            }
            else if (user.isStudent())
            {
                delete_student(user);
            }
        }

        private void delete_teacher(User user)
        {
            List<User> list_Teachers = load_users_list(App.fTeacher_List);
            string[] list_data_lines = new string[list_Teachers.Count - 1] ;
            int j = 0;

            for (int i = 0; i < list_Teachers.Count;i++)
            {
                if (list_Teachers[i].id != user.id)
                {
                    list_data_lines[j] = list_Teachers[i].to_data_line();
                    j++;
                }



            }



            File.WriteAllLines(App.fTeacher_List, list_data_lines);

        }

        private void delete_student(User user)
        {
            List<User> list_Students = load_users_list(App.fStudent_List);
            string[] list_data_lines = new string[list_Students.Count];


            for (int i = 0; i < list_Students.Count; i++)
            {
                if (list_Students[i].id == user.id)
                {

                    list_Students[i].become_copy(user);
                }

                list_data_lines[i] = list_Students[i].to_data_line();
            }



            File.WriteAllLines(App.fStudent_List, list_data_lines);
        }


        private void become_copy(User user)
        {
            this.email = user.email;
            this.password = user.password;
            this.firstName = user.firstName;
            this.lastName = user.lastName;
        }

        private static List<User> load_users_list(string file_name)
        {
            string[] list = File.ReadAllLines(file_name);
            List <User> users = new List<User>();

            for (int i = 0; i < list.Length; i++)
            {
                users.Add(from_data_line_to_user(list[i]));
            }

            return users;
        }

        private static User from_data_line_to_user(string dataline)
        {
            string[] info = dataline.Split(sep[0]);
            User user = new User(info[0], info[1], info[2], info[3], info[4],enUser.eUndefined);

            return user;
        }

        public User(string id,string firstName, string lastName, string email, string password,enUser userType,enMode mode = enMode.eUpdate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.userType = userType;
            this.mode = mode;
        }

        private void add_new_user(User new_user)
        {

            if(new_user.isTeacher()) 
            {

                File.AppendAllText(App.fTeacher_List,new_user.to_data_line() + "\n");
                return;
            }
            else if(new_user.isStudent())
            {
                File.AppendAllText(App.fStudent_List,new_user.to_data_line() + "\n");
                return;
            }

            
        }

        private string to_data_line()
        {
            string line = "";

            line += this.id + sep;
            line += this.firstName + sep;
            line += this.lastName + sep;
            line += this.email + sep;
            line += this.password;



            return line;
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

        public bool isAdmin()
        {
            return this.userType == enUser.eAdmin;

        }
        public User(string id,enUser userType)
        {
            this.id = id;
            this.userType = userType;
            this.mode = enMode.eAddNew;
        }

        public User()
        {
            this.mode = enMode.eEmpty;
        }


        public enum enUser { eStudent = 1, eTeacher = 2,eAdmin = 3, eUndefined =4};
        public enum enMode
        {
            eAddNew,
            eUpdate,
            eDelete,
            eEmpty
        }


        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;


        // not to save
        private enUser userType;
        private enMode mode;
    }
}
