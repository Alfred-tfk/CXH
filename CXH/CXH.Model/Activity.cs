using System;
namespace CXH.Model
{
	/// <summary>
	/// Activity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Activity
	{
		public Activity()
		{}
		#region Model
		private int _activityid;
		private string _activityname;
		private DateTime _endtime;
		private string _activitypicture;
		private string _activityintroduction;
		private string _summary;
		private string _activityverify="待审核";
		private string _activitystatus;
		private string _username;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _activityid=value;}
			get{return _activityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActivityName
		{
			set{ _activityname=value;}
			get{return _activityname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActivityPicture
		{
			set{ _activitypicture=value;}
			get{return _activitypicture;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActivityIntroduction
		{
			set{ _activityintroduction=value;}
			get{return _activityintroduction;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActivityVerify
		{
			set{ _activityverify=value;}
			get{return _activityverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActivityStatus
		{
			set{ _activitystatus=value;}
			get{return _activitystatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		#endregion Model

	}
}

