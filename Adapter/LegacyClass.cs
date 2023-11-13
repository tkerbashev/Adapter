namespace Adapter
{
    public class LegacyClass
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public void Submit( )
        {
            Text3 = "The values are submitted!";
        }
    }
}
