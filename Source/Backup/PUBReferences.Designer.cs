﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace PUB_ZIK {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.ComponentModel.ToolboxItem(true)]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [System.Xml.Serialization.XmlRootAttribute("PUBReferences")]
    [System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class PUBReferences : System.Data.DataSet {
        
        private НалогиФОПDataTable tableНалогиФОП;
        
        private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public PUBReferences() {
            this.BeginInit();
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected PUBReferences(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)) {
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["НалогиФОП"] != null)) {
                    base.Tables.Add(new НалогиФОПDataTable(ds.Tables["НалогиФОП"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new System.Xml.XmlTextReader(new System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public НалогиФОПDataTable НалогиФОП {
            get {
                return this.tableНалогиФОП;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override System.Data.DataSet Clone() {
            PUBReferences cln = ((PUBReferences)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["НалогиФОП"] != null)) {
                    base.Tables.Add(new НалогиФОПDataTable(ds.Tables["НалогиФОП"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(stream), null);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableНалогиФОП = ((НалогиФОПDataTable)(base.Tables["НалогиФОП"]));
            if ((initTable == true)) {
                if ((this.tableНалогиФОП != null)) {
                    this.tableНалогиФОП.InitVars();
                }
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "PUBReferences";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/PUBReferences.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableНалогиФОП = new НалогиФОПDataTable();
            base.Tables.Add(this.tableНалогиФОП);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeНалогиФОП() {
            return false;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(System.Xml.Schema.XmlSchemaSet xs) {
            PUBReferences ds = new PUBReferences();
            System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
            System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
            xs.Add(ds.GetSchemaSerializable());
            System.Xml.Schema.XmlSchemaAny any = new System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            return type;
        }
        
        public delegate void НалогиФОПRowChangeEventHandler(object sender, НалогиФОПRowChangeEvent e);
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [System.Serializable()]
        [System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class НалогиФОПDataTable : System.Data.DataTable, System.Collections.IEnumerable {
            
            private System.Data.DataColumn columnID;
            
            private System.Data.DataColumn columnPeriod;
            
            private System.Data.DataColumn columnIDIndex;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПDataTable() {
                this.TableName = "НалогиФОП";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal НалогиФОПDataTable(System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected НалогиФОПDataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn PeriodColumn {
                get {
                    return this.columnPeriod;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataColumn IDIndexColumn {
                get {
                    return this.columnIDIndex;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПRow this[int index] {
                get {
                    return ((НалогиФОПRow)(this.Rows[index]));
                }
            }
            
            public event НалогиФОПRowChangeEventHandler НалогиФОПRowChanging;
            
            public event НалогиФОПRowChangeEventHandler НалогиФОПRowChanged;
            
            public event НалогиФОПRowChangeEventHandler НалогиФОПRowDeleting;
            
            public event НалогиФОПRowChangeEventHandler НалогиФОПRowDeleted;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddНалогиФОПRow(НалогиФОПRow row) {
                this.Rows.Add(row);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПRow AddНалогиФОПRow(int ID, System.DateTime Period, string IDIndex) {
                НалогиФОПRow rowНалогиФОПRow = ((НалогиФОПRow)(this.NewRow()));
                rowНалогиФОПRow.ItemArray = new object[] {
                        ID,
                        Period,
                        IDIndex};
                this.Rows.Add(rowНалогиФОПRow);
                return rowНалогиФОПRow;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПRow FindByID(int ID) {
                return ((НалогиФОПRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override System.Data.DataTable Clone() {
                НалогиФОПDataTable cln = ((НалогиФОПDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override System.Data.DataTable CreateInstance() {
                return new НалогиФОПDataTable();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnPeriod = base.Columns["Period"];
                this.columnIDIndex = base.Columns["IDIndex"];
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnID = new System.Data.DataColumn("ID", typeof(int), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnPeriod = new System.Data.DataColumn("Period", typeof(System.DateTime), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnPeriod);
                this.columnIDIndex = new System.Data.DataColumn("IDIndex", typeof(string), null, System.Data.MappingType.Element);
                base.Columns.Add(this.columnIDIndex);
                this.Constraints.Add(new System.Data.UniqueConstraint("НалогиФОПKey1", new System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПRow NewНалогиФОПRow() {
                return ((НалогиФОПRow)(this.NewRow()));
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
                return new НалогиФОПRow(builder);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override System.Type GetRowType() {
                return typeof(НалогиФОПRow);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.НалогиФОПRowChanged != null)) {
                    this.НалогиФОПRowChanged(this, new НалогиФОПRowChangeEvent(((НалогиФОПRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.НалогиФОПRowChanging != null)) {
                    this.НалогиФОПRowChanging(this, new НалогиФОПRowChangeEvent(((НалогиФОПRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.НалогиФОПRowDeleted != null)) {
                    this.НалогиФОПRowDeleted(this, new НалогиФОПRowChangeEvent(((НалогиФОПRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.НалогиФОПRowDeleting != null)) {
                    this.НалогиФОПRowDeleting(this, new НалогиФОПRowChangeEvent(((НалогиФОПRow)(e.Row)), e.Action));
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveНалогиФОПRow(НалогиФОПRow row) {
                this.Rows.Remove(row);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(System.Xml.Schema.XmlSchemaSet xs) {
                System.Xml.Schema.XmlSchemaComplexType type = new System.Xml.Schema.XmlSchemaComplexType();
                System.Xml.Schema.XmlSchemaSequence sequence = new System.Xml.Schema.XmlSchemaSequence();
                PUBReferences ds = new PUBReferences();
                xs.Add(ds.GetSchemaSerializable());
                System.Xml.Schema.XmlSchemaAny any1 = new System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                System.Xml.Schema.XmlSchemaAny any2 = new System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                System.Xml.Schema.XmlSchemaAttribute attribute1 = new System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                System.Xml.Schema.XmlSchemaAttribute attribute2 = new System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "НалогиФОПDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                return type;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class НалогиФОПRow : System.Data.DataRow {
            
            private НалогиФОПDataTable tableНалогиФОП;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal НалогиФОПRow(System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableНалогиФОП = ((НалогиФОПDataTable)(this.Table));
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int ID {
                get {
                    return ((int)(this[this.tableНалогиФОП.IDColumn]));
                }
                set {
                    this[this.tableНалогиФОП.IDColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime Period {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableНалогиФОП.PeriodColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'Period\' in table \'НалогиФОП\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableНалогиФОП.PeriodColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string IDIndex {
                get {
                    try {
                        return ((string)(this[this.tableНалогиФОП.IDIndexColumn]));
                    }
                    catch (System.InvalidCastException e) {
                        throw new System.Data.StrongTypingException("The value for column \'IDIndex\' in table \'НалогиФОП\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableНалогиФОП.IDIndexColumn] = value;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsPeriodNull() {
                return this.IsNull(this.tableНалогиФОП.PeriodColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetPeriodNull() {
                this[this.tableНалогиФОП.PeriodColumn] = System.Convert.DBNull;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsIDIndexNull() {
                return this.IsNull(this.tableНалогиФОП.IDIndexColumn);
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetIDIndexNull() {
                this[this.tableНалогиФОП.IDIndexColumn] = System.Convert.DBNull;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class НалогиФОПRowChangeEvent : System.EventArgs {
            
            private НалогиФОПRow eventRow;
            
            private System.Data.DataRowAction eventAction;
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПRowChangeEvent(НалогиФОПRow row, System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public НалогиФОПRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591