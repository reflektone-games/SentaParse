using SentaParse.Core.Chart.Notes;

namespace SentaParse.Core
{
	public static class NoteExtensions
	{
		public static bool Is<TNoteIn, TNoteOut>(this TNoteIn note)
			where TNoteIn : NoteBase
			where TNoteOut : NoteBase
			=> note.GetType() == typeof(TNoteOut);

		public static TNoteOut? As<TNoteIn, TNoteOut>(this TNoteIn note)
			where TNoteIn : NoteBase
			where TNoteOut : NoteBase
			=> note as TNoteOut;
	}
}