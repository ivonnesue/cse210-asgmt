using System;

    public class Assignment
    {
        protected string _studentName;
        private string _topic;

        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }
        public void setStudentName(string studentName)
        {
            _studentName = studentName;
        }

        public string getStudentName()
        {
            return _studentName;
        }

        public void setTopic(string topic)
        {
            _topic = topic;
        }

        public string getTopic()
        {
            return _topic;
        }
        public string GetSummary()
        {
            return $"{_studentName}, {_topic}";
        }
    }

