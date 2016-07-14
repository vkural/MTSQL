using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSQL.Core.Models.Metadata;
using System.IO;
using System.Xml;

namespace MTSQL.Generators
{
    public abstract class DBScriptGenerator : IDBScriptGenerator
    {
        protected List<MetadataTableModel> Tables { get; private set; } = new List<MetadataTableModel>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="streams"></param>
        /// <returns></returns>
        public abstract string GenerateScript(List<MemoryStream> streams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileNames"></param>
        /// <returns></returns>
        public abstract string GenerateScript(List<string> fileNames);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="streams"></param>
        protected void Load(List<MemoryStream> streams)
        {
            foreach (var stream in streams)
            {
                var xDoc = new XmlDocument();

                xDoc.Load(stream);

                ReadXML(xDoc);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileNames"></param> 
        protected void Load(List<string> fileNames)
        {
            foreach (var fileName in fileNames)
            {
                var xDoc = new XmlDocument();

                xDoc.Load(fileName);

                ReadXML(xDoc);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlDocument"></param>
        private void ReadXML(XmlDocument xmlDocument)
        {
            var table = new MetadataTableModel { Name = xmlDocument.DocumentElement.Attributes["tableName"].Value };

            XmlNodeList columnNodes = xmlDocument.DocumentElement.SelectSingleNode("Columns").ChildNodes;

            for (var k = 0; k < columnNodes.Count; k++)
            {
                XmlNode column = columnNodes[k];

                if (column.NodeType != XmlNodeType.Comment)
                {
                    var attr_name = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "name", true) == 0).SingleOrDefault();
                    var attr_dbtype = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "dbtype", true) == 0).SingleOrDefault();
                    var attr_size = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "size", true) == 0).SingleOrDefault();
                    var attr_isnullable = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "isnullable", true) == 0).SingleOrDefault();
                    var attr_isidentity = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "isidentity", true) == 0).SingleOrDefault();
                    var attr_isprimary = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "isprimary", true) == 0).SingleOrDefault();
                    var attr_scale = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "scale", true) == 0).SingleOrDefault();
                    var attr_precision = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "precision", true) == 0).SingleOrDefault();
                    var attr_sequencename = column.Attributes.Cast<XmlAttribute>().Where(x => string.Compare(x.Name, "sequencename", true) == 0).SingleOrDefault();


                    table.Columns.Add(new MetadataColumnModel
                    {
                        Name = attr_name == null ? string.Empty : attr_name.Value,
                        DbType = attr_dbtype == null ? string.Empty : attr_dbtype.Value,
                        Size = attr_size == null ? string.Empty : attr_size.Value,
                        IsNullable = attr_isnullable == null ? string.Empty : attr_isnullable.Value,
                        IsIdentity = attr_isidentity == null ? string.Empty : attr_isidentity.Value,
                        IsPrimary = attr_isprimary == null ? string.Empty : attr_isprimary.Value,
                        Scale = attr_scale == null ? string.Empty : attr_scale.Value,
                        Precision = attr_precision == null ? string.Empty : attr_precision.Value,
                        SequenceName = attr_sequencename == null ? string.Empty : attr_sequencename.Value
                    });
                }
            }

            Tables.Add(table);
        }
    }
}
