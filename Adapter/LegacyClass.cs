namespace Adapter
{
    public class LegacyClass
    {
        public string Text1 { get; set; } = string.Empty;
        public string Text2 { get; set; } = string.Empty;
        public string Text3 { get; set; } = string.Empty;
        public void Submit( )
        {
            Text3 = "The values are submitted!";
        }
    }
}
