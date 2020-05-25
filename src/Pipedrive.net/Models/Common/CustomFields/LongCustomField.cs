namespace Pipedrive.CustomFields
{
    // int
    public class LongCustomField : ICustomField
    {
        public long Value { get; set; }

        public LongCustomField(long value)
        {
            Value = value;
        }
    }
}
