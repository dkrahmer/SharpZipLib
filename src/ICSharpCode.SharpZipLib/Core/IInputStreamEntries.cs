using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	public interface IInputStreamEntries : IDisposable
	{
		IArchiveEntry GetNextEntry();
		Stream GetStream();
	}
}
