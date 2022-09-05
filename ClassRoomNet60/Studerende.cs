using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Studerende
    {
		private String studentName;

		public String StudentName
		{
			get { return studentName; }
			set { studentName = value; }
		}

		private int myBirthMonth;

		public int MyBirthmonth
		{
			get { return myBirthMonth; }
			set { myBirthMonth = value; }
		}


		private int myBirthday;

		public int MyBirthday
		{
			get { return myBirthday; }
			set { myBirthday = value; }
		}

		public Studerende()
		{

		}
		public Studerende(string studentName, int myBirthMonth, int myBirthday)
		{
			StudentName = studentName;
			//StudentName = studentName;
			//this.myBirthMonth = myBirthMonth;
			this.MyBirthmonth = myBirthMonth;
			MyBirthday = myBirthday;
			//MyBirthday = myBirthday;
		}	
	}
}
