using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	/// <summary>
	/// Input Stream Entries Interface
	/// </summary>
	/// <seealso cref="System.IDisposable" />
	public interface IInputStreamEntries : IDisposable
	{
		/// <summary>
		/// Gets the next entry.
		/// </summary>
		/// <returns>
		/// The next entry.
		/// </returns>
		IArchiveEntry GetNextEntry();

		/// <summary>
		/// Gets the stream.
		/// </summary>
		/// <returns>
		/// The stream.
		/// </returns>
		Stream GetStream();
	}
}
