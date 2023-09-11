namespace Lab01
{
    internal class Student
    {
        // StLastName, StFirstName,Grade,Classroom,Bus,TLastName,TFirstName
        public string? StLastName { get; set; }
        public string? StFirstName { get; set; }
        public int Grade { get; set; }
        public int Classroom { get; set; }
        public int Bus { get; set; }
        public string? TLastName { get; set; }
        public string? TFirstName { get; set; }

        public override string ToString()
        {
            string? data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Grade: " + Grade + Environment.NewLine;
            data += "Student Classroom: " + Classroom + Environment.NewLine;
            data += "Student Bus: " + Bus + Environment.NewLine;
            data += "Teacher LastName: " + TLastName + Environment.NewLine;
            data += "Teacher FirstName: " + TFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringStudentClassTeacher()
        {
            string? data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Classroom: " + Classroom + Environment.NewLine;
            data += "Teacher LastName: " + TLastName + Environment.NewLine;
            data += "Teacher FirstName: " + TFirstName + Environment.NewLine;
            //создаем строку из символа, повторяющегося 25 раз
            data += new string('*', 25) + Environment.NewLine;
            return data;
        }

        public string ToStringStudentBus()
        {
            string? data = "Student LastName: " + StLastName + Environment.NewLine;
            data += "Student FirstName: " + StFirstName + Environment.NewLine;
            data += "Student Bus: " + Bus + Environment.NewLine;
            data += new string('*', 25) + Environment.NewLine;
            return data;
        }

        public string ToStringTeacherStudents()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }

        public string ToStringBusStudent()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }
        public string ToStringStudentGrade()
        {
            string? data = "student: " + StLastName + " " + StFirstName + Environment.NewLine;
            return data;
        }

    }
}