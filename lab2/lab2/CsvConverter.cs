using System.IO;
using System.Text;

namespace lab2
{
    class CsvConverter
    {
        public void CsvToHtml(string path, string output)
        {
            string[] lines = File.ReadAllLines(path);
            var strBuilder = new StringBuilder();
            strBuilder.Append("<!DOCTYPE html><html><head><style>table{" +
                "font-family:arial,sans-serif;border-collapse" +
                ":collapse;width:100%;}td,th{border:1px solid" +
                " #333;padding:5px;}</style></head><body><table>");


            foreach (string line in lines)
            {
                string[] rowValues = line.Split(",");
                strBuilder.Append("<tr>");
                foreach (string val in rowValues)
                {
                    strBuilder.Append("<td>");
                    strBuilder.Append(val);
                    strBuilder.Append("</td>");
                }
            }
            strBuilder.Append("</tr>");

            strBuilder.Append("</table>");
            strBuilder.Append("</body></html>");

            File.WriteAllText(output, strBuilder.ToString());
        }
    }
}
