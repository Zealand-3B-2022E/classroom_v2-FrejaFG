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

		private List<Studerende> getStuderende;

		public List<Studerende> GetStuderende
		{
			get { return GetStuderende; }
			set { GetStuderende = value; }
		}

		private DateOnly semesterStart;

		public DateOnly GetSemesterStart
		{
			get { return semesterStart; }
			set { semesterStart = value; }
		}
	}
}
