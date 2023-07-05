using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QCM.Classes
{
    public class clsQCM
    {

        public static clsQCM from_tree_to_QCM_class(System.Windows.Forms.TreeView treeview,
            string title, enLevel level, byte choiseCount,List<byte> correctAnswers)
        {
            clsQCM qcm = new clsQCM();

            qcm.title = title;
            qcm.level = level;
            qcm.choisesCount = choiseCount;
            qcm.questionCount = (byte)treeview.Nodes.Count;


            for (int i = 0; i < treeview.Nodes.Count; i++)
            {

                Question question = new Question();
                question.text = treeview.Nodes[i].Text;
                // Note (Houdaifa) By def it is 1 (for now)
                question.mark = 1;

                for (int j = 0; j < treeview.Nodes[i].Nodes.Count; j++)
                {
                    question.answers.Add(treeview.Nodes[i].Nodes[j].Text);

                    
                }
                question.correctAnswerIndex = correctAnswers[i];



                qcm.QuestionList.Add(question);

            }

            return qcm;
        }

        public static void add_QCM_to_file(clsQCM QCM,bool update = false) 
        {
            if (!update)
            {
                File.AppendAllText(App.fQCM_List, from_QCM_to_line(QCM) + "\n");
            }
           
        }

        public static string from_QCM_to_line(clsQCM qcm)
        {
            string result = "";

            result += qcm.title                                         + ":";
            result += (byte)(qcm.level)                                 + ":";
            result += qcm.questionCount.ToString()                      + ":";
            result += qcm.choisesCount.ToString()                       + ":";


            string sub_result = "";
            for (int i = 0; i < qcm.questionCount; i++)
            {
                sub_result = "";

                sub_result += qcm.QuestionList[i].text              + "/";
                sub_result += qcm.QuestionList[i].correctAnswerIndex    + "/";
                sub_result += qcm.QuestionList[i].mark                  + "/";


                for(int j = 0; j < qcm.QuestionList[i].answers.Count; j++)
                {
                    sub_result += qcm.QuestionList[i].answers[j]        + "/";
                }   

                sub_result = sub_result.Substring(0,sub_result.Length - 1);
                result += sub_result                                    + ":";
            }

            result = result.Substring(0,result.Length - 1);

            return result;
        }
        public clsQCM() {

            this.QuestionList = new List<Question>();

        }

        public clsQCM(string title, enLevel level, byte questionCount, byte chooseCount)
        {

            this.title = title;
            this.level = level;
            this.questionCount = questionCount;
            this.choisesCount = chooseCount;

            this.QuestionList = new List<Question>();
          
        }

        public class Question
        {

            public string text;
            public List<string> answers;
            public byte correctAnswerIndex;
            public byte mark;


            public Question()
            {
                this.answers = new List<string>();
                this.correctAnswerIndex = 0;
                this.text = string.Empty;
                this.mark = 0;
            }
        }

        public List<Question> QuestionList;
        public string title;
        public enLevel level;
        public byte questionCount;
        public byte choisesCount;

    }
}
