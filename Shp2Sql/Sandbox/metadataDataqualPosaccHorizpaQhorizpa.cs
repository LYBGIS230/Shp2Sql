namespace Shp2Sql.Sandbox
{
	#region Imports

	using System;
	using System.CodeDom.Compiler;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Xml.Schema;
	using System.Xml.Serialization;

	#endregion
	/// <remarks />
	[GeneratedCode("xsd", "4.6.1055.0")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true)]
	public class metadataDataqualPosaccHorizpaQhorizpa : object, INotifyPropertyChanged
	{
		private string horizpaeField;

		private string horizpavField;

		/// <remarks />
		[XmlElement(Form = XmlSchemaForm.Unqualified, Order = 0)]
		public string horizpav
		{
			get
			{
				return horizpavField;
			}
			set
			{
				horizpavField = value;
				RaisePropertyChanged("horizpav");
			}
		}

		/// <remarks />
		[XmlElement(Form = XmlSchemaForm.Unqualified, Order = 1)]
		public string horizpae
		{
			get
			{
				return horizpaeField;
			}
			set
			{
				horizpaeField = value;
				RaisePropertyChanged("horizpae");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}