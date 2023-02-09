namespace ArtHub.Core;

#if DEBUG
public class Example
{
	public long Id { get; set; }
	public int FirstProp { get; set; }
	public string? SecondProp { get; set; }
	public DateTimeOffset ThirdProp { get; set; }
}
#endif