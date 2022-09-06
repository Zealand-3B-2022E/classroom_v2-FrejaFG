using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class KlasseRum
    {
		private string klasseNavn;

		public string Klassenavn
		{
			get { return klasseNavn; }
			set { klasseNavn = value; }
		}

		private List<Studerende> studerende;

		public List<Studerende> Studerende
		{
			get { return studerende; }
			set { studerende = value; }
		}

		private DateOnly semesterStart;

		public DateOnly SemesterStart
		{
			get { return semesterStart; }
			set { semesterStart = value; }
		}

		public KlasseRum()
		{

		}

		public KlasseRum(string klasseNavn, List<Studerende> studerende, DateOnly semesterStart)
		{
			this.klasseNavn = klasseNavn;
			//Klassenavn = klassenavn;
			Studerende = studerende;
			//GetStuderende = getStuderende;
			this.semesterStart = semesterStart;
			//GetSemesterStart = getSemesterStart;
		}

		public override string ToString()
		{
			string studerende=" ";
			foreach (var st in Studerende)
			{

				studerende += st.StudentName + st.MyBirthmonth + st.MyBirthday + "\n";
				
			}
			return $"{nameof(klasseNavn)}: {Klassenavn}\n\n{nameof(studerende)}:\n{studerende}\n{nameof(SemesterStart)}: {SemesterStart}";
		}

		public void WhichSeason()
		{
			var resultliste = this.studerende.GroupBy(x => x.Season()).Select(aarstidGroup => new
			{
				aarstid = aarstidGroup.Key,
				countAarstid = aarstidGroup.Count()
			});

			foreach(var item in resultliste)
			{
				Console.WriteLine($"Season: {item.aarstid} Count: {item.countAarstid}");
			}
		}
	}
}
