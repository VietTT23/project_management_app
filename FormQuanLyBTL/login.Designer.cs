﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace FormQuanLyBTL {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("login")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class login : global::System.Data.DataSet {
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public login() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected login(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            login cln = ((login)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "login";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/login.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            login ds = new login();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }
}
namespace FormQuanLyBTL.loginTableAdapters {
    
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class QueriesTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.IDbCommand[] _commandCollection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.IDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.IDbCommand[6];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Connection = new global::System.Data.SqlClient.SqlConnection(global::FormQuanLyBTL.Properties.Settings.Default.QuanLyBaiTapLonConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).CommandText = "SELECT     COUNT(QIn) AS Expr1\r\nFROM         tblTaiKhoan\r\nWHERE     (Ten = @ten) " +
                "AND (QIn = @gt)";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).CommandType = global::System.Data.CommandType.Text;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ten", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@gt", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QIn", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Connection = new global::System.Data.SqlClient.SqlConnection(global::FormQuanLyBTL.Properties.Settings.Default.QuanLyBaiTapLonConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).CommandText = "SELECT        COUNT(QIn) AS Expr1\r\nFROM            tblTaiKhoan\r\nWHERE        (Ten" +
                " = @ten) AND (Pass = @pass)";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).CommandType = global::System.Data.CommandType.Text;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ten", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@pass", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Pass", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Connection = new global::System.Data.SqlClient.SqlConnection(global::FormQuanLyBTL.Properties.Settings.Default.QuanLyBaiTapLonConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).CommandText = "SELECT     COUNT(QIn) AS Expr1\r\nFROM         tblTaiKhoan\r\nWHERE     (Ten = @ten) " +
                "AND (QSua = @gt)";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).CommandType = global::System.Data.CommandType.Text;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ten", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@gt", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QSua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).Connection = new global::System.Data.SqlClient.SqlConnection(global::FormQuanLyBTL.Properties.Settings.Default.QuanLyBaiTapLonConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).CommandText = "SELECT        COUNT(QIn) AS Expr1\r\nFROM            tblTaiKhoan\r\nWHERE        (Ten" +
                " = @ten) AND (QTim = @gt)";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).CommandType = global::System.Data.CommandType.Text;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ten", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@gt", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QTim", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).Connection = new global::System.Data.SqlClient.SqlConnection(global::FormQuanLyBTL.Properties.Settings.Default.QuanLyBaiTapLonConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).CommandText = "SELECT        COUNT(QIn) AS Expr1\r\nFROM            tblTaiKhoan\r\nWHERE        (Ten" +
                " = @ten) AND (QThem = @gt)";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).CommandType = global::System.Data.CommandType.Text;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ten", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@gt", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QThem", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).Connection = new global::System.Data.SqlClient.SqlConnection(global::FormQuanLyBTL.Properties.Settings.Default.QuanLyBaiTapLonConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).CommandText = "SELECT        COUNT(QIn) AS Expr1\r\nFROM            tblTaiKhoan\r\nWHERE        (Ten" +
                " = @ten) AND (QXoa = @gt)";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).CommandType = global::System.Data.CommandType.Text;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ten", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@gt", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QXoa", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual global::System.Nullable<int> CheckIn(string ten, global::System.Nullable<bool> gt) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[0]));
            if ((ten == null)) {
                throw new global::System.ArgumentNullException("ten");
            }
            else {
                command.Parameters[0].Value = ((string)(ten));
            }
            if ((gt.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(gt.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return new global::System.Nullable<int>();
            }
            else {
                return new global::System.Nullable<int>(((int)(returnValue)));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual global::System.Nullable<int> CheckLogin(string ten, string pass) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[1]));
            if ((ten == null)) {
                throw new global::System.ArgumentNullException("ten");
            }
            else {
                command.Parameters[0].Value = ((string)(ten));
            }
            if ((pass == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(pass));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return new global::System.Nullable<int>();
            }
            else {
                return new global::System.Nullable<int>(((int)(returnValue)));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual global::System.Nullable<int> CheckSua(string ten, global::System.Nullable<bool> gt) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[2]));
            if ((ten == null)) {
                throw new global::System.ArgumentNullException("ten");
            }
            else {
                command.Parameters[0].Value = ((string)(ten));
            }
            if ((gt.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(gt.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return new global::System.Nullable<int>();
            }
            else {
                return new global::System.Nullable<int>(((int)(returnValue)));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual global::System.Nullable<int> CheckTim(string ten, global::System.Nullable<bool> gt) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[3]));
            if ((ten == null)) {
                throw new global::System.ArgumentNullException("ten");
            }
            else {
                command.Parameters[0].Value = ((string)(ten));
            }
            if ((gt.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(gt.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return new global::System.Nullable<int>();
            }
            else {
                return new global::System.Nullable<int>(((int)(returnValue)));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual global::System.Nullable<int> CheckThem(string ten, global::System.Nullable<bool> gt) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[4]));
            if ((ten == null)) {
                throw new global::System.ArgumentNullException("ten");
            }
            else {
                command.Parameters[0].Value = ((string)(ten));
            }
            if ((gt.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(gt.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return new global::System.Nullable<int>();
            }
            else {
                return new global::System.Nullable<int>(((int)(returnValue)));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual global::System.Nullable<int> CheckXoa(string ten, global::System.Nullable<bool> gt) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[5]));
            if ((ten == null)) {
                throw new global::System.ArgumentNullException("ten");
            }
            else {
                command.Parameters[0].Value = ((string)(ten));
            }
            if ((gt.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(gt.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return new global::System.Nullable<int>();
            }
            else {
                return new global::System.Nullable<int>(((int)(returnValue)));
            }
        }
    }
}

#pragma warning restore 1591