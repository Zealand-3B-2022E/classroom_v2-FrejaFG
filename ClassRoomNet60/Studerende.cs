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

		public string Season()
		{
			switch (MyBirthmonth)
			{
				case 12:
				case 1:
				case 2:
					return "Winter";

				case 3:
				case 4:
				case 5:
					return "spring";
				case 6:
				case 7:
				case 8:
					return "summer";
				case 9:
				case 10:
				case 11:
					return "Autumn";
				default:
					return $"The month no {MyBirthmonth} are not in the interval 1-12";
			}
		}

		public override string ToString()
		{
			return $"{nameof(StudentName)}: { StudentName}, { nameof(MyBirthmonth)}: { MyBirthmonth}, { nameof(MyBirthday)}: { MyBirthday}, Season: {Season}";
		}
	}
}
