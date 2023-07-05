using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace QCM.Classes
{
    internal class App
    {

        public const string fQCM_List = "QCM_List.txt";
        public const string fStudent_List = "Student_List.txt";
        public const string fTeacher_List = "Teacher_List.txt";


        public enum enStatus { eLogin, eList,eModify,ePreview,eTest,eHis};

        enStatus status;
        public frm_Main main_form;
        public enStatus Status
        {
            get
            {
                return status;
            }

            set
            {

                if(value == enStatus.eModify)
                {

                    main_form.tp_Main.SelectedIndex = 1;         

                }
                if(value == enStatus.eList)
                {
                    main_form.tp_Main.SelectedIndex = 0;
                }

                status = value;
            }
        }


//---------------------------------------------//

        public static App instance()
        {

            if(app_instance == null)
            {
                app_instance = new App();
            }

            return app_instance;
        }

        private App() { }

        private static App app_instance;

        private clsQCM currentQCM;

        public clsQCM CurrentQCM
        {
            get
            {
                return currentQCM;
            }
            set
            {
                currentQCM = value;
            }
        }
    }
}
