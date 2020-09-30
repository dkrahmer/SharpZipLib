namespace ICSharpCode.SharpZipLib.Core
{
	/// <summary>
	/// Archive Entry Interface
	/// </summary>
	public interface IArchiveEntry
	{
		/// <summary>
		/// Name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Size.
		/// </summary>
		long Size { get; }
	}
}
