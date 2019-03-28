using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    [Serializable()]
    public class Student : ISerializable
    {

        public string studentNo;
        public string age;
        public string phone;
        public string name;
        public string surname;
        public string dept;
        public string placeOfBirth;
        public string sex;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Student No", studentNo);
            info.AddValue("Age", age);
            info.AddValue("Name", name);
            info.AddValue("Surname", surname);
            info.AddValue("Phone", phone);
            info.AddValue("Department", dept);
            info.AddValue("Place of Birth", placeOfBirth);
            info.AddValue("Sex", sex);
        }
        public Student(SerializationInfo info, StreamingContext context)
        {
            studentNo = (string)info.GetValue("Student No", typeof(string));
            age = (string)info.GetValue("Age", typeof(string));
            name = (string)info.GetValue("Name", typeof(string));
            surname = (string)info.GetValue("Surname", typeof(string));
            phone = (string)info.GetValue("Phone", typeof(string));
            dept = (string)info.GetValue("Department", typeof(string));
            placeOfBirth = (string)info.GetValue("Place of Birth", typeof(string));
            sex = (string)info.GetValue("Sex", typeof(string));
        }

        public Student()
        {
        }
        public Student(string s)
        {
            studentNo = s;
            age = s;
            phone = s;
            name = s;
            surname = s;
            dept = s;
            placeOfBirth = s;
            sex = s;
    }
    }
}
