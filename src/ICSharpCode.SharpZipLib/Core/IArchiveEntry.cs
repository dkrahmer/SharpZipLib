namespace ICSharpCode.SharpZipLib.Core
{
	public interface IArchiveEntry
	{
		string Name { get; }
		long Size { get; }
	}
}
