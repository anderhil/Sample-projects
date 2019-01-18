namespace multiply.OutputFormatters
{
    public class CSVOutputFormatter : FileOutputFormatter
    {
        public virtual string Separator { get; set; }

        protected CSVOutputFormatter()
        {
        }

        public CSVOutputFormatter(string separator)
        {
            Separator = separator;
        }

        protected override void BeginHeader()
        {
            _builder.AppendFormat("{0,2}", " ").Append(Separator);
        }

        protected override void WriteHeader(int value)
        {
            _builder.AppendFormat("{0, 4}",value).Append(Separator);
        }

        protected override void EndHeader()
        {
            _builder.Remove(_builder.Length - 1, 1);
            _builder.AppendLine();
        }

        protected override void BeginRow(int rowNumber)
        {
            _builder.AppendFormat("{0, 2}",rowNumber).Append(Separator);
        }

        protected override void WriteValue(int value)
        {
            _builder.AppendFormat("{0, 4}",value).Append(Separator);
        }

        protected override void EndRow()
        {
            _builder.Remove(_builder.Length - 1, 1);
            _builder.AppendLine();
        }

        public override OutputFormat Format
        {
            get { return OutputFormat.CSV;}
        }
    }
}