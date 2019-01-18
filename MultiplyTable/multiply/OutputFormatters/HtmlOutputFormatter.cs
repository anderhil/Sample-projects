namespace multiply.OutputFormatters
{
    public class HtmlOutputFormatter : FileOutputFormatter
    {
        public HtmlOutputFormatter()
        {
            _builder.Append("<html><body><table>");
        }

        protected override void BeginHeader()
        {
            _builder.Append("<tr><td></td>");
        }

        protected override void WriteHeader(int value)
        {
            WriteHtmlValue(value);
        }

        protected override void EndHeader()
        {
            _builder.Append("</tr>");
        }

        protected override void BeginRow(int rowNumber)
        {
            _builder.AppendFormat("<tr><td>{0}</td>", rowNumber);
        }

        protected override void WriteValue(int value)
        {
            WriteHtmlValue(value);
        }

        protected override void EndRow()
        {
            _builder.Append("</tr>");
        }

        protected override void FinishWrite()
        {
            _builder.Append("</table></body></html>");
        }

        private void WriteHtmlValue(int val)
        {
            _builder.AppendFormat("<td>{0}</td>", val);
        }

        public override OutputFormat Format
        {
            get { return OutputFormat.Html;}
        }
    }
}