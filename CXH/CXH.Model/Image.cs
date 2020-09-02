using System;
namespace CXH.Model
{
	/// <summary>
	/// Image:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Image
	{
		public Image()
		{}
		#region Model
		private int _imgid;
		private string _imgurl;
		private string _imgtext;
		private string _imglink;
		private string _imgalt;
		/// <summary>
		/// 
		/// </summary>
		public int ImgID
		{
			set{ _imgid=value;}
			get{return _imgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgText
		{
			set{ _imgtext=value;}
			get{return _imgtext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgLink
		{
			set{ _imglink=value;}
			get{return _imglink;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgAlt
		{
			set{ _imgalt=value;}
			get{return _imgalt;}
		}
		#endregion Model

	}
}

